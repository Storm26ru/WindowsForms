﻿
namespace Clok
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelTime = new System.Windows.Forms.Label();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemShowControls = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemShowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemChooseFont = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemColors = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemLoadOnWindowsStartup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.checkBoxShowDate = new System.Windows.Forms.CheckBox();
			this.buttonHideControls = new System.Windows.Forms.Button();
			this.checkBoxShowWeekday = new System.Windows.Forms.CheckBox();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.ContextMenuStrip = this.contextMenuStrip;
			this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTime.Location = new System.Drawing.Point(12, 9);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(118, 51);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "Time";
			this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTopmost,
            this.toolStripMenuItemShowControls,
            this.toolStripSeparator1,
            this.toolStripMenuItemShowDate,
            this.toolStripMenuItemShowWeekday,
            this.toolStripSeparator2,
            this.toolStripMenuItemChooseFont,
            this.toolStripMenuItemColors,
            this.toolStripSeparator3,
            this.toolStripMenuItemLoadOnWindowsStartup,
            this.toolStripSeparator4,
            this.toolStripMenuItemExit});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(210, 204);
			// 
			// toolStripMenuItemTopmost
			// 
			this.toolStripMenuItemTopmost.CheckOnClick = true;
			this.toolStripMenuItemTopmost.Name = "toolStripMenuItemTopmost";
			this.toolStripMenuItemTopmost.Size = new System.Drawing.Size(209, 22);
			this.toolStripMenuItemTopmost.Text = "Topmost";
			this.toolStripMenuItemTopmost.EnabledChanged += new System.EventHandler(this.toolStripMenuItemTopmost_Chehanged);
			// 
			// toolStripMenuItemShowControls
			// 
			this.toolStripMenuItemShowControls.Checked = true;
			this.toolStripMenuItemShowControls.CheckOnClick = true;
			this.toolStripMenuItemShowControls.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemShowControls.Name = "toolStripMenuItemShowControls";
			this.toolStripMenuItemShowControls.Size = new System.Drawing.Size(209, 22);
			this.toolStripMenuItemShowControls.Text = "Show controls";
			this.toolStripMenuItemShowControls.CheckedChanged += new System.EventHandler(this.toolStripMenuItemShowControls_CheckedChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
			// 
			// toolStripMenuItemShowDate
			// 
			this.toolStripMenuItemShowDate.CheckOnClick = true;
			this.toolStripMenuItemShowDate.Name = "toolStripMenuItemShowDate";
			this.toolStripMenuItemShowDate.Size = new System.Drawing.Size(209, 22);
			this.toolStripMenuItemShowDate.Text = "Show date";
			this.toolStripMenuItemShowDate.Click += new System.EventHandler(this.toolStripMenuItemShowDate_Click);
			// 
			// toolStripMenuItemShowWeekday
			// 
			this.toolStripMenuItemShowWeekday.CheckOnClick = true;
			this.toolStripMenuItemShowWeekday.Name = "toolStripMenuItemShowWeekday";
			this.toolStripMenuItemShowWeekday.Size = new System.Drawing.Size(209, 22);
			this.toolStripMenuItemShowWeekday.Text = "Show weekday";
			this.toolStripMenuItemShowWeekday.Click += new System.EventHandler(this.toolStripMenuItemShowWeekday_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
			// 
			// toolStripMenuItemChooseFont
			// 
			this.toolStripMenuItemChooseFont.Name = "toolStripMenuItemChooseFont";
			this.toolStripMenuItemChooseFont.Size = new System.Drawing.Size(209, 22);
			this.toolStripMenuItemChooseFont.Text = "Choose font";
			// 
			// toolStripMenuItemColors
			// 
			this.toolStripMenuItemColors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBackgroundColor,
            this.toolStripMenuItemForegroundColor});
			this.toolStripMenuItemColors.Name = "toolStripMenuItemColors";
			this.toolStripMenuItemColors.Size = new System.Drawing.Size(209, 22);
			this.toolStripMenuItemColors.Text = "Colors";
			// 
			// toolStripMenuItemBackgroundColor
			// 
			this.toolStripMenuItemBackgroundColor.Name = "toolStripMenuItemBackgroundColor";
			this.toolStripMenuItemBackgroundColor.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemBackgroundColor.Text = "Background color";
			this.toolStripMenuItemBackgroundColor.Click += new System.EventHandler(this.toolStripMenuItemBackgroundColor_Click);
			// 
			// toolStripMenuItemForegroundColor
			// 
			this.toolStripMenuItemForegroundColor.Name = "toolStripMenuItemForegroundColor";
			this.toolStripMenuItemForegroundColor.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemForegroundColor.Text = "Foreground color";
			this.toolStripMenuItemForegroundColor.Click += new System.EventHandler(this.toolStripMenuItemBackgroundColor_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
			// 
			// toolStripMenuItemLoadOnWindowsStartup
			// 
			this.toolStripMenuItemLoadOnWindowsStartup.CheckOnClick = true;
			this.toolStripMenuItemLoadOnWindowsStartup.Name = "toolStripMenuItemLoadOnWindowsStartup";
			this.toolStripMenuItemLoadOnWindowsStartup.Size = new System.Drawing.Size(209, 22);
			this.toolStripMenuItemLoadOnWindowsStartup.Text = "Load on Windows startup";
			this.toolStripMenuItemLoadOnWindowsStartup.Click += new System.EventHandler(this.toolStripMenuItemLoadOnWindowsStartup_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(206, 6);
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(209, 22);
			this.toolStripMenuItemExit.Text = "Exit";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// checkBoxShowDate
			// 
			this.checkBoxShowDate.AutoSize = true;
			this.checkBoxShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowDate.Location = new System.Drawing.Point(12, 163);
			this.checkBoxShowDate.Name = "checkBoxShowDate";
			this.checkBoxShowDate.Size = new System.Drawing.Size(132, 29);
			this.checkBoxShowDate.TabIndex = 1;
			this.checkBoxShowDate.Text = "Show date";
			this.checkBoxShowDate.UseVisualStyleBackColor = true;
			this.checkBoxShowDate.CheckedChanged += new System.EventHandler(this.checkBoxShowDate_CheckedChanged);
			// 
			// buttonHideControls
			// 
			this.buttonHideControls.BackColor = System.Drawing.SystemColors.Control;
			this.buttonHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHideControls.Location = new System.Drawing.Point(11, 243);
			this.buttonHideControls.Name = "buttonHideControls";
			this.buttonHideControls.Size = new System.Drawing.Size(176, 44);
			this.buttonHideControls.TabIndex = 2;
			this.buttonHideControls.Text = "Hide controls";
			this.buttonHideControls.UseVisualStyleBackColor = false;
			this.buttonHideControls.Click += new System.EventHandler(this.buttonHideControls_Click);
			// 
			// checkBoxShowWeekday
			// 
			this.checkBoxShowWeekday.AutoSize = true;
			this.checkBoxShowWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowWeekday.Location = new System.Drawing.Point(12, 198);
			this.checkBoxShowWeekday.Name = "checkBoxShowWeekday";
			this.checkBoxShowWeekday.Size = new System.Drawing.Size(175, 29);
			this.checkBoxShowWeekday.TabIndex = 3;
			this.checkBoxShowWeekday.Text = "Show weekday";
			this.checkBoxShowWeekday.UseVisualStyleBackColor = true;
			this.checkBoxShowWeekday.CheckedChanged += new System.EventHandler(this.checkBoxShowWeekday_CheckedChanged);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "notifyIcon1";
			this.notifyIcon.Visible = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(278, 298);
			this.Controls.Add(this.checkBoxShowWeekday);
			this.Controls.Add(this.buttonHideControls);
			this.Controls.Add(this.checkBoxShowDate);
			this.Controls.Add(this.labelTime);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Clock VPD_311";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox checkBoxShowDate;
		private System.Windows.Forms.Button buttonHideControls;
		private System.Windows.Forms.CheckBox checkBoxShowWeekday;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTopmost;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowControls;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowDate;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowWeekday;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChooseFont;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemColors;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBackgroundColor;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemForegroundColor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoadOnWindowsStartup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
	}
}

