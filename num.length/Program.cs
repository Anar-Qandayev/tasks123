using System;

namespace num.length
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin!.");

            int num = Convert.ToInt32(Console.ReadLine());
            int count = NumLength(num);
            Console.WriteLine(count);
        }
         static int NumLength(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            return count;

        }
    }
}
