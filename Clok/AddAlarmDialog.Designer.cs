
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
			this.buttonSound = new System.Windows.Forms.Button();
			this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
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
			this.buttonOK.Location = new System.Drawing.Point(196, 302);
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
			this.buttonCancel.Location = new System.Drawing.Point(278, 302);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// labelFilename
			// 
			this.labelFilename.AutoSize = true;
			this.labelFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFilename.Location = new System.Drawing.Point(10, 128);
			this.labelFilename.Name = "labelFilename";
			this.labelFilename.Size = new System.Drawing.Size(64, 16);
			this.labelFilename.TabIndex = 6;
			this.labelFilename.Text = "Filename";
			// 
			// buttonSound
			// 
			this.buttonSound.Location = new System.Drawing.Point(12, 147);
			this.buttonSound.Name = "buttonSound";
			this.buttonSound.Size = new System.Drawing.Size(75, 23);
			this.buttonSound.TabIndex = 7;
			this.buttonSound.Text = "Sound";
			this.buttonSound.UseVisualStyleBackColor = true;
			this.buttonSound.Click += new System.EventHandler(this.buttonSound_Click);
			// 
			// richTextBoxMessage
			// 
			this.richTextBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBoxMessage.Location = new System.Drawing.Point(12, 192);
			this.richTextBoxMessage.Name = "richTextBoxMessage";
			this.richTextBoxMessage.Size = new System.Drawing.Size(341, 83);
			this.richTextBoxMessage.TabIndex = 8;
			this.richTextBoxMessage.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 173);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "Message";
			// 
			// AddAlarmDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 337);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBoxMessage);
			this.Controls.Add(this.buttonSound);
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
			this.Load += new System.EventHandler(this.AddAlarmDialog_Load);
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
		private System.Windows.Forms.Button buttonSound;
		private System.Windows.Forms.RichTextBox richTextBoxMessage;
		private System.Windows.Forms.Label label1;
	}
}