using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var d = DateTime.Now;
            var c = 1;
            do
            {
                if (IsPalindromeDate(d))
                {
                    Console.WriteLine(c++);
                    Console.WriteLine(d.ToShortDateString().Replace("/", ""));
                }

                d = d.AddDays(1);
            } while (d < new DateTime(2074, 1, 1));
        }

        private static bool IsPalindromeDate(DateTime dateTime)
        {
            var s = dateTime.ToString("ddMMyyyy");
            return s[0] == s[7] &&
                   s[1] == s[6] &&
                   s[2] == s[5] &&
                   s[3] == s[4];
        }
    }
}