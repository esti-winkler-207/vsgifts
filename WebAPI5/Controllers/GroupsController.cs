using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI5.Controllers
{
    [RoutePrefix("api/Groups")]
    public class GroupsController : ApiController
    {
        [HttpGet]

        [Route("getAll")]
        public IHttpActionResult getallgroups()
        {
            return Ok(BLL.BLLgroups.getallgroups());
        }
        [HttpGet]
        [Route("getByPwd/{pwd}")]
        public IHttpActionResult getByPwd(string pwd)
        {
            return Ok(BLL.BLLgroups.getByPwd(pwd));

        }
        
        //[HttpPost]
        //[Route("Addgroup")]
        
        //public IHttpActionResult Addgroup(DTO.groups g1)
        //{

        //    return Ok(BLL.BLLgroups.Addgroup(g1));

        //}
        [HttpPost]
        [Route("update/")]
        public IHttpActionResult updateGroup(DTO.groups g)
        {
            return Ok(BLL.BLLgroups.updateGroup(g));
        }
    }
}
