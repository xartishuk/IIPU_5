using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace DeviceManager.Device
{
    class PCDevice
    {
        public string GUID { get; set; }
        public string HardwareID { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string DriverDescription { get; set; }
        public string SysFile { get; set; }
        public string DevicePath { get; set; }
        public bool Enabled { get; set; }


        public void ChangeState(string method)
        {
            var device = new ManagementObjectSearcher("SELECT * FROM Win32_PNPEntity").Get().OfType<ManagementObject>()
            .FirstOrDefault(x => x["DeviceID"].ToString().Equals(DevicePath));
            try
            {
                device.InvokeMethod(method, new object[] { false });
            }
            catch (ManagementException)
            {
                throw new PCDeviceException("Cannot " + method.ToLower() + " this device.");
            }
            this.Enabled = (method == "Enable") ? true : false;
        }

        
        
        }
    }

