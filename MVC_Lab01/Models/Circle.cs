using System;
namespace MVC_Lab01.Models
{
    public class Circle : Shape, IComparable<Circle>
    {

        //public double St { get; set; }


        override public string Name => $"\"Окружность с радиусом {St}\"";

        public double Dlina => 2 * Math.PI * St;

        public double Area => Math.PI * St * St;
        

        public Circle(double a)
        {
            St = a;
        }

        public int CompareTo(Circle other)
        {
            if (this.Area == other.Area) return 0;
            else if (this.Area > other.Area) return 1;
            else return -1;
        }
    }
}
