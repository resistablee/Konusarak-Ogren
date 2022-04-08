using KonusarakOgren.Entity.Contract;
using KonusarakOgren.Entity.SqlLiteKonusarakOgren.Entities.User;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Business.Auth
{
    public class JwtManager
    {
        private readonly string _key = "Karabiberim vur kadehlere hadi içelim, içelim her gece zevki sefa, doldu gönmlüme. Hadi içelim, acıların yerine...";
        public AccessTokenContract Generate(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(_key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                    //Token içerisinde aşağıdaki bilgiler tutulacak.
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.FirstName),
                    new Claim(ClaimTypes.Surname, user.LastName),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, user.Type.ToString() ?? String.Empty),
                }),
                Expires = DateTime.UtcNow.AddMinutes(15), //Tokenımın yaşam süresi 15 dk olsun

                //key ve keyin şifreleme algoritması
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = (JwtSecurityToken)tokenHandler.CreateToken(tokenDescriptor);

            return new AccessTokenContract
            {
                AccessToken = token.RawData,
                ExpiresIn = token.Payload.Exp,
                RefreshToken = GenerateRefreshToken(),
                RefreshTokenExpireDate = DateTime.UtcNow.AddMinutes(15)
            };
        }

        private static string GenerateRefreshToken()
        {
            var number = new byte[32];
            using var random = RandomNumberGenerator.Create();
            random.GetBytes(number);
            return Convert.ToBase64String(number);
        }
    }
}
