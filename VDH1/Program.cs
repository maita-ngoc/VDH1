using System;
using VDH1.Teachers.Niels;

namespace VDH1
{
    class Program
    {
        // Code momments.
        static void Main(string[] args)
        {
            Niels  n = new Niels("Niels", "Olesen");
            Console.WriteLine(n.FirstName + " " + n.LastName);
        }
    }
}
