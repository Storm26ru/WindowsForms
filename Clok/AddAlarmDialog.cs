using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clok
{
	public partial class AddAlarmDialog : Form
	{
		public Alarm Alarm { get; set; }
		OpenFileDialog openFile;
		public AddAlarmDialog()
		{
			InitializeComponent();
			dateTimePickerDate.Enabled = false;
			Alarm = new Alarm();
			openFile = new OpenFileDialog()
			{
				FileName = "Select file",
				Filter = "Sound files | *.mp3;*.wav",
				Title = "Open sound file"
			};
		}

		private void checkBoxUseDate_CheckedChanged(object sender, EventArgs e)
		{
			dateTimePickerDate.Enabled = checkBoxUseDate.Checked;
			checkedListBoxWeekdays.Enabled = !checkBoxUseDate.Checked;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (checkedListBoxWeekdays.Enabled)
			{
				bool[] days = new bool[checkedListBoxWeekdays.Items.Count];
				for (int i = 0; i < checkedListBoxWeekdays.Items.Count; i++) days[i] = checkedListBoxWeekdays.GetItemChecked(i);
				Alarm.Date = DateTime.MinValue;
				Alarm.Week = new Week(days);
			}
			else Alarm.Week = new Week();
			Console.WriteLine(Alarm.Week);
			if (checkBoxUseDate.Checked) Alarm.Date = dateTimePickerDate.Value.Date;
			Alarm.Time = dateTimePickerTime.Value.TimeOfDay;
			Alarm.Filename = labelFilename.Text;
			Alarm.Message = richTextBoxMessage.Text;

		}

		private void buttonSound_Click(object sender, EventArgs e)
		{
			if (openFile.ShowDialog() == DialogResult.OK)
				labelFilename.Text = openFile.FileName;
		}

		private void AddAlarmDialog_Load(object sender, EventArgs e)
		{
			if(Alarm.Date!=DateTime.MinValue)
			{
				checkBoxUseDate.Checked = true;
				dateTimePickerDate.Value = Alarm.Date;
			}
			dateTimePickerTime.Value = DateTime.Now.Date + Alarm.Time;
			for(byte i = 0; i<checkedListBoxWeekdays.Items.Count;i++) checkedListBoxWeekdays.SetItemChecked(i, Alarm.Week.Days(i));
			labelFilename.Text = Alarm.Filename;
			richTextBoxMessage.Text = Alarm.Message;
		}
	}
}
