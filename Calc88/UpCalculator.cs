using Calculator.ICalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc88
{
    internal class UpCalculator : IUpCalculator
    {
        public int Value3 { get; set; }
        public int Value4 { get; set; }

        public int Exponentiation2(int Value3)
        {
            return Value3 * Value3;
        }
        public int Exponentiation3(int Value3)
        {
            return (Value3 * Value3 * Value3);
        }
        public double Root(double Value3)
        {
            double guess = Value3 / 2;
            for (int i = 0; i < 10; i++)
            {
                guess = (guess + Value3 / guess) / 2;
            }
            return guess;
        }
        public double Sin(double angle)
        {

            angle %= 360;
            if (angle < 0) angle += 360;

            double rad = angle * 3.1415926535 / 180;
            double Value3 = rad;
            return Value3 - (Value3 * Value3 * Value3) / 6 + (Value3 * Value3 * Value3 * Value3 * Value3) / 120 - (Value3 * Value3 * Value3 * Value3 * Value3 * Value3 * Value3) / 5040;
        }
        public double Cos(double angle)
        {
            angle %= 360;
            if (angle < 0) angle += 360;
            double rad = angle * 3.1415926535 / 180;
            double Value3 = rad;
            return 1 - (Value3 * Value3) / 2 + (Value3 * Value3 * Value3 * Value3) / 24 - (Value3 * Value3 * Value3 * Value3 * Value3 * Value3) / 720;
        }
        public double Tan(double angle)
        {
            double sin = Sin(angle);
            double cos = Cos(angle);

            return sin / cos;
        }
    }
}
