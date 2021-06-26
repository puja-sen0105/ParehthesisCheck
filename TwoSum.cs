using System.Collections.Generic;

namespace ParehthesisCheck
{
    //Input: nums = [2,7,11,15], target = 9
    //Output: [0,1]
    //Output: Because nums[0] + nums[1] == 9, we return [0, 1].
    class TwoSum
    {
        public int[] TwoSumMethod(int[] nums, int target)
        {
            int secondNumber = 0;

            int firstIndex = 0;
            int secondIndex = 0;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int x = 0; x <= nums.Length; x++)
            {
                if (dict.ContainsKey(nums[x]))
                {
                    firstIndex = dict[nums[x]];
                    secondIndex = x;
                }
                else
                {
                    secondNumber = target - nums[0];
                    dict.Add(secondNumber, x);
                }
            }

            return new int[] { firstIndex, secondIndex };

        }
    }
}
