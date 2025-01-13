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


namespace Clok
{
	public partial class MainForm : Form
	{
		UriBuilder uriFileFont = new UriBuilder();
		PrivateFontCollection privateFont = new PrivateFontCollection();
		bool CustomFont;
		public MainForm()
		{
			InitializeComponent();
			labelTime.BackColor = Color.AliceBlue;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
			LoadValue();
			
		}
		void SaveValue()
		{
			RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Clock_VPD_311");
			key.SetValue("Topmost", toolStripMenuItemTopmost.Checked);
			key.SetValue("Show_controls", toolStripMenuItemShowControls.Checked);
			key.SetValue("Show_date",toolStripMenuItemShowDate.Checked);
			key.SetValue("Show_weekday",toolStripMenuItemShowWeekday.Checked);
			if(CustomFont) key.SetValue("Font",uriFileFont.Path);
			else key.SetValue("Font",labelTime.Font.Name);
			key.SetValue("FontSize", (int)labelTime.Font.SizeInPoints);
			key.SetValue("Backgraund_color",labelTime.BackColor.ToArgb());
			key.SetValue("Foregraund_color",labelTime.ForeColor.ToArgb());
			//key.Close();
			key.Dispose();
		}
		void LoadValue()
		{
			if (Registry.CurrentUser.OpenSubKey("Software\\Clock_VPD_311") != null)
			{
				RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Clock_VPD_311", false);
				toolStripMenuItemTopmost.Checked = Convert.ToBoolean(key.GetValue("Topmost"));
				toolStripMenuItemShowControls.Checked = Convert.ToBoolean(key.GetValue("Show_controls"));
				checkBoxShowDate.Checked = Convert.ToBoolean(key.GetValue("Show_date"));
				checkBoxShowWeekday.Checked = Convert.ToBoolean(key.GetValue("Show_weekday"));
				if (Convert.ToString(key.GetValue("Font")).Contains('/'))
				{
					try
					{
						privateFont.AddFontFile(Convert.ToString(key.GetValue("Font")));
						labelTime.Font = new Font(privateFont.Families[0], (int)key.GetValue("FontSize"));
						CustomFont = true;
						uriFileFont.Path = Convert.ToString(key.GetValue("Font"));
					}
					catch
					{
						MessageBox.Show($"File {key.GetValue("Font")} is missing or corrupted,select another","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
						toolStripMenuItemCustomFont_Click(null, null);
					}
				}
				else labelTime.Font = new Font(new FontFamily(Convert.ToString(key.GetValue("Font"))),(int)key.GetValue("FontSize"));
				labelTime.BackColor = Color.FromArgb(Convert.ToInt32(key.GetValue("Backgraund_color")));
				labelTime.ForeColor = Color.FromArgb(Convert.ToInt32(key.GetValue("Foregraund_color")));
				key.Dispose();
			}
			RegistryKey startup = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
			if (startup.GetValue("Clok_VPD_311") != null) toolStripMenuItemLoadOnWindowsStartup.Checked = true;
			startup.Dispose();
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
			labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt",System.Globalization.CultureInfo.InvariantCulture);
			if (checkBoxShowDate.Checked)
				labelTime.Text += $"\n{DateTime.Now.ToString("dd.MM.yyyy")}";
			if (checkBoxShowWeekday.Checked) 
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
			notifyIcon.Text =	$"{DateTime.Now.ToString("H: mm")}\n"+
								$"{DateTime.Now.ToString("dd.MM.yyyy")}\n"+
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
			privateFont.Dispose();
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
			if(sender.ToString()=="Background color")
			{
				colorDialog.Color = labelTime.BackColor;
				if (colorDialog.ShowDialog() == DialogResult.OK)
					labelTime.BackColor = colorDialog.Color;
			}else
			{
				colorDialog.Color = labelTime.ForeColor;
				if (colorDialog.ShowDialog() == DialogResult.OK)
					labelTime.ForeColor = colorDialog.Color;
			}
		}

		private void toolStripMenuItemLoadOnWindowsStartup_Click(object sender, EventArgs e)
		{
			RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run",true);
			if (toolStripMenuItemLoadOnWindowsStartup.Checked)
				key.SetValue("Clok_VPD_311", Application.ExecutablePath);
			else
				key.DeleteValue("Clok_VPD_311");
			key.Close();

		}

		private void toolStripMenuItemCustomFont_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog()
			{
				FileName = "Select a font file",
				Filter = "Font files |*.ttf;*.otf",
				Title = "Open font file"
			};
			if(openFile.ShowDialog()==DialogResult.OK)
			{
				uriFileFont.Path = openFile.FileName;
				PrivateFontCollection fontbufer = new PrivateFontCollection();
				try
				{
					privateFont.AddFontFile(uriFileFont.Path);
					fontbufer.AddFontFile(uriFileFont.Path);
					for (int i = 0; i <privateFont.Families.Length; i++)
					{
						if (privateFont.Families[i].Name == fontbufer.Families[0].Name)
						{
							labelTime.Font = new Font(privateFont.Families[i], labelTime.Font.SizeInPoints);
							CustomFont = true;
							break;
						}
					}
					
				}
				catch
				{
					MessageBox.Show($"File {uriFileFont.Path} corrupted,select another", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
					toolStripMenuItemCustomFont_Click(null, null);
				}
				fontbufer.Dispose();
			}

		}

		private void toolStripMenuItemSystemFont_Click(object sender, EventArgs e)
		{
			FontDialog fontDialog = new FontDialog();
			if(fontDialog.ShowDialog()==DialogResult.OK)
			{
				labelTime.Font = fontDialog.Font;
				CustomFont = false;
			}
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			SaveValue();
		}

	}
}
