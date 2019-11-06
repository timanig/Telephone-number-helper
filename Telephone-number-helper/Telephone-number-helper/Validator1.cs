using System;
using System.IO;

namespace Telephone_number_helper
{
    public static class Vaildator1
    {
        public static bool TelephoneValidator(string x)
        {
            try { 

          

            if (x.Contains("(")) //check if number contains a (
                x = x.Replace("(", "");

            if (x.Contains(")")) //check if number contains a )
                x = x.Replace(")", "");

            if (x.Contains("-")) //check if number contains a -
                x = x.Replace("-", "");

            if (x.Contains(" ")) //check if number contains a blank space
                x = x.Replace(" ", "");

            if (x.Length > 10 || x.Length <= 8) //check if number is correct length
            {

                Console.WriteLine("Your phone number is not the correct length!");
                return false;
            }

            foreach (char c in x) //check if number has a char that is not a digit
            {
                if (Char.IsDigit(c))
                    Console.WriteLine($"{false} Your phone number is contains a nondigit!");
                return false;
            }

                Int64 y = Int64.Parse(x); //convert number to digit

            Console.WriteLine($"Your phone number is {y}");

            return true;
        }
            catch (IOException e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        } 
    }
}
