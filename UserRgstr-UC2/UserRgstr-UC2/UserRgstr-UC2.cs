using System.Text.RegularExpressions;

namespace UserRgstr_UC2
{
    internal class Program
    {
        public static string LastName = @"^[A-Z][A-Za-z]{3,10}$";
        static void Main(string[] args)
        {
            Regex r = new Regex(Program.LastName);
            Console.WriteLine("Enter User Last Name: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}
