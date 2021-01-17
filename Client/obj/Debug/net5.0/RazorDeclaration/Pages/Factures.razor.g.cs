// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Facturation.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Atelier3/Facturation/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Atelier3/Facturation/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Atelier3/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Atelier3/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Atelier3/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Atelier3/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Atelier3/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Atelier3/Facturation/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Atelier3/Facturation/Client/_Imports.razor"
using Facturation.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Atelier3/Facturation/Client/_Imports.razor"
using Facturation.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Atelier3/Facturation/Client/Pages/Factures.razor"
using Facturation.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/factures")]
    public partial class Factures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Atelier3/Facturation/Client/Pages/Factures.razor"
       

    static string ColorerFacture(Facture facture)
    {
        if (facture.estSoldee())
        {
            return "success";
        }
        else if (facture.estEnRetard())
        {
            return "danger";
        }
        else
        {
            return "default";
        }
    }

    private IEnumerable<Facture> allFactures = null;
    
    protected override async Task OnInitializedAsync()
    {
        allFactures = await HttpClient.GetFromJsonAsync<IEnumerable<Facture>>("api/factures");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
