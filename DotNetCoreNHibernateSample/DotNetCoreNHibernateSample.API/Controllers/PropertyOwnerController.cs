using System.Collections.Generic;
using DotNetCoreNHibernateSample.Core.Models;
using DotNetCoreNHibernateSample.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreNHibernateSample.API.Controllers
{
    [Route("api/propertyowners")]
    public class PropertyOwnerController : Controller
    {
        private PropertyOwnerService _propertyOwnerService;

        public PropertyOwnerController(PropertyOwnerService propertyOwnerService)
        {
            _propertyOwnerService = propertyOwnerService;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _propertyOwnerService.GetPropertyOwner(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
