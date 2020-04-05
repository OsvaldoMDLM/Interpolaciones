using System;
using System.Windows.Forms;

namespace Interporlaciones
{
    public partial class Lagrange_segundo_Grado : Form
    {
        public Lagrange_segundo_Grado()
        {
            InitializeComponent();
        }
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double x, x0, x1, x2, fx0, fx1, fx2, F2x, F1x;
            //if verificador de que no este vacia la entrada
            if (txt_x.Text == "" || txt_x1.Text == "" || txt_Fx0.Text == "" || txt_Fx1.Text == "" || txt_x2.Text == "" || txt_Fx2.Text == "")
            {
                MessageBox.Show("Elementos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                x = Double.Parse(txt_x.Text);
                x0 = Double.Parse(txt_x0.Text);
                x1 = Double.Parse(txt_x1.Text);
                x2 = Double.Parse(txt_x2.Text);
                fx0 = Double.Parse(txt_Fx0.Text);
                fx1 = Double.Parse(txt_Fx1.Text);
                fx2 = Double.Parse(txt_Fx2.Text);
                if (x < x0 || x > x2)
                {
                    txt_F2x.Clear();
                    txt_F1x.Clear();
                    MessageBox.Show("Extrapolacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    F2x = ((((x - x1) / (x0 - x1)) * ((x - x2) / (x0 - x2))) * fx0) + ((((x - x0) /
                          (x1 - x0)) * ((x - x2) / (x1 - x2))) * fx1) + ((((x - x0) / (x2 - x0)) * ((x - x1) / (x2 - x1))) * fx2);
                    F1x = ((((x - x1) / (x0 - x1)) * fx0) + (((x - x0) / (x1 - x0)) * fx1));
                    F1x = Math.Round(F1x, 7);
                    F2x = Math.Round(F2x, 7);
                    txt_F1x.Text = Convert.ToString(F1x);
                    txt_F2x.Text = Convert.ToString(F2x);
                }
            }
        }

        private void btn_CalcularError_Click(object sender, EventArgs e)
        {
            double Error;
            double exacto = Double.Parse(txt_ValorExacto.Text);
            double redondeado = Double.Parse(txt_F2x.Text);
            Error = ((exacto - redondeado) / exacto) * 100;
            Error = Math.Abs(Error);
            Error = Math.Round(Error, 2);
            txt_Error.Text = Error.ToString() + "%";

        }
        /*Validaciones*******************************************************************************************************************/
        private void txt_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }
        private void txt_x0_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }
        private void txt_x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }
        private void txt_x2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }
        private void txt_Fx0_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void txt_Fx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void txt_Fx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void txt_ValorExacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txt_x.Clear();
            txt_x0.Clear();
            txt_x1.Clear();
            txt_x2.Clear();
            txt_Fx0.Clear();
            txt_Fx1.Clear();
            txt_Fx2.Clear();
            txt_F1x.Clear();
            txt_F2x.Clear();
            txt_ValorExacto.Clear();
            txt_Error.Clear();
        }
    }
}
