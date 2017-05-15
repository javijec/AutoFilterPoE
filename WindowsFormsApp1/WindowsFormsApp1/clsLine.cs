using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
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
}
