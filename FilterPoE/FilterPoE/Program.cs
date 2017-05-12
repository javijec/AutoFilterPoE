using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;

public class Sparkline
{
    public List<double> data { get; set; }
    public double totalChange { get; set; }
}

public class ExplicitModifier
{
    public string text { get; set; }
    public bool optional { get; set; }
}

public class Line
{
    public int id { get; set; }
    public string name { get; set; }
    public string icon { get; set; }
    public int mapTier { get; set; }
    public int levelRequired { get; set; }
    public string baseType { get; set; }
    public int stackSize { get; set; }
    public object variant { get; set; }
    public object prophecyText { get; set; }
    public object artFilename { get; set; }
    public int links { get; set; }
    public int itemClass { get; set; }
    public Sparkline sparkline { get; set; }
    public List<object> implicitModifiers { get; set; }
    public List<ExplicitModifier> explicitModifiers { get; set; }
    public string flavourText { get; set; }
    public string itemType { get; set; }
    public double chaosValue { get; set; }
    public double exaltedValue { get; set; }
    public int count { get; set; }
}

public class RootObject
{
    public List<Line> lines { get; set; }
}






class Program
{
    static void Main(string[] args)
    {
        using (WebClient webClient = new System.Net.WebClient())
        {
            WebClient n = new WebClient();
            var json = n.DownloadString("http://poeninja.azureedge.net/api/Data/GetUniqueMapOverview?league=tmpstandard");
            RootObject maps = JsonConvert.DeserializeObject<RootObject>(json);
           
            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\filtro.txt");


            Console.Write("Inserte valor minimo de mapas: ");
            double VmMapa = new double();
            VmMapa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inserte valor T1 de mapas: ");
            double VT1Mapa = new double();
            VT1Mapa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < maps.lines.Count; i++)
            {
                if (maps.lines[i].chaosValue >= VT1Mapa)
                {
                    file.WriteLine("Show # Maps:Unique - T1 > " + VT1Mapa + " chaos");
                    file.WriteLine("    Class Maps");
                    file.WriteLine("    BaseType \"" + maps.lines[i].baseType + "\"");
                    file.WriteLine("    Rarity Unique");
                    file.WriteLine("    SetFontSize 45");
                    file.WriteLine("");
                    file.WriteLine("    SetTextColor 175 96 37 255           # TEXTCOLOR:	 Uniques");
                    file.WriteLine("    SetBorderColor 175 96 37 255         # BORDERCOLOR:	 Unique Item");
                    file.WriteLine("    SetBackgroundColor 255 255 255 255   # BACKGROUND:	 T1 Global High Value Drop");
                    file.WriteLine("    PlayAlertSound 6 300                 # DROPSOUND:	 T1 Drop");
                    file.WriteLine("");
                }
                if (maps.lines[i].chaosValue >= VmMapa && maps.lines[i].chaosValue < VT1Mapa)
                {
                    file.WriteLine("Show # Maps:Unique > " + VmMapa + " chaos");
                    file.WriteLine("    Class Maps");
                    file.WriteLine("    BaseType \"" + maps.lines[i].baseType + "\"");
                    file.WriteLine("    Rarity Unique");
                    file.WriteLine("    SetFontSize 42");
                    file.WriteLine("");
                    file.WriteLine("    SetBorderColor 175 96 37 255         # BORDERCOLOR:	 Unique Item");
                    file.WriteLine("    PlayAlertSound 4 300                 # DROPSOUND: T1 maps");
                    file.WriteLine("");
                }
            }
            file.Close();
            Console.WriteLine("Creacion del Filtro Terminada");
            Console.ReadKey();
        }
    }
}
