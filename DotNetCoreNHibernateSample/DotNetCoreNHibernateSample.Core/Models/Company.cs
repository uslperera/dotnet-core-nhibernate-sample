using System;
using System.Collections.Generic;

namespace DotNetCoreNHibernateSample.Core.Models
{
    public class Company
    {
		public virtual long Id { get; set; }
		public virtual long OrganizationNumber { get; set; }
		public virtual string Name { get; set; }
		public virtual string Address { get; set; }

		public List<Property> Plants { get; set; }
	}
}
