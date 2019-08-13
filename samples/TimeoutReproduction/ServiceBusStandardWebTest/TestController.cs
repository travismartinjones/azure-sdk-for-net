using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServiceBusStandardWebTest
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public string Get()
        {
            var response = WebRequest.CreateHttp("http://www.microsoft.com/").GetResponse();
            var stream = response.GetResponseStream();
            var reader = new StreamReader(stream);
            return reader.ReadToEnd().Substring(0,100);
        }        
    }
}
