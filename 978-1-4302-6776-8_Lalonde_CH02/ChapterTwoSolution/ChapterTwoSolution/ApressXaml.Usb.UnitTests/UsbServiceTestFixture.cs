using System;
using System.Diagnostics.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApressXaml.Usb;

namespace ApressXaml.Usb.UnitTests
{
    [TestClass]
    public class UsbServiceTestFixture
    {
        [TestMethod]
        public void If_Service_Receives_SuperClass_Then_SpeedService_Validity_ChecK_Returns_True()
        {
         
            var usbTwoDevice = new UsbLegacyThumdriveDevice();

            

            var usbService = new UsbService(usbTwoDevice);
            var expectedMegabytesPerSecond = 2.0;

            var actualMegabytesPerSecond = usbService.CalculateSpeed();

            Assert.AreEqual(expectedMegabytesPerSecond, actualMegabytesPerSecond, "The subclass has interuppted the baseclass.");
        }
    }
}
