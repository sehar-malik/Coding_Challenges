using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintResult(
                Permute(new int[] { 1, 2, 3 })
            );
            ContiguousSubArray contiguousSubArray = new ContiguousSubArray();
            contiguousSubArray.MainFunction();
            LCS lcs = new LCS();
            lcs.LCSMethod();

            //Missing Element
            MissingElement missingElement = new MissingElement();
            missingElement.MissingElementMethod();

            //Cirlce Difference 08/11/2021
            CircleDiff circleDiff = new CircleDiff();
            circleDiff.CircleDifference();
        }

        static IList<IList<int>> Permute(int[] nums)
        {
            var list = new List<IList<int>>();
            return DoPermute(nums, 0, nums.Length - 1, list);
        }

        static IList<IList<int>> DoPermute(int[] nums, int start, int end, IList<IList<int>> list)
        {
            if (start == end)
            {
                list.Add(new List<int>(nums));
            }
            else
            {
                for (var i = start; i <= end; i++)
                {
                    Swap(ref nums[start], ref nums[i]);
                    DoPermute(nums, start + 1, end, list);
                    Swap(ref nums[start], ref nums[i]);
                }
            }

            return list;
        }

        static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        static void PrintResult(IList<IList<int>> lists)
        {
            Console.WriteLine("[");
            foreach (var list in lists)
            {
                Console.WriteLine($"    [{string.Join(',', list)}]");
            }
            Console.WriteLine("]");
        }
    }
}
