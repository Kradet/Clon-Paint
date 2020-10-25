using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Figuras;

namespace Mod_Paint
{
    public enum HerramientaSeleccionada
    {
        Puntero, Triangulo, Rombo, Cuadrado, Circulo
    }


    public partial class Form1 : Form
    {


        List<Triangulo> TriColeccion;
        List<Rombo> RomColeccion;
        List<Cuadrado> CuaColeccion;
        List<Circulo> CirColeccion;
        Triangulo triSelec, objTri;
        Rombo romSelec, objRom;
        Cuadrado cuaSelec, objCua;
        Circulo cirSelec, objCir;

        Graphics g;
        static HerramientaSeleccionada herramienta;
        Point posicion;
        Point p;
        Point control = new Point(0, 0);
        Color color;
        bool click;

        public Form1()
        {
            InitializeComponent();
        }

        public void VerificarNulos()
        {
            if (objTri == null)
                objTri = new Triangulo();
            if (objRom == null)
                objRom = new Rombo();
            if (objCua == null)
                objCua = new Cuadrado();
            if (objCir == null)
                objCir = new Circulo();
        }

        public void ReestablecerValores()
        {
            triSelec = null;
            romSelec = null;
            cuaSelec = null;
            cirSelec = null;

            objTri = null;
            objRom = null;
            objCua = null;
            objCir = null;

            click = false;
            herramienta = HerramientaSeleccionada.Puntero;
            lblEstado.Text = $"Herramienta: {herramienta.ToString()}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReestablecerValores();

            TriColeccion = new List<Triangulo>();
            RomColeccion = new List<Rombo>();
            CuaColeccion = new List<Cuadrado>();
            CirColeccion = new List<Circulo>();

            objTri = new Triangulo();
            objRom = new Rombo();
            objCua = new Cuadrado();
            objCir = new Circulo();

            color = Color.Black;
            g = panelDibujo.CreateGraphics();
        }

        private void btnTri_Click(object sender, EventArgs e)
        {
            herramienta = HerramientaSeleccionada.Triangulo;
            VerificarNulos();
            lblEstado.Text = $"Herramienta: {herramienta.ToString()}";
        }

        private void btnRom_Click(object sender, EventArgs e)
        {
            herramienta = HerramientaSeleccionada.Rombo;
            VerificarNulos();
            lblEstado.Text = $"Herramienta: {herramienta.ToString()}";
        }

        private void btnCua_Click(object sender, EventArgs e)
        {
            herramienta = HerramientaSeleccionada.Cuadrado;
            VerificarNulos();
            lblEstado.Text = $"Herramienta: {herramienta.ToString()}";
        }

        private void btnCir_Click(object sender, EventArgs e)
        {
            herramienta = HerramientaSeleccionada.Circulo;
            VerificarNulos();
            lblEstado.Text = $"Herramienta: {herramienta.ToString()}";
        }

        private void btnPun_Click(object sender, EventArgs e)
        {
            herramienta = HerramientaSeleccionada.Puntero;
            lblEstado.Text = $"Herramienta: {herramienta.ToString()}";
        }

        private void bntColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }

        private void panelDibujo_MouseDown(object sender, MouseEventArgs e)
        {
            switch (herramienta)
            {
                case HerramientaSeleccionada.Puntero:
                    p = panelDibujo.PointToClient(Cursor.Position);
                    foreach (Triangulo item in TriColeccion)
                    {
                        if (item.Dentro(p))
                        {
                            triSelec = item;
                            posicion = p;
                            break;
                        }
                    }
                    foreach (Rombo item in RomColeccion)
                    {
                        if (item.Dentro(p))
                        {
                            romSelec = item;
                            posicion = p;
                            break;
                        }
                    }
                    foreach (Cuadrado item in CuaColeccion)
                    {
                        if (item.Dentro(p))
                        {
                            cuaSelec = item;
                            posicion = p;
                            break;
                        }
                    }
                    foreach (Circulo item in CirColeccion)
                    {
                        if (item.Dentro(p))
                        {
                            cirSelec = item;
                            posicion = p;
                            break;
                        }
                    }
                    break;

                case HerramientaSeleccionada.Triangulo:
                    click = true;
                    objTri.puntoInicial = e.Location;
                    break;

                case HerramientaSeleccionada.Rombo:
                    click = true;
                    objRom.puntoInicial = e.Location;
                    break;

                case HerramientaSeleccionada.Cuadrado:
                    click = true;
                    objCua.puntoInicial = e.Location;
                    break;

                case HerramientaSeleccionada.Circulo:
                    click = true;
                    objCir.puntoInicial = e.Location;
                    break;

                default:
                    break;
            }
        }

