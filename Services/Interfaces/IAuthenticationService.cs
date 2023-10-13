using DataAccessLayer_DAL_;
using DataAccessLayer_DAL_.Auth;


namespace BussinessLayer;

public interface IAuthenticationService
{
    public Task<Response> UserRegister( Register_Model Model);
    public Task<TokenDto> Login(Login_Model Model);


}
