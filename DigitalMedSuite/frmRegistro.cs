using DigitalMedSuite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pantalla_registro
{
    public partial class frmRegistro : Form
    {
        // Variables
        string Nombre, ApellidoPaterno, ApellidoMaterno, CorreoElectronico, Codigo, ConfirmarCodigo, Usuario;
        string Aux = "";
        public frmRegistro()
        {
            InitializeComponent();
        }

//                Picture box / Icono de info.
        private void pictureBox1_MouseHover(object sender, EventArgs e) // Al poner el cursor sobre el icono de informacion saltara el mensaje en el label.
        {
            lbl_Mensaje.Text = "La contraseña debe tener por lo menos 8 caracteres.";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e) // Al quitar el cursor sobre el icono de informacion el mensaje desaparecera.
        {
            lbl_Mensaje.Text = "";
        }

//                 Tabulador
        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                txt_ApellidoPaterno.Focus();
            }
        }
        private void txt_ApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                txt_ApellidoMaterno.Focus();
            }
        }
        private void txt_ApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                txt_CorreoElectronico.Focus();
                lbl_CorreoElectronico.Text = " ";
            }
        }
        private void txt_CorreoElectronico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                txt_codigo.Focus();
                lbl_Codigo.Text = " ";
            }
        }
        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                CheckBox_MostrarCodigo.Focus();
            }
        }
        private void CheckBox_MostrarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                txt_ConfirmarCodigo.Focus();
            }
        }
        private void txt_ConfirmarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                btn_Registrar.Focus();
            }
        }

        //                Click 
        private void Form1_Click(object sender, EventArgs e)            // Al dar click sobre los distintos elementos de la pantalla se evaluara
        {                                                               // si la contraseña o el correo tienen valores escritos para eliminar el texto de ejemplo.
            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";

            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";
        }
        private void label2_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";

            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";
        }
        private void txt_Nombre_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";

            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";
        }
        private void label3_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";

            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";
        }
        private void txt_ApellidoPaterno_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";

            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";
        }
        private void label4_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";

            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";
        }
        private void txt_ApellidoMaterno_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";

            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";
        }
        private void label7_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";

            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";

            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";
        }
        private void label8_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";

            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";
        }
        private void txt_ConfirmarCodigo_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";

            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";
        }
        private void lbl_CorreoElectronico_Click(object sender, EventArgs e)
        {
            lbl_CorreoElectronico.Text = "";
            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";

            txt_CorreoElectronico.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn(); 
            logIn.Show();
            this.Hide();
        }

        private void txt_CorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Codigo_Click(object sender, EventArgs e)
        {
            lbl_Codigo.Text = "";
            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";

            txt_codigo.Focus();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";

            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";
        }
        private void txt_codigo_Click(object sender, EventArgs e)
        {
            lbl_Codigo.Text = "";

            if (txt_CorreoElectronico.Text == "")
                lbl_CorreoElectronico.Text = "example17@gmail.com";
            else
                lbl_CorreoElectronico.Text = "";
        }

        private void txt_CorreoElectronico_Click(object sender, EventArgs e)
        {
            lbl_CorreoElectronico.Text = "";

            if (txt_codigo.Text == "")
                lbl_Codigo.Text = "Example123";
            else
                lbl_Codigo.Text = "";
        }

//                CheckBox mostrar contraseña. 
        private void CheckBox_MostrarCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_MostrarCodigo.Checked)
            {
                txt_codigo.UseSystemPasswordChar = false;
            }
            else
            {
                txt_codigo.UseSystemPasswordChar = true;
            }
        }

//                Boton de registro.
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            // Evaluar si todos los datos estan llenos.
            if (txt_Nombre.Text == "" || txt_ApellidoPaterno.Text == "" || txt_ApellidoMaterno.Text == "" || txt_CorreoElectronico.Text == "" || txt_codigo.Text == "" || txt_ConfirmarCodigo.Text == "")
            {
                MessageBox.Show("Favor de rellenar todos los espacios antes de continuar.");
            }
            else
            {
                // Evaluar si tiene 8 elementos.
                if (txt_codigo.TextLength < 8)
                {
                    MessageBox.Show("La contraseña debe contener por lo menos 8 caracteres.");
                }
                else
                {
                    Codigo = txt_codigo.Text;
                    ConfirmarCodigo = txt_ConfirmarCodigo.Text;
                    // Evaluar que la confirmación de contraseña sea correcta.
                    if (Codigo != ConfirmarCodigo)  
                    {
                        MessageBox.Show("La contraseña no coincide con la confirmación favor intentarlo de nuevo.");
                        txt_codigo.Clear();
                        txt_ConfirmarCodigo.Clear();
                    }
                    else
                    {
                        // Guardar datos en variables.
                        Nombre = txt_Nombre.Text;
                        ApellidoPaterno = txt_ApellidoPaterno.Text;
                        ApellidoMaterno = txt_ApellidoMaterno.Text;
                        CorreoElectronico = txt_CorreoElectronico.Text;

                        // Generar nombre de usuario.
                        Usuario = String.Concat(Nombre[0], Nombre[1], Nombre[2], ApellidoPaterno[0], ApellidoPaterno[1], ApellidoMaterno[0], ApellidoMaterno[1]);

                        MessageBox.Show("El registro fue llevado a cabo de una manera exitosa. " +
                                      "\nNombre completo: " + Nombre + " " + ApellidoPaterno + " " + ApellidoMaterno +
                                      "\nCorreo Electronico: " + CorreoElectronico +
                                      "\nUsuario: " + Usuario.ToUpper());
                        TextWriter correo= new StreamWriter("C:\\Users\\roker\\source\\repos\\DigitalMedSuite_Diseños\\DigitalMedSuite\\bin\\Debug\\Registros\\"+ CorreoElectronico+".txt");
                        correo.WriteLine(Codigo);
                        correo.Close();

                    }
                }
            }
        }
    }
}
