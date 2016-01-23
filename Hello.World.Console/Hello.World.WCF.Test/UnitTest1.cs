using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello.World.WCF.Test.MyHelloTest;

namespace Hello.World.WCF.Test
{
    [TestClass]
    public class SayHello
    {
        [TestMethod]
        public void HelloDearUser()
        {
            //initialize
            string username = "Dear User";
            string expectedResult = "Hello Dear User";
            string realResult;
            HelloWorldClient myservice = new HelloWorldClient();

            //test body
            realResult = myservice.SayHello(username);

            //assert
            Assert.AreEqual(expectedResult, realResult);

                }

        [TestMethod]
        public void HelloEmptyUser()
        {
            //initialize
            string username = "";
            string expectedResult = "Hello ";
            string realResult;
            HelloWorldClient myservice = new HelloWorldClient();

            //test body
            realResult = myservice.SayHello(username);

            //assert
            Assert.AreEqual(expectedResult, realResult);

        }

        [TestMethod]
        public void HelloNothingUser()
        {
            //initialize
            string username = null;
            string expectedResult = "Hello ";
            string realResult;
            HelloWorldClient myservice = new HelloWorldClient();

            //test body
            realResult = myservice.SayHello(username);

            //assert
            Assert.AreEqual(expectedResult, realResult);

        }
    }
}
