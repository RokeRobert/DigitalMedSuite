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
    public partial class frmTurnoAct : Form
    {
        public frmTurnoAct()
        {
            InitializeComponent();
        }

        private void tmrhora_Tick(object sender, EventArgs e)
        {
            lblHora.Text=DateTime.Now.ToLongTimeString();
            lblfecha.Text=DateTime.Now.ToLongDateString();
            lblturn.Text=frmPrincip.Turno.turnoactual.ToString();
            lblturnsig.Text=frmPrincip.Turno.turnosig.ToString();
        }
    }
}
