using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clok
{
	class Week
	{
		byte days=0;
		public Week(bool[]days)
		{
			for(byte i =0; i<days.Length;i++)
			{
				if (days[i]) this.days |= (byte)(1 << i);
			}
			Console.WriteLine(Convert.ToString(this.days));
		}
	}
}
