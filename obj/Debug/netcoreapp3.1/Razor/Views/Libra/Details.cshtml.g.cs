#pragma checksum "C:\Users\Blerina\Desktop\dotnetLMS\Views\Libra\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca2d54fc0fb69ac4fd45d4afbd88a2af36d232e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Libra_Details), @"mvc.1.0.view", @"/Views/Libra/Details.cshtml")]
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
#line 1 "C:\Users\Blerina\Desktop\dotnetLMS\Views\_ViewImports.cshtml"
using Libraryms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Blerina\Desktop\dotnetLMS\Views\_ViewImports.cshtml"
using Libraryms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca2d54fc0fb69ac4fd45d4afbd88a2af36d232e3", @"/Views/Libra/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9772b91d4c7d72fb89dffe9f162861797fdfb849", @"/Views/_ViewImports.cshtml")]
    public class Views_Libra_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Libraryms.Models.Libra>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Blerina\Desktop\dotnetLMS\Views\Libra\Details.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <table class=\"table\">\r\n            <tr>\r\n                <td>");
#nullable restore
#line 8 "C:\Users\Blerina\Desktop\dotnetLMS\Views\Libra\Details.cshtml"
               Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 9 "C:\Users\Blerina\Desktop\dotnetLMS\Views\Libra\Details.cshtml"
               Write(Model.Titulli);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 10 "C:\Users\Blerina\Desktop\dotnetLMS\Views\Libra\Details.cshtml"
               Write(Model.Autori);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 11 "C:\Users\Blerina\Desktop\dotnetLMS\Views\Libra\Details.cshtml"
               Write(Model.E_Lire);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n    </table>\r\n</div>\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Libraryms.Models.Libra> Html { get; private set; }
    }
}
#pragma warning restore 1591
