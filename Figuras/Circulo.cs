using System.Drawing;
using System.Drawing.Drawing2D;

namespace Figuras
{
    public class Circulo:Poligono
    {
        public Point puntoInicial { get; set; }
        public Point puntoFinal { get; set; }

        public Circulo()
        {

        }

        public Circulo(Point inicial, Point final, Color color)
        {
            gp = new GraphicsPath();
            gp.AddEllipse(new Rectangle(inicial, new Size(final.X - inicial.X, final.X - inicial.X)));
            gp.CloseFigure();
            this.color = color;
        }

        public void DibujarCirculo(Graphics g, Color color, Point inicial, Point final)
        {
            Rectangle r = new Rectangle(inicial, new Size(final.X - inicial.X, final.X - inicial.X));
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawEllipse(new Pen(color,2), r);
            g.Dispose();
        }
    }
}
