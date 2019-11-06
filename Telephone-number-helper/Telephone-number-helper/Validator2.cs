using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Telephone_number_helper
{
    public class Validator2
    {
        public Validator2()
        {
            Console.WriteLine("Enter your phone number:");
            string aa = Console.ReadLine();
            TelephoneValidator(aa);
        }

        void TelephoneValidator(string x)
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

            if (x.Length > 10 || x.Length <= 9) //check if number is correct length
            {
                Console.WriteLine($"{false} Your phone number is not the correct length!");
                    Environment.Exit(0);

            }
            foreach (char c in x) //check if number has a char that is not a digit
            {
                if (Char.IsDigit(c))
                    Console.WriteLine($"{false} Your phone number is contains a nondigit!");
            }

                Int64 y = Int64.Parse(x); //convert number to digit

            Console.WriteLine($"Your phone number is {y}");

        }
            catch (FormatException e) 
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        }
    }
}
