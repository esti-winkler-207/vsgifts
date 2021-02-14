using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI5.Controllers
{
    [RoutePrefix("api/parents")]
    public class ParentsController : ApiController
    {
        [HttpPost]
        [Route("addParent")]
        public IHttpActionResult addParent(DTO.parents p)
        {
            return Ok(BLL.BLLparents.addParent(p));
        }
    }
}
