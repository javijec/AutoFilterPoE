using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

public class Sparkline
{
    public List<object> Data { get; set; }
    public double TotalChange { get; set; }
}

public class Line
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int MapTier { get; set; }
        public int LevelRequired { get; set; }
        public string BaseType { get; set; }
        public int StackSize { get; set; }
        public object Variant { get; set; }
        public object ProphecyText { get; set; }
        public object ArtFilename { get; set; }
        public int Links { get; set; }
        public int ItemClass { get; set; }
        public Sparkline Sparkline { get; set; }
        public List<object> ImplicitModifiers { get; set; }
        public List<object> ExplicitModifiers { get; set; }
        public string FlavourText { get; set; }
        public string ItemType { get; set; }
        public double ChaosValue { get; set; }
        public double ExaltedValue { get; set; }
        public int Count { get; set; }
    }

public class Objetos
{
    public List<Line> lines { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        WebClient n = new WebClient();
        var json = n.DownloadString("http://poeninja.azureedge.net/api/Data/GetUniqueMapOverview?league=tmpstandard");
        Objetos Umaps = new Objetos();
        Objetos UMap = JsonConvert.DeserializeObject<Objetos>(json);

        //Eleccion de direcctorio y nombre del filtro.
        var dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        dir = dir.Replace(@"\", @"\\");
        System.IO.StreamWriter file = new System.IO.StreamWriter(dir + "\\filtro.filter");

        ///rango de valores para seleccion de Mapas
        Console.Write("Inserte valor minimo de mapas: ");
        double VmMapa = new double();
        VmMapa = Convert.ToDouble(Console.ReadLine());
        Console.Write("Inserte valor T1 de mapas: ");
        double VT1Mapa = new double();
        VT1Mapa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();

        file.WriteLine("#------------------------------------");
        file.WriteLine("#   [1201] Unique Maps");
        file.WriteLine("#------------------------------------");

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
        file.WriteLine("Hide # Maps:Unique < " + VmMapa + " chaos");
        file.WriteLine("    Class Maps");
        file.WriteLine("    Rarity Unique");
        file.WriteLine("");

        file.Close();
        Console.WriteLine("Creacion del Filtro Terminada");
        Console.ReadKey();
    }
}
