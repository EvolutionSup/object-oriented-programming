using System.Drawing;

namespace FiguresLib
{
    public class Triangle : Polygon
    {
        public Triangle(int id, Point[] points) : base(id, points)
        {
            name = "Треугольник";
        }
    }
}
