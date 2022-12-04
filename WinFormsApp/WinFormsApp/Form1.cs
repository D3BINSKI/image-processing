using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private EditorPanel _editorPanel;
        private HistogramPanel _histogramPanel;
        public Form1()
        {
            InitializeComponent();
            _editorPanel = EditorPanel.FromPath(@"D:\Software\Projects\Computer Graphics\image-processing\WinFormsApp\WinFormsApp\Images\Lenna_(test_image).png", editorPictureBox);
            
            redHistogramPictureBox.Image = new Bitmap(redHistogramPictureBox.Width, redHistogramPictureBox.Height);
            greenHistogramPictureBox.Image = new Bitmap(redHistogramPictureBox.Width, redHistogramPictureBox.Height);
            blueHistogramPictureBox.Image = new Bitmap(redHistogramPictureBox.Width, redHistogramPictureBox.Height);
            _histogramPanel = new HistogramPanel((Bitmap)_editorPanel.Image, redHistogramPictureBox, greenHistogramPictureBox, blueHistogramPictureBox);
            
            _histogramPanel.Update();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roundBrushRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            roundBrushRadiusTrackBar.Enabled = ((RadioButton)sender).Checked;
        }

        private void customMatrixRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            customMatrixFieldsGroupBox.Enabled = ((RadioButton)sender).Checked;
        }

        private void customMatrixRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            customMatrixFieldsGroupBox.Enabled = ((RadioButton)sender).Checked;
        }

        private void applyBttn_Click(object sender, EventArgs e)
        {
            var filter = new MatrixFilter(PredefinedMatrix.Blur, 0);
            _editorPanel.ApplyFilter(filter);
            _editorPanel.SavePreview();
            _histogramPanel.SetImage((Bitmap)_editorPanel.Image);
            _histogramPanel.Update();
        }
    }
}