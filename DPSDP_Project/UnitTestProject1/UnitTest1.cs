using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using DPSDP_Project;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() //test if we can create two boards or not
        {
            Board board1 = Board.Instance();
            Board board2 = Board.Instance();
        }
    }
}
