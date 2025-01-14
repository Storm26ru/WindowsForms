﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clok
{
	public partial class FontDialog : Form
	{
		string execution_path = "";
		string fonts_path = "";
		PrivateFontCollection pfc;
		public string FonthPath { get => fonts_path; }
		public string FontFilename { get; set; }
		public Font Font { get; set; }
		public FontDialog()
		{
			InitializeComponent();
			//pfc = new PrivateFontCollection();
			execution_path = Path.GetDirectoryName(Application.ExecutablePath);
			fonts_path = $"{execution_path}\\..\\..\\Fonts";
			LoadFonts();
		}
		void LoadFonts()
		{
			comboBoxFonts.Items.AddRange(GetFontsFromDirectory(fonts_path, "*.ttf"));
			comboBoxFonts.Items.AddRange(GetFontsFromDirectory(fonts_path, "*.otf"));
			comboBoxFonts.SelectedIndex = 0;	
		}
		string[] GetFontsFromDirectory(string directory,string format)
        {
			string[] fonts = Directory.GetFiles(directory, format);
			for (int i = 0; i < fonts.Length; i++) fonts[i] = fonts[i].Split('\\').Last();
			return fonts;
        }
		void SetFont()
        {
			//PrivateFontCollection pfc= new PrivateFontCollection();
			pfc = new PrivateFontCollection();
			pfc.AddFontFile($"{fonts_path}\\{comboBoxFonts.SelectedItem}");
			labelExample.Font = new Font(pfc.Families[0], Convert.ToInt32(numericUpDownFontSize.Value));
        }

        private void comboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
			SetFont();
        }
    }
}
