namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}