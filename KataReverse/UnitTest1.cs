using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace KataReverse
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void SplitTest()
        {
            var testString = "this is a test";
            var result = Kata.Split(testString, ' ');
            Assert.IsNotNull(result);
            Assert.AreEqual("test", result[3]);
            Assert.AreEqual("a", result[2]);
            Assert.AreEqual("is", result[1]);
            Assert.AreEqual("this", result[0]);
        }

        [TestMethod]
        public void ReverseTest()
        {
            var testREverse = new List<string>()
            {
                "this", "is" , "a", "test"
            };



            var result = Kata.Reverse(testREverse);


            Assert.AreEqual(testREverse[0], result[3]);
            Assert.AreEqual(testREverse[1], result[2]);
            Assert.AreEqual(testREverse[2], result[1]);
            Assert.AreEqual(testREverse[3], result[0]);
        }





        [TestMethod]
        public void BasicTests()
        {
            Assert.AreEqual("world! hello", Kata.ReverseWords("hello world!"));
            Assert.AreEqual("this like speak doesn't yoda", Kata.ReverseWords("yoda doesn't speak like this"));
            Assert.AreEqual("foobar", Kata.ReverseWords("foobar"));
            Assert.AreEqual("kata editor", Kata.ReverseWords("editor kata"));
            Assert.AreEqual("boat your row row row", Kata.ReverseWords("row row row your boat"));
        }

    }
}