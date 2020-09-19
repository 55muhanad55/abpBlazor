using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.Tenants;
using Web.Blazor.Models.Tenants.Results;

namespace Web.Blazor.Services
{
    public class TenantService : ITenantService
    {
        private readonly string _url;
        private readonly ApiClient _http;

        public TenantService(string url, ApiClient http)
        {
            this._url = url;
            this._http = http;
        }
        public async Task<abpResponse<TenantDto>> Create(CreateTenantDto Tenant)
        {
            var response = await _http.PostAsync<abpResponse<TenantDto>>($"{_url}/api/services/app/Tenant/Create", Tenant);
            //var response = await _http.PostAsync<abpResponse<TenantDto>>($"{_url}​/api​/services​/app​/Tenant​/Create", Tenant);
            return response;
        }

        public async Task<abpResponse<string>> Delete(int id)
        {
            var response = await _http.DeleteAsync<abpResponse<string>>($"{_url}/api/services/app/Tenant/Delete", id);
            return response;
        }

        public async Task<abpResponse<TenantDto>> Get(int id)
        {
            var response = await _http.GetAsync<abpResponse<TenantDto>>($"{_url}/api/services/app/Tenant/Get?id={id}");
            return response;
        }

        public async Task<abpResponse<GetAllResult>> GetAll(string keyword, int skipCount, int MaxResultCount)
        {
            var response = await _http.GetAsync<abpResponse<GetAllResult>>($"{_url}/api/services/app/Tenant/GetAll?Keyword={keyword}&SkipCount={skipCount}&MaxResultCount={MaxResultCount}");
            return response;
        }

        public async Task<abpResponse<TenantDto>> Update(TenantDto Tenant)
        {
            var response = await _http.PutAsync<abpResponse<TenantDto>>($"{_url}/api/services/app/Tenant/Update", Tenant);
            return response;
        }
    }
}
