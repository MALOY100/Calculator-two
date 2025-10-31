using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ICalculator
{
    internal interface IUpCalculator
    {
        public int Value3 { get; set; }
        public int Value4 { get; set; }
        public int Exponentiation2(int Value3);
        public int Exponentiation3(int Value3);
        public double Root(double Value3);
        public double Sin(double Value3);
        public double Cos(double Value3);
        public double Tan(double Value3);

    }
}
