#pragma checksum "/home/erik/erik_tech/Pages/admin/SolicitarArticulos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "859596d16ec26283fde39c473bb9a9d15644b094"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(erik_tech.Pages.admin.Pages_admin_SolicitarArticulos), @"mvc.1.0.razor-page", @"/Pages/admin/SolicitarArticulos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/admin/SolicitarArticulos.cshtml", typeof(erik_tech.Pages.admin.Pages_admin_SolicitarArticulos), null)]
namespace erik_tech.Pages.admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/erik/erik_tech/Pages/_ViewImports.cshtml"
using erik_tech;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"859596d16ec26283fde39c473bb9a9d15644b094", @"/Pages/admin/SolicitarArticulos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"333fbca831c60c1986582326cd4054054075c26a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_admin_SolicitarArticulos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/erik/erik_tech/Pages/admin/SolicitarArticulos.cshtml"
  
    Layout = "";

#line default
#line hidden
            BeginContext(58, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "/home/erik/erik_tech/Pages/admin/SolicitarArticulos.cshtml"
 if(Model.articulos.Count == 0){

#line default
#line hidden
            BeginContext(92, 173, true);
            WriteLiteral("    <div class=\"alert alert-info\" role=\"alert\">\n        No haz escrito ningún artículo. <a href=\"#\" class=\"alert-link\" onclick=\"abrir_editor()\">Comienza uno</a>.\n    </div>\n");
            EndContext();
#line 11 "/home/erik/erik_tech/Pages/admin/SolicitarArticulos.cshtml"
}

#line default
#line hidden
#line 12 "/home/erik/erik_tech/Pages/admin/SolicitarArticulos.cshtml"
 foreach (var articulo in Model.articulos)
{
    

#line default
#line hidden
            BeginContext(317, 97, true);
            WriteLiteral("    <div class=\"card\" style=\"margin-bottom:10px\">\n        <div class=\"card-header\" >\n            ");
            EndContext();
            BeginContext(415, 27, false);
#line 17 "/home/erik/erik_tech/Pages/admin/SolicitarArticulos.cshtml"
       Write(articulo.titulo_publicacion);

#line default
#line hidden
            EndContext();
            BeginContext(442, 93, true);
            WriteLiteral("\n        </div>\n        <div class=\"card-body\">\n            <p class=\"card-text\">Categorias: ");
            EndContext();
            BeginContext(536, 45, false);
#line 20 "/home/erik/erik_tech/Pages/admin/SolicitarArticulos.cshtml"
                                        Write(Model.BuscarCategoriasDeArticulo(articulo.Id));

#line default
#line hidden
            EndContext();
            BeginContext(581, 19, true);
            WriteLiteral("</p>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 600, "\"", 628, 2);
            WriteAttributeValue("", 607, "/leer?id=", 607, 9, true);
#line 21 "/home/erik/erik_tech/Pages/admin/SolicitarArticulos.cshtml"
WriteAttributeValue("", 616, articulo.Id, 616, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(629, 206, true);
            WriteLiteral(" target=\"_blank\" class=\"btn btn-primary\"><i class=\"fas fa-external-link-alt\"></i> Ver</a>\n            <a href=\"#\" class=\"btn btn-primary\"><i class=\"fas fa-pencil-alt\"></i> Editar</a>\n            <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 835, "\"", 875, 3);
            WriteAttributeValue("", 845, "EliminarArticulo(", 845, 17, true);
#line 23 "/home/erik/erik_tech/Pages/admin/SolicitarArticulos.cshtml"
WriteAttributeValue("", 862, articulo.Id, 862, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 874, ")", 874, 1, true);
            EndWriteAttribute();
            BeginContext(876, 125, true);
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"fas fa-trash\"></i> Eliminar</a>\n        </div>\n        <div class=\"card-footer text-muted\">");
            EndContext();
            BeginContext(1002, 74, false);
#line 25 "/home/erik/erik_tech/Pages/admin/SolicitarArticulos.cshtml"
                                       Write(Convert.ToDateTime(articulo.fecha_publicacion).Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 18, true);
            WriteLiteral("</div>\n    </div>\n");
            EndContext();
#line 27 "/home/erik/erik_tech/Pages/admin/SolicitarArticulos.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SolicitarArticuloModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SolicitarArticuloModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SolicitarArticuloModel>)PageContext?.ViewData;
        public SolicitarArticuloModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
