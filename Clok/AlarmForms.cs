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
	public partial class AlarmForms : Form
	{
		AddAlarmDialog alarmDialog;
		public AlarmForms()
		{
			InitializeComponent();
			alarmDialog = new AddAlarmDialog();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if(alarmDialog.ShowDialog()==DialogResult.OK)
			{
				listBoxAlarms.Items.Add(new Alarm(alarmDialog.Alarm));
			}
		}
	}
}
