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
		public ListBox listBox { get => listBoxAlarms; }
		public AlarmDialog()
		{
			InitializeComponent();
			alarmAdd = new AlarmAdd();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if(alarmAdd.ShowDialog()==DialogResult.OK)
			{
				listBoxAlarms.Items.Add(alarmAdd.alarm.ToString());
				//if(DateTime.Now.Equals(DateTime.Parse(listBox.Items[0].ToString())))
				//listBox.Items.Add (DateTime.Parse(listBox.Items[0].ToString()).ToString());
				//listBox.Items.Add (DateTime.Now);
			}
		}
	}
}
