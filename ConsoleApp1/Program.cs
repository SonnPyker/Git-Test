using System;

namespace HelloWorld
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            var numMap = new Dictionary<int, int>();
            var result = new int[2];

            for (var i = 0; i < nums.Length; i++)
            {
                var rightNum = target - nums[i];
                if (!numMap.ContainsKey(rightNum))
                {
                    numMap[nums[i]] = i;
                    rightNum = 0;
                }
                else
                {
                    result[0] = numMap[rightNum];
                    result[1] = i;
                    return result;
                }
            }

            return result;

        }
    }
    public class Program
    {
        static int[] nums = { 2, 7, 11, 15 };
        static int target = 9;
        static void Main(string[] args)
        {
            Solution solution = new();
            
            Console.WriteLine(solution.TwoSum(nums, target));
        }
    }
}