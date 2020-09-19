using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Blazor.Models;
using Web.Blazor.Models.Roles;
using Web.Blazor.Models.Roles.Results;


namespace Web.Blazor.Services
{
    public interface IRoleService
    {
        public Task<abpResponse<GetAllResult>> GetAll(string keyword, int skipCount, int MaxResultCount);
        public Task<abpResponse<GetRoleForEditResult>> GetRoleForEdit(int id);
        public Task<abpResponse<GetAllPremsionsResult>> GetAllPremsions();
        public Task<abpResponse<RoleDto>> Create(CreateRoleDto Role);
        public Task<abpResponse<EditRoleDto>> Update(EditRoleDto Role);
        public Task<abpResponse<string>> Delete(int id);

    }
}
