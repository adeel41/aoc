﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            new Day2().Part2();
        }

        static void Day1()
        {
            var data = new List<int>
            {
                119031,
                111204,
                75773,
                95544,
                69987,
                147194,
                74024,
                100438,
                86116,
                89945,
                144856,
                123315,
                64102,
                55491,
                95959,
                149174,
                66810,
                134674,
                88921,
                124270,
                60833,
                125667,
                84885,
                57688,
                89059,
                126854,
                93633,
                103791,
                104295,
                137762,
                101216,
                138060,
                103271,
                95822,
                102000,
                66821,
                126916,
                104629,
                87710,
                79852,
                87852,
                149281,
                92055,
                50969,
                62626,
                112069,
                68560,
                66131,
                139961,
                89456,
                100536,
                51338,
                51075,
                112858,
                134878,
                137702,
                60091,
                111576,
                70517,
                131524,
                56162,
                148346,
                62696,
                110191,
                141106,
                54858,
                66248,
                86402,
                132012,
                96367,
                95319,
                133879,
                115031,
                77875,
                129470,
                146650,
                70048,
                147454,
                123076,
                74563,
                94228,
                59920,
                147986,
                92398,
                51890,
                92686,
                110452,
                85205,
                67482,
                87931,
                69535,
                73948,
                114576,
                65958,
                53081,
                132809,
                76088,
                74553,
                121820,
                121214,
            };

            int getFuel(int val)
            {
                try
                {
                    var result = (val / 3) - 2;
                    if (result <= 0)
                        return 0;
                    result += getFuel(result);
                    return result;
                }
                catch (Exception)
                {
                    return 0;
                }
            }

            var sum = 0;
            foreach (var i in data)
            {
                var fuel = getFuel(i);
                sum += fuel;
            }
            Console.WriteLine("Result: " + sum);
        }

    }
}
