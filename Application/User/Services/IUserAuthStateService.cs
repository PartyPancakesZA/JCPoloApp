using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User.Services
{
    public interface IUserAuthStateService
    {
        public Task<IResponse> SetCurrentUserAsync(IResponse loginResponse);
    }
}
