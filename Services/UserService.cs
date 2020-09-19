using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.User;
using Web.Blazor.Models.User.Results;

namespace Web.Blazor.Services
{
    public class UserService : IUserService
    {
        private readonly string _url;
        private readonly ApiClient _http;

        public UserService(string url, ApiClient http)
        {
            this._url = url;
            this._http = http;
        }
        public async Task<abpResponse<string>> ChangeLanguage(ChangeUserLanguageDto languageName)
        {
            var response = await _http.PostAsync<abpResponse<string>>($"{_url}/api/services/app/User/ChangeLanguage", languageName);
            return response;
        }

        public async Task<abpResponse<bool?>> ChangePassword(ChangePasswordDto changePasswordDto)
        {
            var response = await _http.PostAsync<abpResponse<bool?>>($"{_url}/api/services/app/User/ChangePassword", changePasswordDto);
            return response;
        }

        public async Task<abpResponse<UserResult>> Create(CreateUserDto User)
        {
            var response = await _http.PostAsync<abpResponse<UserResult>>($"{_url}/api/services/app/User/Create", User);
            return response;
        }

        public async Task<abpResponse<string>> Delete(int id)
        {
            var response = await _http.DeleteAsync<abpResponse<string>>($"{_url}/api/services/app/User/Delete",id);
            return response;
        }

        public async Task<abpResponse<UserResult>> Get(int id)
        {
            var response = await _http.GetAsync<abpResponse<UserResult>>($"{_url}/api/services/app/User/Get?id={id}");
            return response;
        }

        public async Task<abpResponse<GetAllResult>> GetAll(string keyword, int skipCount, int MaxResultCount)
        {
            var response = await _http.GetAsync<abpResponse<GetAllResult>>($"{_url}/api/services/app/User/GetAll?Keyword={keyword}&SkipCount={skipCount}&MaxResultCount={MaxResultCount}");
            return response;
        }

        public async Task<abpResponse<GetRolesResult>> GetRoles()
        {
            var response = await _http.GetAsync<abpResponse<GetRolesResult>>($"{_url}/api/services/app/User/GetRoles");
            return response;
        }

        public async Task<abpResponse<bool?>> ResetPassword(ResetPasswordDto resetPasswordDto)
        {
            var response = await _http.PostAsync<abpResponse<bool?>>($"{_url}/api/services/app/User/ResetPassword", resetPasswordDto);
            return response;
        }

        public async Task<abpResponse<UserResult>> Update(UserResult User)
        {
            var response = await _http.PutAsync<abpResponse<UserResult>>($"{_url}/api/services/app/User/Update", User);
            return response;

        }
    }
}
