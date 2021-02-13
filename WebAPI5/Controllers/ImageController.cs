using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI5.Models;
namespace WebAPI5.Controllers
{
    [RoutePrefix("api/image")]
    public class ImageController : ApiController
    {
        public static List<Image> LImages = new List<Image>();
        
        [HttpGet]
        [Route("ga")]
        public IHttpActionResult getall()
        {
            LImages.Add(new Image() { src = "df", file = 456789 });
            return Ok(LImages);
        }
        [HttpPost]
        [Route("add")]   
        
        public IHttpActionResult uploadImage(Image IMG)
        {
            LImages.Add(IMG);
            var res=LImages.ToArray().LastOrDefault();
            return Ok(res);
           


        }
    }
}
