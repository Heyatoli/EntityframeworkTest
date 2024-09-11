using EntityFrameWorkTest.DataContracts;
using EntityFrameWorkTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWorkTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService) 
        {
            this.userService = userService;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet("")]
        public ICollection<UserDTO> GetAll()
        {
            return userService.GetUsers();
        }

        [HttpPost]
        public long Post([FromBody] UserDTO user)
        {
            return userService.AddUser(user);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] UserDTO user)
        {
            //userService.Up
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            userService.DeleteUser(id);
        }
    }
}
