using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI5.Controllers
{
    [RoutePrefix("api/manager")]
    public class ManagerController : ApiController
    {
        [HttpGet]

        [Route("getAll")]
        public IHttpActionResult getallmanager()
        {
            return Ok(BLL.BLLmanager.getallmanager());
        }

        [HttpPost]
        [Route("Add")]
        public IHttpActionResult AddManager(DTO.manager m1)
        {

            return Ok(BLL.BLLmanager.AddManager(m1));

        }
    }
}
