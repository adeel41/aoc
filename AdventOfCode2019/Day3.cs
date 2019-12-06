using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AdventOfCode2019
{
    public class Day3
    {
        public void Part1()
        {
            const string line1 = "R8,U5,L5,D3";
            const string line2 = "U7,R6,D4,L4";
            var centralPort = new Point(1, 1);

            // each instruction produces a number of points.
            var line1Instructions = new List<Point>();
            foreach (var instruction in line1.Split(",", StringSplitOptions.RemoveEmptyEntries))
            {
                var direction = instruction.Substring(0, 1);
                var number = Convert.ToInt32(instruction.Substring(1));
                // we should create number of points from the starting position.
                var resultingPoint = new Point(1,1); //this is the starting position. means should join with the
                switch (direction)
                {
                    case "R":

                }
            }
        }

    }
}
