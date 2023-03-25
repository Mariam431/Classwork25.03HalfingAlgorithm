namespace Classwork25._03_part1_
{
    internal class Program
    {
            enum name
            {
            hey,
            bye, 
            no,
            yes
            }
        static void Main(string[] args)
        {
            Console.WriteLine(((name)2).GetType());
            var s = ((name)2);
            Console.WriteLine(s.ToString().Length.GetTypeCode());
            s = s.ToString().Length;
            Console.WriteLine(s);
            Random random = new Random();
            int num = random.Next(100);
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = num++;
                Console.WriteLine(arr[i]);
            }           

        }
    }
}