#pragma checksum "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/SaisirFacture.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bad9efc6f23142ffb65a42b9adab802adabb992"
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
#nullable restore
#line 2 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/SaisirFacture.razor"
using Facturation.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/SaisirFacture.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SaisirFacture")]
    public partial class SaisirFacture : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Saisir une facture</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "class", "form");
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/SaisirFacture.razor"
                               facture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/SaisirFacture.razor"
                                                        postFacture

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n    \n    ");
                __builder2.AddMarkupContent(10, "<label for=\"numero\">Numero de facture :</label>\n    ");
                __Blazor.Facturation.Client.Pages.SaisirFacture.TypeInference.CreateInputNumber_0(__builder2, 11, 12, "numero", 13, 
#nullable restore
#line 13 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/SaisirFacture.razor"
                                          facture.Numero

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => facture.Numero = __value, facture.Numero)), 15, () => facture.Numero);
                __builder2.AddMarkupContent(16, "\n    \n    ");
                __builder2.AddMarkupContent(17, "<label for=\"client\">Nom de client :</label>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "client");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/SaisirFacture.razor"
                                        facture.Client

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => facture.Client = __value, facture.Client))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => facture.Client));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\n    \n    ");
                __builder2.AddMarkupContent(24, "<label for=\"date-emission\">Date d\'emission :</label>\n    ");
                __Blazor.Facturation.Client.Pages.SaisirFacture.TypeInference.CreateInputDate_1(__builder2, 25, 26, "date-emission", 27, 
#nullable restore
#line 19 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/SaisirFacture.razor"
                                               facture.DateEmission

#line default
#line hidden
#nullable disable
                , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => facture.DateEmission = __value, facture.DateEmission)), 29, () => facture.DateEmission);
                __builder2.AddMarkupContent(30, "\n    \n    ");
                __builder2.AddMarkupContent(31, "<label for=\"date-echeance\">Date d\'echeance :</label>\n    ");
                __Blazor.Facturation.Client.Pages.SaisirFacture.TypeInference.CreateInputDate_2(__builder2, 32, 33, "date-echeance", 34, 
#nullable restore
#line 22 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/SaisirFacture.razor"
                                               facture.DateEcheance

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => facture.DateEcheance = __value, facture.DateEcheance)), 36, () => facture.DateEcheance);
                __builder2.AddMarkupContent(37, "\n    \n    ");
                __builder2.AddMarkupContent(38, "<label for=\"montant\">Total HT :</label>\n    ");
                __Blazor.Facturation.Client.Pages.SaisirFacture.TypeInference.CreateInputNumber_3(__builder2, 39, 40, "montant", 41, 
#nullable restore
#line 25 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/SaisirFacture.razor"
                                           facture.MontantDu

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => facture.MontantDu = __value, facture.MontantDu)), 43, () => facture.MontantDu);
                __builder2.AddMarkupContent(44, "\n\n    ");
                __builder2.AddMarkupContent(45, "<button type=\"submit\">Enregistrer</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/home/camille/Documents/Formation/2-EPSI/Environnement .NET/Facturation/Client/Pages/SaisirFacture.razor"
       
    private Facture facture = new Facture() {DateEmission = DateTime.Today, DateEcheance = DateTime.Today.AddDays(30)};
    
    protected async void postFacture()
    {
        await HttpClient.PostAsJsonAsync("api/factures", facture);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
namespace __Blazor.Facturation.Client.Pages.SaisirFacture
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591