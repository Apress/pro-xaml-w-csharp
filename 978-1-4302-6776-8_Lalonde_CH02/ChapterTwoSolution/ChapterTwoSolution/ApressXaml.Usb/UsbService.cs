using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ApressXaml.Usb
{
    public class UsbService : IUsbService
    {
        private IUsbDevice _Device;
        private double _CurrentSpeed = 0.0;

        public UsbService(IUsbDevice device)
        {
            _Device = device;
        }

        public double CalculateSpeed()
        {
            return _Device.UsbPortSpeedInMegaBytes;
        }
    }
}
