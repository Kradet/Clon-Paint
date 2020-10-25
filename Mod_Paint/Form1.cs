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
        List<Poligono> ColeccionPoligono;
        Poligono poligonoSeleccionado;

        Triangulo objTri;
        Rombo objRom;
        Cuadrado objCua;
        Circulo objCir;

        Graphics g;
        HerramientaSeleccionada herramienta;
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
            poligonoSeleccionado = null;

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

            ColeccionPoligono = new List<Poligono>();

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
                    foreach (Poligono item in ColeccionPoligono)
                    {
                        if (item.Dentro(p))
                        {
                            poligonoSeleccionado = item;
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
                    if (poligonoSeleccionado != null)
                    {
                        poligonoSeleccionado.Mover(e.Location.X - posicion.X, e.Location.Y - posicion.Y);
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
                    if (objTri.puntoFinal != control)
                    {
                        ColeccionPoligono.Add(new Triangulo(objTri.puntoInicial, objTri.puntoMedio, objTri.puntoFinal, color));
                        panelDibujo.Invalidate();
                    }
                    break;
                case HerramientaSeleccionada.Rombo:
                    if (objRom.puntoFinal != control)
                    {
                        ColeccionPoligono.Add(new Rombo(objRom.puntoInicial, objRom.puntoFinal, objRom.punto3, objRom.punto4, color));
                        panelDibujo.Invalidate();
                    }
                    break;
                case HerramientaSeleccionada.Cuadrado:
                    if (objCua.puntoFinal != control)
                    {
                        ColeccionPoligono.Add(new Cuadrado(objCua.puntoInicial, objCua.puntoFinal, color));
                        panelDibujo.Invalidate();
                    }
                    break;
                case HerramientaSeleccionada.Circulo:
                    if (objCir.puntoFinal != control)
                    {
                        ColeccionPoligono.Add(new Circulo(objCir.puntoInicial, objCir.puntoFinal, color));
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
            foreach (Poligono item in ColeccionPoligono)
            {
                item.Dibujar(e.Graphics);
            }
        }
    }
}