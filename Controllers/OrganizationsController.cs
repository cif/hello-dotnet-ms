using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hello_dotnet_ms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        // GET api/organizations
        [HttpGet]
        public ActionResult<IEnumerable<int>> Get()
        {
            return new int[] {1, 2};
        }

        // GET api/organizations/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/organizations
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/organizations/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/organizations/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
