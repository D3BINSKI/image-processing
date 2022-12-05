using System.Diagnostics;
using System.Numerics;

namespace WinFormsApp;

public class EditorPanel
{
    private PictureBox _editorPictureBox;
    private Bitmap _savedEditorBitmap;
    private Bitmap? _modifiedEditorBitmap;

    public Image Image => _savedEditorBitmap;

    public EditorPanel(Image image, PictureBox pictureBox)
    {
        _editorPictureBox = pictureBox;
        _editorPictureBox.Image = image;
        _savedEditorBitmap = new Bitmap(image);
        _modifiedEditorBitmap = _savedEditorBitmap.Clone() as Bitmap;

        UpdateCanvas();            
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
        _modifiedEditorBitmap = (Bitmap)filter.Apply(_modifiedEditorBitmap!);
    }

    public void SavePreview()
    {
        if (_modifiedEditorBitmap != null)
        {
            _savedEditorBitmap = (_modifiedEditorBitmap.Clone() as Bitmap)!;
        }
    }

    public void RevertChanges()
    {
        _modifiedEditorBitmap = _savedEditorBitmap.Clone() as Bitmap;
        UpdateCanvas();
    }
}