using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using DeviceManager.Device;

namespace DeviceManager.Scanner
{
    /// <summary>
    /// This class detects devices
    /// </summary>
    sealed class DeviceScanner
    {
        private static DeviceScanner _instance;
        public static DeviceScanner GetInstance() { return _instance ?? (_instance = new DeviceScanner()); }
        private DeviceScanner() { UpdateDevices(); }

        private const string GUID_PROPERTY = "ClassGUID";
        private const string HARDWARE_ID_PROPERTY = "HardwareID";
        private const string MANUFACTURER_PROPERTY = "Manufacturer";
        private const string NAME_PROPERTY = "Caption";
        private const string DRIVER_DESCRIPTION_PROPERTY = "Description";
        private const string SYS_FILE_PROPERTY = "PathName";
        private const string DEVICE_PATH_PROPERTY = "DeviceID";
        private const string DEVICE_STATUS_PROPERTY = "Status";


        public List<PCDevice> Devices { get; set; }
        public List<PCDevice> UpdateDevices()
        {
            var deviceList = new List<PCDevice>();
            var wmiDeviceList = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity").Get().OfType<ManagementObject>();

            foreach (var device in wmiDeviceList)
            {
                var currentDevice = new PCDevice();

                currentDevice.GUID = device[GUID_PROPERTY]?.ToString();
                currentDevice.HardwareID = ((string[])device[HARDWARE_ID_PROPERTY])?.Aggregate((current, next) => current + next);
                currentDevice.Manufacturer = device[MANUFACTURER_PROPERTY]?.ToString();
                currentDevice.Name = device[NAME_PROPERTY]?.ToString();
                currentDevice.DevicePath = device[DEVICE_PATH_PROPERTY].ToString();
                currentDevice.Enabled = (device[DEVICE_STATUS_PROPERTY].ToString() == "OK") ? true : false;

                var driverInfo = device.GetRelated("Win32_SystemDriver");
                foreach (var driver in driverInfo)
                {
                    currentDevice.SysFile = driver[SYS_FILE_PROPERTY].ToString();
                    currentDevice.DriverDescription = driver[DRIVER_DESCRIPTION_PROPERTY].ToString();
                }

                deviceList.Add(currentDevice);
            }

            Devices = deviceList;
            return Devices;
        }
    }
}
