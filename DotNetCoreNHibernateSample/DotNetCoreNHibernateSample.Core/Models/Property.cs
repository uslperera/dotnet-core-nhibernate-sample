using System;
using System.Collections.Generic;

namespace DotNetCoreNHibernateSample.Core.Models
{
    public class Property
    {
		public virtual long Id { get; set; }
		public virtual string Address { get; set; }
		public virtual int Knr { get; set; }
		public virtual int Gnr { get; set; }
		public virtual int Bnr { get; set; }
		public virtual int Fnr { get; set; }
		public virtual int Snr { get; set; }

		public List<Person> Owners { get; set; }
		public List<Company> Companies { get; set; }
	}
}
