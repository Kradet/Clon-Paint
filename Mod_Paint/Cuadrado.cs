using System.Drawing;
using System.Drawing.Drawing2D;

namespace Mod_Paint
{
    class Cuadrado
    {
        GraphicsPath gp;
        Color color;
        public Point puntoInicial { get; set; }
        public Point puntoFinal { get; set; }

        public Cuadrado()
        {

        }

        public Cuadrado(Point inicial, Point final, Color color)
        {
            gp = new GraphicsPath();
            Rectangle rectangle = new Rectangle(inicial, new Size(final.X - inicial.X, final.X - inicial.X));
            gp.AddRectangle(rectangle);
            gp.CloseFigure();
            this.color = color;
        }

        public void DibujarCuadrado(Graphics g, Color color, Point inicial, Point final)
        {
            Rectangle r = new Rectangle(inicial, new Size(final.X - inicial.X, final.X - inicial.X));
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawRectangle(new Pen(color, 2), r);
            g.Dispose();
        }

        public void Dibujar(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawPath(new Pen(color, 2), gp);
        }

        public bool Dentro(Point p)
        {
            if (gp.IsOutlineVisible(p, new Pen(color)))
            {
                return true;
            }
            else
            {
                return gp.IsVisible(p);
            }
        }

        public void Mover(int x, int y)
        {
            gp.Transform(new Matrix(1, 0, 0, 1, x, y));
        }
    }
}
