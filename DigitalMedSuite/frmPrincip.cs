using ProyectoAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalMedSuite
{
    public partial class frmPrincip : Form
    {
        public frmPrincip()
        {
            InitializeComponent();
        }

        public static class Turno
        {
            public static int turnoactual = 1;
            public static int turnosig = 2;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmTurnoAct frmTurnoAct = new frmTurnoAct();
            frmTurnoAct.Show();
            
        }
        //siguiente turno
        private void button5_Click(object sender, EventArgs e)
        {
            Turno.turnoactual = Turno.turnoactual + 1;
            Turno.turnosig=Turno.turnosig + 1;
        }
        //Nuevo Expediente
        private void btn1_Click(object sender, EventArgs e)
        {
            CapturaDeExpediente cap=new CapturaDeExpediente();
            cap.Show();
            this.Hide();
        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
