using System;
using System.Windows.Forms;

namespace Interporlaciones
{
    public partial class Lagrange_primer_Grado : Form
    {
        public Lagrange_primer_Grado()
        {
            InitializeComponent();
        }
        double F1x;
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double x, x0, x1, fx0, fx1;
            if (txt_x.Text == "" || txt_x1.Text == "" || txt_Fx0.Text == "" || txt_Fx1.Text == "")
            {
                MessageBox.Show("Elementos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                x = Double.Parse(txt_x.Text);
                x1 = Double.Parse(txt_x1.Text);
                x0 = Double.Parse(txt_x0.Text);
                fx0 = Double.Parse(txt_Fx0.Text);
                fx1 = Double.Parse(txt_Fx1.Text);
                if (x < x0 || x > x1)
                {
                    txt_F1x.Clear();
                    MessageBox.Show("Extrapolacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    F1x = ((((x - x1) / (x0 - x1)) * fx0) + (((x - x0) / (x1 - x0)) * fx1));
                    F1x = Math.Round(F1x, 7);
                    txt_F1x.Text = Convert.ToString(F1x);
                }
            }
        }

        private void btn_CalcularError_Click(object sender, EventArgs e)
        {
            double Error;
            double exacto = Double.Parse(txt_ValorExacto.Text);
            double redondeado = double.Parse(txt_F1x.Text);
            Error = ((exacto - redondeado) / exacto) * 100;
            Error = Math.Abs(Error);
            Error = Math.Round(Error, 2);
            txt_Error.Text = Error.ToString() + "%";
        }
        /*Validaciones*************************************************************************************************************/
        //validamos con una funcion alojada en la clase program
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

        private void txt_Fx0_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void txt_Fx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void txt_ValorExacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void lbl_F1x_Click(object sender, EventArgs e)
        {

        }

        private void txt_F1x_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txt_x.Clear();
            txt_x0.Clear();
            txt_x1.Clear();
            txt_Fx0.Clear();
            txt_Fx1.Clear();
            txt_F1x.Clear();
            txt_ValorExacto.Clear();
            txt_Error.Clear();
        }
    }
}
