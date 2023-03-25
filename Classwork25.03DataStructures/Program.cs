namespace Classwork25._03DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[101];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
                        
            int target = 24;            

            int left = 0; 
            int right = numbers.Length - 1; 
            int count = 1;
            while (left <= right)
            {
                int mid = (left + right) / 2; 

                if (numbers[mid] == target)
                {
                    Console.WriteLine("The number {0} is at index {1}", target, mid);
                    Console.WriteLine(count);
                    break;
                }
                else if (numbers[mid] < target)
                {
                    left = mid + 1; 
                }
                else
                {
                    right = mid - 1;
                }
                count++;
            }       

        }
    }
}