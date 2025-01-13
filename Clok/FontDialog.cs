using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
		public string FonthPath { get => fonts_path; }
		public string FontFilename { get; set; }
		public Font Font { get; set; }
		public FontDialog()
		{
			InitializeComponent();
			
			execution_path = Path.GetDirectoryName(Application.ExecutablePath);
			fonts_path = $"{execution_path}\\..\\..\\Fonts";
			LoadFonts();
		}
		void LoadFonts()
		{

			
		}
	}
}
