using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBNCheck
{
    [TestFixture]
    public class IsbnFormatTests
    {
        [Test]
        public void is_valid_isbn_format_dashes()
        {
            string isbn = "978-1-86197-876-9";
            Assert.AreEqual(true, IsbnFormat.CorrectFormat(isbn));
        }

        [Test]
        public void is_valid_isbn_format_spaces()
        {
            string isbn = "978 1 86197 876 9";
            Assert.AreEqual(true , IsbnFormat.CorrectFormat(isbn));
        }

        [Test]
        public void is_not_valid_isbn_format()
        {
            string isbn = "929-k-87938-987-9";
            Assert.AreNotEqual(true, IsbnFormat.CorrectFormat(isbn));
        }

        [Test]
        public void string_only_contains_numbers()
        {
            string isbn = "123";

            Assert.AreEqual(true, IsbnFormat.ContainsNumbers(isbn));
        }
    }
}
