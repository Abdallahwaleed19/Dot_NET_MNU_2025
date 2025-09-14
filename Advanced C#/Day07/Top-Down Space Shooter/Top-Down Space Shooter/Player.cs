using System.Drawing;
public class Player
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Speed { get; set; }
    public bool IsAlive { get; set; }
    public Image PlayerImage { get; set; }

    public Player(int x, int y, int w, int h, int s, Image img)
    {
        X = x; Y = y; Width = w; Height = h; Speed = s; PlayerImage = img; IsAlive = true;
    }
    public Rectangle GetBounds() => new Rectangle(X, Y, Width, Height);
}