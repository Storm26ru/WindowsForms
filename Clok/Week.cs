using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clok
{
	public class Week
	{
		byte days=0;
		public Week(bool[]days)
		{
			for(byte i =0; i<days.Length;i++)
			{
				if (days[i]) this.days |= (byte)(1 << i);
			}
		}
		public override string ToString()
		{
			string Weekdays = "";
			for(byte i = 0; i<7;i++)
			{
				if ((days & (1 << i)) != 0)
				{
					if (i == 6) Weekdays += $"{(DayOfWeek)(i - 6)}";
					else Weekdays += $"{(DayOfWeek)(i + 1)} ";
				}
			}
			return Weekdays;
		}
		
	}
}
