using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace myWebApiApp.Controllers
{
    public class TestDataController : ApiController
    {
        static Dictionary<string, Object> dataList = new Dictionary<string, object>();
        // GET: api/TestData
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(dataList);
        }

        // GET: api/TestData/5
        [HttpGet]
        public IHttpActionResult Get(string key)
        {
            return Ok(dataList[key]);
        }

        // POST: api/TestData?key=5
        [HttpPost]
        public IHttpActionResult Post(string key, [FromBody]object value)
        {
            dataList.Add(key, value);
            return Ok(true);
        }

        // PUT: api/TestData/5
        [HttpPut]
        public IHttpActionResult Put(string key, [FromBody]object value)
        {
            dataList[key] = value;
            return Ok(true);
        }

        // DELETE: api/TestData/5
        [HttpDelete]
        public IHttpActionResult Delete(string key)
        {
            dataList.Remove(key);
            return Ok(true);
        }
    }
}
