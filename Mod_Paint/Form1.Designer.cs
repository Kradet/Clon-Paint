namespace Mod_Paint
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblLocalizacion = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnPun = new System.Windows.Forms.Button();
            this.btnRom = new System.Windows.Forms.Button();
            this.btnCua = new System.Windows.Forms.Button();
            this.btnCir = new System.Windows.Forms.Button();
            this.btnTri = new System.Windows.Forms.Button();
            this.bntColor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(230, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "|";
            // 
            // panelDibujo
            // 
            this.panelDibujo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDibujo.AutoSize = true;
            this.panelDibujo.BackColor = System.Drawing.Color.White;
            this.panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDibujo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelDibujo.Location = new System.Drawing.Point(2, 39);
            this.panelDibujo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(797, 383);
            this.panelDibujo.TabIndex = 6;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            this.panelDibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDibujo_MouseDown);
            this.panelDibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDibujo_MouseMove);
            this.panelDibujo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDibujo_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntColor);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblLocalizacion);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(233, 428);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(107, 18);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Herramienta: ";
            // 
            // lblLocalizacion
            // 
            this.lblLocalizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLocalizacion.AutoSize = true;
            this.lblLocalizacion.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalizacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizacion.Location = new System.Drawing.Point(3, 428);
            this.lblLocalizacion.Name = "lblLocalizacion";
            this.lblLocalizacion.Size = new System.Drawing.Size(111, 18);
            this.lblLocalizacion.TabIndex = 0;
            this.lblLocalizacion.Text = "Localización: ";
            // 
            // btnPun
            // 
            this.btnPun.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPun.BackgroundImage")));
            this.btnPun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPun.FlatAppearance.BorderSize = 0;
            this.btnPun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPun.Location = new System.Drawing.Point(196, 3);
            this.btnPun.Name = "btnPun";
            this.btnPun.Size = new System.Drawing.Size(40, 30);
            this.btnPun.TabIndex = 4;
            this.btnPun.UseVisualStyleBackColor = false;
            this.btnPun.Click += new System.EventHandler(this.btnPun_Click);
            // 
            // btnRom
            // 
            this.btnRom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRom.BackgroundImage")));
            this.btnRom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRom.FlatAppearance.BorderSize = 0;
            this.btnRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRom.Location = new System.Drawing.Point(58, 3);
            this.btnRom.Name = "btnRom";
            this.btnRom.Size = new System.Drawing.Size(40, 30);
            this.btnRom.TabIndex = 3;
            this.btnRom.UseVisualStyleBackColor = false;
            this.btnRom.Click += new System.EventHandler(this.btnRom_Click);
            // 
            // btnCua
            // 
            this.btnCua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCua.BackgroundImage")));
            this.btnCua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCua.FlatAppearance.BorderSize = 0;
            this.btnCua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCua.Location = new System.Drawing.Point(104, 3);
            this.btnCua.Name = "btnCua";
            this.btnCua.Size = new System.Drawing.Size(40, 30);
            this.btnCua.TabIndex = 2;
            this.btnCua.UseVisualStyleBackColor = false;
            this.btnCua.Click += new System.EventHandler(this.btnCua_Click);
            // 
            // btnCir
            // 
            this.btnCir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCir.BackgroundImage")));
            this.btnCir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCir.FlatAppearance.BorderSize = 0;
            this.btnCir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCir.Location = new System.Drawing.Point(150, 3);
            this.btnCir.Name = "btnCir";
            this.btnCir.Size = new System.Drawing.Size(40, 30);
            this.btnCir.TabIndex = 1;
            this.btnCir.UseVisualStyleBackColor = false;
            this.btnCir.Click += new System.EventHandler(this.btnCir_Click);
            // 
            // btnTri
            // 
            this.btnTri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTri.BackgroundImage")));
            this.btnTri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTri.FlatAppearance.BorderSize = 0;
            this.btnTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTri.Location = new System.Drawing.Point(12, 3);
            this.btnTri.Name = "btnTri";
            this.btnTri.Size = new System.Drawing.Size(40, 30);
            this.btnTri.TabIndex = 0;
            this.btnTri.UseVisualStyleBackColor = false;
            this.btnTri.Click += new System.EventHandler(this.btnTri_Click);
            // 
            // bntColor
            // 
            this.bntColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bntColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntColor.BackgroundImage")));
            this.bntColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntColor.FlatAppearance.BorderSize = 0;
            this.bntColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntColor.Location = new System.Drawing.Point(269, 5);
            this.bntColor.Name = "bntColor";
            this.bntColor.Size = new System.Drawing.Size(40, 30);
            this.bntColor.TabIndex = 8;
            this.bntColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bntColor.UseVisualStyleBackColor = false;
            this.bntColor.Click += new System.EventHandler(this.bntColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.btnPun);
            this.Controls.Add(this.btnRom);
            this.Controls.Add(this.btnCua);
            this.Controls.Add(this.btnCir);
            this.Controls.Add(this.btnTri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clon-Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTri;
        private System.Windows.Forms.Button btnCir;
        private System.Windows.Forms.Button btnCua;
        private System.Windows.Forms.Button btnRom;
        private System.Windows.Forms.Button btnPun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblLocalizacion;
        private System.Windows.Forms.Button bntColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

