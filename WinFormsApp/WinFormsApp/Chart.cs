namespace WinFormsApp;

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