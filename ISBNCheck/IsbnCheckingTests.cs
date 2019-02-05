using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBNCheck
{
    [TestFixture]
    public class IsbnCheckingTests
    {
        [Test]
        public void first_12_isbn_equals_sum()
        {
            int first12 = 93;

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
            isbn.Add(7);

            Assert.AreEqual(first12, IsbnChecking.First12IsbnSum(isbn));
        }

        [Test]
        public void isbn_check_digit_equals_mod10()
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
            isbn.Add(7);

            Assert.AreEqual(isbn[12], IsbnChecking.CheckDigit(isbn));
        }

        [Test]
        public void isbn_is_valid()
        {
            string isbn = "978-0-306-40615-7";

            Assert.AreEqual(true, IsbnChecking.CheckDigitIsCorrect(isbn));
        }

        [Test]
        public void isbn_is_not_valid()
        {
            string isbn = "978-0-306-40615-3";

            Assert.AreNotEqual(true, IsbnChecking.CheckDigitIsCorrect(isbn));
        }
    }
}
