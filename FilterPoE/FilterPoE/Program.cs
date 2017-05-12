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

            for (int i = 0; i < maps.lines.Count; i++)
            {
                if (maps.lines[i].chaosValue > 10)
                {

                    Console.Write("Nombre del mapa: ");
                    Console.Write(maps.lines[i].name);
                    Console.Write(", Base del mapa: ");
                    Console.Write(maps.lines[i].baseType);
                    Console.Write(", Valor en chaos del mapa: ");
                    Console.WriteLine(maps.lines[i].chaosValue);
                    file.Write("Nombre del mapa: ");
                    file.Write(maps.lines[i].name);
                    file.Write(", Base del mapa: ");
                    file.Write(maps.lines[i].baseType);
                    file.Write(", Valor en chaos del mapa: ");
                    file.WriteLine(maps.lines[i].chaosValue);

                }
            }
            Console.ReadKey();
            file.Close();
        }
    }
}
