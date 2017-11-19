using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodingSampleTest
{
    [TestClass]
    public class CheckSetenceTest
    {
        [TestMethod]
        public void CheckSetenceTest_Clumsy()
        {
            var checking = new CodingExample.Checking();
            List<string> expected = new List<string>() { "tony - 2", "stark - 2", "96 - 1", "northwestern - 1", "will - 1", "become - 2", "a - 3", "ceo - 2", "at - 1", "inc - 1", "and - 2", "father - 1", "home - 1" };
            List<string> actual = checking.CheckSentence("Tony Stark ('96 Northwestern) will become a CEO at Tony Stark Inc., and become a father and a home CEO");
            try
            {
                CollectionAssert.AreEqual(expected, actual);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        [TestMethod]
        public void CheckSetenceTest_Default()
        {
            var checking = new CodingExample.Checking();
            List<string> expected = new List<string>() { "this - 2", "is - 2", "a - 1","statement - 1","and - 1","so - 1"};
            List<string> actual = checking.CheckSentence("This is a statement, and so is this.");
            try
            {
                CollectionAssert.AreEqual(expected, actual);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        [TestMethod]
        public void CheckSetenceTest_SpecialCharacters()
        {
            var checking = new CodingExample.Checking();
            List<string> expected = new List<string>(){"hello - 5"};
            List<string> actual = checking.CheckSentence("Hello@Hello&Hello(Hello)Hello...");
            try
            {
                CollectionAssert.AreEqual(expected, actual);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
