using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DeviceManager.Dispatcher;
using DeviceManager.Device;

namespace DeviceManager
{
    public partial class DeviceManagerForm : Form
    {
        private DeviceDispatcher dispatcher = DeviceDispatcher.GetInstance();

        public DeviceManagerForm()
        {
            InitializeComponent();
            devicesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            devicesGridView.MultiSelect = false;
            UpdateData();
        }

        public void UpdateData()
        {
            var deviceList = dispatcher.Devices;
            devicesGridView.Rows.Clear();
            foreach (var device in deviceList)
            {
                devicesGridView.Rows.Add(device.GUID, device.HardwareID, device.Manufacturer, device.Name, device.DriverDescription, device.SysFile, device.DevicePath);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnableButton_Click(object sender, EventArgs e)
        {
            var selectedRow = devicesGridView.SelectedRows[0].Index;
            var deviceList = dispatcher.Devices;
            try
            {
                deviceList.FirstOrDefault(x => x.DevicePath.Equals(devicesGridView.SelectedCells[6].Value))?.ChangeState("Enable");
                MessageBox.Show(this, devicesGridView.SelectedCells[3].Value + " was enabled succefully", "OK - deviceManager");

                disableButton.Enabled = true;
                enableButton.Enabled = false;
            }
            catch (PCDeviceException exc) { MessageBox.Show(this, exc.Message, "Error - DeviceManager"); }

        }

        private void DisableButton_Click(object sender, EventArgs e)
        {
            var selectedRow = devicesGridView.SelectedRows[0].Index;
            var deviceList = dispatcher.Devices;
            try
            {
                deviceList.FirstOrDefault(x => x.DevicePath.Equals(devicesGridView.SelectedCells[6].Value))?.ChangeState("Disable");
                MessageBox.Show(this, devicesGridView.SelectedCells[3].Value + " was disabled succefully", "OK - deviceManager");

                disableButton.Enabled = false;
                enableButton.Enabled = true;
            }
            catch (PCDeviceException exc) { MessageBox.Show(this, exc.Message, "Error - DeviceManager"); }

        }

        private void DevicesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var device = dispatcher.Devices.FirstOrDefault(x => x.DevicePath.Equals(devicesGridView.SelectedCells[6].Value));
            if (device.Enabled == true)
            {
                enableButton.Enabled = false;
                disableButton.Enabled = true;
            }
            if (device.Enabled == false)
            {
                enableButton.Enabled = true;
                disableButton.Enabled = false;
            } 
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
