using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNum a = new ComplexNum(1, 2);
            ComplexNum b = new ComplexNum(1, 1);
            ComplexNum c = new ComplexNum(3, 4);
            ComplexNum d = new ComplexNum(5, 1);
            ComplexNum R = new ComplexNum();
           
            R = b.Power(3) + ((a+b) / (c-a)) *d;
            R.PrintComplexNumber();
        }
    }
}
