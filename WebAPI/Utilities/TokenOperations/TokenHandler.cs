using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Utilities.TokenOperations.Model;

namespace WebAPI.Utilities.TokenOperations
{
    public class TokenHandler
    {

        private IConfiguration Configuration;

        public TokenHandler(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        public Token CreateAccessToken()
        {
            Token tokenModel = new Token();

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:SecurityKey"]));
            SigningCredentials credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

            tokenModel.Expiration = DateTime.Now.AddMinutes(5);

            JwtSecurityToken jwtToken = new JwtSecurityToken(
                
                audience : Configuration["Token:Audience"],
                issuer   : Configuration["Token:Issuer"],
                expires  : tokenModel.Expiration,
                signingCredentials : credentials,
                notBefore : DateTime.Now
                );

            JwtSecurityTokenHandler jwtTokenHandler = new JwtSecurityTokenHandler();
            tokenModel.AccessToken = jwtTokenHandler.WriteToken(jwtToken);

            return tokenModel;

        } 

    }
}
