#pragma checksum "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1148c5b8ab7602b64e812ff5a5eef2e39be15979"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Blazor.Pages.Account
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
#line 14 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
using Models.TokenAuth;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AccountLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Web.Blazor.Pages.Account.ChangeTenant>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "h4");
            __builder.AddAttribute(5, "class", "text-center mb-3");
            __builder.AddContent(6, 
#nullable restore
#line 20 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                                  c.l["LogIn"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                      model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 21 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                                                                       Auth

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((LoginFormContext) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "input-group");
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenComponent<Web.Blazor.Shared.Components.InputTextBox>(21);
                __builder2.AddAttribute(22, "type", "text");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "placeholder", 
#nullable restore
#line 27 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                                            c.l["UserNameOrEmail"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(25, "maxlength", "256");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                                           model.userNameOrEmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.userNameOrEmailAddress = __value, model.userNameOrEmailAddress))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.userNameOrEmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.AddMarkupContent(30, "<div class=\"input-group-append\">\r\n                    <div class=\"input-group-text\">\r\n                        <span class=\"fas fa-user\"></span>\r\n                    </div>\r\n                </div>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __Blazor.Web.Blazor.Pages.Account.Login.TypeInference.CreateValidationMessage_0(__builder2, 32, 33, 
#nullable restore
#line 36 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                                    () => model.userNameOrEmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "input-group");
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.OpenComponent<Web.Blazor.Shared.Components.InputTextBox>(42);
                __builder2.AddAttribute(43, "type", "password");
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "placeholder", 
#nullable restore
#line 43 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                                            c.l["Password"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(46, "maxlength", "32");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                                           model.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.password = __value, model.password))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.AddMarkupContent(51, "<div class=\"input-group-append\">\r\n                    <div class=\"input-group-text\">\r\n                        <span class=\"fas fa-lock\"></span>\r\n                    </div>\r\n                </div>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __Blazor.Web.Blazor.Pages.Account.Login.TypeInference.CreateValidationMessage_1(__builder2, 53, 54, 
#nullable restore
#line 51 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                                    () => model.password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(55, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group row");
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-md-8");
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "custom-control custom-checkbox");
                __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                                                                        () => model.rememberClient = !model.rememberClient

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(66, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(67);
                __builder2.AddAttribute(68, "class", "custom-control-input");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                                                model.rememberClient

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.rememberClient = __value, model.rememberClient))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => model.rememberClient));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n                    ");
                __builder2.OpenElement(73, "label");
                __builder2.AddAttribute(74, "class", "custom-control-label");
                __builder2.AddMarkupContent(75, "\r\n                        ");
                __builder2.AddContent(76, 
#nullable restore
#line 60 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                         c.l["RememberMe"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(77, "\r\n\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col-md-4");
                __builder2.AddMarkupContent(83, "\r\n                ");
                __builder2.OpenElement(84, "button");
                __builder2.AddAttribute(85, "type", "submit");
                __builder2.AddAttribute(86, "class", "btn btn-primary btn-block");
                __builder2.AddAttribute(87, "disabled", 
#nullable restore
#line 68 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                                   busy

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(88, "\r\n                    ");
                __builder2.AddContent(89, 
#nullable restore
#line 69 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                     c.l["LogIn"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(90, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 74 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
     if (sessionService.UserInfo.tenant != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "        ");
            __builder.OpenElement(96, "p");
            __builder.AddAttribute(97, "class", "mb-1");
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.OpenElement(99, "a");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                         goToRegister

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(101, "\r\n                <i class=\"fa fa-plus-circle\"></i> ");
            __builder.AddContent(102, 
#nullable restore
#line 78 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
                                                   c.l["Register"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(103, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 81 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.OpenComponent<Web.Blazor.Pages.Account.Footer>(107);
            __builder.CloseComponent();
            __builder.AddMarkupContent(108, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Account\Login.razor"
       
    private AuthenticateRequest model = new AuthenticateRequest();

    bool busy = false;

    bool isSelfRegistrationAllowed = false;

    protected override async Task OnInitializedAsync()
    {

        isSelfRegistrationAllowed = sessionService.UserInfo.tenant != null;
        await Task.FromResult(isSelfRegistrationAllowed);

    }




    void goToRegister()
    {
        NavigationManager.NavigateTo("/Account/Register");
    }


    public async Task Auth()
    {
        busy = true;
        var response = await Authenticater.AuthenticateAsync(model);

        if (response.success)
        {
            await localStorge.SetItemAsync("Abp.AuthToken", response.result.accessToken);
            await jsRuntime.InvokeVoidAsync("goto", "/");
        }
        else
        {
            notificationService.Notify(new NotificationMessage()
            {
                Severity = NotificationSeverity.Error,
                Summary = response.error.message,
                Detail = response.error.details,
                Duration = 4000
            });

        }
        busy = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionService sessionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalStorage localStorge { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService notificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService Authenticater { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserConfigurationService c { get; set; }
    }
}
namespace __Blazor.Web.Blazor.Pages.Account.Login
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
