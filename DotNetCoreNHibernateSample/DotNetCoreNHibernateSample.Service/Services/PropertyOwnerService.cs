using DotNetCoreNHibernateSample.Core.Models;
using DotNetCoreNHibernateSample.Data.Core;

namespace DotNetCoreNHibernateSample.Service.Services
{
    public class PropertyOwnerService
    {
        private IUnitOfWork _unitOfWork;
        public PropertyOwnerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Person GetPropertyOwner(long id)
        {
            var person = _unitOfWork.PersonRepository.Get(id);
            return person;
        }
    }
}
