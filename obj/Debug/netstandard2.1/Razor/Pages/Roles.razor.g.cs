#pragma checksum "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a8aee9f8311f774a15a2216934476a5f34db276"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Blazor.Pages
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
#line 3 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
using Models.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
using Web.Blazor.Pages.RolesDialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
           [Authorize(Policy = "Roles")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Roles")]
    public partial class Roles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "content-header");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-6");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "h1");
            __builder.AddContent(13, 
#nullable restore
#line 14 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                     c.l["Roles"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-6 text-right");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                          async () => await CreateRoleDialog()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "\r\n                    <i class=\"fa fa-plus-square\"></i>\r\n                    ");
            __builder.AddContent(23, 
#nullable restore
#line 19 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                     c.l["Create"]

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenElement(30, "section");
            __builder.AddAttribute(31, "class", "content px-2 loading");
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "container-fluid");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "card");
            __builder.AddMarkupContent(38, "\r\n\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "card-header");
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(42);
            __builder.AddAttribute(43, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 30 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                 searchKeyword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "input-group");
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "input-group-prepend");
                __builder2.AddMarkupContent(51, "\r\n                            ");
                __builder2.OpenElement(52, "button");
                __builder2.AddAttribute(53, "type", "submit");
                __builder2.AddAttribute(54, "class", "btn btn-primary");
                __builder2.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                                     () =>  refreshResult(searchKeyword.keyword,0)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(56, "\r\n                                <i class=\"fas fa-search\"></i>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "placeholder", 
#nullable restore
#line 37 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                      c.l["SearchWithThreeDot"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                                                              searchKeyword.keyword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchKeyword.keyword = __value, searchKeyword.keyword))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => searchKeyword.keyword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "card-body table-responsive p-0");
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<RoleDto>>(72);
            __builder.AddAttribute(73, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<RoleDto>>(
#nullable restore
#line 44 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                   pageRoles

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(75, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RoleDto>>(76);
                __builder2.AddAttribute(77, "Property", "name");
                __builder2.AddAttribute(78, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                                  c.l["RoleName"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RoleDto>>(80);
                __builder2.AddAttribute(81, "Property", "displayName");
                __builder2.AddAttribute(82, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                                         c.l["DisplayName"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<RoleDto>>(84);
                __builder2.AddAttribute(85, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                                 c.l["Actions"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "Width", "200px");
                __builder2.AddAttribute(87, "Template", (Microsoft.AspNetCore.Components.RenderFragment<RoleDto>)((role) => (__builder3) => {
                    __builder3.AddMarkupContent(88, "\r\n                                ");
                    __builder3.OpenElement(89, "button");
                    __builder3.AddAttribute(90, "type", "button");
                    __builder3.AddAttribute(91, "class", "btn btn-sm btn-secondary");
                    __builder3.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                                                 async () => await EditeRoleDialog(role.id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(93, "\r\n                                    <i class=\"fas fa-pencil-alt\"></i>\r\n                                    ");
                    __builder3.AddContent(94, 
#nullable restore
#line 52 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                     c.l["Edit"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(95, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(96, "\r\n                                ");
                    __builder3.OpenElement(97, "button");
                    __builder3.AddAttribute(98, "type", "button");
                    __builder3.AddAttribute(99, "class", "btn btn-sm btn-danger mx-2");
                    __builder3.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                                                   async () => await DeleteRole(role.id,role.name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(101, "\r\n                                    <i class=\"fas fa-trash\"></i>\r\n                                    ");
                    __builder3.AddContent(102, 
#nullable restore
#line 56 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                     c.l["Delete"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(103, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(104, "\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(106, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n\r\n\r\n\r\n\r\n            ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "card-footer bg-light border-top");
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "row");
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "col-sm-4 col-12 text-sm-left text-center");
            __builder.AddMarkupContent(116, "\r\n                        ");
            __builder.OpenElement(117, "button");
            __builder.AddAttribute(118, "class", "btn btn-secondary");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                       async () => await refreshResult(searchKeyword.keyword,(currentPage-1)*10) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(120, "\r\n                            <i class=\"fas fa-redo-alt\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                    ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "col-sm-4 col-12 text-center");
            __builder.AddMarkupContent(125, "\r\n                        ");
            __builder.OpenElement(126, "p");
            __builder.AddAttribute(127, "class", "mb-0 my-2");
            __builder.AddMarkupContent(128, "\r\n                            ");
            __builder.AddContent(129, 
#nullable restore
#line 77 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                             c.l["TotalRecordsCount"].Replace("{0}",totalRoles.ToString())

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(130, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                    ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "col-sm-4 col-12");
            __builder.AddMarkupContent(135, "\r\n                        ");
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "float-sm-right m-auto");
            __builder.AddMarkupContent(138, "\r\n\r\n                            ");
            __builder.OpenElement(139, "nav");
            __builder.AddMarkupContent(140, "\r\n                                ");
            __builder.OpenElement(141, "ul");
            __builder.AddAttribute(142, "class", "pagination m-0 ng-star-inserted");
            __builder.AddAttribute(143, "style", true);
            __builder.AddMarkupContent(144, "\r\n\r\n\r\n                                    ");
            __builder.OpenElement(145, "li");
            __builder.AddAttribute(146, "class", "page-item" + " ng-star-inserted" + " " + (
#nullable restore
#line 87 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                            (currentPage == 1) ? @disabled : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(147, "\r\n                                        ");
            __builder.OpenElement(148, "a");
            __builder.AddAttribute(149, "class", "page-link ng-star-inserted");
            __builder.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                                           async () => await refreshResult(searchKeyword.keyword,(currentPage-2)*10)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(151, "\r\n                                            <i class=\"fas fa-chevron-left\"></i>\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 95 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                     for (int i = 1; i < pages + 1; i++)
                                    {
                                        int pageNum = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(154, "                                        ");
            __builder.OpenElement(155, "li");
            __builder.AddAttribute(156, "class", "page-item" + " " + (
#nullable restore
#line 98 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                               (currentPage == pageNum) ? @active : ""

#line default
#line hidden
#nullable disable
            ) + " ng-star-inserted");
            __builder.AddAttribute(157, "style", "z-index: 0;");
            __builder.AddMarkupContent(158, "\r\n                                            ");
            __builder.OpenElement(159, "a");
            __builder.AddAttribute(160, "class", "page-link");
            __builder.AddAttribute(161, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                              async () => await refreshResult(searchKeyword.keyword,(pageNum*10-10))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(162, " ");
            __builder.AddContent(163, 
#nullable restore
#line 99 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                                                                                                         i

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(164, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n");
#nullable restore
#line 101 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(167, "                                    ");
            __builder.OpenElement(168, "li");
            __builder.AddAttribute(169, "class", "page-item" + " ng-star-inserted" + " " + (
#nullable restore
#line 102 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                            (currentPage == pages) ? @disabled : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(170, "\r\n                                        ");
            __builder.OpenElement(171, "a");
            __builder.AddAttribute(172, "class", "page-link ng-star-inserted");
            __builder.AddAttribute(173, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                                           async () => await refreshResult(searchKeyword.keyword,(currentPage*10))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(174, "<i class=\"fas fa-chevron-right\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 124 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
       
            SearchKeyword searchKeyword = new SearchKeyword();
            int MaxResultCount = 10;
            int pages = 1;
            int currentPage = 1;
            int totalRoles = 0;
            List<RoleDto> pageRoles = new List<RoleDto>();


            string disabled = "disabled";
            string active = "active";
            protected override async Task OnInitializedAsync()
            {

                await refreshResult("", 0);
            }

            private async Task refreshResult(string word, int skip)
            {
                var response = await role.GetAll(word, skip, MaxResultCount);
                pageRoles = response.result.items;
                totalRoles = response.result.totalCount;
                pages = 1 + ((totalRoles - 1) / MaxResultCount);
                if (currentPage <= pages)
                {
                    currentPage = (skip / 10) + 1;
                }
                else
                {
                    currentPage = (skip / 10);
                }
            }

            private async Task DeleteRole(int id,string roleName)
            {
                var dialogResult = await dialogService.Confirm(c.l["RoleDeleteWarningMessage"].Replace("{0}", roleName),c.l["AreYouSureWantToDelete"].Replace("{0}",roleName), new ConfirmOptions() { OkButtonText = c.l["Yes"], CancelButtonText = c.l["No"] });
                if (dialogResult.HasValue && dialogResult.Value)
                {
                    var response = await role.Delete(id);
                    if (response.success)
                    {
                        notificationService.Notify(new NotificationMessage()
                        {
                            Severity = NotificationSeverity.Success,
                            Summary = c.l["SuccessfullyDeleted"],
                            Detail = "",
                            Duration = 3000
                        });
                        await refreshResult(searchKeyword.keyword, (currentPage - 1) * 10);
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
                }
            }

            async Task CreateRoleDialog() => await dialogService.OpenAsync(c.l["CreateNewRole"], ds =>
    

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Web.Blazor.Pages.RolesDialogs.CreateRole>(185);
            __builder2.AddAttribute(186, "ds", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DialogService>(
#nullable restore
#line 188 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                     ds

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(187, "OnCreated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 188 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                    async () => await refreshResult(searchKeyword.keyword,(currentPage-1)*10)

#line default
#line hidden
#nullable disable
            )));
            __builder2.CloseComponent();
            __builder2.AddContent(188, " ");
        }
#nullable restore
#line 188 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                                                                  );


    async Task EditeRoleDialog(int id) => await dialogService.OpenAsync(c.l["EditRole"], ds =>
    

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Web.Blazor.Pages.RolesDialogs.EditRole>(189);
            __builder2.AddAttribute(190, "ds", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DialogService>(
#nullable restore
#line 192 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                   ds

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddAttribute(191, "OnCreated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 192 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                  async () => await refreshResult(searchKeyword.keyword,(currentPage-1)*10)

#line default
#line hidden
#nullable disable
            )));
            __builder2.AddAttribute(192, "roleId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 192 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                                                                     id

#line default
#line hidden
#nullable disable
            ));
            __builder2.CloseComponent();
            __builder2.AddContent(193, "     ");
        }
#nullable restore
#line 192 "C:\Users\Mohanad\source\repos\bp\aspnet-core\Web.Blazor\Pages\Roles.razor"
                                                                                                                                );


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService notificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleService role { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserConfigurationService c { get; set; }
    }
}
#pragma warning restore 1591
