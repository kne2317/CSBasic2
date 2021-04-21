using System;

namespace CSBasic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력 : ");

            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            if (input % 2 == 1)
            {
                Console.WriteLine("홀수");
            }

            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
        }
    }
}
