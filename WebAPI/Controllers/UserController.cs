using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Utilities.TokenOperations;
using WebAPI.Utilities.TokenOperations.Model;

namespace WebAPI.Controllers
{
    [Route("[controller]s")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private IConfiguration Configuration;

        public UserController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet("connect/token")]
        public ActionResult<Token> GetToken()
        {
            TokenHandler tokenHandler = new TokenHandler(Configuration);

            return tokenHandler.CreateAccessToken();
        } 

    }
}
