#pragma checksum "/home/erik/erik.tech/Pages/admin/editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a717d5ae2fccdfd5309ee71d335677870af1bbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(erik_tech.Pages.admin.Pages_admin_editar), @"mvc.1.0.razor-page", @"/Pages/admin/editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/admin/editar.cshtml", typeof(erik_tech.Pages.admin.Pages_admin_editar), null)]
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
#line 1 "/home/erik/erik.tech/Pages/_ViewImports.cshtml"
using erik_tech;

#line default
#line hidden
#line 2 "/home/erik/erik.tech/Pages/admin/editar.cshtml"
using Microsoft.CodeAnalysis.CSharp.Syntax;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a717d5ae2fccdfd5309ee71d335677870af1bbb", @"/Pages/admin/editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"333fbca831c60c1986582326cd4054054075c26a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_admin_editar : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "/home/erik/erik.tech/Pages/admin/editar.cshtml"
  
    Layout = "";

#line default
#line hidden
#line 7 "/home/erik/erik.tech/Pages/admin/editar.cshtml"
  
    if (Model.error)
    {
        

#line default
#line hidden
            BeginContext(130, 17, false);
#line 10 "/home/erik/erik.tech/Pages/admin/editar.cshtml"
   Write(Html.Raw("error"));

#line default
#line hidden
            EndContext();
#line 10 "/home/erik/erik.tech/Pages/admin/editar.cshtml"
                          ;
    }
    else
    {
        

#line default
#line hidden
            BeginContext(179, 20, false);
#line 14 "/home/erik/erik.tech/Pages/admin/editar.cshtml"
   Write(Html.Raw("correcto"));

#line default
#line hidden
            EndContext();
#line 14 "/home/erik/erik.tech/Pages/admin/editar.cshtml"
                             ;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditarModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EditarModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EditarModel>)PageContext?.ViewData;
        public EditarModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
