#pragma checksum "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eb136d4cf95f3749a03207e04b9f02b718c7a55"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Print.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\_Imports.razor"
using Blazor_Print;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\_Imports.razor"
using Blazor_Print.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\_Imports.razor"
using Blazor_Print.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employees")]
    public partial class EmployeeList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Funcionários</h3>\r\n\r\n");
#nullable restore
#line 7 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\Pages\EmployeeList.razor"
 if (employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "    <img src=\"/images/basicloader.gif\">\r\n");
#nullable restore
#line 10 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\Pages\EmployeeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<thead>\r\n            <tr>\r\n                <th>Nome</th>\r\n                <th>Sobrenome</th>\r\n                <th>Endereço</th>\r\n                <th>Cidade</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 23 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\Pages\EmployeeList.razor"
             foreach (var employee in employees)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 26 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\Pages\EmployeeList.razor"
                         employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 27 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\Pages\EmployeeList.razor"
                         employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 28 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\Pages\EmployeeList.razor"
                         employee.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 29 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\Pages\EmployeeList.razor"
                         employee.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 31 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\Pages\EmployeeList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 34 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\Pages\EmployeeList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\Pages\EmployeeList.razor"
       
    List<Employee> employees;

    protected override async Task OnInitializedAsync()
    {
        employees = await empService.GetEmployees();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService empService { get; set; }
    }
}
#pragma warning restore 1591
