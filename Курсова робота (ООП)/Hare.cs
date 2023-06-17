using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова_робота__ООП_
{
    public class Hare
    {
        public string proID { get; }
        public Hare(string proid)
        {
            proID = proid;
        }
        public const string ID = "3";


        public string Name { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Hare(string name, int column, int row)
        {
            Name = name;
            PositionX = column;
            PositionY = row;
        }
        public Hare()
        {
            Name = "3";
            PositionX = 0;
            PositionY = 0;
        }
    }
}
