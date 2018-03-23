using AdventOfCodeDay3.SpiralMemory;
using System;

namespace AdventOfCodeDay3.SpiralMemory
{
    public class ManhattanDistanceCalculator
    {
        public ManhattanDistanceCalculator()
        {
        }

        public int GetIndexOfValue(int input)
        {
            var index = 1;

            while (Math.Pow((2 * index + 1), 2) < input)
            {
                index++;
            }

            return index;
        }

        public int Calculate(int input)
        {
            var index = GetIndexOfValue(input);
            var square = SquareOfSpiral.SquareFactory(index);
            var points = square.GetPoints();

            Point point = points.Find(u => u.Value == input);
            int result = 0;

            for(int i = 1; i <= Math.Abs(point.X); i++)
            {
                result += 1;
            }

            for (int i = 1; i <= Math.Abs(point.Y); i++)
            {
                result += 1;
            }

            return result;

        }
    }
}
