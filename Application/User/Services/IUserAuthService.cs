using Application.Response;
using Application.User.Dtos.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Services
{
    public interface IUserAuthService
    {
        public Task<IResponse> LoginUserAsync(UserLoginRequest request);
    }
}
