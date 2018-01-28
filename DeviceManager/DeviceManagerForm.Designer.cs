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
    partial class DeviceManagerForm : Form
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.devicesGridView = new System.Windows.Forms.DataGridView();
            this.GUIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HardwareIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SysFileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevicePathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.disableButton = new System.Windows.Forms.Button();
            this.enableButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.devicesGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // devicesGridView
            // 
            this.devicesGridView.AllowUserToAddRows = false;
            this.devicesGridView.AllowUserToDeleteRows = false;
            this.devicesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devicesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.devicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devicesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GUIDColumn,
            this.HardwareIDColumn,
            this.ManufacturerColumn,
            this.NameColumn,
            this.DriverDescriptionColumn,
            this.SysFileColumn,
            this.DevicePathColumn});
            this.devicesGridView.Location = new System.Drawing.Point(8, 7);
            this.devicesGridView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.devicesGridView.Name = "devicesGridView";
            this.devicesGridView.ReadOnly = true;
            this.devicesGridView.Size = new System.Drawing.Size(2752, 719);
            this.devicesGridView.TabIndex = 0;
            this.devicesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DevicesGridView_CellContentClick);
            // 
            // GUIDColumn
            // 
            this.GUIDColumn.HeaderText = "GUID";
            this.GUIDColumn.Name = "GUIDColumn";
            this.GUIDColumn.ReadOnly = true;
            // 
            // HardwareIDColumn
            // 
            this.HardwareIDColumn.HeaderText = "HardwareID";
            this.HardwareIDColumn.Name = "HardwareIDColumn";
            this.HardwareIDColumn.ReadOnly = true;
            // 
            // ManufacturerColumn
            // 
            this.ManufacturerColumn.HeaderText = "Manufacturer";
            this.ManufacturerColumn.Name = "ManufacturerColumn";
            this.ManufacturerColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // DriverDescriptionColumn
            // 
            this.DriverDescriptionColumn.HeaderText = "DriverDescription";
            this.DriverDescriptionColumn.Name = "DriverDescriptionColumn";
            this.DriverDescriptionColumn.ReadOnly = true;
            // 
            // SysFileColumn
            // 
            this.SysFileColumn.HeaderText = "SysFile";
            this.SysFileColumn.Name = "SysFileColumn";
            this.SysFileColumn.ReadOnly = true;
            // 
            // DevicePathColumn
            // 
            this.DevicePathColumn.HeaderText = "DevicePath";
            this.DevicePathColumn.Name = "DevicePathColumn";
            this.DevicePathColumn.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.devicesGridView, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.46215F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.53785F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2768, 868);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // disableButton
            // 
            this.disableButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.disableButton.Location = new System.Drawing.Point(1369, 47);
            this.disableButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(1366, 67);
            this.disableButton.TabIndex = 2;
            this.disableButton.Text = "Disable";
            this.disableButton.UseVisualStyleBackColor = true;
            this.disableButton.Click += new System.EventHandler(this.DisableButton_Click);
            // 
            // enableButton
            // 
            this.enableButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.enableButton.Location = new System.Drawing.Point(8, 47);
            this.enableButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(1345, 67);
            this.enableButton.TabIndex = 1;
            this.enableButton.Text = "Enable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.EnableButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.61558F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.38442F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.enableButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.disableButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 740);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2752, 121);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // DeviceManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2768, 868);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "DeviceManagerForm";
            this.Text = "Device Manager";
            ((System.ComponentModel.ISupportInitialize)(this.devicesGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView devicesGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HardwareIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SysFileColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevicePathColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Button disableButton;
    }
}

