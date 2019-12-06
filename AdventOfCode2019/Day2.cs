using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    public class Day2
    {
        private List<int> _data = new List<int>();

        private void ResetMemory()
        {
            _data = new List<int> { 1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 13, 1, 19, 1, 19, 6, 23, 1, 23, 6, 27, 1, 13, 27, 31, 2, 13, 31, 35, 1, 5, 35, 39, 2, 39, 13, 43, 1, 10, 43, 47, 2, 13, 47, 51, 1, 6, 51, 55, 2, 55, 13, 59, 1, 59, 10, 63, 1, 63, 10, 67, 2, 10, 67, 71, 1, 6, 71, 75, 1, 10, 75, 79, 1, 79, 9, 83, 2, 83, 6, 87, 2, 87, 9, 91, 1, 5, 91, 95, 1, 6, 95, 99, 1, 99, 9, 103, 2, 10, 103, 107, 1, 107, 6, 111, 2, 9, 111, 115, 1, 5, 115, 119, 1, 10, 119, 123, 1, 2, 123, 127, 1, 127, 6, 0, 99, 2, 14, 0, 0 };
        }

        public void Part1()
        {
            ResetMemory();
            Console.WriteLine("Day 2: Part 1: " + CalculatePosition(12, 2));
        }

        public void Part2()
        {
            var noun = 0;
            var verb = 0;
            for (int i = 0; i <= 99; i++)
            {
                var breakIt = false;
                for (int j = 0; j <= 99; j++)
                {
                    ResetMemory();
                    var result = CalculatePosition(i, j);
                    if (result == 19690720)
                    {
                        noun = i;
                        verb = j;
                        breakIt = true;
                        break;
                    }
                }

                if (breakIt)
                    break;
            }

            Console.WriteLine($"Day 2: Part 2: {100 * noun + verb}"  );
        }

        private int CalculatePosition(int position1, int position2)
        {
            _data[1] = position1;
            _data[2] = position2;

            for (int i = 0; i < _data.Count; i += 4)
            {
                try
                {
                    var action = _data[i];
                    if (action == 99)
                        break;

                    var operandAPosition = _data[i + 1];
                    var operandBPosition = _data[i + 2];
                    var outputPosition = _data[i + 3];

                    int result;
                    if (action == 1)
                        result = _data[operandAPosition] + _data[operandBPosition];
                    else if (action == 2)
                        result = _data[operandAPosition] * _data[operandBPosition];
                    else
                        break;

                    _data[outputPosition] = result;
                }
                catch (Exception)
                {
                    break;
                }
            }

            return _data[0];
        }
    }
}
