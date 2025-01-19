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
	public partial class AlarmDialog : Form
	{
		AlarmAdd alarmAdd;
		public UriBuilder uriFileSoud;
		public ListBox listBox { get => listBoxAlarms; }
		public AlarmDialog()
		{
			InitializeComponent();
			alarmAdd = new AlarmAdd();
			listBoxAlarms.Sorted = true;
			uriFileSoud = new UriBuilder();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (alarmAdd.ShowDialog() == DialogResult.OK)
			{
				if (listBoxAlarms.FindString(alarmAdd.alarm.ToString()) < 0)
					listBoxAlarms.Items.Add(alarmAdd.alarm.ToString());
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e) => listBoxAlarms.Items.Remove(listBoxAlarms.SelectedItem);
				
		private void listBoxAlarms_DoubleClick(object sender, EventArgs e)
		{
			if (listBoxAlarms.Items.Count > 0)
			{	if (listBoxAlarms.SelectedItem != null)
				{
					alarmAdd = new AlarmAdd(DateTime.Parse(listBoxAlarms.SelectedItem.ToString()));
					if (alarmAdd.ShowDialog() == DialogResult.OK)
						listBoxAlarms.Items[listBoxAlarms.SelectedIndex] = alarmAdd.alarm.ToString();
				}
				else MessageBox.Show("Select an Alarm", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else buttonAdd_Click(sender, e);
		}

		private void buttonSound_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog()
			{
				FileName = "Select file",
				Filter = "Sound files | *.mp3;*.wav",
				Title = "Open sound file"
			};
			if(openFile.ShowDialog()==DialogResult.OK)
			{
				uriFileSoud.Path = openFile.FileName;
			}
		}
	}
}
