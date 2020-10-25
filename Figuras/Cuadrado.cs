using System.Drawing;
using System.Drawing.Drawing2D;

namespace Figuras
{
    public class Cuadrado:Poligono
    {
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
    }
}
