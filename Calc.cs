using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    public class Calc
    {
        public struct Triple
        {
            public readonly double squareTr;
            public readonly string isRectangular;
            public Triple(double squareTr, string isRectangular)
            {
                this.isRectangular = isRectangular;
                this.squareTr = squareTr;
            }
        }
        public double SquareCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2.0);
        }
        public Triple SquareRect(double a, double b, double c)
        {

            string s = "непрямоугольный треугольних";
            if (a > b && a > c) //определение типа треугольника
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)) s = "прямоугольный треугольник";
            }
            else if (b > c && b > c)
            {
                if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)) s = "прямоугольный треугольник";
            }
            else if (c > a && c > b)
            {
                if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)) s = "прямоугольный треугольник";
            }


            double p = (a + b + c) / 2; //расчет периметра
            Triple tr = new Triple(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), s);//возврат значения площади и определения прямоугольный или нет
           
            return tr;

        }
    }


}


