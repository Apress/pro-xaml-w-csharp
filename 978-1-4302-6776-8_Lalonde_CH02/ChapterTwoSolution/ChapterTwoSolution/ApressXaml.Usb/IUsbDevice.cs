using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApressXaml.Usb
{
    public interface IUsbDevice
    {
        double UsbPortSpeedInMegaBytes { get; set; }

    }
}
