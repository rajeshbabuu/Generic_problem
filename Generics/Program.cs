using static Generics.Maxnum;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Based Problems");

            float output = Maxnum.MaxIntegerNumber(111, 1, 12);
            Console.WriteLine("\nMax   float number is: " + output);
        }
    }
}