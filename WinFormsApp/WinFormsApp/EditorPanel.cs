using System.Numerics;

namespace WinFormsApp;

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

    public void ApplyFilter(MatrixFilter filter)
    {
        _editorPictureBox.Image = filter.Apply(_editorBitmap);
    }

    public void SavePreview()
    {
        _editorBitmap = (Bitmap)_editorPictureBox.Image;
    }
}