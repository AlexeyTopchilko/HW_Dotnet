using System;
using System.Text;

namespace HW._08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string = GetString();
            Console.WriteLine(@string);
            string newString = ChangeString(@string);
            Console.WriteLine(newString);
        }
        static string GetString()
        {
            Console.WriteLine("Please input a string: ");
            string @string = Console.ReadLine();
            bool chek = @string.Contains('?');
            while (!chek)
            {
                Console.WriteLine("Please input another string");
                @string = Console.ReadLine();
                chek = @string.Contains('?');
            }
            return @string;
        }

        static string ChangeString(string @string)
        {
            StringBuilder sb = new StringBuilder(@string);
            int i;
            for (i = 0; i < sb.Length; i++)
            {
                if (sb[i].Equals('?'))
                    break;
                else if (sb[i].Equals('!') || sb[i].Equals('.'))
                {
                    sb.Remove(i, 1);
                    --i;
                }    
            }
            sb.Replace(' ', '_', i, sb.Length - i);
            string newString = sb.ToString();
            return newString;
        }
    }
}