using System.Diagnostics;
using System.Drawing.Design;
using System.Numerics;

namespace WinFormsApp;

public class EditorPanel
{
    private PictureBox _editorPictureBox;
    private Bitmap _savedEditorBitmap;
    private Bitmap? _modifiedEditorBitmap;
    private List<PointF[]> _polygons;
    private List<PointF>? _newPolygon;
    private List<(PointF point, int radius)> _brushPoints;
    private MatrixFilter _currentFilter;

    public Image Image => _savedEditorBitmap;

    public EditorPanel(Image image, PictureBox pictureBox)
    {
        _editorPictureBox = pictureBox;
        _editorPictureBox.Image = image;
        _savedEditorBitmap = new Bitmap(image);
        _modifiedEditorBitmap = _savedEditorBitmap.Clone() as Bitmap;
        _polygons = new List<PointF[]>();
        _brushPoints = new List<(PointF, int)>();

        UpdateCanvas();            
    }

    public void SetImage(Image image)
    {
        RevertChanges();
        _editorPictureBox.Image = image;
        _savedEditorBitmap = new Bitmap(image);
        _modifiedEditorBitmap = _savedEditorBitmap.Clone() as Bitmap;
        _editorPictureBox.Refresh();
    }

    public static EditorPanel FromPath(string path, PictureBox pictureBox) => new EditorPanel(Image.FromFile(path), pictureBox);

    public void UpdateCanvas()
    {
        using var g = Graphics.FromImage(_editorPictureBox.Image);

        g.DrawImage(_modifiedEditorBitmap!, 0, 0);
        _editorPictureBox.Refresh();
    }

    public void ApplyFilter(MatrixFilter filter)
    {
         _editorPictureBox.Image = (Bitmap)filter.Apply(_savedEditorBitmap!);
         _editorPictureBox.Refresh();
    }
    
    public void SetFilter(MatrixFilter filter)
    {
        _currentFilter = filter;
        _modifiedEditorBitmap = (Bitmap)filter.Apply(_savedEditorBitmap!);

        if (_brushPoints.Count <= 0) return;
        
        var brush = new TextureBrush(_modifiedEditorBitmap);
        var g = Graphics.FromImage(_editorPictureBox.Image);
        foreach (var brushPoint in _brushPoints)
        {
            g.FillEllipse(brush, brushPoint.point.X - 20, brushPoint.point.Y - 20, brushPoint.radius, brushPoint.radius);
        }
        _editorPictureBox.Refresh();
    }

    public void UpdatePolygonArea(MatrixFilter filter)
    {
        if (_polygons.Count == 0)
            return;
        
        var filteredImage = filter.Apply(_savedEditorBitmap);
        using var g = Graphics.FromImage(_editorPictureBox.Image);
        
        var brush = new TextureBrush(filteredImage);

        foreach (var polygon in _polygons)
        {
            g.FillPolygon(brush, polygon);
        }
        _editorPictureBox.Refresh();
    }
    
    public void UpdateBrushArea(PointF point, int radius)
    {
        using var g = Graphics.FromImage(_editorPictureBox.Image);
        var brush = new TextureBrush(_modifiedEditorBitmap!);
        
        g.FillEllipse(brush, point.X-20, point.Y-20, radius, radius);
        _editorPictureBox.Refresh();
    }

    public void SavePreview()
    {
        _savedEditorBitmap = (_editorPictureBox.Image.Clone() as Bitmap)!;
        _modifiedEditorBitmap = (Bitmap)_currentFilter.Apply(_savedEditorBitmap);
        _polygons.Clear();
        _brushPoints.Clear();
    }

    public void RevertChanges()
    {
        _editorPictureBox.Image = _savedEditorBitmap.Clone() as Bitmap;
        _editorPictureBox.Refresh();
        _polygons.Clear();
        _brushPoints.Clear();
    }
    
    public bool AddPointToPolygon(PointF point)
    {
        _newPolygon ??= new List<PointF>();

        if (_newPolygon.Count < 3)
        {
            _newPolygon.Add(point);
        }
        else if(Math.Abs(_newPolygon[0].X - _newPolygon[^1].X) < 10 && Math.Abs(_newPolygon[0].Y - _newPolygon[^1].Y) < 10)
        {
            _polygons.Add(_newPolygon.ToArray());
            _newPolygon = null;
            ClearPolygonPreview();
            return false;
        }

        _newPolygon.Add(point);
        DrawPolygonPreview();
        return true;
    }

    public void Brush(PointF point, int radius)
    {
        _brushPoints!.Add((point, radius));
        UpdateBrushArea(point, radius);
    }

    private void DrawPolygonPreview()
    {
        if (_newPolygon == null)
            return;
        
        using var g = Graphics.FromImage(_editorPictureBox.Image);
        var pen = new Pen(Brushes.Black, 3);
        g.DrawLines(pen, _newPolygon.ToArray());
        _editorPictureBox.Refresh();
    }
    
    private void ClearPolygonPreview()
    {
        using var g = Graphics.FromImage(_editorPictureBox.Image);
        g.DrawImage(_savedEditorBitmap, 0, 0);
        _editorPictureBox.Refresh();
    }
}