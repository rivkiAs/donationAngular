using Association.API.NewFolder;
using Association.Core.Entities;
using Association.Core.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Association.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KerenController : ControllerBase
    {
        // GET: api/<KerenController>
        private readonly IKerenService _IKerenServiceObject;
      

        public KerenController(IKerenService IKerenServiceObject)
        {
            this._IKerenServiceObject = IKerenServiceObject;
        }
        // GET: api/<DonationTypeController>
        [HttpGet]
        public IEnumerable<keren> Get()
        {
            return _IKerenServiceObject.Get();
        }

        // GET api/<DonationController>/5
        [HttpGet("{id}")]
        public keren Get(int id)
        {
            return _IKerenServiceObject.Get(id);
        }

        // POST api/<DonationController>
        [HttpPost]
        public keren Post([FromBody] KerenPostModel value)
        {
            keren nKeren = new keren
            {
                CatalogNumber=value.CatalogNumber,
                Description=value.Description,
                Percent=value.Percent,
                Target=value.Target
            };

            _IKerenServiceObject.Post(nKeren);
            return nKeren;
        }

        // PUT api/<DonationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] KerenPostModel value)
        {
            keren nKeren = new keren
            {
                CatalogNumber = value.CatalogNumber,
                Description = value.Description,
                Percent = value.Percent,
                Target = value.Target
            };
            _IKerenServiceObject.Put(id, nKeren);
        }

        // DELETE api/<DonationController>/5
        [HttpDelete("{id}")]
        public keren Delete(int id)
        {
            keren nKeren = new keren
            {
                CatalogNumber = 0,
                Description ="bla",
                Percent = 0,
                Target = 0
            };
            _IKerenServiceObject.Delete(id);
            return nKeren;
        }
    }
}
