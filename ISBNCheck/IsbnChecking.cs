using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBNCheck
{
    class IsbnChecking
    {
        public static int first12IsbnSum(List<int> isbn)
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
    }
}
