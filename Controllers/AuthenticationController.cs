using BussinessLayer;
using DataAccessLayer_DAL_;
using DataAccessLayer_DAL_.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.Management.Service.Data_Access_Layer__DAL_.Models;
using IAuthenticationService = BussinessLayer.IAuthenticationService;

namespace Online_Recruitment_Platform_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService AuthenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            this.AuthenticationService = authenticationService;
        }

      


        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] Login_Model Model)
        {


            var Result = await AuthenticationService.Login(Model);

            if (Result != null)
                return Ok(Result);
            // if problem occured
            return StatusCode(StatusCodes.Status500InternalServerError, Result);
        }

        [HttpPost]
        [Route("signup")]
        public async Task<ActionResult<TokenDto>> SignUp(Register_Model Model)
        {
            var registrationResult = await AuthenticationService.UserRegister(Model);

            if (registrationResult.Status.Equals("Success"))
            {
                // Generate a JWT token for the newly registered user
                var loginResult = await AuthenticationService.Login(new Login_Model
                {
                    Username = Model.Username,
                    Password = Model.Password
                });

                if (loginResult != null)
                {
                    // Return the JWT token or whatever response you need for a successful login
                    return Ok(loginResult);
                }
                else
                {
                    // Handle login failure
                    return StatusCode(StatusCodes.Status500InternalServerError, "Login failed");
                }
            }
            else
            {
                // Handle registration failure
                return StatusCode(StatusCodes.Status500InternalServerError, registrationResult);
            }
        }


    }
}
