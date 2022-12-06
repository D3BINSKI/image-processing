using System.Drawing.Drawing2D;
using System.Numerics;

namespace WinFormsApp;

static class PredefinedFilter
{
    public static readonly (int[,] matrix, int offset, int divider) Negative = (new int[3, 3]
    {
        {0, 0, 0}, 
        {0, -1, 0}, 
        {0, 0, 0}
        
    }, 255, 1);
    
    public static readonly (int[,] matrix, int offset, int divider) Identity = (new int[3, 3]
    {
        {0, 0, 0}, 
        {0, 1, 0}, 
        {0, 0, 0}}, 0, 1);
    
    public static readonly (int[,] matrix, int offset, int divider) Blur = (new int[3, 3]
    {
        {1, 1, 1}, 
        {1, 1, 1}, 
        {1, 1, 1}}, 0, 9);
    
    public static readonly (int[,] matrix, int offset, int divider) Sharpening = (new int[3, 3]
    {
        {0, -1, 0}, 
        {-1, 5, -1}, 
        {0, -1, 0}}, 0, 1);
    
    public static readonly (int[,] matrix, int offset, int divider) EdgeDetection = (new int[3, 3]
    {
        {-1, 0, 1}, 
        {-1, 0, 1}, 
        {-1, 0, 1}}, 0, 1);
    
    public static readonly (int[,] matrix, int offset, int divider) Carving = (new int[3, 3]
    {
        {-1, -1, 0}, 
        {-1, 2, 1}, 
        {0, 1, 1}}, 0, 2);
    
}

public class MatrixFilter
{
    private int _offset;
    public int[,] Matrix => _filterMatrix;
    private int[,] _filterMatrix;
    private int _divider;
    public MatrixFilter(int[,] matrix, int offset, int divider)
    {
        _filterMatrix = matrix;
        _offset = offset;
        _divider = divider;
    }

    public MatrixFilter(int[,] matrix, int offset)
    {
        _filterMatrix = matrix;
        _offset = offset;

        _divider = 0;
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                _divider += _filterMatrix[i + 1, j + 1];
            }
        }
        
        _divider = _divider == 0 ? 1 : Math.Abs(_divider);

    }

    public MatrixFilter((int[,] matrix, int offset, int divider) filter)
    {
        _filterMatrix = filter.matrix;
        _offset = filter.offset;
        _divider = filter.divider;
    }

    public Image Apply(Image refImage)
    {
        var bitmap = (Bitmap)refImage;
        var result = new Bitmap(bitmap.Width, bitmap.Height);
        
        for (int y = 1; y < refImage.Height - 1; y++)
        {
            for (int x = 1; x < refImage.Width - 1; x++)
            {
                var pixelColor = ComputePixelColor(bitmap, x, y);
                result.SetPixel(x, y, pixelColor);
            }
        }

        return result;
    }
    
    private Color ComputePixelColor(Bitmap bitmap, int x, int y)
    {
        var pixelToModify = bitmap.GetPixel(x, y);
        var red = _offset;
        var green = _offset;
        var blue = _offset;
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                var pixel = bitmap.GetPixel(x + i, y + j);
                red += pixel.R * _filterMatrix[i + 1, j + 1];
                green += pixel.G * _filterMatrix[i + 1, j + 1];
                blue += pixel.B * _filterMatrix[i + 1, j + 1];
            }
        }
        
        return Color.FromArgb(255,
            Math.Max(Math.Min(red/_divider, 255), 0),
            Math.Max(Math.Min(green/_divider, 255), 0),
            Math.Max(Math.Min(blue/_divider, 255), 0));
    }
}