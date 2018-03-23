using AdventOfCodeDay3;
using AdventOfCodeDay3.SpiralMemory;
using NFluent;
using NUnit.Framework;

namespace AdventOfCodeDay3Tests
{
    public class SquareOfSpiralTestsShould
    {
        [TestCase(1, 8)]
        [TestCase(2, 16)]
        [TestCase(3, 24)]
        [TestCase(4, 32)]
        public void Give_The_Number_Of_Items_In_Square_Of_An_Index_Given(int index, int expected)
        {
            SquareOfSpiral squareOfSpiral = SquareOfSpiral.SquareFactory(index);
            Check.That(squareOfSpiral.GetPoints().Count()).IsEqualTo(expected);
        }


        [TestCase(2, 21, -2)]
        [TestCase(3, 46, 0)]
        public void Give_The_Abscisse_Given_A_Number_And_His_Index(int index, int searchedValue, int expected)
        {
            SquareOfSpiral square = SquareOfSpiral.SquareFactory(index);
            Point point = square.GetPoints().Find(u => u.Value == searchedValue);
            Check.That(point.X).IsEqualTo(expected);

        }


    }
}
