using Application.Response;
using Application.User.Dtos.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Services
{
    public interface IUserRepositoryService
    {
        public Task<IResponse> RegisterUserAsync(UserRegisterRequest request);
    }
}
