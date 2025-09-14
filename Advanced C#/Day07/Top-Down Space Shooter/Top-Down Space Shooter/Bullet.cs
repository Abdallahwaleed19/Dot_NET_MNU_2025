using System.Drawing;
public class Bullet
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Speed { get; set; }
    public bool IsActive { get; set; }

    public Bullet(int x, int y, int w, int h, int s)
    {
        X = x; Y = y; Width = w; Height = h; Speed = s; IsActive = true;
    }
    public Rectangle GetBounds() => new Rectangle(X, Y, Width, Height);
}