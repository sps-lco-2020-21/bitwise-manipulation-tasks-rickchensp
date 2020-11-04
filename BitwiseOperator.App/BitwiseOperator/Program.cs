using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 0b10101, 0b11111, 0b11100};
            List<int> result = new List<int> { };
            List<int> expected = new List<int> { 1, 5, 1, 5, 10, 2, 5, 1, 2, 11, 1, 7, 1, 7, 15, 3, 15, 3, 7, 31, 0, 4, 1, 7, 
                14, 3, 12, 0, 6, 25 };

            foreach (int i in numbers)
            {
                result.Add(Rightmost(i));
                result.Add(Rightmost3(i));

                result.Add(Leftmost(i));
                result.Add(Leftmost3(i));

                result.Add(RemoveRightMost(i));
                result.Add(RemoveRightMost3(i));

                result.Add(RemoveLeftMost(i));
                result.Add(RemoveLeftMost3(i));

                result.Add(RemoveFirstLast(i));
                result.Add(LeftMosttoRight(i));
            }

            for (int i = 0; i < expected.Count(); ++i)
            {
                Debug.Assert(expected[i] == result[i]);
            }

            Console.ReadKey();
        }



        private static int Rightmost(int input)
        {
            return input & 0b00001;
        }

        private static int Rightmost3(int input)
        {
            return input & 0b00111;
        }

        private static int Leftmost(int input)
        {
            return input >> 4;
        }

        private static int Leftmost3(int input)
        {
            return input >> 2;
        }

        private static int RemoveRightMost(int input)
        {
            return input >> 1;
        }

        private static int RemoveRightMost3(int input)
        {
            return input >> 3;
        }

        private static int RemoveLeftMost(int input)
        {
            return input & 0b01111;  //test later
        }

        private static int RemoveLeftMost3(int input)
        {
            return input & 0b00011;
        }

        private static int RemoveFirstLast(int input)
        {
            return (input & 0b01110) >> 1;  //test later
        }

        private static int LeftMosttoRight(int input)
        {
            int leftmost = input >> 4;
            return ((input & 0b01111) << 1) + leftmost;//come back later
        }
    }
}
