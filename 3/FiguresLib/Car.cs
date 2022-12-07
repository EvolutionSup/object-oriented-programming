using System.Collections.Generic;
using System.Drawing;

namespace FiguresLib
{
    public class Car : Rectangle
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public Rectangle r1;
        public Rectangle r2;
        public Square sq1;
        public Square sq2;
        public Circle circle1;
        public Circle circle2;
        public Triangle triangle1;
        public List<Figure> figures;
        public Car(int id, int x, int y, int w, int h) : base(id, x - 100, y - 60, w, h)
        {
            name = "Грузовик";
            figures = new List<Figure>();
            r1 = new Rectangle(0, x - 100, y, 100, 50);
            r2 = new Rectangle(0, x + 4, y - 50, 50, 100);
            sq1 = new Square(0, x + 16, y - 25, 25);
            sq2 = new Square(0, x + 58, y + 7, 42);
            circle1 = new Circle(0, x - 85, y + 53, 20);
            circle2 = new Circle(0, x + 40, y + 53, 20);
            Point point1 = new Point(x - 100, y - 2);
            Point point2 = new Point(x - 1, y - 2);
            Point point3 = new Point(x - 50, y - 60);
            Point[] tri_points = { point1, point2, point3 };
            triangle1 = new Triangle(0, tri_points);
            Figure[] fs = { r1, r2, sq1, sq2, circle1, circle2, triangle1 };
            figures.AddRange(fs);
        }

        public override void Draw()
        {
            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        Init.pen.Color = Color.DarkRed;
                        r1.Draw();
                        break;
                    case 1:
                        Init.pen.Color = Color.Green;
                        r2.Draw();
                        break;
                    case 2:
                        Init.pen.Color = Color.Red;
                        sq1.Draw();
                        break;
                    case 3:
                        Init.pen.Color = Color.Blue;
                        sq2.Draw();
                        break;
                    case 4:
                        Init.pen.Color = Color.Brown;
                        circle1.Draw();
                        break;
                    case 5:
                        Init.pen.Color = Color.Brown;
                        circle2.Draw();
                        break;
                    case 6:
                        Init.pen.Color = Color.Yellow;
                        triangle1.Draw();
                        break;
                }
            }
            Init.pen.Color = Color.Black;
        }
        public override void MoveTo(int x, int y)
        {
            Init.Clear();
            this.x += x;
            this.y += y;
            for (int i = 0; i < 7; i++)
            {
                Figure figure = figures[i];
                if (figure.points != null)
                {
                    for (int j = 0; j < figure.points.Length; j++)
                    {
                        figure.points[j].X += x;
                        figure.points[j].Y += y;
                    }
                    figure.x = figure.points[0].X;
                    figure.y = figure.points[0].Y;
                }
                else
                {
                    figure.x += x;
                    figure.y += y;
                }
                
            }
            this.Draw();
            foreach (Figure f in ShapeContainer.figureList)
            {
                f.Draw();
            }
        }
    }
}
