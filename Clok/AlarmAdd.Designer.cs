
namespace Clok
{
	partial class AlarmAdd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmAdd));
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.CustomFormat = "dd.MM.yyyy";
			this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDate.Location = new System.Drawing.Point(12, 12);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(94, 22);
			this.dateTimePickerDate.TabIndex = 0;
			// 
			// dateTimePickerTime
			// 
			this.dateTimePickerTime.CustomFormat = "hh:mm:ss tt";
			this.dateTimePickerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerTime.Location = new System.Drawing.Point(113, 12);
			this.dateTimePickerTime.Name = "dateTimePickerTime";
			this.dateTimePickerTime.ShowUpDown = true;
			this.dateTimePickerTime.Size = new System.Drawing.Size(94, 22);
			this.dateTimePickerTime.TabIndex = 1;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(213, 11);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// AlarmAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 49);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.dateTimePickerTime);
			this.Controls.Add(this.dateTimePickerDate);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AlarmAdd";
			this.Text = "AlarmAdd";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerTime;
		private System.Windows.Forms.Button buttonOK;
	}
}