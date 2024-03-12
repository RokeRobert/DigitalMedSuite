using Pantalla_registro;
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
using Microsoft.Win32;
using System.Diagnostics;


namespace DigitalMedSuite
{
    public partial class LogIn : Form
    {
        

        public LogIn()
        {
            InitializeComponent();
           
        }
        //Evento Cuando se Cambia el Texto en la TextBox PW(Contrasenia)
        private void txtPW_TextChanged(object sender, EventArgs e)
        {
            txtPW.UseSystemPasswordChar = true;
            txtPW.ForeColor=System.Drawing.SystemColors.ControlText;
        }
        private void txtPW_Click_txt(object sender, EventArgs e)
        {
          
        }
        //Evento Click a btnLogIn (Iniciar Sesion)
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string correo, contra, CE, PW;
            CE = txtCE.Text;
            PW = txtPW.Text;

            try
            {
                TextReader archivo = new StreamReader("C:\\Users\\roker\\source\\repos\\DigitalMedSuite_Diseños\\DigitalMedSuite\\bin\\Debug\\Registros\\" + txtCE.Text + ".txt");
                contra = archivo.ReadLine();
                archivo.Close();

                if (PW == contra)
                {
                    frmPrincip frmPrincip = new frmPrincip();
                    frmPrincip.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Correo y/o contraseña no validos");
                    txtCE.Text = "";
                    txtPW.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Correo y/o contraseña no validos");
                txtCE.Text = "";
                txtPW.Text = "";
            }
            

        }
        //Evento clickear espacio en blanco del forms
        private void LogIn_Click(object sender, EventArgs e)
        {
            if (txtPW.Text == string.Empty) 
            { txtPW.Text = "Contraseña";
              txtPW.UseSystemPasswordChar = false;
                txtPW.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
            if (txtCE.Text == string.Empty) 
            { 
                txtCE.Text = "Correo Electrónico";
                txtCE.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }
        }
        //Evento click txtCE(Correo Electronico)
        private void txtCE_Click(object sender, EventArgs e)
        {
            if (txtCE.Text == "Correo Electrónico") 
            {
                txtCE.Text = string.Empty;
                txtCE.ForeColor = System.Drawing.SystemColors.ControlText;
            }
            if (txtPW.Text == string.Empty)
            {
                txtPW.Text = "Contraseña";
                txtPW.UseSystemPasswordChar = false;
                txtPW.ForeColor = System.Drawing.SystemColors.WindowFrame;
            }

        }
        //Evento click txtPW(Contrasenia)
        private void txtPW_Click(object sender, EventArgs e)
        {
            if (txtPW.Text == "Contraseña") { txtPW.Text = string.Empty; }
            if (txtCE.Text == string.Empty) 
            {
                txtCE.Text = "Correo Electrónico";
                txtCE.ForeColor = System.Drawing.SystemColors.WindowFrame; 
            }
        }

        private void txtCE_TextChanged(object sender, EventArgs e)
        {
            txtCE.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
             frmRegistro registro = new frmRegistro();
            registro.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPW.UseSystemPasswordChar = false;
            }
            else
            {
                txtPW.UseSystemPasswordChar = true;
            }
        }
    }
}
