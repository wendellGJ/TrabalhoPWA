#pragma checksum "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\Pages\Print.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcb83be9efcb7617c77fe2b1e7860605730d2adf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/print")]
    public partial class Print : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "D:\_blazor\_blazor_10\Blazor_Print\Blazor_Print\Pages\Print.razor"
       

    protected override async Task OnInitializedAsync()
    {
        await PrintEmployees();
    }

    public async Task PrintEmployees()
    {
        await IJS.InvokeAsync<object>("open", new object[] { "/printEmployees", "_blank" });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJS { get; set; }
    }
}
#pragma warning restore 1591