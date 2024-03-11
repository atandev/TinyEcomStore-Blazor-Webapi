using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TinyEcomStore.Models.Response;

namespace TinyEcomStore.Server.Jwt
{
    public class JwtHandle
    {
        private readonly IConfiguration _configuration;
        private readonly IConfigurationSection _jwtSetting;

        public JwtHandle(IConfiguration configuration)
        {
            _configuration = configuration;
            _jwtSetting = _configuration.GetSection("JwtSettings");
        }
        public SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_jwtSetting.GetSection("securityKey").Value);
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        public List<Claim> GetClaims(AuthUserResponse user)
        {
            var claims = new List<Claim>()
            {
                new Claim("Id", user.Id.ToString()),
                new Claim("Username", user.Username),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.GivenName, $"{user.Firstname} {user.Lastname}"),
                new Claim(ClaimTypes.Role, user.Role)
            };
            return claims;
        }
        public JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken(
                issuer: _jwtSetting["validIssuer"],
                audience: _jwtSetting["validAudience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_jwtSetting["expiryInMinutes"])),
                signingCredentials: signingCredentials
                );
            return tokenOptions;
        }
    }
}
