using System;
using System.Windows.Forms;

namespace Interporlaciones
{
    public partial class Cuadratica : Form
    {
        public Cuadratica()
        {
            InitializeComponent();
        }
        //variable global necesaria para almacenar el resultado y calcular el error
        double Fx;

        private void btnCalcularInterpolacion_Click(object sender, EventArgs e)
        {
            if (txtx.Text == "" || txtx0.Text == "" || txtx1.Text == "" || txtx2.Text == "" || txtFX0.Text == "" || txtFX1.Text == "" || txtFX2.Text == "")
            {
                MessageBox.Show("Elementos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Declaracion e inicializacion de variables
                double x = Double.Parse(txtx.Text);
                double fx0 = Double.Parse(txtFX0.Text);
                double fx1 = Double.Parse(txtFX1.Text);
                double fx2 = Double.Parse(txtFX2.Text);
                double x0 = Double.Parse(txtx0.Text);
                double x1 = Double.Parse(txtx1.Text);
                double x2 = Double.Parse(txtx2.Text);
                if (x < x0 || x > x2)
                {
                    txtb0.Clear();
                    txtb1.Clear();
                    txtb2.Clear();
                    txtFx.Clear();
                    MessageBox.Show("Extrapolacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Proceso para calcular la interpolacion cuadratica
                    double b0 = Double.Parse(txtFX0.Text);
                    double b1 = (fx1 - fx0) / (x1 - x0);
                    double b2 = (((fx2 - fx1) / (x2 - x1)) - b1) / (x2 - x0);
                    Fx = b0 + b1 * (x - x0) + b2 * ((x - x0) * (x - x1));//resultado final 

                    //salida
                    txtb0.Text = Convert.ToString(b0);
                    txtb1.Text = Convert.ToString(b1);
                    txtb2.Text = Convert.ToString(b2);
                    txtFx.Text = Convert.ToString(Fx);
                }
            }
        }

        private void btnCalcularError_Click(object sender, EventArgs e)
        {
            double exacto = Double.Parse(txtValorExacto.Text);//Declaracion e inicalizacion de variable
            double error = ((exacto - Fx) / exacto) * 100;//declaracion de la variable contenedora y proceso 
            error = Math.Abs(error);//Devuelve el valor absoluto de un número especificado.
            error = Math.Round(error, 2);//redondep de decimales
            txtError.Text = error.ToString() + " %";//resultado final
        }


        /*Validaciones**************************************************************************************************************/
        //validamos con una funcion alojada en la clase programa
        private void txtx_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void txtx0_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void txtx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void txtx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void txtFX0_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void txtFX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void txtFX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void txtValorExacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtx.Clear();
            txtx0.Clear();
            txtx1.Clear();
            txtx2.Clear();
            txtFX0.Clear();
            txtFX1.Clear();
            txtFX2.Clear();
            txtValorExacto.Clear();
            txtb0.Clear();
            txtb1.Clear();
            txtb2.Clear();
            txtFx.Clear();
            txtError.Clear();
        }
    }
}
