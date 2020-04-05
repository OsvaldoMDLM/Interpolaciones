using System;
using System.Windows.Forms;

namespace Interporlaciones
{
    public partial class Lineal : Form
    {
        public Lineal()
        {
            InitializeComponent();
        }
        double FX;//Variable Global necesaria para almacenar el resultado y calcular el error
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtFX0.Text == "" || txtFX1.Text == "" || txt_x0.Text == "" || txt_x1.Text == "")
            {
                MessageBox.Show("Elementos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                //Declaracion de variables e inicialozacion (Entrada)
                double fx0 = double.Parse(txtFX0.Text);
                double fx1 = double.Parse(txtFX1.Text);
                double x = double.Parse(txt_x.Text);
                double x0 = double.Parse(txt_x0.Text);
                double x1 = double.Parse(txt_x1.Text);
                if (x < x0 || x > x1)
                {
                    txtResultado.Clear();
                    MessageBox.Show("Extrapolacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    FX = (fx0) + ((fx1 - fx0) / (x1 - x0)) * (x - x0);//Formula para calcular la interpolacion lineal (proceso)
                    txtResultado.Text = Convert.ToString(FX);//salida
                }
            }
        }

        private void btnCalcularErrorAbs_Click(object sender, EventArgs e)
        {
            double ValorExacto = double.Parse(txtValorExacto.Text);//Declaracion de variable e inicializacion(entrada)
            double error;//variable que almacenara el resultado
            error = ((ValorExacto - FX) / (ValorExacto)) * 100;//ecuacion para calcular el error
            error = Math.Abs(error);//Devuelve el valor absoluto de un número especificado.
            error = Math.Round(error, 2);//redondeo a solo 4 decimales
            txtErrorAbs.Text = (Convert.ToString(error) + "%");//salida
        }

        /*Validaciones************************************************************************************************************************/
        //validamos con una funcion alojada en la clase program
        private void txtFX0_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void txtFX1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);

        }

        private void txtValorExacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtFX0.Clear();
            txtFX1.Clear();
            txt_x.Clear();
            txt_x0.Clear();
            txt_x1.Clear();
            txtResultado.Clear();
            txtValorExacto.Clear();
            txtErrorAbs.Clear();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
