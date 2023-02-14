using System.Text.RegularExpressions;

namespace UserRgstr_UC4
{
    internal class Program
    {
        public static string PhoneNumber = @"^[9]?[1]?[ ][0-9]{1,10}$";
        static void Main(string[] args)
        {
            Regex r = new Regex(Program.PhoneNumber);
            Console.WriteLine("Enter User Contact Number: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}