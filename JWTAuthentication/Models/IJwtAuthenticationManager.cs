
namespace JWTAuthentication.Models
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string UserName, string Password);
    }
}
