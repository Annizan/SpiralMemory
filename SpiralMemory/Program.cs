using AdventOfCodeDay3.SpiralMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir le nombre dont la distance est à déterminer :");
            var isNumber = int.TryParse(Console.ReadLine(),out int input);
            while(!isNumber)
            {
                Console.WriteLine("Veuillez saisir le nombre dont la distance est à déterminer :");
                isNumber = int.TryParse(Console.ReadLine(), out input);
            }
            var Calculator = new ManhattanDistanceCalculator();

            Console.WriteLine(Calculator.Calculate(input));
            Console.ReadLine();
        }
    }
}
