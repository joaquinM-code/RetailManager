﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RMDataManager.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values return string array
        public IHttpActionResult Get()
        {
            string userID = RequestContext.Principal.Identity.GetUserId();
            return Ok(new string[] { "value1", "value2", userID });
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}