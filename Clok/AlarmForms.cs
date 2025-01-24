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
		public ListBox listBox { get => listBoxAlarms; }
		public AlarmForms()
		{
			InitializeComponent();
			alarmDialog = new AddAlarmDialog();
		}

		private void SortListBox()
		{
			Alarm[] alarmsToday = listBoxAlarms.Items.Cast<Alarm>().Where(
				a => a.Time > DateTime.Now.TimeOfDay && (a.Date == DateTime.Now.Date || a.Date == DateTime.MinValue)).OrderBy(a =>a.Time).ToArray();
			Alarm[] alarm = listBoxAlarms.Items.Cast<Alarm>().Where(
				a => a.Date != DateTime.Now.Date && a.Date != DateTime.MinValue).OrderBy(a => a.Time).ToArray();
			listBoxAlarms.Items.Clear();
			listBoxAlarms.Items.AddRange(alarmsToday);
			listBoxAlarms.Items.AddRange(alarm);
		
		}
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if(alarmDialog.ShowDialog()==DialogResult.OK)
			{
				listBoxAlarms.Items.Add(new Alarm(alarmDialog.Alarm));
			}
		}

		private void buttonSort_Click(object sender, EventArgs e)
		{
			this.SortListBox();
		}
	}
}
