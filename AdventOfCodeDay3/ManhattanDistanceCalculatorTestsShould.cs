using AdventOfCodeDay3.SpiralMemory;
using NFluent;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeDay3
{
    class ManhattanDistanceCalculatorTestsShould
    {
        [TestCase(9, 1)]
        [TestCase(34, 3)]
        [TestCase(60, 4)]
        public void Give_The_Index_Of_A_Given_Number(int input, int expected)
        {

            ManhattanDistanceCalculator manhattanDistanceCalculator = new ManhattanDistanceCalculator();
            Check.That(manhattanDistanceCalculator.GetIndexOfValue(input)).IsEqualTo(expected);
        }

        [TestCase(3, 2)]
        public void Rename(int input, int expected)
        {
            ManhattanDistanceCalculator manhattanDistanceCalculator = new ManhattanDistanceCalculator();
            Check.That(manhattanDistanceCalculator.Calculate(input)).IsEqualTo(expected);
        }
    }
}
