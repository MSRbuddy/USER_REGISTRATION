using System.Text.RegularExpressions;

namespace UserRgstr_UC_8
{
    internal class Program
    {
        public static string PwdRule4 = @"^[A-Z]{1,7}[a-z]{6,20}[0-9]{1,7}[-\#\$\.\%\&\8]?$";
        static void Main(string[] args)
        {
            Regex r = new Regex(Program.PwdRule4);
            Console.WriteLine("Enter User Password: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}