using System.Text.RegularExpressions;

namespace UserRgstr_UC7
{
    internal class Program
    {
        public static string PwdRule3 = @"^[A-Z]{1,7}[a-z]{6,20}[0-9]{1,7}$";
        static void Main(string[] args)
        {
            Regex r = new Regex(Program.PwdRule3);
            Console.WriteLine("Enter User Password: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}
