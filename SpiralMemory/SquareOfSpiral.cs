using AdventOfCodeDay3;
using System;
using System.Collections.Generic;

namespace AdventOfCodeDay3.SpiralMemory
{
    public class SquareOfSpiral
    {
        private int index;
        private List<Point> points = new List<Point>();

        private SquareOfSpiral(int index, List<Point> points)
        {
            this.index = index;
            this.points = points;
        }

        
        public List<Point> GetPoints()
        {
            List<Point> listOfPoints = points;
            return listOfPoints;
        }




        public static SquareOfSpiral SquareFactory(int index)
        {
            double maxValueOfSquare = Math.Pow((2 * index + 1), 2);
            double numberOfValueInSquare = maxValueOfSquare - Math.Pow((2 * index - 1), 2);
            List<Point> points = new List<Point>();

            Stack<Point> numbers = new Stack<Point>();
            for (double i = 0; i < numberOfValueInSquare; i++)
            {
                numbers.Push(new Point(maxValueOfSquare));
                maxValueOfSquare -= 1;
            }

            var x = index;
            var y = (-index + 1);

            //firstPoint
            var firstpoint = numbers.Pop();
            firstpoint.X = x;
            firstpoint.Y = y;
            points.Add(firstpoint);

            for(int i = 0; i<(numberOfValueInSquare/4)-1; i++)
            {
                y++;
                var point = numbers.Pop();
                point.X = x;
                point.Y = y;

                points.Add(point);
                
            }

            for (int i = 0; i < numberOfValueInSquare / 4; i++)
            {
                x--;
                var point = numbers.Pop();
                point.X = x;
                point.Y = y;

                points.Add(point);
            }

            for (int i = 0; i < numberOfValueInSquare / 4; i++)
            {
                y--;
                var point = numbers.Pop();
                point.X = x;
                point.Y = y;

                points.Add(point);
            }

            for (int i = 0; i < numberOfValueInSquare / 4; i++)
            {
                x++;
                var point = numbers.Pop();
                point.X = x;
                point.Y = y;

                points.Add(point);
            }

            return new SquareOfSpiral(index, points);
        }
    }

}
