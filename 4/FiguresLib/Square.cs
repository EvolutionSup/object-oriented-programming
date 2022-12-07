namespace FiguresLib
{
    public class Square : Rectangle
    {
        public Square(int id, int x, int y, int w, string name) : base(id, x, y, w, w)
        {
            this.name = "Квадрат";
            this.n_name = name;
        }
    }
}
