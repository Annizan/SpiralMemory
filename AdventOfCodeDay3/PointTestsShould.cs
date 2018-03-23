using AdventOfCodeDay3.SpiralMemory;
using NFluent;
using NUnit.Framework;

namespace AdventOfCodeDay3
{
    public class PointTestsShould
    {
        [TestCase(2, 1, 0)]
        public void Give_The_Abscisse_Of_A_Point(double value, int x, int y)
        {
            Point point = new Point(value)
            {
                X = 1
            };
            Check.That(point.X).IsEqualTo(x);
        }
    }
}
