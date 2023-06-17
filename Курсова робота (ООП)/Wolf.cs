using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_робота__ООП_
{
    public class Wolf
    {
        private static Random rnd = new Random();

        public string proID { get; }
        public string Name { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Hunger { get; set; }

        public Wolf(string proid, int hunger)
        {
            proID = proid;
            Hunger = hunger;
        }

        public const string ID = "BM";

        public Wolf(string name, int positionX, int positionY, int hunger)
        {
            Name = name;
            PositionX = positionX;
            PositionY = positionY;
            Hunger = hunger;
        }

        public Wolf()
        {
            Name = "BM";
            PositionX = 0;
            PositionY = 0;
            Hunger = 30;
        }
    }
}

