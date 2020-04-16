using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Storeman.Models;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Storeman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        //Constructor
        public AccountController(UserManager<User> userManager,
                SignInManager<User> signInManager,
                IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [EnableCors("AllowOrigin")]
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUser registration)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            User newUser = new User
            {
                Email = registration.Email,
                UserName = registration.Email,
                Id = registration.Email,
            };
            IdentityResult result = await _userManager.CreateAsync(newUser,
            registration.Password);
            var user = await _userManager.FindByEmailAsync(registration.Email);
            if (registration.Email.Contains("admin"))
            {
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            await _userManager.AddClaimAsync(user,
            new Claim("Registration-Date", DateTime.UtcNow.ToString("MM-dd-yy")));
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return Ok(result);
        }
        [EnableCors("AllowOrigin")]
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<SuccessfulLoginResult>> Login([FromBody] LoginUser login)
        {
            SignInResult result = await
            _signInManager.PasswordSignInAsync(login.Email,
            login.Password,
            isPersistent: false, lockoutOnFailure: false);
            if (!result.Succeeded)
            {
                return Unauthorized();
            }
            User user = await
            _userManager.FindByEmailAsync(login.Email);
            JwtSecurityToken token = await GenerateTokenAsync(user);
            //defined
            string serializedToken = new
            JwtSecurityTokenHandler().WriteToken(token); //serialize the token
            return Ok(new SuccessfulLoginResult()
            {
                Token = serializedToken
            });
        }
        private async Task<JwtSecurityToken> GenerateTokenAsync(User user)
        {
            var claims = new List<Claim>()
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(ClaimTypes.NameIdentifier, user.Id),
                    new Claim(ClaimTypes.Name, user.UserName),
                };
            var userClaims = await _userManager.GetClaimsAsync(user);
            claims.AddRange(userClaims);
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            // Loading the user Claims
            var expirationDays = _configuration.GetValue<int>
                ("JWTConfiguration:TokenExpirationDays");
            var siginingKey =
                Encoding.UTF8.GetBytes(_configuration.GetValue<string>
                ("JWTConfiguration:SigningKey"));
            var token = new JwtSecurityToken
                (
                issuer: _configuration.GetValue<string>
                ("JWTConfiguration:Issuer"),
                audience: _configuration.GetValue<string>
                ("JWTConfiguration:Audience"),
                claims: claims,
                expires:
                DateTime.UtcNow.Add(TimeSpan.FromDays(expirationDays)),
                notBefore: DateTime.UtcNow,
                signingCredentials: new SigningCredentials(new
                SymmetricSecurityKey(siginingKey),
                SecurityAlgorithms.HmacSha256)
                );
            return token;
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet("Email")]
        public ActionResult<string> GetEmail()
        {
            return Ok(User.Identity.Name);
        }
    }
}
