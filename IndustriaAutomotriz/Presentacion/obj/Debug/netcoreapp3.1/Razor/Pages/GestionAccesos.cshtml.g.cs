#pragma checksum "C:\Users\Ana Cilia\OneDrive\Escritorio\ProyectoMisionTIC\IndustriaAutomotriz\Presentacion\Pages\GestionAccesos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "695386ecd989350751bd6cb4a89824dfff4bb843"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentacion.Pages.Pages_GestionAccesos), @"mvc.1.0.razor-page", @"/Pages/GestionAccesos.cshtml")]
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
#line 1 "C:\Users\Ana Cilia\OneDrive\Escritorio\ProyectoMisionTIC\IndustriaAutomotriz\Presentacion\Pages\_ViewImports.cshtml"
using Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"695386ecd989350751bd6cb4a89824dfff4bb843", @"/Pages/GestionAccesos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182c3e91b32ea8a235c851f1e3419ceac5b361a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GestionAccesos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""organizador"">
    <div class=""encabezado"">
        <div>
            <i class=""bi bi-list-stars"" style=""font-size:50px; line-height:0px; color:aliceblue; margin-left:15px;""></i>
        </div>
        <div>
            <h1 class=""administrador"">Gestión de Accesos</h1>
        </div>
    </div>
    <div class=""container-fluid center"">
        <div class=""txtAlign"">
            <div>
                <h1>Externos</h1>
            </div>
            <div>
                <div class=""txtAlign"">
                    <a href=""/CrudAccesoC"">
                        <i class=""bi bi-plugin iconos"" style=""font-size:128px; line-height:0px; color:#b5b073""></i>
                    </a>
                </div>
            </div>
        </div>
        <div class=""txtAlign"">
            <div>
                <h1>Internos</h1>
            </div>
            <div");
            BeginWriteAttribute("class", " class=\"", 944, "\"", 952, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <a href=""/CrudAccesosE"">
                    <i class=""bi bi-building iconos"" style=""font-size:128px; line-height:0px; color:#b5b073""></i>
                </a>
            </div>
        </div>
        <div class=""txtAlign"">
            <div>
                <h1>Empleados</h1>
            </div>
            <div");
            BeginWriteAttribute("class", " class=\"", 1294, "\"", 1302, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <a href=""/CrudEmpleado"">
                    <i class=""bi bi-person-workspace iconos"" style=""font-size:128px; line-height:0px; color:#b5b073""></i>
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

    .administrador {
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
    
    .center {
        margin: 0;
        position: absolute;
        top: 50%;
        left: 50%;
        -ms-transform: translate(-50%, -50%);
        transform: translate(-50%, -50%)");
            WriteLiteral(@";
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

    .iconos {}

    .iconos:hover {
        color: MediumVioletRed !important;
    }
</style>

<style type=""text/css"" media=""screen (max-width:390px)"">
    i {
        font-size: 50px;
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Presentacion.Pages.GestionAccesos> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentacion.Pages.GestionAccesos> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentacion.Pages.GestionAccesos>)PageContext?.ViewData;
        public Presentacion.Pages.GestionAccesos Model => ViewData.Model;
    }
}
#pragma warning restore 1591
