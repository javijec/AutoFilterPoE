using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
                   
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
        }

        private void Boton_Filtro(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";
            string dir = null;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                dir = fbd.SelectedPath;
                dir = dir.Replace(@"\", @"\\");
            }
            else
            {
                dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            }

            MessageBox.Show(dir);

            if (cB_UMaps.Checked == true)
            {
                WebClient n = new WebClient();
                var json = n.DownloadString("http://poeninja.azureedge.net/api/Data/GetUniqueMapOverview?league=tmpstandard");
                Objetos Umaps = new Objetos();
                Objetos UMap = JsonConvert.DeserializeObject<Objetos>(json);

                //Eleccion de direcctorio y nombre del filtro.
                dir = dir.Replace(@"\", @"\\");
                System.IO.StreamWriter file = new System.IO.StreamWriter(dir + "\\filtro.filter");

                ///rango de valores para seleccion de Mapas
                double VmMapa = new double();
                VmMapa = Convert.ToDouble(vChaosmUM.Value);
                double VT1Mapa = new double();
                VT1Mapa = Convert.ToDouble(vChaosT1UM.Value);


                /// Mapas Mayor valor
                file.WriteLine("Show # Maps:Unique - T1 > " + VT1Mapa + " chaos");
                file.WriteLine("    Class Maps");
                file.Write("    BaseType ");
                for (int i = 0; i < UMap.lines.Count; i++)
                {
                    if (UMap.lines[i].ChaosValue >= VT1Mapa)
                    {
                        file.Write("\"" + UMap.lines[i].BaseType + "\" ");
                    }
                }
                file.WriteLine(" ");
                file.WriteLine("    Rarity Unique");
                file.WriteLine("    SetFontSize 45");
                file.WriteLine("");
                file.WriteLine("    SetTextColor 175 96 37 255           # TEXTCOLOR:	 Uniques");
                file.WriteLine("    SetBorderColor 175 96 37 255         # BORDERCOLOR:	 Unique Item");
                file.WriteLine("    SetBackgroundColor 255 255 255 255   # BACKGROUND:	 T1 Global High Value Drop");
                file.WriteLine("    PlayAlertSound 6 300                 # DROPSOUND:	 T1 Drop");
                file.WriteLine("");

                /// Mapas Bajo Valor
                file.WriteLine("Show # Maps:Unique > " + VmMapa + " chaos");
                file.WriteLine("    Class Maps");
                file.Write("    BaseType ");
                for (int i = 0; i < UMap.lines.Count; i++)
                {
                    if (UMap.lines[i].ChaosValue >= VmMapa && UMap.lines[i].ChaosValue < VT1Mapa)
                    {
                        file.Write("\"" + UMap.lines[i].BaseType + "\" ");
                    }
                }
                file.WriteLine(" ");
                file.WriteLine("    Rarity Unique");
                file.WriteLine("    SetFontSize 42");
                file.WriteLine("");
                file.WriteLine("    SetBorderColor 175 96 37 255         # BORDERCOLOR:	 Unique Item");
                file.WriteLine("    PlayAlertSound 4 300                 # DROPSOUND: T1 maps");
                file.WriteLine("");

                ///Mapas Ocultos
                if (cB_mUM.Checked == true) {
                    file.WriteLine("Show # Maps:Unique < " + VmMapa + " chaos");
                    } else
                {
                    file.WriteLine("Hide # Maps:Unique < " + VmMapa + " chaos");

                }
                file.WriteLine("    Class Maps");
                file.WriteLine("    Rarity Unique");
                file.WriteLine("");

                MessageBox.Show("Filtro terminado");
                file.Close();

            }
        }

        private void Boton_Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