        private void panelDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            lblLocalizacion.Text = $"Localización: {e.Location.X}, {e.Location.Y}";

            switch (herramienta)
            {
                case HerramientaSeleccionada.Puntero:

                    if (triSelec != null)
                    {
                        triSelec.Mover(e.Location.X - posicion.X, e.Location.Y - posicion.Y);
                        panelDibujo.Invalidate(); //Invalidamos para que nos vuelva a enviar el evento draw
                        posicion = e.Location;
                    }
                    else if (cuaSelec != null)
                    {
                        cuaSelec.Mover(e.Location.X - posicion.X, e.Location.Y - posicion.Y);
                        panelDibujo.Invalidate();
                        posicion = e.Location;
                    }
                    else if (romSelec != null)
                    {
                        romSelec.Mover(e.Location.X - posicion.X, e.Location.Y - posicion.Y);
                        panelDibujo.Invalidate();
                        posicion = e.Location;
                    }
                    else if (cirSelec != null)
                    {
                        cirSelec.Mover(e.Location.X - posicion.X, e.Location.Y - posicion.Y);
                        panelDibujo.Invalidate();
                        posicion = e.Location;
                    }
                    break;

                case HerramientaSeleccionada.Triangulo:
                    if (click)
                    {
                        g = panelDibujo.CreateGraphics();
                        g.Clear(Color.White);
                        objTri.puntoFinal = e.Location;
                        objTri.DibujarTriangulo(g, color, objTri.puntoInicial, objTri.puntoFinal);
                    }
                    break;

                case HerramientaSeleccionada.Rombo:
                    if (click)
                    {
                        g = panelDibujo.CreateGraphics();
                        g.Clear(Color.White);
                        objRom.puntoFinal = e.Location;
                        objRom.DibujarRombo(g, color, objRom.puntoInicial, objRom.puntoFinal);
                    }
                    break;

                case HerramientaSeleccionada.Cuadrado:
                    if (click)
                    {
                        g = panelDibujo.CreateGraphics();
                        g.Clear(Color.White);
                        objCua.puntoFinal = e.Location;
                        objCua.DibujarCuadrado(g, color, objCua.puntoInicial, objCua.puntoFinal);
                    }
                    break;

                case HerramientaSeleccionada.Circulo:
                    if (click)
                    {
                        g = panelDibujo.CreateGraphics();
                        g.Clear(Color.White);
                        objCir.puntoFinal = e.Location;
                        objCir.DibujarCirculo(g, color, objCir.puntoInicial, objCir.puntoFinal);
                    }
                    break;

                default:
                    break;
            }
        }

        private void panelDibujo_MouseUp(object sender, MouseEventArgs e)
        {
            switch (herramienta)
            {
                case HerramientaSeleccionada.Triangulo:
                    //Error de calculo al tener un triangulo y cualquier figura ya dibujado y dar click sin mover el puntero
                    //Por resolver; ith, es el punto medio
                    if (objTri.puntoFinal != control)
                    {
                        TriColeccion.Add(new Triangulo(objTri.puntoInicial, objTri.puntoMedio, objTri.puntoFinal, color));
                        panelDibujo.Invalidate();
                    }
                    break;
                case HerramientaSeleccionada.Rombo:
                    if (objRom.puntoFinal != control)
                    {
                        RomColeccion.Add(new Rombo(objRom.puntoInicial, objRom.puntoFinal, objRom.punto3, objRom.punto4, color));
                        panelDibujo.Invalidate();
                    }
                    break;
                case HerramientaSeleccionada.Cuadrado:
                    if (objCua.puntoFinal != control)
                    {
                        CuaColeccion.Add(new Cuadrado(objCua.puntoInicial, objCua.puntoFinal, color));
                        panelDibujo.Invalidate();
                    }
                    break;
                case HerramientaSeleccionada.Circulo:
                    if (objCir.puntoFinal != control)
                    {
                        CirColeccion.Add(new Circulo(objCir.puntoInicial, objCir.puntoFinal, color));
                        panelDibujo.Invalidate();
                    }
                    break;

                default:
                    break;
            }

            ReestablecerValores();
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            foreach (Triangulo item in TriColeccion)
            {
                item.Dibujar(e.Graphics);
            }
            foreach (Rombo item in RomColeccion)
            {
                item.Dibujar(e.Graphics);
            }
            foreach (Cuadrado item in CuaColeccion)
            {
                item.Dibujar(e.Graphics);
            }
            foreach (Circulo item in CirColeccion)
            {
                item.Dibujar(e.Graphics);
            }
        }
    }
}