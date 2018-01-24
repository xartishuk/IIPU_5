using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeviceManager.Device;
using DeviceManager.Scanner;

namespace DeviceManager.Dispatcher
{
    sealed class DeviceDispatcher
    {
        private static DeviceDispatcher _instance;
        public static DeviceDispatcher GetInstance() { return _instance ?? (_instance = new DeviceDispatcher()); }
        private DeviceDispatcher() { UpdateDevices(); }

        public List<PCDevice> Devices { get; private set; }
        public List<PCDevice> UpdateDevices()
        {
            var scanner = DeviceScanner.GetInstance();
            scanner.UpdateDevices();
            Devices = scanner.Devices;
            return Devices;
        }
    }
}
