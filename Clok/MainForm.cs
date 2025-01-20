using System;
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
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace Clok
{
	public partial class MainForm : Form
	{
		DateTime alarmTime;
		FontDialog fontDialog;
		AlarmDialog alarmDialog;
		public MainForm()
		{
			InitializeComponent();
			labelTime.BackColor = Color.AliceBlue;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
			alarmDialog = new AlarmDialog();
			LoadSettings();
			if (fontDialog == null) fontDialog = new FontDialog();
			axWindowsMediaPlayer.Ctlcontrols.stop();
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
		void AlarmSound()
		{
			if (alarmDialog.uriFileSoud.Path != "/")
				axWindowsMediaPlayer.URL = alarmDialog.uriFileSoud.Path;
			axWindowsMediaPlayer.settings.volume = 70;
			axWindowsMediaPlayer.Ctlcontrols.play();
			axWindowsMediaPlayer.Visible = true;
		}
		void LoadSettings()
		{
			StreamReader sr = null;
			try
			{
				sr = new StreamReader($"{Path.GetDirectoryName(Application.ExecutablePath)}\\..\\..\\Settings.ini");
				toolStripMenuItemTopmost.Checked = Boolean.Parse(sr.ReadLine());
				toolStripMenuItemShowControls.Checked = Boolean.Parse(sr.ReadLine());
				toolStripMenuItemShowConsole.Checked = Boolean.Parse(sr.ReadLine());
				toolStripMenuItemShowDate.Checked = Boolean.Parse(sr.ReadLine());
				toolStripMenuItemShowWeekday.Checked = Boolean.Parse(sr.ReadLine());
				string fontname = sr.ReadLine();
				float fontsize = (float)Convert.ToDouble(sr.ReadLine());
				labelTime.BackColor = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
				labelTime.ForeColor = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
				alarmDialog.uriFileSoud.Path = sr.ReadLine();
				int count = Convert.ToInt32(sr.ReadLine());
				for (int i = 0; i < count; i++)
				{
					string line = sr.ReadLine();
					if(DateTime.Parse(line).CompareTo(DateTime.Now)>0)
						alarmDialog.listBox.Items.Add(line);

				}
				sr.Close();
				if (alarmDialog.listBox.Items.Count>0) alarmTime = DateTime.Parse(alarmDialog.listBox.Items[0].ToString());
				fontDialog = new FontDialog(fontname, fontsize);
				labelTime.Font = fontDialog.Font;
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "In LoadSettings()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(this, ex.ToString(), "In LoadSettings()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void SaveSettings()
		{
			StreamWriter sw =
				new StreamWriter($"{Path.GetDirectoryName(Application.ExecutablePath)}\\..\\..\\Settings.ini");
			sw.WriteLine($"{toolStripMenuItemTopmost.Checked}");
			sw.WriteLine($"{toolStripMenuItemShowControls.Checked}");
			sw.WriteLine($"{toolStripMenuItemShowConsole.Checked}");
			sw.WriteLine($"{toolStripMenuItemShowDate.Checked}");
			sw.WriteLine($"{toolStripMenuItemShowWeekday.Checked}");
			sw.WriteLine($"{fontDialog.FontFilename}");
			sw.WriteLine($"{labelTime.Font.Size}");
			sw.WriteLine($"{labelTime.BackColor.ToArgb()}");
			sw.WriteLine($"{labelTime.ForeColor.ToArgb()}");
			sw.WriteLine($"{alarmDialog.uriFileSoud.Path}");
			sw.WriteLine($"{alarmDialog.listBox.Items.Count}");
			for (int i = 0; i < alarmDialog.listBox.Items.Count; i++)
				sw.WriteLine($"{alarmDialog.listBox.Items[i].ToString()}");
			sw.Close();
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
			
			if (alarmTime.Year == DateTime.Now.Year &&
				alarmTime.Month == DateTime.Now.Month &&
				alarmTime.Day == DateTime.Now.Day&&
				alarmTime.Hour==DateTime.Now.Hour&&
				alarmTime.Minute==DateTime.Now.Minute&&
				alarmTime.Second==DateTime.Now.Second)
			{
				System.Threading.Thread.Sleep(1000);
				AlarmSound();
				alarmDialog.listBox.Items.RemoveAt(0);
				if(alarmDialog.listBox.Items.Count>0)
					alarmTime = DateTime.Parse(alarmDialog.listBox.Items[0].ToString());
			}
			
		}

		private void buttonHideControls_Click(object sender, EventArgs e) => toolStripMenuItemShowControls.Checked = false;

		private void labelTime_DoubleClick(object sender, EventArgs e) => toolStripMenuItemShowControls.Checked = true;

		private void toolStripMenuItemExit_Click(object sender, EventArgs e) =>this.Close();

		private void toolStripMenuItemTopmost_CheckedChanged(object sender, EventArgs e) =>this.TopMost = toolStripMenuItemTopmost.Checked;

		private void toolStripMenuItemShowControls_CheckedChanged(object sender, EventArgs e) => SetVisibility(toolStripMenuItemShowControls.Checked);

	    private void toolStripMenuItemShowDate_CheckedChanged(object sender, EventArgs e) => checkBoxShowDate.Checked = toolStripMenuItemShowDate.Checked;

		private void checkBoxShowDate_CheckedChanged(object sender, EventArgs e) => toolStripMenuItemShowDate.Checked = checkBoxShowDate.Checked;

	    private void toolStripMenuItemShowWeekday_CheckedChanged(object sender, EventArgs e) => checkBoxShowWeekday.Checked = toolStripMenuItemShowWeekday.Checked;

		private void checkBoxShowWeekday_CheckedChanged(object sender, EventArgs e) => toolStripMenuItemShowWeekday.Checked = checkBoxShowWeekday.Checked;

		private void toolStripMenuItemBackgroundColor_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.AllowFullOpen = true;
			if (sender.ToString() == "Background color")
			{
				colorDialog.Color = labelTime.BackColor;
				if (colorDialog.ShowDialog(this) == DialogResult.OK)
					labelTime.BackColor = colorDialog.Color;
			}
			else
			{
				colorDialog.Color = labelTime.ForeColor;
				if (colorDialog.ShowDialog(this) == DialogResult.OK)
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
			//key.Close();
			key.Dispose();

		}

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
			if(!TopMost)
            {
				this.TopMost = true;
				this.TopMost = false;
            }
        }

        private void toolStripMenuItemShowConsole_CheckedChanged(object sender, EventArgs e)
        {
			bool show = toolStripMenuItemShowConsole.Checked ? AllocConsole() : FreeConsole();
        }
		[DllImport("kernel32.dll")]
		static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		static extern bool FreeConsole();

		private void toolStripMenuItemChooseFont_Click(object sender, EventArgs e)
		{
			if(fontDialog.ShowDialog(this)==DialogResult.OK)
			{
				labelTime.Font = fontDialog.Font;
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}

		private void alarmsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(alarmDialog.ShowDialog()==DialogResult.OK)
			{
				if(alarmDialog.listBox.Items.Count>0)
				alarmTime = DateTime.Parse(alarmDialog.listBox.Items[0].ToString());
			}
		}

		private void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
		{
			if(e.newState==1|e.newState==2)
				axWindowsMediaPlayer.Visible = false;
		}
	}
		
}
