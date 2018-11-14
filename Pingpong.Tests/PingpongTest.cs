using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongMain;


namespace PingPongMain.Tests
{
    [TestClass]
    public class PingPongClassTest
    {
        [TestMethod]
        public void PingPong_NumberDivisibleByThreeAndFive_pingpong()
        {
            PingPongClass testPingPong = new PingPongClass();
            Assert.AreEqual("ping-pong", testPingPong.CheckNumber(15));
            
        }
        [TestMethod]
        public void PingPong_NumberDivisibleByThree_ping()
        {
            PingPongClass testPingPong = new PingPongClass();
            Assert.AreEqual("ping", testPingPong.CheckNumber(6));
            
        }
        [TestMethod]
        public void PingPong_NumberDivisibleByFive_ping()
        {
            PingPongClass testPingPong = new PingPongClass();
            Assert.AreEqual("pong", testPingPong.CheckNumber(10));
            
        }
    }
}