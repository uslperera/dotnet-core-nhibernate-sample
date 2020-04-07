using DotNetCoreNHibernateSample.Core.Models;
using NHibernate;
using NHibernate.Mapping.ByCode.Conformist;

namespace DotNetCoreNHibernateSample.Data.Configurations
{
    public class PersonMapping: ClassMapping<Person>
    {
        public PersonMapping()
        {
            Id(x => x.Id, x =>
            {
                x.Type(NHibernateUtil.Int64);
                x.Column("id");
            });

            Property(p => p.SSN, p =>
            {
                p.Type(NHibernateUtil.StringClob);
                p.NotNullable(false);
                p.Column("ssn");
            });

            Property(p => p.FirstName, p =>
            {
                p.Type(NHibernateUtil.StringClob);
                p.NotNullable(false);
                p.Column("firstname");
            });

            Property(p => p.LastName, p =>
            {
                p.Type(NHibernateUtil.StringClob);
                p.NotNullable(false);
                p.Column("lastname");
            });

            Table("person");
        }
    }
}
