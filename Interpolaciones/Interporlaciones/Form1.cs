using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Interporlaciones
{   //clase de interpolacion que almacena al form
    public partial class Interpolaciones : Form
    {
        public Interpolaciones()
        {
            InitializeComponent();
        }
        //accion que nos permite manupular la barra de titulo 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //metodo que hace que aparesca un form dento de un panel 
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        /**********************************************************************************************************/
        //evento que nos permite salir de la aplicacion
        private void PicSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();//evento que termina de ejecutar la aplicacion
        }
        //evento que permite minimizar la pestaña
        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //accion que permite mover de lado la barra de titulo y toda la pestaña
        private void lblinterpolacion_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //hacemos que el panel contenedor inicie con el form inicio 
        private void Interpolaciones_Load(object sender, EventArgs e)
        {
            imagenInicio_Click(null, e);
        }
        //accion que permite mover de lado la barra de titulo y toda la pestaña
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //es la imagne que nos regresa al inicio de el form
        private void imagenInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Inicio());
        }

        /**************************************************INTERPOLACIONES******************************************/
        //Habre el form de interpolacion Lineal 
        private void btnLineal_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Lineal());//conecta a el form de interpolacion Lineal
        }
        //habre el form de interpolacion Cuadratica
        private void btnCuadratica_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Cuadratica());//conecta a el form de interpolacion cuadratica
        }

        //evento que muestra el sub menu de interpolaciones

        private void btnLagrange_MouseEnter(object sender, EventArgs e)
        {
            submenulagrange.Visible = true;
        }
        //boton de sub menu dentro de lagrange
        //boton que nos da la opcion de interpolacion de primer grado
        private void bntPrimerGrado_Click(object sender, EventArgs e)
        {
            submenulagrange.Visible = false;//accion que hace oculta el submenu despues de hacer click
            AbrirFormInPanel(new Lagrange_primer_Grado());//conecta a el form de interpolacion de primer grado
        }
        //evento que permite la opcion de interpolacion de segundo grado
        private void btnSegundoGrado_Click(object sender, EventArgs e)
        {
            submenulagrange.Visible = false;//accion que hace oculta el submenu despues de hacer click
            AbrirFormInPanel(new Lagrange_segundo_Grado()); //conecta a el form de interpolacion de segundo grado
        }


    }
}
