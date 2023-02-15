using System.Text.RegularExpressions;

namespace UserRgstr_UC9
{
    internal class UserRgstr
    {
        public static string SampleEmail = @"^\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z$";
        static void Main(string[] args)
        {
            Regex r = new Regex(UserRgstr.SampleEmail);
            Console.WriteLine("Enter User Sample Email: ");
            Console.WriteLine(r.IsMatch(Console.ReadLine()));
        }
    }
}