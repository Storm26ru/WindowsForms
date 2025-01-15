
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
			this.dateTimeTime = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.CustomFormat = "dd.MM.yyyy";
			this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDate.Location = new System.Drawing.Point(28, 33);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(94, 22);
			this.dateTimePickerDate.TabIndex = 0;
			// 
			// dateTimeTime
			// 
			this.dateTimeTime.CustomFormat = "hh:mm:ss tt";
			this.dateTimeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimeTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimeTime.Location = new System.Drawing.Point(128, 33);
			this.dateTimeTime.Name = "dateTimeTime";
			this.dateTimeTime.ShowUpDown = true;
			this.dateTimeTime.Size = new System.Drawing.Size(94, 22);
			this.dateTimeTime.TabIndex = 1;
			// 
			// AlarmAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 450);
			this.Controls.Add(this.dateTimeTime);
			this.Controls.Add(this.dateTimePickerDate);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AlarmAdd";
			this.Text = "AlarmAdd";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.DateTimePicker dateTimeTime;
	}
}