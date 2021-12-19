using System;

namespace Git_initial
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime today= new DateTime(2021,12,19);
            Console.WriteLine("Hello Github! \n\rFrom now on, we are going to meet everyday, and grow up together.");
            Console.WriteLine("😎❤️😍");
            Console.WriteLine("Heyyy, it's the " + (DateTime.Today - today).TotalDays + ". day already 😎😎");
        }
    }
}
