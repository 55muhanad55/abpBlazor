using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.Roles;
using Web.Blazor.Models.Roles.Results;

namespace Web.Blazor.Services
{
    public class RoleService : IRoleService
    {
        private readonly string _url;
        private readonly ApiClient _http;

        public RoleService(string url, ApiClient http)
        {
            this._url = url;
            this._http = http;
        }
        public async Task<abpResponse<RoleDto>> Create(CreateRoleDto Role)
        {
            var Response = await _http.PostAsync<abpResponse<RoleDto>>($"{_url}/api/services/app/Role/Create", Role);
            return Response;
        }

        public async Task<abpResponse<string>> Delete(int id)
        {
            var Response = await _http.DeleteAsync<abpResponse<string>>($"{_url}/api/services/app/Role/Delete", id);
            return Response;
        }

        public async Task<abpResponse<GetAllResult>> GetAll(string keyword, int skipCount, int MaxResultCount)
        {
            var Response = await _http.GetAsync<abpResponse<GetAllResult>>($"{_url}/api/services/app/Role/GetAll?Keyword={keyword}&SkipCount={skipCount}&MaxResultCount={MaxResultCount}");
            return Response;
        }

        public async Task<abpResponse<GetAllPremsionsResult>> GetAllPremsions()
        {
            var Response = await _http.GetAsync<abpResponse<GetAllPremsionsResult>>($"{_url}/api/services/app/Role/GetAllPermissions");
            return Response;
        }

        public async Task<abpResponse<GetRoleForEditResult>> GetRoleForEdit(int id)
        {
            var Response = await _http.GetAsync<abpResponse<GetRoleForEditResult>>($"{_url}/api/services/app/Role/GetRoleForEdit?Id={id}");
            return Response;
        }

        public async Task<abpResponse<EditRoleDto>> Update(EditRoleDto Role)
        {
            //var Response = await _http.GetAsync<abpResponse<EditRoleDto>>($"{_url}/api/services/app/Role/GetAllPermissions");
            var Response = await _http.PutAsync<abpResponse<EditRoleDto>>($"{_url}/api/services/app/Role/Update", Role);
            return Response;
        }
    }
}
