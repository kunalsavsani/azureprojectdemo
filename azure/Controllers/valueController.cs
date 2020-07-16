﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace azure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class valueController : ControllerBase
    {
        // GET: api/value
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "azure", "project" };
        }

        // GET: api/value/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/value
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/value/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
