#pragma checksum "C:\Users\PAOLA\proyectos-visual\repositorio\DevTic-Masters\IndustriaAutomotriz\Presentacion\Pages\EspacioTrabajo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78ea4311607aa91d2322df9c0adace827fdfabc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentacion.Pages.Pages_EspacioTrabajo), @"mvc.1.0.razor-page", @"/Pages/EspacioTrabajo.cshtml")]
namespace Presentacion.Pages
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
#line 1 "C:\Users\PAOLA\proyectos-visual\repositorio\DevTic-Masters\IndustriaAutomotriz\Presentacion\Pages\_ViewImports.cshtml"
using Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78ea4311607aa91d2322df9c0adace827fdfabc1", @"/Pages/EspacioTrabajo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182c3e91b32ea8a235c851f1e3419ceac5b361a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EspacioTrabajo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""organizador"">
    <div class=""encabezado"">
        <div>
            <i class=""bi bi-wrench-adjustable-circle"" style=""font-size: 50px; line-height:0px; color:aliceblue; margin-left:15px;""></i>
        </div>
        <div>
            <h1 class=""administrador"">Mi Espacio de Trabajo</h1>
        </div>
    </div>
    <div class=""container-fluid center"">
        <div class=""txtAlign"">
            <div>
                <h1>Clientes</h1>
            </div>
            <div>
                <div");
            BeginWriteAttribute("class", " class=\"", 572, "\"", 580, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <a href=""/CrudCliente"">
                        <i class=""bi bi-people-fill iconos"" style=""font-size:128px; line-height:0px; color:#b5b073""></i>
                    </a>
                </div>
            </div>
        </div>
        <div class=""txtAlign"">
            <div>
                <h1>Vehiculos</h1>
            </div>
            <div");
            BeginWriteAttribute("class", " class=\"", 960, "\"", 968, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <a href=""/CrudVehiculo"">
                    <i class=""bi bi-car-front-fill iconos"" style=""font-size:128px; line-height:0px; color:#b5b073""></i>
                </a>
            </div>
        </div>
        <div class=""txtAlign"">
            <div>
                <h1>Revisiones</h1>
            </div>
            <div");
            BeginWriteAttribute("class", " class=\"", 1317, "\"", 1325, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <a href=""/CrudRevision"">
                    <i class=""bi bi-list-check iconos"" style=""font-size:128px; line-height:0px; color:#b5b073""></i>
                </a>
            </div>
        </div>
        <div class=""xtAlign"">
            <div>
                <h1>Ordenes</h1>
            </div>
            <div");
            BeginWriteAttribute("class", " class=\"", 1666, "\"", 1674, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <a href=""/CrudOrdenes"">
                    <i class=""bi bi-info-square-fill iconos"" style=""font-size:120px; line-height:0px; color:#b5b073""></i>
                </a>
            </div>
        </div>
    </div>
</div>
<style>
    h1 {
        font-size: 27px;
        color: royalblue;
        background-color: aliceblue;
        font-weight: 600;
    }

    .administrador{
        color: aliceblue;
        background-color: royalblue;
        margin-left: 20px;
    }


    .organizador {
        display: flex;
        flex-direction: column;
        width: 70%;
    }

    .encabezado {
        display: flex;
        justify-content: center;
        align-items: center;
        background-color: royalblue;
        color: white;
        padding: 15px 0px;
    }

    .organizador-td {
        display: flex;
        flex-direction: row;
    }

    .center {
        margin: 0;
        position: absolute;
        top: 50%;
        left: 50%;
       ");
            WriteLiteral(@" -ms-transform: translate(-50%, -50%);
        transform: translate(-50%, -50%);
    }

    .alineamiento {
        margin-top: 190px;
    }

    .txtAlign {
        text-align: center;
    }

    .container-fluid {
        justify-content: space-evenly;
        width: 70%;
        flex-wrap: wrap;
    }

    svg {
        object-fit: cover;
    }

    .iconos{
    }

    .iconos:hover{
        color:MediumVioletRed !important;
    }
</style>

<style type=""text/css"" media=""screen (max-width:390px)"">
    i{
        font-size: 50px;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Presentacion.Pages.EspacioTrabajo> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentacion.Pages.EspacioTrabajo> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentacion.Pages.EspacioTrabajo>)PageContext?.ViewData;
        public Presentacion.Pages.EspacioTrabajo Model => ViewData.Model;
    }
}
#pragma warning restore 1591
