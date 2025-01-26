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
				a => (a.Date != DateTime.Now.Date && a.Date !=DateTime.MinValue ) ||( a.Time<DateTime.Now.TimeOfDay && a.Date == DateTime.MinValue)).OrderBy(a => a.Time).ToArray();
			listBoxAlarms.Items.Clear();
			listBoxAlarms.Items.AddRange(alarmsToday);
			listBoxAlarms.Items.AddRange(alarm);
		
		}
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if(alarmDialog.ShowDialog()==DialogResult.OK)
			{
				if(listBoxAlarms.FindString(alarmDialog.Alarm.ToString())<0)
                {
					listBoxAlarms.Items.Add(new Alarm(alarmDialog.Alarm));
					this.SortListBox();
                }
			}
		}

		public void Sort()
        {
			this.SortListBox();
        }
		private void buttonDelete_Click(object sender, EventArgs e) => listBoxAlarms.Items.Remove(listBoxAlarms.SelectedItem);

        private void listBoxAlarms_DoubleClick(object sender, EventArgs e)
        {
			if (listBoxAlarms.Items.Count > 0)
			{
				if (listBoxAlarms.SelectedItem != null)
				{
					alarmDialog.Alarm = (Alarm)listBoxAlarms.SelectedItem;
					if (alarmDialog.ShowDialog() == DialogResult.OK)
					{
						listBoxAlarms.Items[listBoxAlarms.SelectedIndex] = alarmDialog.Alarm;
						this.SortListBox();
					}
				}
			}
			else buttonAdd_Click(sender, e);
        }
    }
}
