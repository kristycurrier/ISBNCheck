﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBNCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> isbn = new List<int>();
            isbn.Add(9);
            isbn.Add(7);
            isbn.Add(8);
            isbn.Add(0);
            isbn.Add(3);
            isbn.Add(0);
            isbn.Add(6);
            isbn.Add(4);
            isbn.Add(0);
            isbn.Add(6);
            isbn.Add(1);
            isbn.Add(5);

            int answer = IsbnChecking.first12IsbnSum(isbn);

            Console.ReadKey();

        }
    }
}
