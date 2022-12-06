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
            _editorPanel = EditorPanel.FromPath(@"D:\Software\Projects\Computer Graphics\image-processing\WinFormsApp\WinFormsApp\Images\Lenna_(test_image).png", editorPictureBox);
            
            redHistogramPictureBox.Image = new Bitmap(redHistogramPictureBox.Width, redHistogramPictureBox.Height);
            greenHistogramPictureBox.Image = new Bitmap(redHistogramPictureBox.Width, redHistogramPictureBox.Height);
            blueHistogramPictureBox.Image = new Bitmap(redHistogramPictureBox.Width, redHistogramPictureBox.Height);
            _histogramPanel = new HistogramPanel((Bitmap)_editorPanel.Image, redHistogramPictureBox, greenHistogramPictureBox, blueHistogramPictureBox);
            _regionSetting = WinFormsApp.Region.EntireImage;
            _isBrushActive = false;
            
            _histogramPanel.Update();
            identityRadioButton.Checked = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customMatrixRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            customMatrixFieldsGroupBox.Enabled = ((RadioButton)sender).Checked;
            offsetPanel.Enabled = ((RadioButton)sender).Checked;
            dividerPanel.Enabled = ((RadioButton)sender).Checked;
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

        private void FilterEntireRegion(MatrixFilter filter)
        {
            _editorPanel.ApplyFilter(filter);
        }
        
        private void roundBrushRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((RadioButton)sender).Checked;
            if (!isChecked) _editorPanel.RevertChanges();
            _editorPanel.SetFilter(_currentFilter);
            roundBrushRadiusTrackBar.Enabled = isChecked;
            _regionSetting = isChecked ? WinFormsApp.Region.Brush : _regionSetting;
        }

        private void entireImageRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((RadioButton)sender).Checked;
            if (!isChecked) _editorPanel.RevertChanges();
            _editorPanel.SetFilter(_currentFilter);
            _regionSetting = isChecked ? WinFormsApp.Region.EntireImage : _regionSetting;
        }

        private void PolygonRegionRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = ((RadioButton)sender).Checked;
            if (!isChecked) _editorPanel.RevertChanges();
            _editorPanel.SetFilter(_currentFilter);
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
                _editorPanel.Brush(editorPictureBox.PointToClient(Cursor.Position));
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