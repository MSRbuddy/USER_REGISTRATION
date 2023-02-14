using System.Text.RegularExpressions;

namespace UserRgstr_UC5
{
    internal class Program
    {
        public static string PwdRule1 = @"^[A-Za-z]{8,20}$";
        static void Main(string[] args)
        {
            Regex r = new Regex(Program.PwdRule1);
            Console.WriteLine("Enter User Password: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}