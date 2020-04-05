namespace Interporlaciones
{
    partial class Lineal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lineal));
            this.txtErrorAbs = new System.Windows.Forms.TextBox();
            this.btnCalcularErrorAbs = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.txt_x0 = new System.Windows.Forms.TextBox();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.lblx1 = new System.Windows.Forms.Label();
            this.lblx0 = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.txtFX1 = new System.Windows.Forms.TextBox();
            this.txtFX0 = new System.Windows.Forms.TextBox();
            this.txtValorExacto = new System.Windows.Forms.TextBox();
            this.lblFX1 = new System.Windows.Forms.Label();
            this.lblFX0 = new System.Windows.Forms.Label();
            this.lblValorExacto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_datos1 = new System.Windows.Forms.Label();
            this.lblResultadoErroAbs = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_datos2 = new System.Windows.Forms.Label();
            this.btnCE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtErrorAbs
            // 
            this.txtErrorAbs.BackColor = System.Drawing.Color.White;
            this.txtErrorAbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtErrorAbs.Enabled = false;
            this.txtErrorAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorAbs.Location = new System.Drawing.Point(162, 154);
            this.txtErrorAbs.Margin = new System.Windows.Forms.Padding(5);
            this.txtErrorAbs.Multiline = true;
            this.txtErrorAbs.Name = "txtErrorAbs";
            this.txtErrorAbs.Size = new System.Drawing.Size(245, 40);
            this.txtErrorAbs.TabIndex = 38;
            // 
            // btnCalcularErrorAbs
            // 
            this.btnCalcularErrorAbs.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCalcularErrorAbs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularErrorAbs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularErrorAbs.Font = new System.Drawing.Font("MS PGothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularErrorAbs.ForeColor = System.Drawing.Color.DimGray;
            this.btnCalcularErrorAbs.Location = new System.Drawing.Point(162, 98);
            this.btnCalcularErrorAbs.Margin = new System.Windows.Forms.Padding(5);
            this.btnCalcularErrorAbs.Name = "btnCalcularErrorAbs";
            this.btnCalcularErrorAbs.Size = new System.Drawing.Size(245, 46);
            this.btnCalcularErrorAbs.TabIndex = 37;
            this.btnCalcularErrorAbs.Text = "Calcular error";
            this.btnCalcularErrorAbs.UseVisualStyleBackColor = false;
            this.btnCalcularErrorAbs.Click += new System.EventHandler(this.btnCalcularErrorAbs_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("MS PGothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.DimGray;
            this.btnCalcular.Location = new System.Drawing.Point(118, 197);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(164, 46);
            this.btnCalcular.TabIndex = 30;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(-5, 267);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(128, 29);
            this.lblResultado.TabIndex = 36;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(118, 262);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(5);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(354, 36);
            this.txtResultado.TabIndex = 35;
            // 
            // txt_x1
            // 
            this.txt_x1.BackColor = System.Drawing.Color.White;
            this.txt_x1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x1.Location = new System.Drawing.Point(384, 137);
            this.txt_x1.Margin = new System.Windows.Forms.Padding(5);
            this.txt_x1.Multiline = true;
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.Size = new System.Drawing.Size(164, 36);
            this.txt_x1.TabIndex = 29;
            this.txt_x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_x1_KeyPress);
            // 
            // txt_x0
            // 
            this.txt_x0.BackColor = System.Drawing.Color.White;
            this.txt_x0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x0.Location = new System.Drawing.Point(384, 91);
            this.txt_x0.Margin = new System.Windows.Forms.Padding(5);
            this.txt_x0.Multiline = true;
            this.txt_x0.Name = "txt_x0";
            this.txt_x0.Size = new System.Drawing.Size(164, 36);
            this.txt_x0.TabIndex = 28;
            this.txt_x0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_x0_KeyPress);
            // 
            // txt_x
            // 
            this.txt_x.BackColor = System.Drawing.Color.White;
            this.txt_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x.Location = new System.Drawing.Point(384, 45);
            this.txt_x.Margin = new System.Windows.Forms.Padding(5);
            this.txt_x.Multiline = true;
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(164, 36);
            this.txt_x.TabIndex = 27;
            this.txt_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_x_KeyPress);
            // 
            // lblx1
            // 
            this.lblx1.AutoSize = true;
            this.lblx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx1.ForeColor = System.Drawing.Color.White;
            this.lblx1.Location = new System.Drawing.Point(332, 139);
            this.lblx1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblx1.Name = "lblx1";
            this.lblx1.Size = new System.Drawing.Size(57, 29);
            this.lblx1.TabIndex = 33;
            this.lblx1.Text = "X1=";
            // 
            // lblx0
            // 
            this.lblx0.AutoSize = true;
            this.lblx0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx0.ForeColor = System.Drawing.Color.White;
            this.lblx0.Location = new System.Drawing.Point(332, 98);
            this.lblx0.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblx0.Name = "lblx0";
            this.lblx0.Size = new System.Drawing.Size(57, 29);
            this.lblx0.TabIndex = 32;
            this.lblx0.Text = "X0=";
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblx.ForeColor = System.Drawing.Color.White;
            this.lblx.Location = new System.Drawing.Point(345, 52);
            this.lblx.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(44, 29);
            this.lblx.TabIndex = 31;
            this.lblx.Text = "X=";
            // 
            // txtFX1
            // 
            this.txtFX1.BackColor = System.Drawing.Color.White;
            this.txtFX1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFX1.ForeColor = System.Drawing.Color.Black;
            this.txtFX1.Location = new System.Drawing.Point(118, 136);
            this.txtFX1.Margin = new System.Windows.Forms.Padding(5);
            this.txtFX1.Multiline = true;
            this.txtFX1.Name = "txtFX1";
            this.txtFX1.Size = new System.Drawing.Size(164, 36);
            this.txtFX1.TabIndex = 26;
            this.txtFX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFX1_KeyPress);
            // 
            // txtFX0
            // 
            this.txtFX0.BackColor = System.Drawing.Color.White;
            this.txtFX0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFX0.ForeColor = System.Drawing.Color.Black;
            this.txtFX0.Location = new System.Drawing.Point(118, 90);
            this.txtFX0.Margin = new System.Windows.Forms.Padding(5);
            this.txtFX0.Multiline = true;
            this.txtFX0.Name = "txtFX0";
            this.txtFX0.Size = new System.Drawing.Size(164, 36);
            this.txtFX0.TabIndex = 23;
            this.txtFX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFX0_KeyPress);
            // 
            // txtValorExacto
            // 
            this.txtValorExacto.BackColor = System.Drawing.Color.White;
            this.txtValorExacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorExacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorExacto.Location = new System.Drawing.Point(162, 47);
            this.txtValorExacto.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorExacto.Multiline = true;
            this.txtValorExacto.Name = "txtValorExacto";
            this.txtValorExacto.Size = new System.Drawing.Size(245, 41);
            this.txtValorExacto.TabIndex = 22;
            this.txtValorExacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorExacto_KeyPress);
            // 
            // lblFX1
            // 
            this.lblFX1.AutoSize = true;
            this.lblFX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFX1.ForeColor = System.Drawing.Color.White;
            this.lblFX1.Location = new System.Drawing.Point(35, 136);
            this.lblFX1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFX1.Name = "lblFX1";
            this.lblFX1.Size = new System.Drawing.Size(88, 29);
            this.lblFX1.TabIndex = 25;
            this.lblFX1.Text = "F(X1)=";
            // 
            // lblFX0
            // 
            this.lblFX0.AutoSize = true;
            this.lblFX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFX0.ForeColor = System.Drawing.Color.White;
            this.lblFX0.Location = new System.Drawing.Point(35, 91);
            this.lblFX0.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFX0.Name = "lblFX0";
            this.lblFX0.Size = new System.Drawing.Size(88, 29);
            this.lblFX0.TabIndex = 24;
            this.lblFX0.Text = "F(X0)=";
            // 
            // lblValorExacto
            // 
            this.lblValorExacto.AutoSize = true;
            this.lblValorExacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorExacto.ForeColor = System.Drawing.Color.White;
            this.lblValorExacto.Location = new System.Drawing.Point(17, 59);
            this.lblValorExacto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblValorExacto.Name = "lblValorExacto";
            this.lblValorExacto.Size = new System.Drawing.Size(153, 29);
            this.lblValorExacto.TabIndex = 21;
            this.lblValorExacto.Text = "Valor Exacto:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_datos1);
            this.panel1.Controls.Add(this.lblResultadoErroAbs);
            this.panel1.Controls.Add(this.lblValorExacto);
            this.panel1.Controls.Add(this.btnCalcularErrorAbs);
            this.panel1.Controls.Add(this.txtErrorAbs);
            this.panel1.Controls.Add(this.txtValorExacto);
            this.panel1.Location = new System.Drawing.Point(27, 343);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 212);
            this.panel1.TabIndex = 43;
            // 
            // lbl_datos1
            // 
            this.lbl_datos1.AutoSize = true;
            this.lbl_datos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datos1.ForeColor = System.Drawing.Color.White;
            this.lbl_datos1.Location = new System.Drawing.Point(50, 0);
            this.lbl_datos1.Name = "lbl_datos1";
            this.lbl_datos1.Size = new System.Drawing.Size(366, 32);
            this.lbl_datos1.TabIndex = 50;
            this.lbl_datos1.Text = "Calcular porcentaje de error";
            // 
            // lblResultadoErroAbs
            // 
            this.lblResultadoErroAbs.AutoSize = true;
            this.lblResultadoErroAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoErroAbs.ForeColor = System.Drawing.Color.White;
            this.lblResultadoErroAbs.Location = new System.Drawing.Point(42, 165);
            this.lblResultadoErroAbs.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResultadoErroAbs.Name = "lblResultadoErroAbs";
            this.lblResultadoErroAbs.Size = new System.Drawing.Size(128, 29);
            this.lblResultadoErroAbs.TabIndex = 39;
            this.lblResultadoErroAbs.Text = "Resultado:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbl_datos2);
            this.panel2.Controls.Add(this.btnCE);
            this.panel2.Controls.Add(this.lblFX0);
            this.panel2.Controls.Add(this.btnCalcular);
            this.panel2.Controls.Add(this.txt_x0);
            this.panel2.Controls.Add(this.txtResultado);
            this.panel2.Controls.Add(this.txt_x);
            this.panel2.Controls.Add(this.txt_x1);
            this.panel2.Controls.Add(this.lblFX1);
            this.panel2.Controls.Add(this.lblResultado);
            this.panel2.Controls.Add(this.txtFX0);
            this.panel2.Controls.Add(this.txtFX1);
            this.panel2.Controls.Add(this.lblx);
            this.panel2.Controls.Add(this.lblx0);
            this.panel2.Controls.Add(this.lblx1);
            this.panel2.Location = new System.Drawing.Point(27, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 324);
            this.panel2.TabIndex = 44;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_datos2
            // 
            this.lbl_datos2.AutoSize = true;
            this.lbl_datos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datos2.ForeColor = System.Drawing.Color.White;
            this.lbl_datos2.Location = new System.Drawing.Point(156, 0);
            this.lbl_datos2.Name = "lbl_datos2";
            this.lbl_datos2.Size = new System.Drawing.Size(367, 32);
            this.lbl_datos2.TabIndex = 51;
            this.lbl_datos2.Text = "Calcular interpolacion lineal";
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCE.Font = new System.Drawing.Font("MS PGothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.DimGray;
            this.btnCE.Location = new System.Drawing.Point(290, 197);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(126, 46);
            this.btnCE.TabIndex = 52;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // Lineal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 798);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Lineal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interpolación Lineal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtErrorAbs;
        private System.Windows.Forms.Button btnCalcularErrorAbs;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txt_x1;
        private System.Windows.Forms.TextBox txt_x0;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.Label lblx0;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.TextBox txtFX1;
        private System.Windows.Forms.TextBox txtFX0;
        private System.Windows.Forms.TextBox txtValorExacto;
        private System.Windows.Forms.Label lblFX1;
        private System.Windows.Forms.Label lblFX0;
        private System.Windows.Forms.Label lblValorExacto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblResultadoErroAbs;
        private System.Windows.Forms.Label lbl_datos1;
        private System.Windows.Forms.Label lbl_datos2;
        private System.Windows.Forms.Button btnCE;
    }
}