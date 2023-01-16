namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Based Problems");

            string output = Maxnum.MaxIntegerNumber("Apple", "Peach", "Banana");
            Console.WriteLine("\nMax string word is: " + output);
        }
    }
}