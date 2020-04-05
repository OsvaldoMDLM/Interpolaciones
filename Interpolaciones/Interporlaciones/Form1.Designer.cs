namespace Interporlaciones
{
    partial class Interpolaciones
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interpolaciones));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnLineal = new System.Windows.Forms.Button();
            this.btnCuadratica = new System.Windows.Forms.Button();
            this.btnLagrange = new System.Windows.Forms.Button();
            this.imagenInicio = new System.Windows.Forms.PictureBox();
            this.panelizquierdo = new System.Windows.Forms.Panel();
            this.lbltipo_de_interpolacion = new System.Windows.Forms.Label();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submenulagrange = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bntPrimerGrado = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSegundoGrado = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PicSalir = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imagenInicio)).BeginInit();
            this.panelizquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.submenulagrange.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbltitulo.Location = new System.Drawing.Point(431, 9);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(570, 36);
            this.lbltitulo.TabIndex = 3;
            this.lbltitulo.Text = "Programa para calcular interpolaciones";
            this.lbltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblinterpolacion_MouseDown);
            // 
            // btnLineal
            // 
            this.btnLineal.BackColor = System.Drawing.Color.Transparent;
            this.btnLineal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLineal.FlatAppearance.BorderSize = 0;
            this.btnLineal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnLineal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineal.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLineal.ForeColor = System.Drawing.Color.White;
            this.btnLineal.Location = new System.Drawing.Point(18, 187);
            this.btnLineal.Margin = new System.Windows.Forms.Padding(4);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(261, 55);
            this.btnLineal.TabIndex = 0;
            this.btnLineal.Text = "&Lineal";
            this.btnLineal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLineal.UseVisualStyleBackColor = false;
            this.btnLineal.Click += new System.EventHandler(this.btnLineal_Click);
            // 
            // btnCuadratica
            // 
            this.btnCuadratica.BackColor = System.Drawing.Color.Transparent;
            this.btnCuadratica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuadratica.FlatAppearance.BorderSize = 0;
            this.btnCuadratica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnCuadratica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuadratica.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadratica.ForeColor = System.Drawing.Color.White;
            this.btnCuadratica.Location = new System.Drawing.Point(18, 259);
            this.btnCuadratica.Margin = new System.Windows.Forms.Padding(4);
            this.btnCuadratica.Name = "btnCuadratica";
            this.btnCuadratica.Size = new System.Drawing.Size(261, 55);
            this.btnCuadratica.TabIndex = 1;
            this.btnCuadratica.Text = "&Cuadratica";
            this.btnCuadratica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCuadratica.UseVisualStyleBackColor = false;
            this.btnCuadratica.Click += new System.EventHandler(this.btnCuadratica_Click);
            // 
            // btnLagrange
            // 
            this.btnLagrange.BackColor = System.Drawing.Color.Transparent;
            this.btnLagrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLagrange.FlatAppearance.BorderSize = 0;
            this.btnLagrange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnLagrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLagrange.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLagrange.ForeColor = System.Drawing.Color.White;
            this.btnLagrange.Location = new System.Drawing.Point(18, 345);
            this.btnLagrange.Margin = new System.Windows.Forms.Padding(4);
            this.btnLagrange.Name = "btnLagrange";
            this.btnLagrange.Size = new System.Drawing.Size(261, 55);
            this.btnLagrange.TabIndex = 2;
            this.btnLagrange.Text = "La&grange";
            this.btnLagrange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLagrange.UseVisualStyleBackColor = false;
            this.btnLagrange.MouseEnter += new System.EventHandler(this.btnLagrange_MouseEnter);
            // 
            // imagenInicio
            // 
            this.imagenInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagenInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagenInicio.Image = ((System.Drawing.Image)(resources.GetObject("imagenInicio.Image")));
            this.imagenInicio.Location = new System.Drawing.Point(8, 9);
            this.imagenInicio.Name = "imagenInicio";
            this.imagenInicio.Size = new System.Drawing.Size(271, 129);
            this.imagenInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenInicio.TabIndex = 13;
            this.imagenInicio.TabStop = false;
            this.imagenInicio.Click += new System.EventHandler(this.imagenInicio_Click);
            // 
            // panelizquierdo
            // 
            this.panelizquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(223)))), ((int)(((byte)(34)))));
            this.panelizquierdo.Controls.Add(this.lbltipo_de_interpolacion);
            this.panelizquierdo.Controls.Add(this.Minimizar);
            this.panelizquierdo.Controls.Add(this.panel1);
            this.panelizquierdo.Controls.Add(this.submenulagrange);
            this.panelizquierdo.Controls.Add(this.panel3);
            this.panelizquierdo.Controls.Add(this.panel2);
            this.panelizquierdo.Controls.Add(this.PicSalir);
            this.panelizquierdo.Controls.Add(this.btnLineal);
            this.panelizquierdo.Controls.Add(this.imagenInicio);
            this.panelizquierdo.Controls.Add(this.btnCuadratica);
            this.panelizquierdo.Controls.Add(this.btnLagrange);
            this.panelizquierdo.Location = new System.Drawing.Point(-5, 42);
            this.panelizquierdo.Name = "panelizquierdo";
            this.panelizquierdo.Size = new System.Drawing.Size(287, 721);
            this.panelizquierdo.TabIndex = 16;
            // 
            // lbltipo_de_interpolacion
            // 
            this.lbltipo_de_interpolacion.AutoSize = true;
            this.lbltipo_de_interpolacion.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo_de_interpolacion.ForeColor = System.Drawing.Color.White;
            this.lbltipo_de_interpolacion.Location = new System.Drawing.Point(20, 141);
            this.lbltipo_de_interpolacion.Name = "lbltipo_de_interpolacion";
            this.lbltipo_de_interpolacion.Size = new System.Drawing.Size(252, 26);
            this.lbltipo_de_interpolacion.TabIndex = 20;
            this.lbltipo_de_interpolacion.Text = "Escoge una Interpolacion";
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(40, 613);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(68, 66);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 0;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(8, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 55);
            this.panel1.TabIndex = 18;
            // 
            // submenulagrange
            // 
            this.submenulagrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(223)))), ((int)(((byte)(34)))));
            this.submenulagrange.Controls.Add(this.panel7);
            this.submenulagrange.Controls.Add(this.panel4);
            this.submenulagrange.Controls.Add(this.bntPrimerGrado);
            this.submenulagrange.Controls.Add(this.panel5);
            this.submenulagrange.Controls.Add(this.btnSegundoGrado);
            this.submenulagrange.Location = new System.Drawing.Point(40, 417);
            this.submenulagrange.Name = "submenulagrange";
            this.submenulagrange.Size = new System.Drawing.Size(239, 142);
            this.submenulagrange.TabIndex = 19;
            this.submenulagrange.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.panel7.Location = new System.Drawing.Point(10, 75);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 55);
            this.panel7.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(10, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 55);
            this.panel4.TabIndex = 19;
            // 
            // bntPrimerGrado
            // 
            this.bntPrimerGrado.BackColor = System.Drawing.Color.Transparent;
            this.bntPrimerGrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntPrimerGrado.FlatAppearance.BorderSize = 0;
            this.bntPrimerGrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.bntPrimerGrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntPrimerGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPrimerGrado.ForeColor = System.Drawing.Color.White;
            this.bntPrimerGrado.Location = new System.Drawing.Point(10, 12);
            this.bntPrimerGrado.Margin = new System.Windows.Forms.Padding(4);
            this.bntPrimerGrado.Name = "bntPrimerGrado";
            this.bntPrimerGrado.Size = new System.Drawing.Size(222, 55);
            this.bntPrimerGrado.TabIndex = 21;
            this.bntPrimerGrado.Text = "1er Grado";
            this.bntPrimerGrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntPrimerGrado.UseVisualStyleBackColor = false;
            this.bntPrimerGrado.Click += new System.EventHandler(this.bntPrimerGrado_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(195)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Location = new System.Drawing.Point(-48, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 55);
            this.panel5.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(195)))));
            this.panel6.Location = new System.Drawing.Point(-143, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 55);
            this.panel6.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(195)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(-131, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 55);
            this.button2.TabIndex = 19;
            this.button2.Text = "La&grange";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSegundoGrado
            // 
            this.btnSegundoGrado.BackColor = System.Drawing.Color.Transparent;
            this.btnSegundoGrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSegundoGrado.FlatAppearance.BorderSize = 0;
            this.btnSegundoGrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnSegundoGrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegundoGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundoGrado.ForeColor = System.Drawing.Color.White;
            this.btnSegundoGrado.Location = new System.Drawing.Point(16, 75);
            this.btnSegundoGrado.Margin = new System.Windows.Forms.Padding(4);
            this.btnSegundoGrado.Name = "btnSegundoGrado";
            this.btnSegundoGrado.Size = new System.Drawing.Size(216, 55);
            this.btnSegundoGrado.TabIndex = 19;
            this.btnSegundoGrado.Text = "2do Grado";
            this.btnSegundoGrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSegundoGrado.UseVisualStyleBackColor = false;
            this.btnSegundoGrado.Click += new System.EventHandler(this.btnSegundoGrado_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(8, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 55);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(8, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 55);
            this.panel2.TabIndex = 17;
            // 
            // PicSalir
            // 
            this.PicSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(223)))), ((int)(((byte)(34)))));
            this.PicSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSalir.Image = ((System.Drawing.Image)(resources.GetObject("PicSalir.Image")));
            this.PicSalir.Location = new System.Drawing.Point(114, 587);
            this.PicSalir.Name = "PicSalir";
            this.PicSalir.Size = new System.Drawing.Size(80, 66);
            this.PicSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSalir.TabIndex = 15;
            this.PicSalir.TabStop = false;
            this.PicSalir.Click += new System.EventHandler(this.PicSalir_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.BarraTitulo.Controls.Add(this.lbltitulo);
            this.BarraTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarraTitulo.Location = new System.Drawing.Point(1, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1447, 45);
            this.BarraTitulo.TabIndex = 17;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoSize = true;
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.panelContenedor.Location = new System.Drawing.Point(281, 45);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelContenedor.Size = new System.Drawing.Size(1164, 718);
            this.panelContenedor.TabIndex = 18;
            // 
            // Interpolaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1446, 763);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.panelizquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Interpolaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interpolaciones";
            this.Load += new System.EventHandler(this.Interpolaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenInicio)).EndInit();
            this.panelizquierdo.ResumeLayout(false);
            this.panelizquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.submenulagrange.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLineal;
        private System.Windows.Forms.Button btnCuadratica;
        private System.Windows.Forms.Button btnLagrange;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox imagenInicio;
        private System.Windows.Forms.Panel panelizquierdo;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox PicSalir;
        private System.Windows.Forms.Panel submenulagrange;
        private System.Windows.Forms.Button bntPrimerGrado;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSegundoGrado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Label lbltipo_de_interpolacion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
    }
}

