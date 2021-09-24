using System;
namespace MVC_Lab01.Models
{
    public class Shape
    {

        public double St { get; set; }

        virtual public string Name => "\"Фигура\"";
        

        public Shape()
        {
        }
    }
}
