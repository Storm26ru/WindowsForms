﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using Microsoft.Win32;
using System.IO;


namespace Clok
{
	public partial class MainForm : Form
	{
		
		bool CustomFont;
		public MainForm()
		{
			InitializeComponent();
			labelTime.BackColor = Color.AliceBlue;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);

		}
		

		private void ToolStripMenuItemCustomFont_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		void SetVisibility(bool visible)
		{
			checkBoxShowDate.Visible = visible;
			checkBoxShowWeekday.Visible = visible;
			buttonHideControls.Visible = visible;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedDialog : FormBorderStyle.None;
			this.ShowInTaskbar = visible;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
			if (checkBoxShowDate.Checked)
				labelTime.Text += $"\n{DateTime.Now.ToString("dd.MM.yyyy")}";
			if (checkBoxShowWeekday.Checked)
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
			notifyIcon.Text = $"{DateTime.Now.ToString("H: mm")}\n" +
								$"{DateTime.Now.ToString("dd.MM.yyyy")}\n" +
								$"{DateTime.Now.DayOfWeek}";
		}

		private void buttonHideControls_Click(object sender, EventArgs e)
		{
			SetVisibility(toolStripMenuItemShowControls.Checked = false);

		}

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			SetVisibility(toolStripMenuItemShowControls.Checked = true);
		}

		private void toolStripMenuItemTopmost_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = toolStripMenuItemTopmost.Checked;
		}

		private void toolStripMenuItemExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void toolStripMenuItemShowControls_CheckedChanged(object sender, EventArgs e)
		{
			SetVisibility(toolStripMenuItemShowControls.Checked);
		}
		private void toolStripMenuItemShowDate_Click(object sender, EventArgs e)
		{
			checkBoxShowDate.Checked = toolStripMenuItemShowDate.Checked;
		}

		private void checkBoxShowDate_CheckedChanged(object sender, EventArgs e)
		{
			toolStripMenuItemShowDate.Checked = checkBoxShowDate.Checked;
		}

		private void toolStripMenuItemShowWeekday_Click(object sender, EventArgs e)
		{
			checkBoxShowWeekday.Checked = toolStripMenuItemShowWeekday.Checked;
		}

		private void checkBoxShowWeekday_CheckedChanged(object sender, EventArgs e)
		{
			toolStripMenuItemShowWeekday.Checked = checkBoxShowWeekday.Checked;
		}

		private void toolStripMenuItemBackgroundColor_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.AllowFullOpen = true;
			if (sender.ToString() == "Background color")
			{
				colorDialog.Color = labelTime.BackColor;
				if (colorDialog.ShowDialog() == DialogResult.OK)
					labelTime.BackColor = colorDialog.Color;
			}
			else
			{
				colorDialog.Color = labelTime.ForeColor;
				if (colorDialog.ShowDialog() == DialogResult.OK)
					labelTime.ForeColor = colorDialog.Color;
			}
		}

		private void toolStripMenuItemLoadOnWindowsStartup_Click(object sender, EventArgs e)
		{
			RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if (toolStripMenuItemLoadOnWindowsStartup.Checked)
				key.SetValue("Clok_VPD_311", Application.ExecutablePath);
			else
				key.DeleteValue("Clok_VPD_311");
			key.Close();

		}

	}
		
}
