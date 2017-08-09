﻿using System.Collections.Generic;
using System.Web.Http;

namespace WebApi_MyGet.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: api/Default
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// The GET on DefaultController
        /// </summary>
        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// The POST on DefaultController
        /// </summary>
        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
