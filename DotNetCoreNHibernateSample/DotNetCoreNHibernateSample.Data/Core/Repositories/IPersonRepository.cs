using DotNetCoreNHibernateSample.Core.Models;

namespace DotNetCoreNHibernateSample.Data.Core.Repositories
{
    public interface IPersonRepository: IRepository<Person, long>
    {
    }
}
