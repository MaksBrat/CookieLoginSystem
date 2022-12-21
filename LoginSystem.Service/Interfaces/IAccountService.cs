using LoginSystem.Domain.Respose;
using LoginSystem.Domain.ViewModel.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Service.Interfaces
{
    public interface IAccountService
    {
        Task<IBaseResponse<ClaimsIdentity>> Register(RegisterViewModel model);
        Task<IBaseResponse<ClaimsIdentity>> Login(LoginViewModel model);
    }
}
