using System.Text.RegularExpressions;

namespace UserRgstr_UC3
{
    internal class Program
    {
        public static string MailId = @"^[a-z|a-z.a-z]@[a-z|a-z.a-z]|[.a-z]$";
        static void Main(string[] args)
        {
            Regex r = new Regex(Program.MailId);
            Console.WriteLine("Enter User Email Id: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}