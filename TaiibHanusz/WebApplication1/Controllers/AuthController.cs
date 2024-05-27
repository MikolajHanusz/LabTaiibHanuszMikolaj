using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost, Route("login")]
        public IActionResult Login([FromQuery]String user, String pass)
        { 
            if( user == null || pass == null) 
            {
                return BadRequest("Invlaid client");
            }
            if(user == "login" && pass == "pass")
            {
                var secretkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("sadsadsadhytsfuysdgfuysgrygsduyfgwuegiuweehfuyhwsfuihbweyfhiwuehfiuwehfiuwehfiuhwefiuhwefiu"));
                var signingCredentials = new SigningCredentials(secretkey, SecurityAlgorithms.HmacSha256);
                var tokenOptions = new JwtSecurityToken(
                    issuer:"http://localhost:5000",
                    audience: "http://localhost:5000",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signingCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok( new { Token = tokenString } );
            }
            return Unauthorized();
        }
    }
}
