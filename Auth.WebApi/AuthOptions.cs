using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Auth.WebApi
{
    public class AuthOptions
    {
        public const string ISSUER = "OcelotApiGateway"; 
        public const string AUDIENCE = "OcelotApiGateway"; 
        const string KEY = "mysupersecret_secretkey!123"; 
        public const int LIFETIME = 1440; 
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
