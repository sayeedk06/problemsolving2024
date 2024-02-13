namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] num = {2,7,11,15}
            int target = 9

            loop through each element in num
                loop through element in num and compare the first loop elements with the second
                    if matches the target then save the index of both the loop

            */

            int[] num = { 2, 7, 11, 15 };
            int[] savedindex = new int[2];
            int target = 17;

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i+1; j  < num.Length; j++)
                {
                    if (num[i] + num[j] == target)
                    {
                        savedindex[0] = i;
                        savedindex[1] = j;
                        break;
                    }
                }
            }

            for (int i = 0;i < savedindex.Length; i++)
            {
                Console.WriteLine(savedindex[i]);
                
            }
        }
    }
}