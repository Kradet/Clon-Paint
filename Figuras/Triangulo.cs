using System.Drawing;
using System.Drawing.Drawing2D;

namespace Figuras
{
    public class Triangulo
    {
        GraphicsPath gp;
        public Point puntoInicial { get; set; }
        public Point puntoMedio { get; set; }
        public Point puntoFinal { get; set; }
        Color color;

        public Triangulo()
        {

        }

        public Triangulo(Point inicial, Point medio, Point final, Color color)
        {

            gp = new GraphicsPath();
            Point[] vertices = {inicial, medio, final};
            gp.AddPolygon(vertices);
            gp.CloseFigure();
            this.color = color;
        }

        // Dibuja un triangulo y despues lo borra en tiempo real
        public void DibujarTriangulo(Graphics g, Color color, Point inicial, Point final)
        {
            Pen lapiz = new Pen(color, 2);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //Calculando el punto final de la izquierda, o punto medio **Las variables puntoFinal y punto Inicial, nos dan la parte derecha
            puntoMedio = new Point(inicial.X - (final.X - inicial.X), final.Y);

            g.DrawLine(lapiz, inicial, final);
            g.DrawLine(lapiz, final, puntoMedio);
            g.DrawLine(lapiz, puntoMedio, inicial);

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