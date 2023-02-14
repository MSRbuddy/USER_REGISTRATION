using System.Text.RegularExpressions;

namespace UserRgstr_UC6
{
    internal class Program
    {
        public static string PwdRule2 = @"^[A-Z]{1,7}[a-z]{7,20}$";
        static void Main(string[] args)
        {
            Regex r = new Regex(Program.PwdRule2);
            Console.WriteLine("Enter User Password: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}