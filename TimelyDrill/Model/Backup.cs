using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimelyDrill.Model
{
	public class Backup
	{
		public string DestinationPath { get; set; }

		public DateTime Time { get; set; }

		public override string ToString()
		{
			return Time.ToString("yyyy-MM-d--HH-mm-ss");
		}

	}
}
