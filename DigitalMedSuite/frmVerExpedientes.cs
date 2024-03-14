using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalMedSuite
{
    public partial class frmVerExpedientes : Form
    {
        string Path = @"C:\Users\roker\source\repos\DigitalMedSuite_Diseños\DigitalMedSuite\bin\Debug\Expedientes";
        public frmVerExpedientes()
        {
            InitializeComponent();
        }

        private void frmVerExpedientes_Load(object sender, EventArgs e)
        {
          
            GetFiles();
        }

        private void GetFiles() 
        {
            DirectoryInfo di = new DirectoryInfo(Path);
           /* string[] lst = Directory.GetFiles(@"C:\Users\roker\source\repos\DigitalMedSuite_Diseños\DigitalMedSuite\bin\Debug\Expedientes");
           */ 
            foreach (var sFile in di.GetFiles())
            {

                cob_Archivos.Items.Add(sFile.Name);

            }
           

        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            frmPrincip princip = new frmPrincip(); 
            princip.Show();
            this .Hide ();
        }
    }
}
