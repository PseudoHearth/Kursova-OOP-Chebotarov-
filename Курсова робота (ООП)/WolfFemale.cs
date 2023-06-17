using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова_робота__ООП_
{
    public class WolfFemale
    {
        private static Random rnd = new Random();

        public string proID { get; }
        public string Name { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Hunger { get; set; }

        public WolfFemale(string proid, int hunger)
        {
            proID = proid;
            Hunger = hunger;
        }

        public const string ID = "BF";

        public WolfFemale(string name, int positionX, int positionY, int hunger)
        {
            Name = name;
            PositionX = positionX;
            PositionY = positionY;
            Hunger = hunger;
        }

        public WolfFemale()
        {
            Name = "BF";
            PositionX = 0;
            PositionY = 0;
            Hunger = 30;
        }
    }
}
