﻿namespace LCThreeSum
{
    public class Program
    {
        /// <summary>
        /// Given an array nums of n integers, returns elements a, b, c in nums such that a + b + c = 0. A two-pointer approach is used to solve the problem.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length < 3)
            {
                return result;
            }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        left++;
                        right--;
                        while (left < right && nums[left] == nums[left - 1])
                        {
                            left++;
                        }
                        while (left < right && nums[right] == nums[right + 1])
                        {
                            right--;
                        }
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
