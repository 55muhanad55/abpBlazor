using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.User;
using Web.Blazor.Models.User.Results;

namespace Web.Blazor.Services
{
    public interface IUserService
    {
        public Task<abpResponse<UserResult>> Create(CreateUserDto User);
        public Task<abpResponse<UserResult>> Update(UserResult User);
        public Task<abpResponse<string>> Delete(int id);
        public Task<abpResponse<GetRolesResult>> GetRoles();
        public Task<abpResponse<UserResult>> Get(int id);
        public Task<abpResponse<string>> ChangeLanguage(ChangeUserLanguageDto languageName);
        public Task<abpResponse<bool?>> ChangePassword(ChangePasswordDto changePasswordDto);
        public Task<abpResponse<bool?>> ResetPassword(ResetPasswordDto resetPasswordDto);
        public Task<abpResponse<GetAllResult>> GetAll(string keyword, int skipCount, int MaxResultCount);

    }
}
