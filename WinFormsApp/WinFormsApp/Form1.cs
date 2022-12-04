using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var editorPanel = EditorPanel.FromPath(@"D:\Software\Projects\Computer Graphics\image-processing\WinFormsApp\WinFormsApp\Images\Lenna_(test_image).png", editorPictureBox);
            
            redHistogramPictureBox.Image = new Bitmap(redHistogramPictureBox.Width, redHistogramPictureBox.Height);
            greenHistogramPictureBox.Image = new Bitmap(redHistogramPictureBox.Width, redHistogramPictureBox.Height);
            blueHistogramPictureBox.Image = new Bitmap(redHistogramPictureBox.Width, redHistogramPictureBox.Height);
            var histogramsPanel = new HistogramPanel((Bitmap)editorPanel.Image, redHistogramPictureBox, greenHistogramPictureBox, blueHistogramPictureBox);
            
            histogramsPanel.Update();
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

    public class EditorPanel
    {
        private PictureBox _editorPictureBox;
        private Bitmap _editorBitmap;

        public Image Image => _editorBitmap;

        public EditorPanel(Image image, PictureBox pictureBox)
        {
            _editorPictureBox = pictureBox;
            _editorPictureBox.Image = image;
            _editorBitmap = new Bitmap(image);

            Update();            
        }

        public static EditorPanel FromPath(string path, PictureBox pictureBox) => new EditorPanel(Image.FromFile(path), pictureBox);

        public void Update()
        {
            using var g = Graphics.FromImage(_editorPictureBox.Image);

            g.DrawImage(_editorBitmap, 0, 0);

        }
    }

    public class HistogramPanel
    {
        private PictureBox _redHistogramPictureBox;
        private PictureBox _greenHistogramPictureBox;
        private PictureBox _blueHistogramPictureBox;
        private HistogramRGB _histogramRGB;
        
        public HistogramPanel(Bitmap referenceImage, PictureBox redHistogramPictureBox, PictureBox greenHistogramPictureBox, PictureBox blueHistogramPictureBox)
        {
            _redHistogramPictureBox = redHistogramPictureBox;
            _greenHistogramPictureBox = greenHistogramPictureBox;
            _blueHistogramPictureBox = blueHistogramPictureBox;
            _histogramRGB = new HistogramRGB(referenceImage);
        }
        
        public void SetImage(Bitmap image)
        {
            _histogramRGB.SetImage(image);
        }
        
        public void Update()
        {
            _histogramRGB.Update();
            var xValues = new int[256];
            for (var i = 0; i < 256; i++)
            {
                xValues[i] = i;
            }
            _redHistogramPictureBox.Image = Chart.GetChart(_redHistogramPictureBox.Size, xValues, _histogramRGB.Red, 0, 256, Pens.Red);
            _greenHistogramPictureBox.Image = Chart.GetChart(_greenHistogramPictureBox.Size, xValues, _histogramRGB.Green, 0, 256, Pens.Green);
            _blueHistogramPictureBox.Image = Chart.GetChart(_blueHistogramPictureBox.Size, xValues, _histogramRGB.Blue, 0, 256, Pens.Blue);
        }
    }

    public class HistogramRGB
    {
        private int[] _red;
        private int[] _green;
        private int[] _blue;
        private Image _referenceImage;

        public int[] Red => _red;
        public int[] Green => _green;
        public int[] Blue => _blue;
        
        public HistogramRGB(Image referenceImage)
        {
            _red = new int[256];
            _green = new int[256];
            _blue = new int[256];
            _referenceImage = referenceImage;
            ProcessImage(_referenceImage);
        }
        
        public void SetImage(Image image)
        {
            _referenceImage = image;
        }

        public void Update()
        {
            ProcessImage(_referenceImage);
        }

        private void ProcessImage(Image image)
        {
            var bm = (Bitmap)image;
            for (int i = 0; i < 256; i++)
            {
                _red[i] = 0;
                _green[i] = 0;
                _blue[i] = 0;
            }
            
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    // Get pixel color 
                    Color c = bm.GetPixel(x,y);
                    //Update RGB values with pixel color
                    _red[c.R]++;
                    _green[c.G]++;
                    _blue[c.B]++;
                }
            }
        }
    }

    public static class Chart
    {
        public static Image GetChart(Size size, int[] xValues, int[] yValues, int minX, int maxX, Pen chartColor)
        {
            if (xValues.Count() != yValues.Count())
            {
                throw new ArgumentException($"Number of X axis values ({xValues.Count()}) is different from number of Y axis values ({yValues.Count()})");
            }
            if (minX > maxX)
            {
                throw new ArgumentException("min value > max value");
            }
            var bitmap = new Bitmap(size.Width, size.Height);

            var dataCount = xValues.Count();
            var maxY = yValues.Max();

            var barWidth = size.Width / dataCount;

            using var g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            var xScale = size.Width / (maxX - minX);
            float yScale = size.Height / (float)maxY;

            for (int i = 0; i < dataCount; i++)
            {
                var x = xValues[i];
                var y = yValues[i];
                
                if (x > minX && x < maxX)
                {
                    g.DrawLine(chartColor, x*xScale, 0, x * xScale, Math.Min(y, maxY) * yScale);
                }
            };
            
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return bitmap;
        }
    }
}