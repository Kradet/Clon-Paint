using System.Drawing;
using System.Drawing.Drawing2D;

namespace Figuras
{
    public class Triangulo : Poligono
    {
        public Point puntoInicial { get; set; }
        public Point puntoMedio { get; set; }
        public Point puntoFinal { get; set; }

        public Triangulo()
        {

        }

        public Triangulo(Point inicial, Point medio, Point final, Color color) : base(color)
        {

            gp = new GraphicsPath();
            Point[] vertices = {inicial, medio, final};
            gp.AddPolygon(vertices);
            gp.CloseFigure();
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
    }
}