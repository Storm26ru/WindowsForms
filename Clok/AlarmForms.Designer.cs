
namespace Clok
{
	partial class AlarmForms
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmForms));
			this.listBoxAlarms = new System.Windows.Forms.ListBox();
			this.labelAlarmInfo = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSort = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxAlarms
			// 
			this.listBoxAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxAlarms.FormattingEnabled = true;
			this.listBoxAlarms.HorizontalScrollbar = true;
			this.listBoxAlarms.Location = new System.Drawing.Point(12, 12);
			this.listBoxAlarms.Name = "listBoxAlarms";
			this.listBoxAlarms.Size = new System.Drawing.Size(459, 225);
			this.listBoxAlarms.TabIndex = 0;
			// 
			// labelAlarmInfo
			// 
			this.labelAlarmInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelAlarmInfo.AutoSize = true;
			this.labelAlarmInfo.Location = new System.Drawing.Point(12, 244);
			this.labelAlarmInfo.Name = "labelAlarmInfo";
			this.labelAlarmInfo.Size = new System.Drawing.Size(73, 13);
			this.labelAlarmInfo.TabIndex = 1;
			this.labelAlarmInfo.Text = "labelAlarmInfo";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAdd.Location = new System.Drawing.Point(315, 259);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(396, 259);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonSort
			// 
			this.buttonSort.AutoEllipsis = true;
			this.buttonSort.Location = new System.Drawing.Point(234, 258);
			this.buttonSort.Name = "buttonSort";
			this.buttonSort.Size = new System.Drawing.Size(75, 23);
			this.buttonSort.TabIndex = 4;
			this.buttonSort.Text = "Sort";
			this.buttonSort.UseVisualStyleBackColor = true;
			this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
			// 
			// AlarmForms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 294);
			this.Controls.Add(this.buttonSort);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.labelAlarmInfo);
			this.Controls.Add(this.listBoxAlarms);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AlarmForms";
			this.ShowInTaskbar = false;
			this.Text = "AlarmsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxAlarms;
		private System.Windows.Forms.Label labelAlarmInfo;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSort;
	}
}