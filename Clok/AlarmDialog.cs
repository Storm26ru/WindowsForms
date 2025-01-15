﻿using System;
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
		public AlarmDialog()
		{
			InitializeComponent();
			alarmAdd = new AlarmAdd();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			alarmAdd.ShowDialog();
		}
	}
}
