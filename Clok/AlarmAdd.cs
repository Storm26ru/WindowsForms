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
	public partial class AlarmAdd : Form
	{
		public DateTime alarm { get; set; }
		public AlarmAdd()
		{
			InitializeComponent();
			dateTimePickerDate.MinDate = DateTime.Today;
		}
		public AlarmAdd(DateTime alarm) : this()
		{
			dateTimePickerDate.Value = alarm;
			dateTimePickerTime.Value = alarm;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			alarm = new DateTime(dateTimePickerDate.Value.Year,dateTimePickerDate.Value.Month,dateTimePickerDate.Value.Day,
								dateTimePickerTime.Value.Hour,dateTimePickerTime.Value.Minute,dateTimePickerTime.Value.Second);
			if (alarm.CompareTo(DateTime.Now) < 0)
			{
				this.DialogResult = DialogResult.None;
				MessageBox.Show("Alarm is less than the current time", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
