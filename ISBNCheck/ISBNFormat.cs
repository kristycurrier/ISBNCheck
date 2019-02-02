using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ISBNCheck
{
    public class IsbnFormat
    {
        public static bool CorrectFormat(string Isbn)
        {
            Regex regex = new Regex(@"[0-9]*[-| ][0-9]*[-| ][0-9]*[-| ][0-9]*[-| ][0-9]*");
            Match match = regex.Match(Isbn);
            bool validIsbn = match.Success;

            return validIsbn;
        }

        public static bool ContainsNumbers(string isbn)
        {
            bool containsOnlyNubers = true;
            foreach (var x in isbn)
            {
                bool realInt = int.TryParse(x.ToString(), out int num);
                if(realInt == false)
                {
                    containsOnlyNubers = false;
                }
            }
            return containsOnlyNubers;
        }
    }
}
