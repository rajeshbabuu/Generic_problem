using static Generics.Maxnum;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Based Problems");


            string output = Maxnum.MaxIntegerNumber("Peach", "Apple", "Banana");
            Console.WriteLine("\nMax string word is: " + output);
        }
    }
}