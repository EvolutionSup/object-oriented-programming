using System.Drawing;
using System.Drawing.Drawing2D;

namespace FiguresLib
{
    public class Square : Rectangle
    {
        public Matrix matrix = new Matrix();
        public Square(int id, int x, int y, int w, string name) : base(id, x, y, w, w)
        {
            this.name = "Квадрат";
            this.n_name = name;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Transform = matrix;
            g.DrawRectangle(Init.pen, x, y, w, h);
            Init.pictureBox.Image = Init.bitmap;
        }
    }
}
