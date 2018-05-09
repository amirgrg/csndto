using System.Collections.Generic;
using csn.dto.vehicle.Repository;
using Microsoft.AspNetCore.Mvc;

namespace csn.dto.vehicle.Controllers
{
    /// <inheritdoc />
    [Route("api/[controller]")]
    public class VehicleController : Controller
    {
        private readonly IVehicleRepository _repo;

        /// <inheritdoc />
        public VehicleController(IVehicleRepository repo)
        {
            _repo = repo;
        }


        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //_repo.Add();
            return "value";
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
