using Association.API.NewFolder;
using Association.Core.Entities;
using Association.Core.IRepositories;
using Association.Core.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Association.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICitiesService _IcitiesServiceObject;

        public CitiesController(ICitiesService IcitiesServiceObject)
        {
            this._IcitiesServiceObject = IcitiesServiceObject;
        } 


        [HttpGet]
        public List<Cities> Get()
        {
            return _IcitiesServiceObject.Get();
        }

        // GET api/<CitiesController>/5
        [HttpGet("{id}")]
        public Cities Get(int id)
        {
           return _IcitiesServiceObject.Get(id);
        }

        // POST api/<CitiesController>
        [HttpPost]
        public void Post([FromBody] CitiesPostModel value)
        {
            Cities nCity = new Cities { CityName = value.CityName };
            _IcitiesServiceObject.Post(nCity);
        }

        // PUT api/<CitiesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CitiesPostModel value)
        {
            Cities nCity = new Cities { CityName = value.CityName };
            _IcitiesServiceObject.Put(id, nCity);
        }

        // DELETE api/<CitiesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _IcitiesServiceObject.Delete(id);
        }
    }
}
