using System;
using System.Collections.Generic;
using System.Net;
using csn.dto.vehicle.Models.Vehicle;
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
        public string Get(Guid id)
        {
            _repo.ListIdData(id);
            return "value";
        }

        // POST api/values
        [HttpPost]
        [Route("PostVehicle")]
        public ContentResult Post([FromBody]Vehicle data)
        {
            if (data == null)
            {
                return new ContentResult
                {
                    StatusCode = (int)HttpStatusCode.BadRequest,
                    ContentType = Request.ContentType,
                    Content = "Empty data is not cool"
                };
            }
           var result = _repo.Save(data);
            return new ContentResult
            {
                Content = result.ToString(),
                StatusCode = (int)HttpStatusCode.OK,
                ContentType = Request.ContentType
            };
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
