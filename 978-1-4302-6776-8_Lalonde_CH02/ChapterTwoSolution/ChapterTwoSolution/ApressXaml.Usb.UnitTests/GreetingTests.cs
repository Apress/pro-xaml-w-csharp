using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApressXaml.Usb;

namespace ApressXaml.Usb.UnitTests
{
    [TestClass]
    public class GreetingTests
    {
        private IUserLoginService _UserLoginService;

        [TestInitialize]
        public void Test_Init()
        {
            _UserLoginService = new UserLoginService();
        }


        [TestMethod]
        public void If_A_Name_With_More_Than_Zero_Characters_Is_Passed_Then_The_Service_Will_Return_A_Greeting_Message()
        {
            if (_UserLoginService == null)
                throw new NullReferenceException();

            var validName = "Buddy";

            var actualGreeting = _UserLoginService.GreetUser(validName);
            var expectedGreeting = "Hello Buddy!";
            
            Assert.AreEqual(expectedGreeting, actualGreeting, "The user greeting is incorrect");
        }
    }
}
