namespace Lecture4_Prog120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double numerator = 5;
            double denominator = 0;
            if(denominator !=0)
            { Console.WriteLine(numerator / denominator); }
            else { Console.WriteLine("your denominator cannot be 0"); }
            //int number1
            while (!int.TryParse(Console.ReadLine(), out int number1)
                &&
                !int.TryParse(Console.ReadLine(), out int number2)) ;
        } //Main
    } // class
} //namespace
