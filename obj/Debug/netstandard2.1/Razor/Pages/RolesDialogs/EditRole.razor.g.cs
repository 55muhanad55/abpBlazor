#pragma checksum "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da31585a6581bec5bf949c03966ad2dbe7d31e13"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Blazor.Pages.RolesDialogs
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Web.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Web.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Web.Blazor.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
using Models.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
using Models.Roles.Results;

#line default
#line hidden
#nullable disable
    public partial class EditRole : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenTabs>(0);
            __builder.AddAttribute(1, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabsItem>(3);
                __builder2.AddAttribute(4, "Text", "Details");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
                    __builder3.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                             roleModel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                                       EditeRoleAsync

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(11, "\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(13, "\r\n\r\n                ");
                        __builder4.OpenElement(14, "div");
                        __builder4.AddAttribute(15, "class", "form-group row required");
                        __builder4.AddMarkupContent(16, "\r\n                    ");
                        __builder4.OpenElement(17, "label");
                        __builder4.AddAttribute(18, "for", "name");
                        __builder4.AddAttribute(19, "class", "col-md-3 col-form-label");
                        __builder4.AddContent(20, "  ");
                        __builder4.AddContent(21, 
#nullable restore
#line 13 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                                                         c.l["Name"]

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(22, " ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(23, "\r\n                    ");
                        __builder4.OpenElement(24, "div");
                        __builder4.AddAttribute(25, "class", "col-md-9");
                        __builder4.AddMarkupContent(26, "\r\n                        ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                        __builder4.AddAttribute(28, "type", "text");
                        __builder4.AddAttribute(29, "name", "name");
                        __builder4.AddAttribute(30, "class", "form-control ng-untouched ng-pristine ng-invalid");
                        __builder4.AddAttribute(31, "ng-reflect-required", "");
                        __builder4.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                                roleModel.name

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => roleModel.name = __value, roleModel.name))));
                        __builder4.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => roleModel.name));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(35, "\r\n                        ");
                        __Blazor.Web.Blazor.Pages.RolesDialogs.EditRole.TypeInference.CreateValidationMessage_0(__builder4, 36, 37, 
#nullable restore
#line 16 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                                () => roleModel.name

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(38, "\r\n\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(39, "\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(40, "\r\n                ");
                        __builder4.OpenElement(41, "div");
                        __builder4.AddAttribute(42, "class", "form-group row required");
                        __builder4.AddMarkupContent(43, "\r\n                    ");
                        __builder4.OpenElement(44, "label");
                        __builder4.AddAttribute(45, "for", "displayName");
                        __builder4.AddAttribute(46, "class", "col-md-3 col-form-label");
                        __builder4.AddContent(47, " ");
                        __builder4.AddContent(48, 
#nullable restore
#line 21 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                                                               c.l["DisplayName"]

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(49, " ");
                        __builder4.CloseElement();
                        __builder4.OpenElement(50, "div");
                        __builder4.AddAttribute(51, "class", "col-md-9");
                        __builder4.AddMarkupContent(52, "\r\n                        ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                        __builder4.AddAttribute(54, "type", "text");
                        __builder4.AddAttribute(55, "name", "displayName");
                        __builder4.AddAttribute(56, "class", "form-control ng-untouched ng-pristine ng-invalid");
                        __builder4.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                                roleModel.displayName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => roleModel.displayName = __value, roleModel.displayName))));
                        __builder4.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => roleModel.displayName));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(60, "\r\n                        ");
                        __Blazor.Web.Blazor.Pages.RolesDialogs.EditRole.TypeInference.CreateValidationMessage_1(__builder4, 61, 62, 
#nullable restore
#line 23 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                                () => roleModel.displayName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(63, "\r\n\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(64, "\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(65, "\r\n                ");
                        __builder4.OpenElement(66, "div");
                        __builder4.AddAttribute(67, "class", "form-group row mb-0");
                        __builder4.AddMarkupContent(68, "\r\n                    ");
                        __builder4.OpenElement(69, "label");
                        __builder4.AddAttribute(70, "for", "description");
                        __builder4.AddAttribute(71, "class", "col-md-3 col-form-label");
                        __builder4.AddContent(72, " ");
                        __builder4.AddContent(73, 
#nullable restore
#line 28 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                                                               c.l["RoleDescription"]

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(74, " ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(75, "\r\n                    ");
                        __builder4.OpenElement(76, "div");
                        __builder4.AddAttribute(77, "class", "col-md-9");
                        __builder4.AddMarkupContent(78, "\r\n                        ");
                        __builder4.OpenElement(79, "textarea");
                        __builder4.AddAttribute(80, "type", "text");
                        __builder4.AddAttribute(81, "name", "description");
                        __builder4.AddAttribute(82, "class", "form-control ng-untouched ng-pristine ng-valid");
                        __builder4.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                         roleModel.description

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => roleModel.description = __value, roleModel.description));
                        __builder4.SetUpdatesAttributeName("value");
                        __builder4.AddMarkupContent(85, " \r\n                   ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(86, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(87, "\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(88, "\r\n                <br>\r\n                ");
                        __builder4.OpenElement(89, "div");
                        __builder4.AddAttribute(90, "class", "modal-footer justify-content-between");
                        __builder4.AddMarkupContent(91, "\r\n                    ");
                        __builder4.OpenElement(92, "button");
                        __builder4.AddAttribute(93, "type", "button");
                        __builder4.AddAttribute(94, "class", "btn btn-default");
                        __builder4.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                                                            ()=> ds.Close()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddMarkupContent(96, "\r\n                        ");
                        __builder4.AddContent(97, 
#nullable restore
#line 37 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                         c.l["Cancel"]

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(98, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(99, "\r\n\r\n                    ");
                        __builder4.OpenElement(100, "button");
                        __builder4.AddAttribute(101, "type", "submit");
                        __builder4.AddAttribute(102, "class", "btn btn-primary");
                        __builder4.AddMarkupContent(103, "\r\n                        ");
                        __builder4.AddContent(104, 
#nullable restore
#line 41 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                         c.l["Save"]

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(105, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(106, "\r\n                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(107, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabsItem>(110);
                __builder2.AddAttribute(111, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                               c.l["Permissions"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(113, "\r\n            ");
                    __builder3.OpenElement(114, "div");
                    __builder3.AddAttribute(115, "class", "form-group row mb-0");
                    __builder3.AddMarkupContent(116, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(117);
                    __builder3.AddAttribute(118, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 48 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                 roleModel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(119, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(120, "\r\n\r\n\r\n");
#nullable restore
#line 51 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                     foreach (var premsion in permissionsDialogs)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(121, "                        ");
                        __builder4.OpenElement(122, "div");
                        __builder4.AddAttribute(123, "class", "col-md-6 ng-star-inserted");
                        __builder4.AddMarkupContent(124, "\r\n                            ");
                        __builder4.OpenElement(125, "div");
                        __builder4.AddAttribute(126, "class", "custom-control custom-checkbox");
                        __builder4.AddMarkupContent(127, "\r\n                               \r\n                                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(128);
                        __builder4.AddAttribute(129, "type", "checkbox");
                        __builder4.AddAttribute(130, "class", "custom-control-input");
                        __builder4.AddAttribute(131, "id", 
#nullable restore
#line 56 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                                                                                 premisionsIndex

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(132, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                                                                        () => checkboxClick(premsion)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(133, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                                            premsion.Granted

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(134, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => premsion.Granted = __value, premsion.Granted))));
                        __builder4.AddAttribute(135, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => premsion.Granted));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(136, "\r\n                                ");
                        __builder4.OpenElement(137, "label");
                        __builder4.AddAttribute(138, "class", "custom-control-label");
                        __builder4.AddAttribute(139, "for", 
#nullable restore
#line 58 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                                                          premisionsIndex

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(140, "\r\n                                    ");
                        __builder4.AddContent(141, 
#nullable restore
#line 59 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                                     premsion.DisplayName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(142, "\r\n                                ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(143, "\r\n                            ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(144, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(145, "\r\n");
#nullable restore
#line 63 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
                        premisionsIndex++;
                    }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(146, "                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(147, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(148, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(149, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\RolesDialogs\EditRole.razor"
       
    EditRoleDto roleModel = new EditRoleDto();
    List<PermissionsDialog> permissionsDialogs = new List<PermissionsDialog>();
    int premisionsIndex = 0;

    [Parameter]
    public DialogService ds { get; set; }
    [Parameter]
    public EventCallback<bool> OnCreated { get; set; }
    [Parameter]
    public int roleId { get; set; }


    protected override async Task OnInitializedAsync()
    {
        var respose = await role.GetRoleForEdit(roleId);
        roleModel = new EditRoleDto
        {
            name = respose.result.role.name,
            displayName = respose.result.role.displayName,
            description = respose.result.role.description,
            grantedPermissions = new List<string>(),

        };


        foreach (var item in respose.result.permissions)
        {
            permissionsDialogs.Add(new PermissionsDialog
            {
                Name = item.name,
                DisplayName = item.displayName,
                Granted = false
            });

        }

        foreach (var item in respose.result.grantedPermissionNames)
        {
            roleModel.grantedPermissions.Add(item);
            permissionsDialogs.Find(p => p.Name == item).Granted = true;
        }
    }

    async Task addPremsion(string premision)
    {
        roleModel.grantedPermissions.Add(premision);
        await Task.FromResult(roleModel.grantedPermissions);
    }
    async Task removePremsion(string premision)
    {
        roleModel.grantedPermissions.Remove(premision);
        await Task.FromResult(roleModel.grantedPermissions);
    }



    async Task checkboxClick(PermissionsDialog premision)
    {
        premision.Granted = !premision.Granted;
        if (premision.Granted)
        {
            await addPremsion(premision.Name);
        }
        else
        {
            await removePremsion(premision.Name);
        }
    }

    async Task EditeRoleAsync()
    {
        roleModel.id = roleId;
        var response = await role.Update(roleModel);
        if (response.success)
        {
            notificationService.Notify(new NotificationMessage()
            {
                Severity = NotificationSeverity.Success,
                Summary = c.l["SavedSuccessfully"],
                Detail = "",
                Duration = 3000
            });
            await OnCreated.InvokeAsync(true);

        }
        else
        {
            notificationService.Notify(new NotificationMessage()
            {
                Severity = NotificationSeverity.Error,
                Summary = response.error.message,
                Detail = response.error.details,
                Duration = 3000
            });
        }
        ds.Close();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService notificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleService role { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserConfigurationService c { get; set; }
    }
}
namespace __Blazor.Web.Blazor.Pages.RolesDialogs.EditRole
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591