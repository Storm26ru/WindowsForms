using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clok
{
	class Alarm
	{
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public Week Week { get; set; }
		public string Filename { get; set; }
		public string Message { get; set; }

		public Alarm(DateTime date,TimeSpan time,Week week,string filename, string message)
		{
			Date = date;
			Time = time;
			Week = week;
			Filename = filename;
			Message = message;
		}
		public override string ToString()
		{
			string textline = "";
			if (Date != DateTime.MinValue) textline += $"{Date}\t";
			textline += DateTime.Today.Add(Time).ToString("hh:mm:ss tt");
			textline += $"{Week}\t";
			textline += $"{Filename}\t";
			textline += $"{Message}";
			return textline;
		}
	}
}
