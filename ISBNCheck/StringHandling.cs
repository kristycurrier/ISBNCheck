using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBNCheck
{
    public class StringHandling
    {
        public static bool IsValidInput(string input)
        {
            bool validInput = String.IsNullOrEmpty(input);
            if (validInput == true)
            {
                return false;
            }
            return true;
        }

        public static string RemoveWhiteSpaceAndDashes(string input)
        {
            input = input.Replace("-", "");
            input = input.Replace(" ", "");

            return input;
        }

    }
}
