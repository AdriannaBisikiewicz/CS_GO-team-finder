using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS_GO.Domain.Model;
using CS_GO.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    [Route ("api/[controller]")]
    public class ValuesController : Controller {

        private IUserService _userService;

        public ValuesController (IUserService userService) {
            _userService = userService;
        }

        [HttpGet ("GetUsers")]
        public IList<User> GetAllUsers () {
            return _userService.GetAllUsers();
        }

        [HttpPost]
        [Route ("[action]")]
        public void AddUser ([FromBody]User user) {
            _userService.AddUser (user);
        }
    }
}