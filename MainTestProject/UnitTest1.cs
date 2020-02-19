using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainOrderTrack;
using Xunit;

namespace MainTestProject
{
    [TestClass]
    public class UnitTest1
    {
        MainOrderTrack.Square hello = new MainOrderTrack.Square();
        [TestMethod]
        [Fact]
        public void TestMethod1()
        {

            hello.Area(3.2, 'x');
            hello.Area(3.4, 2.0);
            
            
        }
    }
}
