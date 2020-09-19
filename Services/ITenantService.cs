using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.Tenants;
using Web.Blazor.Models.Tenants.Results;

namespace Web.Blazor.Services
{
    interface ITenantService
    {
        public Task<abpResponse<TenantDto>> Create(CreateTenantDto Tenant);
        public Task<abpResponse<string>> Delete(int id);
        public Task<abpResponse<GetAllResult>> GetAll(string keyword, int skipCount, int MaxResultCount);
        public Task<abpResponse<TenantDto>> Get(int id);
        public Task<abpResponse<TenantDto>> Update(TenantDto Tenant);



    }
}
