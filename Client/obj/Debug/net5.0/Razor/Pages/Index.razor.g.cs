#pragma checksum "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ccf4af67143c1146aa7ac4672fbb97b01f54c88"
// <auto-generated/>
#pragma warning disable 1591
namespace Facturation.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/_Imports.razor"
using Facturation.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/_Imports.razor"
using Facturation.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Facturation</h1>");
#nullable restore
#line 6 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/Index.razor"
 if (dataCA == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "h2");
            __builder.AddMarkupContent(3, "CA Facturé : ");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#nullable restore
#line 12 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/Index.razor"
                              dataCA["CAfacture"].ToString("€ 0.00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(6, "h2");
            __builder.AddMarkupContent(7, "Trésorerie en attente : ");
            __builder.OpenElement(8, "strong");
            __builder.AddContent(9, 
#nullable restore
#line 14 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/Index.razor"
                                         dataCA["TresoEnAttente"].ToString("€ 0.00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/Index.razor"
       
    private Dictionary<string, float> dataCA = null;
    
    protected override async Task OnInitializedAsync()
    {
        dataCA = await HttpClient.GetFromJsonAsync<Dictionary<string, float>>("api/dashboard");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
