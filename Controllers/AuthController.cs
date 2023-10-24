using DineWise.Data.DTO;
using DineWise.Data.Models;
using DineWise.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DineWise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IUserRepository userRepository;
        private readonly ITokenHandler tokenHandler;

        public AuthController(UserManager<User> userManager,IUserRepository userRepository, ITokenHandler tokenHandler)
        {
            this.userManager = userManager;
            this.userRepository = userRepository;
            this.tokenHandler = tokenHandler;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> RegisterAsync(RegisterRequestDto registerRequest)
        {
            var identityUser = new User
            {
                UserName = registerRequest.Username,
                Email = registerRequest.Email,
                PhoneNumber = registerRequest.Phonenumber,
                FirstName = registerRequest.FirstName,
                LastName = registerRequest.LastName


            };
            var identityResult = await userManager.CreateAsync(identityUser, registerRequest.Password);
            if(identityResult.Succeeded)
            {
                var roleIdentityResult = await userManager.AddToRoleAsync(identityUser, "User");
                if(roleIdentityResult.Succeeded)
                {
                    return Ok("Noice");
                }
                return BadRequest(roleIdentityResult);

            }

            return BadRequest(identityResult);

        }

        //[HttpPost]
        //[Route("login")]
        //public async Task<IActionResult> LoginAsync(LoginRequestDto loginRequest)
        //{
        //    //make sure neither inputs are empty
        //    if(loginRequest.Username == "" || loginRequest.Password== "" ) { 
        //        return BadRequest("Please Enter Valid Username & Password");
        //    }
        //    //check if user is authenticated
        //    //match username and password
        //    var user = await userRepository.AuthenticateAsync(
        //        loginRequest.Username, loginRequest.Password);

        //    if (user!=null) {
        //        //generate jwt token
        //        return Ok(await tokenHandler.CreateTokenAsync(user));
        //    }

        //    return BadRequest("Username or Password Incorrect");
        //}
    }
}
