using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongApp;

namespace PingPongApp.Tests
{
  [TestClass]
  public class PingPongTest
  {

    [TestMethod]
    public void PingPongCheck_ResultStringof3_12Ping()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("1, 2, Ping", testPingPong.PingPongCheck(3));
    }

    [TestMethod]
    public void PingPongCheck_ResultStringof5_12Ping4Pong()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("1, 2, Ping, 4, Pong", testPingPong.PingPongCheck(5));
    }

    [TestMethod]
    public void PingPongCheck_ResultStringof15_12Ping4PongPing78PingPong11Ping1314PingPong()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("1, 2, Ping, 4, Pong, Ping, 7, 8, Ping, Pong, 11, Ping, 13, 14, Ping-Pong", testPingPong.PingPongCheck(15));
    }

  }
}