#pragma checksum "E:\erik_tech\Pages\Perfiles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4be1a34d6b7ba214ac7434fae2eb82b6ec85316"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(erik_tech.Pages.Pages_Perfiles), @"mvc.1.0.razor-page", @"/Pages/Perfiles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Perfiles.cshtml", typeof(erik_tech.Pages.Pages_Perfiles), @"{user}")]
namespace erik_tech.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\erik_tech\Pages\_ViewImports.cshtml"
using erik_tech;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{user}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4be1a34d6b7ba214ac7434fae2eb82b6ec85316", @"/Pages/Perfiles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"333fbca831c60c1986582326cd4054054075c26a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Perfiles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/leer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\erik_tech\Pages\Perfiles.cshtml"
  
    ViewData["title"] = "";

#line default
#line hidden
#line 6 "E:\erik_tech\Pages\Perfiles.cshtml"
  
    if(Model.fuePost){
        Layout = "";

#line default
#line hidden
            BeginContext(114, 12, true);
            WriteLiteral("        <h2>");
            EndContext();
            BeginContext(127, 22, false);
#line 9 "E:\erik_tech\Pages\Perfiles.cshtml"
       Write(Model.usuario.username);

#line default
#line hidden
            EndContext();
            BeginContext(149, 6, true);
            WriteLiteral("</h2>\n");
            EndContext();
#line 10 "E:\erik_tech\Pages\Perfiles.cshtml"

    }
    else
    {

#line default
#line hidden
            BeginContext(177, 37, true);
            WriteLiteral("        <p>La imagen</p>\n        <h2>");
            EndContext();
            BeginContext(215, 22, false);
#line 15 "E:\erik_tech\Pages\Perfiles.cshtml"
       Write(Model.usuario.username);

#line default
#line hidden
            EndContext();
            BeginContext(237, 35, true);
            WriteLiteral("</h2>\n        <h3>Publicaciones de ");
            EndContext();
            BeginContext(273, 22, false);
#line 16 "E:\erik_tech\Pages\Perfiles.cshtml"
                        Write(Model.usuario.username);

#line default
#line hidden
            EndContext();
            BeginContext(295, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 17 "E:\erik_tech\Pages\Perfiles.cshtml"
        foreach(var articulos in Model.articulosUsuario)
        {

#line default
#line hidden
            BeginContext(368, 93, true);
            WriteLiteral("            <div class=\"card\">\n                <div class=\"card-header\">\n                    ");
            EndContext();
            BeginContext(462, 28, false);
#line 21 "E:\erik_tech\Pages\Perfiles.cshtml"
               Write(articulos.titulo_publicacion);

#line default
#line hidden
            EndContext();
            BeginContext(490, 120, true);
            WriteLiteral("\n                </div>\n                <div class=\"card-body\">\n                    <p>Categorias:\n                    \n");
            EndContext();
#line 26 "E:\erik_tech\Pages\Perfiles.cshtml"
                         if(Model.categoriasArticulos[articulos.Id][1])
                        {

#line default
#line hidden
            BeginContext(708, 57, true);
            WriteLiteral("                            <i class=\"fab fa-linux\"></i>\n");
            EndContext();
#line 29 "E:\erik_tech\Pages\Perfiles.cshtml"
                        }

#line default
#line hidden
            BeginContext(791, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 30 "E:\erik_tech\Pages\Perfiles.cshtml"
                         if(Model.categoriasArticulos[articulos.Id][2])
                        {

#line default
#line hidden
            BeginContext(889, 59, true);
            WriteLiteral("                            <i class=\"fab fa-windows\"></i>\n");
            EndContext();
#line 33 "E:\erik_tech\Pages\Perfiles.cshtml"
                        }

#line default
#line hidden
            BeginContext(974, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 34 "E:\erik_tech\Pages\Perfiles.cshtml"
                         if(Model.categoriasArticulos[articulos.Id][3])
                        {

#line default
#line hidden
            BeginContext(1072, 57, true);
            WriteLiteral("                            <i class=\"fab fa-apple\"></i>\n");
            EndContext();
#line 37 "E:\erik_tech\Pages\Perfiles.cshtml"
                        }

#line default
#line hidden
            BeginContext(1155, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 38 "E:\erik_tech\Pages\Perfiles.cshtml"
                         if(Model.categoriasArticulos[articulos.Id][4])
                        {

#line default
#line hidden
            BeginContext(1253, 59, true);
            WriteLiteral("                            <i class=\"fab fa-android\"></i>\n");
            EndContext();
#line 41 "E:\erik_tech\Pages\Perfiles.cshtml"
                        }

#line default
#line hidden
            BeginContext(1338, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 42 "E:\erik_tech\Pages\Perfiles.cshtml"
                         if(Model.categoriasArticulos[articulos.Id][5])
                        {

#line default
#line hidden
            BeginContext(1436, 56, true);
            WriteLiteral("                            <i class=\"fab fa-code\"></i>\n");
            EndContext();
#line 45 "E:\erik_tech\Pages\Perfiles.cshtml"
                        }

#line default
#line hidden
            BeginContext(1518, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 46 "E:\erik_tech\Pages\Perfiles.cshtml"
                         if(Model.categoriasArticulos[articulos.Id][6])
                        {

#line default
#line hidden
            BeginContext(1616, 59, true);
            WriteLiteral("                            <i class=\"fab fa-gamepad\"></i>\n");
            EndContext();
#line 49 "E:\erik_tech\Pages\Perfiles.cshtml"
                        }

#line default
#line hidden
            BeginContext(1701, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 50 "E:\erik_tech\Pages\Perfiles.cshtml"
                         if(Model.categoriasArticulos[articulos.Id][7])
                        {

#line default
#line hidden
            BeginContext(1799, 59, true);
            WriteLiteral("                            <i class=\"fab fa-desktop\"></i>\n");
            EndContext();
#line 53 "E:\erik_tech\Pages\Perfiles.cshtml"
                        }

#line default
#line hidden
            BeginContext(1884, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 54 "E:\erik_tech\Pages\Perfiles.cshtml"
                         if(Model.categoriasArticulos[articulos.Id][8])
                        {

#line default
#line hidden
            BeginContext(1982, 60, true);
            WriteLiteral("                            <i class=\"fas fa-question\"></i>\n");
            EndContext();
#line 57 "E:\erik_tech\Pages\Perfiles.cshtml"
                        }

#line default
#line hidden
            BeginContext(2068, 54, true);
            WriteLiteral("        \n                    </p>\n                    ");
            EndContext();
            BeginContext(2122, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4be1a34d6b7ba214ac7434fae2eb82b6ec8531610108", async() => {
                BeginContext(2171, 4, true);
                WriteLiteral("Leer");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "E:\erik_tech\Pages\Perfiles.cshtml"
                                          WriteLiteral(articulos.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2179, 65, true);
            WriteLiteral("\n                </div>\n                <div class=\"card-footer\">");
            EndContext();
            BeginContext(2245, 75, false);
#line 62 "E:\erik_tech\Pages\Perfiles.cshtml"
                                    Write(Convert.ToDateTime(articulos.fecha_publicacion).Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2320, 26, true);
            WriteLiteral("</div>\n            </div>\n");
            EndContext();
#line 64 "E:\erik_tech\Pages\Perfiles.cshtml"
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PerfilModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PerfilModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PerfilModel>)PageContext?.ViewData;
        public PerfilModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
