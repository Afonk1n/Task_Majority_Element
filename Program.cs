using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 3, 4};
            int res = 0, counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (counter == 0)
                {
                    res = nums[i];
                }
                counter = res == nums[i] ? counter + 1 : counter - 1;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
