using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBNCheck
{
    [TestFixture]
    public class StringHandlingTest
    {
        [Test]
        public void is_valid_string_input()
        {
            bool validInput = StringHandling.IsValidInput("aa");

            Assert.AreEqual(true, validInput);
        }

        [Test]
        public void removed_extra_characters()
        {
            string input = "a b c";

            string inputRemoved = StringHandling.RemoveWhiteSpaceAndDashes(input);

            Assert.AreEqual("abc", inputRemoved);
        }

        [Test]
        public void string_is_converted_to_list()
        {
            List<int> listOfNum = new List<int>();
            listOfNum.Add(1);
            listOfNum.Add(2);
            listOfNum.Add(3);

            List<int> functionList = StringHandling.isbnStringToList("123");

            Assert.AreEqual(listOfNum, functionList);
        }
    }
}
