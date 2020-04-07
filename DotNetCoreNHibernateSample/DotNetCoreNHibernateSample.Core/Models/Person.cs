using System;
using System.Collections.Generic;

namespace DotNetCoreNHibernateSample.Core.Models
{
    public class Person
    {
		public virtual long Id { get; set; }
		public virtual string SSN { get; set; }
		public virtual string FirstName { get; set; }
		public virtual string LastName { get; set; }

		public virtual List<Property> Properties { get; set; }
	}
}
