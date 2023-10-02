using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class ComplexNum
    {
        public double module { get; set; } 
        public double argument { get; set; }
        public double realPart { get; set; }
        public double imaginaryPart { get; set; }

        public ComplexNum()
        {      
        }
        public ComplexNum(double _module, double _argument)
        {
            module = _module;
            argument = _argument;
            realPart = module * Math.Cos(argument);
            imaginaryPart = module * Math.Sin(argument);
        }
        public double GetModule()
        {
            return module;
        }
        public double GetArgument()
        {
            return argument;
        }

        public ComplexNum Power(double n)
        {
            double newModule = Math.Pow(module, n);
            double newArgument = argument * n;

            return new ComplexNum(newModule, newArgument);
        }
        public static ComplexNum operator +(ComplexNum a, ComplexNum b)
        {
            return new ComplexNum
            {
                realPart = a.realPart + b.realPart,
                imaginaryPart = a.imaginaryPart + b.imaginaryPart
            };
        }

        public static ComplexNum operator -(ComplexNum a, ComplexNum b)
        {
            return new ComplexNum
            {
                realPart = a.realPart - b.realPart,
                imaginaryPart = a.imaginaryPart - b.imaginaryPart
            };
        }

        public static ComplexNum operator *(ComplexNum a, ComplexNum b)
        {
            return new ComplexNum
            {
                realPart = a.realPart * b.realPart - a.imaginaryPart * b.imaginaryPart,
                imaginaryPart = a.realPart * b.imaginaryPart + a.imaginaryPart * b.realPart
            };
        }

        public static ComplexNum operator /(ComplexNum a, ComplexNum b)
        {
            double denominator = b.realPart * b.realPart + b.imaginaryPart * b.imaginaryPart;
            return new ComplexNum
            {
                realPart = (a.realPart * b.realPart + a.imaginaryPart * b.imaginaryPart) / denominator,
                imaginaryPart = (a.imaginaryPart * b.realPart - a.realPart * b.imaginaryPart) / denominator
            };
        }
        public void PrintComplexNumber()
        {
            module = Math.Sqrt(realPart * realPart + imaginaryPart * imaginaryPart);
            argument = Math.Atan2(imaginaryPart, realPart);
            Console.WriteLine("Комплексное число в тригонометрическом виде:");
            Console.WriteLine($"R=|{module}|*(Cos({argument})+Sin({argument})i)");


            Console.WriteLine("Комплексное число в алгебраическом виде:");
            Console.WriteLine($"R={realPart}+{imaginaryPart}i");
        }
       
    }
}
