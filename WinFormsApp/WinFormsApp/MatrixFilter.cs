using System.Drawing.Drawing2D;
using System.Numerics;

namespace WinFormsApp;

static class PredefinedMatrix
{
    public static readonly int[,] Negative = new int[3, 3]
    {
        {0, 0, 0}, 
        {0, -1, 0}, 
        {0, 0, 0}};
    
    public static readonly int[,] Identity = new int[3, 3]
    {
        {1, 0, 0}, 
        {0, 1, 0}, 
        {0, 0, 1}};
    
    public static readonly int[,] Blur = new int[3, 3]
    {
        {1, 1, 1}, 
        {1, 1, 1}, 
        {1, 1, 1}};
    
    public static readonly int[,] Sharpening = new int[3, 3]
    {
        {0, -1, 0}, 
        {-1, 5, -1}, 
        {0, -1, 0}};
    
    public static readonly int[,] Carving = new int[3, 3]
    {
        {0, 0, 0}, 
        {0, 3, 1}, 
        {0, 1, 1}};
    
}

public class MatrixFilter
{
    private int _offset;
    public Matrix Matrix { get; set; }
    private int[,] _filterMatrix;
    public MatrixFilter(int[,] matrix, int offset)
    {
        _filterMatrix = matrix;
        _offset = offset;
    }

    public Image Apply(Image refImage)
    {
        var bitmap = (Bitmap)refImage;
        var result = new Bitmap(bitmap.Width, bitmap.Height);
        for (int y = 1; y < refImage.Height - 1; y++)
        {
            for (int x = 1; x < refImage.Width - 1; x++)
            {
                var pixelColor = ComputePixelColor(bitmap, x, y, _filterMatrix);
                result.SetPixel(x, y, pixelColor);
            }
        }

        return result;
    }

    private Color ComputePixelColor(Bitmap bitmap, int x, int y, int[,] filterMatrix)
    {
        var pixelToModify = bitmap.GetPixel(x, y);
        var red = _offset;
        var green = _offset;
        var blue = _offset;
        var divider = 0;
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                divider += filterMatrix[i + 1, j + 1];
                var pixel = bitmap.GetPixel(x + i, y + j);
                red += pixel.R * filterMatrix[i + 1, j + 1];
                green += pixel.G * filterMatrix[i + 1, j + 1];
                blue += pixel.B * filterMatrix[i + 1, j + 1];
            }
        }

        divider = divider == 0 ? 1 : Math.Abs(divider);

        return Color.FromArgb(
            Math.Min(red/divider, 255),
            Math.Min(green/divider, 255),
            Math.Min(blue/divider, 255));
    }
}