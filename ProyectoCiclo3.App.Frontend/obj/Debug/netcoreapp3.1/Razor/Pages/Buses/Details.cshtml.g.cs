#pragma checksum "C:\Users\Anderson\Desktop\EQUIPO 8\Repositorio-Equipo-8\ProyectoCiclo3.App.Frontend\Pages\Buses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b1725a6ff75533a97c8b9439641d3d2a60f6233"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Buses.Pages_Buses_Details), @"mvc.1.0.razor-page", @"/Pages/Buses/Details.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Buses
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Anderson\Desktop\EQUIPO 8\Repositorio-Equipo-8\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b1725a6ff75533a97c8b9439641d3d2a60f6233", @"/Pages/Buses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Buses_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Anderson\Desktop\EQUIPO 8\Repositorio-Equipo-8\ProyectoCiclo3.App.Frontend\Pages\Buses\Details.cshtml"
  
    var buses = Model.Buses;

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<ul class=\"list-group list-group-flush\">\r\n  <li class=\"list-group-item\"> <b>id: </b> ");
#nullable restore
#line 8 "C:\Users\Anderson\Desktop\EQUIPO 8\Repositorio-Equipo-8\ProyectoCiclo3.App.Frontend\Pages\Buses\Details.cshtml"
                                      Write(buses.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>Marca: </b> ");
#nullable restore
#line 9 "C:\Users\Anderson\Desktop\EQUIPO 8\Repositorio-Equipo-8\ProyectoCiclo3.App.Frontend\Pages\Buses\Details.cshtml"
                                         Write(buses.marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>Modelo: </b> ");
#nullable restore
#line 10 "C:\Users\Anderson\Desktop\EQUIPO 8\Repositorio-Equipo-8\ProyectoCiclo3.App.Frontend\Pages\Buses\Details.cshtml"
                                          Write(buses.modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>Kilometraje: </b> ");
#nullable restore
#line 11 "C:\Users\Anderson\Desktop\EQUIPO 8\Repositorio-Equipo-8\ProyectoCiclo3.App.Frontend\Pages\Buses\Details.cshtml"
                                              Write(buses.kilometraje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>Num Asientos: </b> ");
#nullable restore
#line 12 "C:\Users\Anderson\Desktop\EQUIPO 8\Repositorio-Equipo-8\ProyectoCiclo3.App.Frontend\Pages\Buses\Details.cshtml"
                                               Write(buses.numero_de_asientos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>Placa: </b> ");
#nullable restore
#line 13 "C:\Users\Anderson\Desktop\EQUIPO 8\Repositorio-Equipo-8\ProyectoCiclo3.App.Frontend\Pages\Buses\Details.cshtml"
                                        Write(buses.placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>  ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoCiclo3.App.Frontend.Pages.DetailsBusesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsBusesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsBusesModel>)PageContext?.ViewData;
        public ProyectoCiclo3.App.Frontend.Pages.DetailsBusesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
