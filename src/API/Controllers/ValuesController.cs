﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS_GO.Domain.Model;
using CS_GO.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private IUserService _userService;
        public ValuesController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAuthor/{surname}")]
        public User GetAuthorBySurname(string surname)
        {
            return _userService.GetBySurname(surname);
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
