using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingString;
using System.Collections.Generic;
using FluentAssertions;


namespace SortingStringTests
{
    [TestClass]
    public class SorterTests
    {
        [TestMethod]
        public void All_Letters_Lowercase()
        {
            string uppercaseString = "LLnda";
            SortedDictionary<char, int> sortedDictionary = new SortedDictionary<char, int>();
            sortedDictionary.Add('a', 1);
            sortedDictionary.Add('d', 1);
            sortedDictionary.Add('l', 2);
            sortedDictionary.Add('n', 1);
            Sorter sorter = new Sorter();
            var actual = sorter.Sort(uppercaseString);
            actual.Should().BeEquivalentTo(sortedDictionary);
        }


        [TestMethod]
        public void Should_Ignore_Punctuation()
        {
            string digitString = "ll'-*;./?:!da";
            SortedDictionary<char, int> sortedDictionary = new SortedDictionary<char, int>();
            sortedDictionary.Add('a', 1);
            sortedDictionary.Add('d', 1);
            sortedDictionary.Add('l', 2);
            Sorter sorter = new Sorter();
            var actual = sorter.Sort(digitString);
            actual.Should().BeEquivalentTo(sortedDictionary);
        }

        [TestMethod]
        public void Test_Empty_String()
        {
            string digitString = "";
            SortedDictionary<char, int> sortedDictionary = new SortedDictionary<char, int>();
            Sorter sorter = new Sorter();
            var actual = sorter.Sort(digitString);
            actual.Should().BeEquivalentTo(sortedDictionary);
        }

        [TestMethod]
        public void Should_Ignore_Blank_Spaces()
        {
            string stringWithSpaces = "j      l";
            SortedDictionary<char, int> sortedDictionary = new SortedDictionary<char, int>();
            sortedDictionary.Add('j', 1);
            sortedDictionary.Add('l', 1);
            Sorter sorter = new Sorter();
            var actual = sorter.Sort(stringWithSpaces);
            actual.Should().BeEquivalentTo(sortedDictionary);
        }

    }
}
