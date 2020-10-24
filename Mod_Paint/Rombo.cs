using System.Drawing;
using System.Drawing.Drawing2D;

namespace Mod_Paint
{
    class Rombo
    {
        GraphicsPath gp;
        public Point puntoInicial { get; set; }
        public Point puntoFinal { get; set; }
        Point punto3;
        Point punto4;
        Color color;

        public Rombo(Point punto1, Point punto2, Point punto3, Point punto4, Color color)
        {
            gp = new GraphicsPath();
            Point[] vertices = { punto1, punto2, punto3, punto4 };
            gp.AddPolygon(vertices);
            gp.CloseAllFigures();
            this.color = color;
        }

        public void DibujarRombo(Graphics g, Color color, Point inicial, Point final)
        {
            Pen lapiz = new Pen(color, 2);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //Calculamos los otros dos puntos, el inferior y el izquierdo
            punto3 = new Point(inicial.X, (final.Y - inicial.Y) + final.Y);
            punto4 = new Point(inicial.X - (final.X - inicial.X), final.Y);

            //Dibujamos el poligono en sentido horario
            g.DrawLine(lapiz, inicial, final);
            g.DrawLine(lapiz, final, punto3);
            g.DrawLine(lapiz, punto3, punto4);
            g.DrawLine(lapiz, punto4, inicial);

            g.Dispose();
            lapiz.Dispose();
        }

        public void Dibujar(Graphics e)
        {
            Pen lapiz = new Pen(color, 2);
            e.SmoothingMode = SmoothingMode.AntiAlias;
            e.DrawPath(lapiz, gp);
        }

        public bool Dentro(Point p)
        {
            if(gp.IsOutlineVisible(p, new Pen(color)))
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
