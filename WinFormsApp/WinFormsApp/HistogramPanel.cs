namespace WinFormsApp;

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