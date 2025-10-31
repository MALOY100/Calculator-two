using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ICalculator
{
    internal interface ICalculator
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public double Add(double Value1, double Value2);
        public double Sub(double Value1, double Value2);
        public double Math(double Value1, double Value2);
        public double Div(double Value1, double Value2);

    }
}