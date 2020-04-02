using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class Calculator
    {
        public double a;
        public double b;

        public void sum()
        {
            double c = a + b;
            Console.WriteLine("Summary is: " + c);
        }
        public void S()
        {
            double c = a * a;
            Console.WriteLine("Circuit is: " + c);
        }
        public void o()
        {
            double c = 4 * a;
            Console.WriteLine("Obvod is: " + c);
        }
        public void P()
        {
            double c = a * a + b * b;
            c = Math.Sqrt(c);
            c = Math.Round(c, 2);
            Console.WriteLine("Pythagorean theorem is : " + c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator anwser = new Calculator();
            Console.Write("First number: ");
            anwser.a = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            anwser.b = int.Parse(Console.ReadLine());
            anwser.sum();
            anwser.o();
            anwser.S();
            anwser.P();
            Console.ReadKey();
        }
    }
}
