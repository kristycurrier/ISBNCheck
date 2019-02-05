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
            bool NotValidInput = String.IsNullOrEmpty(input);
            if (NotValidInput == true)
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

        public static List<int> isbnStringToList(string isbn)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < isbn.Length; i++)
            {
                int num = int.Parse(isbn[i].ToString());
                list.Add(num);
            }
            return list;
        }

    }
}
