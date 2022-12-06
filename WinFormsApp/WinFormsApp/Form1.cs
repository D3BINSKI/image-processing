using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Accessibility;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private EditorPanel _editorPanel;
        private HistogramPanel _histogramPanel;
        private Region _regionSetting;
        private bool _isPolygonAddMode;
        private MatrixFilter _currentFilter;
        private bool _isBrushActive;

        public Form1()
        {
            InitializeComponent();
            _editorPanel =
                EditorPanel.FromPath(
                    @"D:\Software\Projects\Computer Graphics\image-processing\WinFormsApp\WinFormsApp\Images\Lenna_(test_image).png",
                    editorPictureBox);

            redHistogramPictureBox.Image = new Bitmap(redHistogramPictureBox.Width, redHistogramPictureBox.Height);
            greenHistogramPictureBox.Image = new Bitmap(redHistogramPictureBox.Width, redHistogramPictureBox.Height);
            blueHistogramPictureBox.Image = new Bitmap(redHistogramPictureBox.Width, redHistogramPictureBox.Height);
            _histogramPanel = new HistogramPanel((Bitmap)_editorPanel.Image, redHistogramPictureBox,
                greenHistogramPictureBox, blueHistogramPictureBox);
            _regionSetting = WinFormsApp.Region.EntireImage;
            _isBrushActive = false;

            _histogramPanel.Update();
            identityRadioButton.Checked = true;
            InitializeCustomMatrix();
        }

        private void InitializeCustomMatrix()
        {
            matrix11TextBox.Text = "0";
            matrix12TextBox.Text = "0";
            matrix13TextBox.Text = "0";
            matrix21TextBox.Text = "0";
            matrix22TextBox.Text = "0";
            matrix23TextBox.Text = "0";
            matrix31TextBox.Text = "0";
            matrix32TextBox.Text = "0";
            matrix33TextBox.Text = "0";

            offsetTextBox.Text = "0";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void applyChangesBttn_Click(object sender, EventArgs e)
        {
            _isPolygonAddMode = false;
            _editorPanel.SavePreview();
            _histogramPanel.SetImage((Bitmap)_editorPanel.Image);
            _histogramPanel.Update();
        }

        private void revertChangesButton_Click(object sender, EventArgs e)
        {
            _editorPanel.RevertChanges();
        }

        private void identityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                _currentFilter = new MatrixFilter(PredefinedFilter.Identity);
                _editorPanel.SetFilter(_currentFilter);

                switch (_regionSetting)
                {
                    case WinFormsApp.Region.EntireImage:
                        FilterEntireRegion(_currentFilter);
                        break;
                    case WinFormsApp.Region.Polygon:
                        _editorPanel.UpdatePolygonArea(_currentFilter);
                        break;
                    case WinFormsApp.Region.Brush:
                        _editorPanel.SetFilter(_currentFilter);
                        break;
                }
            }
        }

        private void blurRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                _currentFilter = new MatrixFilter(PredefinedFilter.Blur);
                _editorPanel.SetFilter(_currentFilter);

                switch (_regionSetting)
                {
                    case WinFormsApp.Region.EntireImage:
                        FilterEntireRegion(_currentFilter);
                        break;
                    case WinFormsApp.Region.Polygon:
                        _editorPanel.UpdatePolygonArea(_currentFilter);
                        break;
                    case WinFormsApp.Region.Brush:
                        _editorPanel.SetFilter(_currentFilter);
                        break;
                }
            }
        }

        private void carvingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                _currentFilter = new MatrixFilter(PredefinedFilter.Carving);
                _editorPanel.SetFilter(_currentFilter);

                switch (_regionSetting)
                {
                    case WinFormsApp.Region.EntireImage:
                        FilterEntireRegion(_currentFilter);
                        break;
                    case WinFormsApp.Region.Polygon:
                        _editorPanel.UpdatePolygonArea(_currentFilter);
                        break;
                    case WinFormsApp.Region.Brush:
                        _editorPanel.SetFilter(_currentFilter);
                        break;
                }
            }
        }

        private void edgeDetectionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                _currentFilter = new MatrixFilter(PredefinedFilter.EdgeDetection);
                _editorPanel.SetFilter(_currentFilter);
                switch (_regionSetting)
                {
                    case WinFormsApp.Region.EntireImage:
                        FilterEntireRegion(_currentFilter);
                        break;
                    case WinFormsApp.Region.Polygon:
                        _editorPanel.UpdatePolygonArea(_currentFilter);
                        break;
                    case WinFormsApp.Region.Brush:
                        _editorPanel.SetFilter(_currentFilter);
                        break;
                }
            }
        }

        private void negativeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                _currentFilter = new MatrixFilter(PredefinedFilter.Negative);
                _editorPanel.SetFilter(_currentFilter);
                
                switch (_regionSetting)
                {
                    case WinFormsApp.Region.EntireImage:
                        FilterEntireRegion(_currentFilter);
                        break;
                    case WinFormsApp.Region.Polygon:
                        _editorPanel.UpdatePolygonArea(_currentFilter);
                        break;
                    case WinFormsApp.Region.Brush:
                        _editorPanel.SetFilter(_currentFilter);
                        break;
                }
            }
        }
        
        private void customMatrixRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            customMatrixFieldsGroupBox.Enabled = ((RadioButton)sender).Checked;
            offsetPanel.Enabled = ((RadioButton)sender).Checked;
            dividerPanel.Enabled = ((RadioButton)sender).Checked;

            UpdateCustomMatrix();
        }

        private void FilterEntireRegion(MatrixFilter filter)
        {
            _editorPanel.ApplyFilter(filter);
        }

        private void roundBrushRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((RadioButton)sender).Checked;
            if (!isChecked) _editorPanel.RevertChanges();
            roundBrushRadiusTrackBar.Enabled = isChecked;
            _regionSetting = isChecked ? WinFormsApp.Region.Brush : _regionSetting;
        }

        private void entireImageRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((RadioButton)sender).Checked;
            if (!isChecked) _editorPanel.RevertChanges();
            if(isChecked) _editorPanel.ApplyFilter(_currentFilter);
            _regionSetting = isChecked ? WinFormsApp.Region.EntireImage : _regionSetting;
        }

        private void PolygonRegionRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((RadioButton)sender).Checked;
            if (!isChecked) _editorPanel.RevertChanges();
            _regionSetting = isChecked ? WinFormsApp.Region.Polygon : _regionSetting;

            addPolygonButton.Enabled = isChecked;
        }

        private void addPolygonButton_Click(object sender, EventArgs e)
        {
            addPolygonButton.Enabled = false;
            _isPolygonAddMode = true;
        }

        private void editorPictureBox_Click(object sender, EventArgs e)
        {
            if (!_isPolygonAddMode) return;

            var point = editorPictureBox.PointToClient(Cursor.Position);
            _isPolygonAddMode = _editorPanel.AddPointToPolygon(point);
            addPolygonButton.Enabled = !_isPolygonAddMode;
            if (!_isPolygonAddMode)
            {
                _editorPanel.UpdatePolygonArea(_currentFilter);
            }
        }

        private void editorPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _isBrushActive = true;
        }

        private void editorPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _isBrushActive = false;
        }

        private void editorPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isBrushActive && _regionSetting == WinFormsApp.Region.Brush)
            {
                _editorPanel.Brush(editorPictureBox.PointToClient(Cursor.Position), roundBrushRadiusTrackBar.Value);
            }
        }

        private void matrix11TextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || !customMatrixRadioButton.Checked) return;
            
            UpdateCustomMatrix();
            
        }

        private void matrix12TextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || !customMatrixRadioButton.Checked) return;

            UpdateCustomMatrix();

        }

        private void matrix13TextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || !customMatrixRadioButton.Checked) return;

            UpdateCustomMatrix();

        }

        private void matrix21TextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || !customMatrixRadioButton.Checked) return;

            UpdateCustomMatrix();

        }

        private void matrix22TextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || !customMatrixRadioButton.Checked) return;

            UpdateCustomMatrix();

        }

        private void matrix23TextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || !customMatrixRadioButton.Checked) return;

            UpdateCustomMatrix();

        }

        private void matrix31TextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || !customMatrixRadioButton.Checked) return;

            UpdateCustomMatrix();

        }

        private void matrix32TextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || !customMatrixRadioButton.Checked) return;

            UpdateCustomMatrix();

        }

        private void matrix33TextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || !customMatrixRadioButton.Checked) return;

            UpdateCustomMatrix();
        }
        
        private void offsetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || !customMatrixRadioButton.Checked) return;
            
            UpdateCustomMatrix();
        }
        
        private void dividerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "" || !customMatrixRadioButton.Checked) return;
            
            UpdateCustomMatrix();
        }

        private void UpdateCustomMatrix()
        {
            try
            {
                var matrix = new int[,]
                {
                    {
                        Convert.ToInt32(matrix11TextBox.Text), Convert.ToInt32(matrix12TextBox.Text),
                        Convert.ToInt32(matrix13TextBox.Text)
                    },
                    {
                        Convert.ToInt32(matrix21TextBox.Text), Convert.ToInt32(matrix22TextBox.Text),
                        Convert.ToInt32(matrix23TextBox.Text)
                    },
                    {
                        Convert.ToInt32(matrix31TextBox.Text), Convert.ToInt32(matrix32TextBox.Text),
                        Convert.ToInt32(matrix33TextBox.Text)
                    }
                };
                if (!countDividerCheckBox.Checked)
                    _currentFilter = new MatrixFilter(matrix, Convert.ToInt32(offsetTextBox.Text),
                        Convert.ToInt32(dividerTextBox.Text));
                else
                    _currentFilter = new MatrixFilter(matrix, Convert.ToInt32(offsetTextBox.Text));
                _editorPanel.SetFilter(_currentFilter);

                switch (_regionSetting)
                {
                    case WinFormsApp.Region.EntireImage:
                        FilterEntireRegion(_currentFilter);
                        break;
                    case WinFormsApp.Region.Polygon:
                        _editorPanel.UpdatePolygonArea(_currentFilter);
                        break;
                    case WinFormsApp.Region.Brush:
                        _editorPanel.SetFilter(_currentFilter);
                        break;
                }
            }
            catch 
            {
                return;
            }
            
        }

        private void changeImageButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = @"jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    
                    _editorPanel.SetImage(new Bitmap(Image.FromFile(filePath)));
                    _histogramPanel.SetImage((Bitmap)_editorPanel.Image);
                    _histogramPanel.Update();
                    
                    _editorPanel.SetFilter(_currentFilter);
                }
            }
        }

        private void countDividerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCustomMatrix();
        }

        private void generateImageButton_Click(object sender, EventArgs e)
        {
            var imageGenerator = new HSVStripesGenerator(new Range(0, 360), new Range(0, 1000), 500, 50,
                new Size(editorPictureBox.Width, editorPictureBox.Height));
            
            _editorPanel.SetImage(imageGenerator.GetImage());
            _histogramPanel.SetImage((Bitmap)_editorPanel.Image);
            _histogramPanel.Update();
        }
    }

    enum Region
    {
        EntireImage,
        Brush,
        Polygon
    }

    public class HSVStripesGenerator
    {
        private int _vValue;
        private Range _hRange;
        private Range _sRange;
        private int _stripesNumber;
        private Size _imageSize;

        private HSVStripe[] _hsvStripes;

        public int V { get => _vValue; set => _vValue = value; }

        public HSVStripesGenerator(Range hRange, Range sRange, int v, int n, Size size)
        {
            _hRange = hRange;
            _sRange = sRange;
            _vValue = v;
            _stripesNumber = n;
            _imageSize = size;
            _hsvStripes = new HSVStripe[_stripesNumber];
            
            InitializeStripes();
        }

        private void InitializeStripes()
        {
            var stripeSize = new Size(_imageSize.Width / _stripesNumber, _imageSize.Height);
            var hIter = (_hRange.End.Value - _hRange.Start.Value) / _stripesNumber;
            for (int i = 0; i < _stripesNumber; i++)
            {
                var h = _hRange.Start.Value + hIter * i;
                _hsvStripes[i] = new HSVStripe(stripeSize, h, _vValue, _sRange);
            }
        }

        public Image GetImage()
        {
            var bitmap = new Bitmap(_imageSize.Width, _imageSize.Height);
            var x = 0;
            var xIter = _imageSize.Width / _stripesNumber;
            using var g = Graphics.FromImage(bitmap);
            foreach (var stripe in _hsvStripes)
            {
                var stripeImage = stripe.GetStripe(100);
                
                g.FillRectangle(new TextureBrush(stripeImage), x, 0, xIter, _imageSize.Height);
                x += xIter;
            }

            return bitmap;
        }

    }

    public class HSVStripe
    {
        private Size _size;

        private int _h;
        private int _v;
        private Range _sRange;
        
        public int V { get => _v; set => _v = value; }

        public HSVStripe(Size size, int h, int v, Range sRange)
        {
            _size = size;
            _h = h;
            _v = v;
            _sRange = sRange;
        }
        
        public Image GetStripe(int n)
        {
            var bitmap = new Bitmap(_size.Width, _size.Height);

            var colors = HSV.GetRGBColors(_h, _v, _sRange, n);

            var colorWidth = _size.Height / colors.Length;

            using var g = Graphics.FromImage(bitmap);
            
            var y = 0;
            foreach (var color in colors)
            {
                var brush = new SolidBrush(color);
                g.FillRectangle(brush, 0, y, bitmap.Width, colorWidth*2);

                y += colorWidth;
            }

            return bitmap;
        }
        
    }

    public class HSV
    {
        public static Color[] GetRGBColors(int h, int v, Range sRange, int n)
        {
            var colors = new Color[n];
            var sIter = (sRange.End.Value - sRange.Start.Value) / n;
            for (int i = 0; i < n; i++)
            {
                var s = sRange.Start.Value + i * sIter;
                var C = Math.Max(Math.Min(v * s, 255), 0);
                var X = Math.Max(Math.Min(C * (1 - Math.Abs((h / 60) % 2 - 1)), 255), 0);
                var m = v - C;
                
                if (h is >= 0 and < 60)
                {
                    colors[i] = Color.FromArgb(255, C, X, 0);
                }
                else if(h is >= 60 and < 120)
                {
                    colors[i] = Color.FromArgb(255, X, C, 0);
                }
                else if(h is >= 120 and < 180)
                {
                    colors[i] = Color.FromArgb(255, 0, C, X);
                }
                else if(h is >= 180 and < 240)
                {
                    colors[i] = Color.FromArgb(255, 0, X, C);
                }
                else if(h is >= 240 and < 300)
                {
                    colors[i] = Color.FromArgb(255, X, 0, C);
                }
                else if(h is >= 300 and < 360)
                {
                    colors[i] = Color.FromArgb(255, C, 0, X);
                }

                i++;
            }

            return colors;
        }
    }
}