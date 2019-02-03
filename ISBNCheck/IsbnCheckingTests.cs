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

            Assert.AreEqual(first12, IsbnChecking.first12IsbnSum(isbn));
        }

    }
}
