#pragma checksum "/home/rafael/Downloads/partial-view-ajax-main/Views/Shared/_MenuPrincipal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "335ac62f010f2048dc6db244ff07fafddcee33c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MenuPrincipal), @"mvc.1.0.view", @"/Views/Shared/_MenuPrincipal.cshtml")]
namespace AspNetCore
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
#line 1 "/home/rafael/Downloads/partial-view-ajax-main/Views/_ViewImports.cshtml"
using Vendas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/rafael/Downloads/partial-view-ajax-main/Views/_ViewImports.cshtml"
using Vendas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335ac62f010f2048dc6db244ff07fafddcee33c8", @"/Views/Shared/_MenuPrincipal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f0c972a6c9d93dbf8620d96a80968161f5dc594", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MenuPrincipal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"menu-esquerdo\">\n<ul>\n<li><a href=\"/\">Início</a></li>\n<li><a href=\"/Carrinho\">Carrinho</a></li>\n<li><a href=\"/Contato\">Contato</a></li>\n<li><a href=\"/Login\">Login</a></li>\n</ul>\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
