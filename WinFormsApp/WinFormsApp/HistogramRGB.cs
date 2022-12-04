namespace WinFormsApp;

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
        Update();
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