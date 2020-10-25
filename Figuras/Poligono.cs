using System.Drawing;
using System.Drawing.Drawing2D;

namespace Figuras
{
    public abstract class Poligono
    {
        protected Point control = new Point(0, 0);
        public Point Control { get => control; }
        protected GraphicsPath gp;
        protected Color color;

        public Poligono(){}

        public Poligono(Color color)
        {
            this.color = color;
        }

        public void Dibujar(Graphics e)
        {
            Pen lapiz = new Pen(color, 2);
            e.SmoothingMode = SmoothingMode.AntiAlias;
            e.DrawPath(lapiz, gp);
        }

        public bool Dentro(Point p)
        {
            if (gp.IsOutlineVisible(p, new Pen(color, 2)))
            {
                return true;
            }
            else
            {
                return gp.IsVisible(p);
            }
        }

        public void Mover(int dx, int dy)
        {
            gp.Transform(new Matrix(1, 0, 0, 1, dx, dy));
        }
    }
}
