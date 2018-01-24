using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceManager.Device
{
    class PCDeviceException : Exception
    {
        public PCDeviceException(string message) : base(message) { }
    }
}
