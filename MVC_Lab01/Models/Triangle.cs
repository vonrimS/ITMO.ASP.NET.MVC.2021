using System;
namespace MVC_Lab01.Models
{
    public class Triangle : Shape
    {

        //public double Sta { get; set; }
        public double Stb { get; set; }
        public double Stc { get; set; }

        override public string Name => $"\"Треугольник со сторонами {St}, {Stb}, {Stc}\"";
        //{
        //    get
        //    {
        //        return String.Format("\"Треугольник со сторонами {0}, {1}, {2}\"", Sta, Stb, Stc);
        //    }
        //}

        public double Perimeter => Math.Round(St + Stb + Stc);
        //{
        //    get
        //    {
        //        double p = Sta + Stb + Stc;
        //        return p;
        //    }
        //}

        public double Area
        {
            get
            {
                double sq = Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - St) * (Perimeter / 2 - Stb) * (Perimeter / 2 - Stc));
                return sq;
            }
        }

        public Triangle(double a, double b, double c)
        {
            St = a;
            Stb = b;
            Stc = c;
        }
    }
}
