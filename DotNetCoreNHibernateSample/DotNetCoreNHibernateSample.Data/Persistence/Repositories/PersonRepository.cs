using DotNetCoreNHibernateSample.Core.Models;
using DotNetCoreNHibernateSample.Data.Core.Repositories;
using NHibernate;

namespace DotNetCoreNHibernateSample.Data.Persistence.Repositories
{
    public class PersonRepository:Repository<Person, long>, IPersonRepository
    {
        public PersonRepository(ISession session): base(session)
        {
        }
    }
}
