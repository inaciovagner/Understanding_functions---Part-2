using System;
namespace CsharpPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Add(x, y);
        }
        static void Add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine(sum);
        }
    }
}
