#pragma checksum "C:\Users\Blerina\Documents\dotnetLMS\Views\Huazimi\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c78fde056233809378befe30c86b07d2b3a8ef2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Huazimi_Details), @"mvc.1.0.view", @"/Views/Huazimi/Details.cshtml")]
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
#line 1 "C:\Users\Blerina\Documents\dotnetLMS\Views\_ViewImports.cshtml"
using Libraryms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Blerina\Documents\dotnetLMS\Views\_ViewImports.cshtml"
using Libraryms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c78fde056233809378befe30c86b07d2b3a8ef2e", @"/Views/Huazimi/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9772b91d4c7d72fb89dffe9f162861797fdfb849", @"/Views/_ViewImports.cshtml")]
    public class Views_Huazimi_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Libraryms.Models.Huazimi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Blerina\Documents\dotnetLMS\Views\Huazimi\Details.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 8 "C:\Users\Blerina\Documents\dotnetLMS\Views\Huazimi\Details.cshtml"
           Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 9 "C:\Users\Blerina\Documents\dotnetLMS\Views\Huazimi\Details.cshtml"
           Write(Model.DataPritjes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 10 "C:\Users\Blerina\Documents\dotnetLMS\Views\Huazimi\Details.cshtml"
           Write(Model.DataKthimit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 11 "C:\Users\Blerina\Documents\dotnetLMS\Views\Huazimi\Details.cshtml"
           Write(Model.Klienti_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "C:\Users\Blerina\Documents\dotnetLMS\Views\Huazimi\Details.cshtml"
           Write(Model.Libra_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\Blerina\Documents\dotnetLMS\Views\Huazimi\Details.cshtml"
           Write(Model.Aktiv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Libraryms.Models.Huazimi> Html { get; private set; }
    }
}
#pragma warning restore 1591
