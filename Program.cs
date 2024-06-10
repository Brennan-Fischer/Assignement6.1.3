namespace Assignement6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 0, 3, 0, 4, 0, 5 };
            int count = 0;

            for (int i = 0; i < nums.Length; i++) 
            { 

                    if (nums[i]==0)
                    {
                        count++;
                    }
                    else { nums[i - count] = nums[i]; }
                    
                
            
            }
            for (int i = nums.Length-count; i<nums.Length; i++)
            {
                nums[i] = 0;
            }

            foreach(int i in nums) { Console.Write($" {i}"); }
        }

        
    }
}
