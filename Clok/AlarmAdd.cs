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
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			alarm = new DateTime(dateTimePickerDate.Value.Year,dateTimePickerDate.Value.Month,dateTimePickerDate.Value.Day,
								dateTimePickerTime.Value.Hour,dateTimePickerTime.Value.Minute,dateTimePickerTime.Value.Second);
			
		}
	}
}
