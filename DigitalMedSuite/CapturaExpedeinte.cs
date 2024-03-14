using ProyectoAdmiCaptura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAdmin
{
    public partial class CapturaDeExpediente : Form
    {
        public CapturaDeExpediente()
        {
            InitializeComponent();
        }
        public string GenerarNumeroDeExpediente()
        {
            DateTime Hoy = DateTime.Today;
            string Dia = "", Mes = "";
            if (Hoy.Day < 10)
                Dia = string.Concat("0", Hoy.Day.ToString());
            else
                Dia = Hoy.Day.ToString();
            if (Hoy.Month < 10)
                Mes = string.Concat("0", Hoy.Month.ToString());
            else
                Mes = Hoy.Month.ToString();
            return String.Concat("30", Dia, Mes, Datos.i);
        }
        public string InsertadoDeInformacionString(string CajaDeTexto)
        {
            try
            {
                if (CajaDeTexto == "")
                    throw new Exception();
                else
                    return CajaDeTexto;
            }
            catch (Exception)
            {
                MessageBox.Show("Datos incopletos");
                return "";
            }
            
        }
        public string GeneradorDeCURP()
        {
            String PrimeraLetraNombre, PrimeraLetraApellidoP, PrimeraLetraApellidoM, DiaN, MesN, AñoN, UltimosDigitos;
            String PrimeraVocalApeP, ConsonanteApeP, ConsonanteApeM, ConsonanteNombre, Sexo;
            //Almacena la primera letra del nombre y los apellidos
            PrimeraLetraNombre = String.Concat(txtNombre.Text[0]);
            PrimeraLetraApellidoP = String.Concat(txtApellidoP.Text[0]);
            PrimeraLetraApellidoM = String.Concat(txtApellidoM.Text[0]);
            UltimosDigitos = txtUltimosDigitosCURP.Text;
            //Obtiene los ultimos dos digitos del año ingresado
            AñoN = String.Concat(txtAñoN.Text[2], txtAñoN.Text[3]);
            DiaN = comboBoxDiaN.Text;
            MesN = comboBoxMesN.Text;
            //Se mandan los apellidos y los nombres al metido siguente para obtener las vocales y las iniciales
            PrimeraVocalApeP = ObtencionDeVocales(txtApellidoP.Text);
            ConsonanteApeP = ObtencionDeConsonantes(txtApellidoP.Text);
            ConsonanteApeM = ObtencionDeConsonantes(txtApellidoM.Text);
            ConsonanteNombre = ObtencionDeConsonantes(txtNombre.Text);
            //
            if (cobSexo.Text == "Hombre")
                Sexo = "H";
            else
                Sexo = "M";
            //Junta todas las variables para sacar la curp
            return String.Concat(PrimeraLetraApellidoP, PrimeraVocalApeP, PrimeraLetraApellidoM, PrimeraLetraNombre
                , AñoN, MesN, DiaN, Sexo, ObtenerLugarDeNacimiento(), ConsonanteApeP, 
                ConsonanteApeM, ConsonanteNombre, UltimosDigitos);
        }
        public string ObtenerLugarDeNacimiento()
        {
            string Estados = listaEstados.Text;
            switch (Estados)
            {
                case "AGUASCALIENTES": return "AS";
                case "BAJA CALIFORNIA": return "BC";
                case "BAJA CALIFORNIA SUR": return "BS";
                case "CAMPECHE": return "CC";
                case "COAHUILA": return "CL";
                case "COLIMA": return "CM";
                case "CHIAPAS": return "CS";
                case "CHIHUAHUA": return "CH";
                case "DISTRITO FEDERAL": return "DF";
                case "DURANGO": return "DG";
                case "GUANAJUATO": return "GT";
                case "GUERRERO": return "GR";
                case "HIDALGO": return "HG";
                case "JALISCO": return "JC";
                case "MEXICO": return "MC";
                case "MICHOACAN": return "MN";
                case "MORELOS": return "MS";
                case "NAYARIT": return "NT";
                case "NUEVO LEON": return "NL";
                case "OAXACA": return "OC";
                case "PUEBLA": return "PL";
                case "QUERETARO": return "QUERETARO";
                case "QUINTANA ROO": return "QR";
                case "SAN LUIS POTOSI": return "SP";
                case "SINALOA": return "SL";
                case "SONORA": return "SR";
                case "TABASCO": return "TC";
                case "TAMAULIPAS": return "TS";
                case "TLAXCALA": return "TL";
                case "VERACRUZ": return "VZ";
                case "YUCATAN": return "YN";
                case "ZACATECAS": return "ZS";
            }
            return "XX";
        }
        public string ObtencionDeConsonantes(string Palabra)
        {
            //Se adelanta una posicion el contador por que inicial ya se esta ocupando
            int i = 1;
            //Ciclo que evalua la palabra buscando la primera consonante
            do
            {
                string Letra = String.Concat(Palabra[i]);
                switch (Letra)
                {
                    case "B": return "B";
                    case "C": return "C";
                    case "D": return "D";
                    case "F": return "F";
                    case "G": return "G";
                    case "H": return "H";
                    case "J": return "J";
                    case "K": return "K";
                    case "L": return "L";
                    case "M": return "M";
                    case "N": return "N";
                    case "Ñ": return "X";
                    case "P": return "P";
                    case "Q": return "Q";
                    case "R": return "R";
                    case "S": return "S";
                    case "T": return "T";
                    case "V": return "V";
                    case "W": return "W";
                    case "X": return "X";
                    case "Y": return "Y";
                    case "Z": return "Z";
                }
                i++;
            } while (i != Palabra.Length + 1);
            return "X";
        }
        public string ObtencionDeVocales(string Palabra)
        {
            int i = 0;
            //Un ciclo que recorrera la palabra clave en busca de la vocal
            try
            {
                do
                {
                    switch (String.Concat(Palabra[i]))
                    {
                        case "A":
                            return "A";
                        case "E":
                            return "E";
                        case "I":
                            return "I";
                        case "O":
                            return "O";
                        case "U":
                            return "U";
                    }

                    i++;
                } while (i != Palabra.Length + 1);
            }
            //Si no encuentra nada regresara la default
            catch (System.ArgumentOutOfRangeException)
            {
                return "X";
            }
            return "X";
        }
        public int ObtenerEdad()
        {
            int AnoActual = 0,AnoDelPaciente=0;
            DateTime Hoy = DateTime.Now;
            AnoActual= Hoy.Year;
            AnoDelPaciente = int.Parse(txtAñoN.Text);
            return AnoActual-AnoDelPaciente;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double AlturaT, PesoT;
            int EdadT=ObtenerEdad();
            string NombreT;
            string Sexo, Nombres,Telefono,TelefonoEmerg,Correo,TipoSangre,ActivoSex,Alergias,Adicciones,ETS,HistQuirurgico,AnteFam,NumExp;
            Sexo = InsertadoDeInformacionString(cobSexo.Text);
            NombreT=String.Concat(txtNombre.Text,txtApellidoP.Text,txtApellidoM.Text);
            Nombres= InsertadoDeInformacionString(NombreT);
            Telefono = InsertadoDeInformacionString(txtTelefono.Text);
            TelefonoEmerg = InsertadoDeInformacionString(txtTelefonoEmergencia.Text);
            Correo = InsertadoDeInformacionString(txtCorreoE.Text);
            TipoSangre = InsertadoDeInformacionString(cobTipodeSangre.Text);
            ActivoSex = InsertadoDeInformacionString(cobSexActivo.Text);
            Alergias= InsertadoDeInformacionString(txtAlergias.Text);
            Adicciones = InsertadoDeInformacionString(txtAdicciones.Text);
            ETS= InsertadoDeInformacionString(txtETS.Text);
            HistQuirurgico = InsertadoDeInformacionString(txtHistQuirugico.Text);
            AnteFam = InsertadoDeInformacionString(txtAnteFam.Text);
            NumExp = GenerarNumeroDeExpediente();
            try
            {
                AlturaT = double.Parse(txtAltura.Text);
                PesoT = int.Parse(txtPeso.Text);
                if (EdadT < 0 || AlturaT < 0 || PesoT < 0)
                    throw new Exception();
                Datos.Edad[Datos.i]=EdadT;
                Datos.Peso[Datos.i]=int.Parse(txtPeso.Text);
                Datos.Altura[Datos.i]=double.Parse(txtAltura.Text);

                TextWriter expediente = new StreamWriter("C:\\Users\\roker\\source\\repos\\DigitalMedSuite_Diseños\\DigitalMedSuite\\bin\\Debug\\Expedientes\\" + NumExp +" - "+NombreT+ ".txt");
                expediente.WriteLine(Nombres);
                expediente.WriteLine(Telefono);
                expediente.WriteLine(TelefonoEmerg);
                expediente.WriteLine(Correo);
                expediente.WriteLine(TipoSangre);
                expediente.WriteLine(ActivoSex);
                expediente.WriteLine(Alergias);
                expediente.WriteLine(Adicciones);
                expediente.WriteLine(ETS);
                expediente.WriteLine(HistQuirurgico);
                expediente.WriteLine(AnteFam);
                expediente.WriteLine(NumExp);
                expediente.Close();
            }
            catch(FormatException)
            {
                MessageBox.Show("No introducir letras en la Altura,Peso y Edad");
            }
            catch (Exception)
            {
                MessageBox.Show("No introducir numeros negativos en la altura, peso y edad");
            }
            Datos.CURP[Datos.i]=GeneradorDeCURP();
            MessageBox.Show("Numero de expediente: "+Datos.NumeroDeExpediente[Datos.i]+"\nCURP: " + Datos.CURP[Datos.i]);
            Datos.i++;
        }
    }
}
