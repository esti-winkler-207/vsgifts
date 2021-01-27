using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI5.Controllers
{
    [RoutePrefix("api/Products")]
    public class ProductsController : ApiController
    {
        [HttpGet]
        [Route("getAll")]
        public IHttpActionResult getAllproducts()
        {
            return Ok(BLL.BLLproducts.getAllproducts());
        }
    }
}
