using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] numbers = { 1, 2, 3, 5, 10, 15, 20, 6, 40, 7 };
            int target = 17;
            program.TwoSum(numbers, target);
        }


        public int[] TwoSum(int[] numbers, int target)
        {

            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = target - numbers[i];


                if (result.ContainsKey(remainder))
                {
                    return new int[] { result[remainder], i };


                }
                result.Add(numbers[i], i);

            }

            return numbers;



        }
    }
}
