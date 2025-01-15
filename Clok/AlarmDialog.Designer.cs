
namespace Clok
{
	partial class AlarmDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmDialog));
			this.listBoxAlarm = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// listBoxAlarm
			// 
			this.listBoxAlarm.FormattingEnabled = true;
			this.listBoxAlarm.Location = new System.Drawing.Point(12, 12);
			this.listBoxAlarm.Name = "listBoxAlarm";
			this.listBoxAlarm.Size = new System.Drawing.Size(231, 95);
			this.listBoxAlarm.TabIndex = 0;
			// 
			// AlarmDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 450);
			this.Controls.Add(this.listBoxAlarm);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AlarmDialog";
			this.Text = "Alarms";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxAlarm;
	}
}