namespace Interporlaciones
{
    partial class Lagrange_primer_Grado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lagrange_primer_Grado));
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_x0 = new System.Windows.Forms.Label();
            this.lbl_x1 = new System.Windows.Forms.Label();
            this.lbl_F1x = new System.Windows.Forms.Label();
            this.lbl_Fx0 = new System.Windows.Forms.Label();
            this.lbl_Fx1 = new System.Windows.Forms.Label();
            this.lbl_ValorExacto = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_x0 = new System.Windows.Forms.TextBox();
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.txt_F1x = new System.Windows.Forms.TextBox();
            this.txt_Fx0 = new System.Windows.Forms.TextBox();
            this.txt_Fx1 = new System.Windows.Forms.TextBox();
            this.txt_ValorExacto = new System.Windows.Forms.TextBox();
            this.txt_Error = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_CalcularError = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCE = new System.Windows.Forms.Button();
            this.lbl_datos2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x.Location = new System.Drawing.Point(22, 38);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(37, 32);
            this.lbl_x.TabIndex = 0;
            this.lbl_x.Text = "x:";
            // 
            // lbl_x0
            // 
            this.lbl_x0.AutoSize = true;
            this.lbl_x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x0.Location = new System.Drawing.Point(11, 82);
            this.lbl_x0.Name = "lbl_x0";
            this.lbl_x0.Size = new System.Drawing.Size(53, 32);
            this.lbl_x0.TabIndex = 1;
            this.lbl_x0.Text = "x0:";
            // 
            // lbl_x1
            // 
            this.lbl_x1.AutoSize = true;
            this.lbl_x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x1.Location = new System.Drawing.Point(11, 130);
            this.lbl_x1.Name = "lbl_x1";
            this.lbl_x1.Size = new System.Drawing.Size(53, 32);
            this.lbl_x1.TabIndex = 2;
            this.lbl_x1.Text = "x1:";
            // 
            // lbl_F1x
            // 
            this.lbl_F1x.AutoSize = true;
            this.lbl_F1x.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_F1x.Location = new System.Drawing.Point(56, 259);
            this.lbl_F1x.Name = "lbl_F1x";
            this.lbl_F1x.Size = new System.Drawing.Size(70, 32);
            this.lbl_F1x.TabIndex = 3;
            this.lbl_F1x.Text = "F1x:";
            this.lbl_F1x.Click += new System.EventHandler(this.lbl_F1x_Click);
            // 
            // lbl_Fx0
            // 
            this.lbl_Fx0.AutoSize = true;
            this.lbl_Fx0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fx0.Location = new System.Drawing.Point(333, 44);
            this.lbl_Fx0.Name = "lbl_Fx0";
            this.lbl_Fx0.Size = new System.Drawing.Size(70, 32);
            this.lbl_Fx0.TabIndex = 4;
            this.lbl_Fx0.Text = "Fx0:";
            // 
            // lbl_Fx1
            // 
            this.lbl_Fx1.AutoSize = true;
            this.lbl_Fx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fx1.Location = new System.Drawing.Point(333, 88);
            this.lbl_Fx1.Name = "lbl_Fx1";
            this.lbl_Fx1.Size = new System.Drawing.Size(70, 32);
            this.lbl_Fx1.TabIndex = 5;
            this.lbl_Fx1.Text = "Fx1:";
            // 
            // lbl_ValorExacto
            // 
            this.lbl_ValorExacto.AutoSize = true;
            this.lbl_ValorExacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorExacto.Location = new System.Drawing.Point(251, 129);
            this.lbl_ValorExacto.Name = "lbl_ValorExacto";
            this.lbl_ValorExacto.Size = new System.Drawing.Size(181, 32);
            this.lbl_ValorExacto.TabIndex = 6;
            this.lbl_ValorExacto.Text = "Valor exacto:";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.Location = new System.Drawing.Point(40, 303);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(85, 32);
            this.lbl_Error.TabIndex = 7;
            this.lbl_Error.Text = "Error:";
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(61, 38);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(172, 38);
            this.txt_x.TabIndex = 11;
            this.txt_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_x_KeyPress);
            // 
            // txt_x0
            // 
            this.txt_x0.Location = new System.Drawing.Point(61, 82);
            this.txt_x0.Name = "txt_x0";
            this.txt_x0.Size = new System.Drawing.Size(172, 38);
            this.txt_x0.TabIndex = 12;
            this.txt_x0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_x0_KeyPress);
            // 
            // txt_x1
            // 
            this.txt_x1.Location = new System.Drawing.Point(61, 126);
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.Size = new System.Drawing.Size(172, 38);
            this.txt_x1.TabIndex = 13;
            this.txt_x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_x1_KeyPress);
            // 
            // txt_F1x
            // 
            this.txt_F1x.Enabled = false;
            this.txt_F1x.Location = new System.Drawing.Point(119, 259);
            this.txt_F1x.Name = "txt_F1x";
            this.txt_F1x.Size = new System.Drawing.Size(262, 38);
            this.txt_F1x.TabIndex = 14;
            this.txt_F1x.TextChanged += new System.EventHandler(this.txt_F1x_TextChanged);
            // 
            // txt_Fx0
            // 
            this.txt_Fx0.Location = new System.Drawing.Point(399, 38);
            this.txt_Fx0.Name = "txt_Fx0";
            this.txt_Fx0.Size = new System.Drawing.Size(172, 38);
            this.txt_Fx0.TabIndex = 15;
            this.txt_Fx0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Fx0_KeyPress);
            // 
            // txt_Fx1
            // 
            this.txt_Fx1.Location = new System.Drawing.Point(399, 82);
            this.txt_Fx1.Name = "txt_Fx1";
            this.txt_Fx1.Size = new System.Drawing.Size(172, 38);
            this.txt_Fx1.TabIndex = 16;
            this.txt_Fx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Fx1_KeyPress);
            // 
            // txt_ValorExacto
            // 
            this.txt_ValorExacto.Location = new System.Drawing.Point(425, 124);
            this.txt_ValorExacto.Name = "txt_ValorExacto";
            this.txt_ValorExacto.Size = new System.Drawing.Size(172, 38);
            this.txt_ValorExacto.TabIndex = 17;
            this.txt_ValorExacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorExacto_KeyPress);
            // 
            // txt_Error
            // 
            this.txt_Error.Enabled = false;
            this.txt_Error.Location = new System.Drawing.Point(119, 303);
            this.txt_Error.Name = "txt_Error";
            this.txt_Error.Size = new System.Drawing.Size(262, 38);
            this.txt_Error.TabIndex = 18;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Calcular.Font = new System.Drawing.Font("MS PGothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Calcular.Location = new System.Drawing.Point(58, 183);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(172, 45);
            this.btn_Calcular.TabIndex = 19;
            this.btn_Calcular.Text = "Clacular";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_CalcularError
            // 
            this.btn_CalcularError.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_CalcularError.Font = new System.Drawing.Font("MS PGothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalcularError.ForeColor = System.Drawing.Color.DimGray;
            this.btn_CalcularError.Location = new System.Drawing.Point(449, 183);
            this.btn_CalcularError.Name = "btn_CalcularError";
            this.btn_CalcularError.Size = new System.Drawing.Size(204, 45);
            this.btn_CalcularError.TabIndex = 20;
            this.btn_CalcularError.Text = "Calcular error";
            this.btn_CalcularError.UseVisualStyleBackColor = false;
            this.btn_CalcularError.Click += new System.EventHandler(this.btn_CalcularError_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCE);
            this.panel2.Controls.Add(this.btn_CalcularError);
            this.panel2.Controls.Add(this.txt_x);
            this.panel2.Controls.Add(this.lbl_x);
            this.panel2.Controls.Add(this.lbl_ValorExacto);
            this.panel2.Controls.Add(this.btn_Calcular);
            this.panel2.Controls.Add(this.txt_ValorExacto);
            this.panel2.Controls.Add(this.lbl_x0);
            this.panel2.Controls.Add(this.lbl_Error);
            this.panel2.Controls.Add(this.txt_Fx1);
            this.panel2.Controls.Add(this.txt_Error);
            this.panel2.Controls.Add(this.lbl_x1);
            this.panel2.Controls.Add(this.txt_Fx0);
            this.panel2.Controls.Add(this.lbl_F1x);
            this.panel2.Controls.Add(this.txt_F1x);
            this.panel2.Controls.Add(this.lbl_Fx0);
            this.panel2.Controls.Add(this.txt_x1);
            this.panel2.Controls.Add(this.lbl_Fx1);
            this.panel2.Controls.Add(this.txt_x0);
            this.panel2.Location = new System.Drawing.Point(18, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 538);
            this.panel2.TabIndex = 22;
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCE.Font = new System.Drawing.Font("MS PGothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.DimGray;
            this.btnCE.Location = new System.Drawing.Point(257, 183);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(172, 45);
            this.btnCE.TabIndex = 55;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // lbl_datos2
            // 
            this.lbl_datos2.AutoSize = true;
            this.lbl_datos2.Location = new System.Drawing.Point(12, 9);
            this.lbl_datos2.Name = "lbl_datos2";
            this.lbl_datos2.Size = new System.Drawing.Size(456, 64);
            this.lbl_datos2.TabIndex = 27;
            this.lbl_datos2.Text = "Calcular interpolacion de lagrange \r\nde primer grado";
            // 
            // Lagrange_primer_Grado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1162, 798);
            this.Controls.Add(this.lbl_datos2);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Lagrange_primer_Grado";
            this.Text = "Lagrange_primer_Grado";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_x0;
        private System.Windows.Forms.Label lbl_x1;
        private System.Windows.Forms.Label lbl_F1x;
        private System.Windows.Forms.Label lbl_Fx0;
        private System.Windows.Forms.Label lbl_Fx1;
        private System.Windows.Forms.Label lbl_ValorExacto;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_x0;
        private System.Windows.Forms.TextBox txt_x1;
        private System.Windows.Forms.TextBox txt_F1x;
        private System.Windows.Forms.TextBox txt_Fx0;
        private System.Windows.Forms.TextBox txt_Fx1;
        private System.Windows.Forms.TextBox txt_ValorExacto;
        private System.Windows.Forms.TextBox txt_Error;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_CalcularError;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_datos2;
        private System.Windows.Forms.Button btnCE;
    }
}