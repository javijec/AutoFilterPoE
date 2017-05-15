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
using System.Windows;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            Bitmap b;
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = (Image)b;
            Graphics g = Graphics.FromImage(b);
            Color myColor = Color.FromArgb(trackBar4.Value, trackBar5.Value, trackBar6.Value);
            SolidBrush myBrush = new SolidBrush(myColor);
            g.FillRectangle(myBrush, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            label7.ForeColor = Color.FromArgb(trackBar_RGB1.Value, trackBar_RGB2.Value, trackBar_RGB3.Value);
            label7.BackColor = Color.FromArgb(trackBar4.Value, trackBar5.Value, trackBar6.Value);
        }

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
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
                file.WriteLine("    SetTextColor " + trackBar_RGB1.Value + " " + trackBar_RGB2.Value + " " + trackBar_RGB3.Value + " 255           # TEXTCOLOR:	 Uniques");
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

        private void RgbUMaps(object sender, EventArgs e)
        {
            RGBUM1.Value = trackBar_RGB1.Value;
            RGBUM2.Value = trackBar_RGB2.Value;
            RGBUM3.Value = trackBar_RGB3.Value;
            numericUpDown1.Value = trackBar1.Value;
            numericUpDown2.Value = trackBar2.Value;
            numericUpDown3.Value = trackBar3.Value;
            numericUpDown4.Value = trackBar4.Value;
            numericUpDown5.Value = trackBar5.Value;
            numericUpDown6.Value = trackBar6.Value;
            numericUpDown8.Value = trackBar8.Value;
            numericUpDown7.Value = trackBar97.Value;
            Bitmap b;
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = (Image)b;
            Graphics g = Graphics.FromImage(b);
            Color myColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            SolidBrush myBrush = new SolidBrush(myColor);
            g.FillRectangle(myBrush, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            Color myColor2 = Color.FromArgb(trackBar4.Value, trackBar5.Value, trackBar6.Value);
            SolidBrush myBrush2 = new SolidBrush(myColor2);
            g.FillRectangle(myBrush2, new Rectangle(0+5, 0+5, pictureBox1.Width-10, pictureBox1.Height-10));
            label7.ForeColor = Color.FromArgb(trackBar_RGB1.Value, trackBar_RGB2.Value, trackBar_RGB3.Value);
            label7.BackColor = Color.FromArgb(trackBar4.Value, trackBar5.Value, trackBar6.Value);
        }

        private void RgbUMaps2(object sender, EventArgs e)
        {
            trackBar_RGB1.Value = Convert.ToInt32(RGBUM1.Value);
            trackBar_RGB2.Value = Convert.ToInt32(RGBUM2.Value);
            trackBar_RGB3.Value = Convert.ToInt32(RGBUM3.Value);
            trackBar1.Value = Convert.ToInt32(numericUpDown1.Value);
            trackBar2.Value = Convert.ToInt32(numericUpDown2.Value);
            trackBar3.Value = Convert.ToInt32(numericUpDown3.Value);
            trackBar4.Value = Convert.ToInt32(numericUpDown4.Value);
            trackBar5.Value = Convert.ToInt32(numericUpDown5.Value);
            trackBar6.Value = Convert.ToInt32(numericUpDown6.Value);
            trackBar8.Value = Convert.ToInt32(numericUpDown8.Value);
            trackBar97.Value = Convert.ToInt32(numericUpDown7.Value);
            Bitmap b;
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = (Image)b;
            Graphics g = Graphics.FromImage(b);
            Color myColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            SolidBrush myBrush = new SolidBrush(myColor);
            g.FillRectangle(myBrush, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            Color myColor2 = Color.FromArgb(trackBar4.Value, trackBar5.Value, trackBar6.Value);
            SolidBrush myBrush2 = new SolidBrush(myColor2);
            g.FillRectangle(myBrush2, new Rectangle(0 + 5, 0 + 5, pictureBox1.Width - 10, pictureBox1.Height - 10));
            label7.ForeColor = Color.FromArgb(trackBar_RGB1.Value,trackBar_RGB2.Value,trackBar_RGB3.Value);
            label7.BackColor = Color.FromArgb(trackBar4.Value, trackBar5.Value, trackBar6.Value);
        }
    }
}
