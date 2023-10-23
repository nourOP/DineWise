using DineWise.Data.DTO;
using DineWise.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DineWise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly ITokenHandler tokenHandler;

        public AuthController(IUserRepository userRepository, ITokenHandler tokenHandler) 
        {
            this.userRepository = userRepository;
            this.tokenHandler = tokenHandler;
        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync(LoginRequestDto loginRequest)
        {
            //make sure neither inputs are empty
            if(loginRequest.Username == "" || loginRequest.Password== "" ) { 
                return BadRequest("Please Enter Valid Username & Password");
            }
            //check if user is authenticated
            //match username and password
            var user = await userRepository.AuthenticateAsync(
                loginRequest.Username, loginRequest.Password);

            if (user!=null) {
                //generate jwt token
                return Ok(await tokenHandler.CreateTokenAsync(user));
            }

            return BadRequest("Username or Password Incorrect");
        }
    }
}
