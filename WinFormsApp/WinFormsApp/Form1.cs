using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

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
                }
            }
        }
    }

    enum Region
    {
        EntireImage,
        Brush,
        Polygon
    }
}