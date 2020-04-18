using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayInterviewQuestions
{
    public class Question1SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            int n = nums.Length;
            var unique = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count = count + 1;
                    }
                }
                for (int k = i + 1; k < n; k++)
                {
                    if (nums[i] == nums[k])
                    {
                        count = count + 1;
                    }
                }
                if (count == 0)
                {
                    unique = nums[i];
                    break;
                }
            }
            return unique;
        }
    }
}
