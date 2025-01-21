
namespace Clok
{
	partial class AddAlarmDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
			this.checkBoxUseDate = new System.Windows.Forms.CheckBox();
			this.checkedListBoxWeekdays = new System.Windows.Forms.CheckedListBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelFilename = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.CustomFormat = "yyyy.MM.dd";
			this.dateTimePickerDate.Enabled = false;
			this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDate.Location = new System.Drawing.Point(13, 48);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(145, 31);
			this.dateTimePickerDate.TabIndex = 0;
			// 
			// dateTimePickerTime
			// 
			this.dateTimePickerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerTime.Location = new System.Drawing.Point(208, 48);
			this.dateTimePickerTime.Name = "dateTimePickerTime";
			this.dateTimePickerTime.ShowUpDown = true;
			this.dateTimePickerTime.Size = new System.Drawing.Size(145, 31);
			this.dateTimePickerTime.TabIndex = 1;
			// 
			// checkBoxUseDate
			// 
			this.checkBoxUseDate.AutoSize = true;
			this.checkBoxUseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxUseDate.Location = new System.Drawing.Point(13, 13);
			this.checkBoxUseDate.Name = "checkBoxUseDate";
			this.checkBoxUseDate.Size = new System.Drawing.Size(117, 29);
			this.checkBoxUseDate.TabIndex = 2;
			this.checkBoxUseDate.Text = "Use date";
			this.checkBoxUseDate.UseVisualStyleBackColor = true;
			this.checkBoxUseDate.CheckedChanged += new System.EventHandler(this.checkBoxUseDate_CheckedChanged);
			// 
			// checkedListBoxWeekdays
			// 
			this.checkedListBoxWeekdays.CheckOnClick = true;
			this.checkedListBoxWeekdays.ColumnWidth = 48;
			this.checkedListBoxWeekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkedListBoxWeekdays.FormattingEnabled = true;
			this.checkedListBoxWeekdays.Items.AddRange(new object[] {
            "Mo",
            "Tu",
            "We",
            "Th",
            "Fr",
            "Sa",
            "Su"});
			this.checkedListBoxWeekdays.Location = new System.Drawing.Point(13, 96);
			this.checkedListBoxWeekdays.MultiColumn = true;
			this.checkedListBoxWeekdays.Name = "checkedListBoxWeekdays";
			this.checkedListBoxWeekdays.Size = new System.Drawing.Size(340, 19);
			this.checkedListBoxWeekdays.TabIndex = 3;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(196, 186);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(278, 186);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// labelFilename
			// 
			this.labelFilename.AutoSize = true;
			this.labelFilename.Location = new System.Drawing.Point(10, 128);
			this.labelFilename.Name = "labelFilename";
			this.labelFilename.Size = new System.Drawing.Size(49, 13);
			this.labelFilename.TabIndex = 6;
			this.labelFilename.Text = "Filename";
			// 
			// AddAlarmDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 221);
			this.Controls.Add(this.labelFilename);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.checkedListBoxWeekdays);
			this.Controls.Add(this.checkBoxUseDate);
			this.Controls.Add(this.dateTimePickerTime);
			this.Controls.Add(this.dateTimePickerDate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AddAlarmDialog";
			this.ShowInTaskbar = false;
			this.Text = "AddAlarmDialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerTime;
		private System.Windows.Forms.CheckBox checkBoxUseDate;
		private System.Windows.Forms.CheckedListBox checkedListBoxWeekdays;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelFilename;
	}
}