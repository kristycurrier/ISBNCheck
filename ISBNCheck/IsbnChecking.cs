using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBNCheck
{
    class IsbnChecking
    {
        public static int First12IsbnSum(List<int> isbn)
        {
            int num = 0;

            for (int i = 1; i <= 12; i++)
            {
                int j = i;
                if(i%2 == 0)
                {
                    int listNum = isbn[j - 1];
                    int isbnNum = isbn[j -1] * 3;
                    num += isbnNum;
                }
                else if(i%2 == 1)
                {
                    int listNum = isbn[j - 1];
                    int isbnNum = isbn[j -1] * 1;
                    num += isbnNum;
                }
            }
            return num;
        }

        public static int CheckDigit(List<int> isbn)
        {
            int isbn12Sum= First12IsbnSum(isbn);

            int checkDigit = 10- (isbn12Sum % 10);

            if (checkDigit == 10)
            {
                checkDigit = 0;
            }
            return checkDigit;
        }

        public static bool CheckDigitIsCorrect(string isbn)
        {
            if (IsbnFormat.CorrectFormat(isbn) == false || StringHandling.IsValidInput(isbn) == false)   
            {
                return false;
            }
                
            isbn = StringHandling.RemoveWhiteSpaceAndDashes(isbn);

            if (IsbnFormat.ContainsNumbers(isbn) == false)
            {
                return false;
            }

            List<int> isbnList = StringHandling.IsbnStringToList(isbn);
            int checkDigit = CheckDigit(isbnList);

            if (checkDigit == isbnList[12])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
