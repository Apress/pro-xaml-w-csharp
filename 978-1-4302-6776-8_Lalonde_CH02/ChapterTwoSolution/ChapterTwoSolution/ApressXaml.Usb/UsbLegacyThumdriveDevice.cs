using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApressXaml.Usb
{
    public class UsbLegacyThumdriveDevice : IUsbDevice
    {
        private double _deviceSpeedInMegaBytes = 1.0;

        public double UsbPortSpeedInMegaBytes
        {
            get { return _deviceSpeedInMegaBytes; }
            set { _deviceSpeedInMegaBytes = value; }
        }
    }
}
