using DataAccessLayer_DAL_;
using DataAccessLayer_DAL_.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using User.Management.Service.Data_Access_Layer__DAL_.Models;

namespace BussinessLayer;

    public class AuthenticationService : IAuthenticationService
    {
    //public UserManager<Employee_Model> EmployeeManager { get; }
    //public UserManager<Compuny_Model> CompunyManager { get; }
    public UserManager<UserModel> UserManager { get; }
    public RoleManager<IdentityRole> RoleManager { get; }
    public IConfiguration Configuration { get; }

    public AuthenticationService( RoleManager<IdentityRole> roleManager, UserManager<UserModel> userManager , IConfiguration configuration)
    {
        UserManager = userManager;
        RoleManager = roleManager;
        Configuration = configuration;
    }





    public async  Task<Response> UserRegister(Register_Model Model)
    {

        var test = await UserManager.FindByNameAsync(Model.Username);
        var User_Exists = await UserManager.FindByNameAsync(Model.Username);
        if (User_Exists != null)

            return  new Response { Status = "Error", Message = "The User Already Exist " };


        UserModel user = new()
        {
            Email = Model.Email,
            SecurityStamp = Guid.NewGuid().ToString(),
            UserName = Model.Username,

        };
        var result = await UserManager.CreateAsync(user, Model.Password);


        if (!result.Succeeded)
        {
            string ErrorsMassege = string.Join("\n", result.Errors.Select(e => e.Description));


            Response Response = new Response() { Status = "Error", Message = ErrorsMassege };

            return  Response;
        }



        return new Response { Status = "Success", Message = "User created successfully!" };


    }






    public async Task<TokenDto> Login(Login_Model Model)
    {
 

        var User = await UserManager.FindByNameAsync(Model.Username);
        if (User != null && await UserManager.CheckPasswordAsync(User, Model.Password))
        {
            var UserRoles = await UserManager.GetRolesAsync(User);

            // Assign Claims To Logged User 
            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, User.UserName),
                    new Claim(ClaimTypes.Email , User.Email),
                    new Claim(ClaimTypes.NameIdentifier , User.Id)
                };

            User.LastLoginTime = DateTime.Now;

            // Assign All Roles In dataBase THat Related TO THe Logged User in Claims 

            foreach (var userRole in UserRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }

            var token = GetToken(authClaims);

            return new TokenDto()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = token.ValidTo
            };
        }
        return null;

    }






    

    private JwtSecurityToken GetToken(List<Claim> authClaims)
    {
        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]));

        var token = new JwtSecurityToken(
            expires: DateTime.Now.AddHours(3),
            claims: authClaims,
            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );

        return token;
    }
}

