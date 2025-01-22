using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clok
{
	public class Alarm
	{
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public Week Week { get; set; }
		public string Filename { get; set; }
		public string Message { get; set; }

		public Alarm()
		{
			Date = DateTime.MinValue;
		}
		public Alarm(DateTime date,TimeSpan time,Week week,string filename, string message)
		{
			Date = date;
			Time = time;
			Week = week;
			Filename = filename;
			Message = message;
		}
		public Alarm(Alarm other) : this(other.Date, other.Time, other.Week, other.Filename, other.Message) { }

		public override string ToString()
		{
			string textline = "";
			if (Date != DateTime.MinValue) textline += $"{Date.ToString("yyyy.MM.d")}\t";
			textline += DateTime.Today.Add(Time).ToString("hh:mm:ss tt")+"\t";
			textline += $"{Week}\t";
			textline += $"{Filename}\t";
			textline += $"{Message}";
			return textline;
		}
	}
}
