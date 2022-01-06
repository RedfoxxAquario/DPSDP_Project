using Microsoft.VisualStudio.TestTools.UnitTesting;
using DPSDP_Project;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() //test the singleton pattern
        {
            Board board1 = Board.Instance();
            Assert.ThrowsException<Exception>(() => Board.Instance());
            //we try to create a second board, but we shoud get an exception as we can only have one board and set up a singleton pattern

        }

        [TestMethod]
        public void TestMethod2() //case go in jail after 3 doubles
        {
            Player player1 = new Player("Player_test");
            player1.State.DoubleDiceCount = 2;
            Assert.IsFalse(player1.State.StateChangeCheck());
            //We test if the player stays free if only has done 2 doubles, meaning StateChangeCheck should return false

            player1.State.DoubleDiceCount = 3;
            Assert.IsTrue(player1.State.StateChangeCheck());
        }

        [TestMethod]
        public void TestMethod3() //case go to jail
        {
            Player player1 = new Player("Player_test");
            player1.current=new GoToJailPosition(1);
            Assert.IsFalse(player1.Current.onStop(player1));
            //We test if the player can stay at this position when he arrives on this position. It shoud return false meaning the game lauches the onMOve function immediatly which sends him to jail. 

        }

        [TestMethod]
        public void TestMethod4() //case go out of jail after a double
        {
            Player player1 = new Player("Player_test");
            player1.State=new Jail();
            player1.State.DoubleDiceCount = 1;
            Assert.IsTrue(player1.State.StateChangeCheck());
            //We test if the player that is in jail and did a double will be free, meaning StateChangeCheck should return true
        }
    }
}
