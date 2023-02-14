using System.Text.RegularExpressions;

namespace UserRgstr_UC1
{
    internal class Program
    {
        public static string FirstName = @"^[A-Z][A-Za-z]{3,10}$";
        static void Main(string[] args) 
        {
            Regex r = new Regex(Program.FirstName);
            Console.WriteLine("Enter User First Name: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}