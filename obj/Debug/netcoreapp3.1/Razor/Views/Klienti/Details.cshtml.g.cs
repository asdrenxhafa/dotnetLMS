#pragma checksum "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de0259f36ea43982875d93bb894de30ee6d565d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Klienti_Details), @"mvc.1.0.view", @"/Views/Klienti/Details.cshtml")]
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
#line 1 "C:\Users\leu\source\repos\dotnetLMS\Views\_ViewImports.cshtml"
using Libraryms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leu\source\repos\dotnetLMS\Views\_ViewImports.cshtml"
using Libraryms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de0259f36ea43982875d93bb894de30ee6d565d1", @"/Views/Klienti/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9772b91d4c7d72fb89dffe9f162861797fdfb849", @"/Views/_ViewImports.cshtml")]
    public class Views_Klienti_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Libraryms.Models.Klienti>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Details.cshtml"
     
ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"" style=""color:black;"">
        <tr>
            <td bgcolor=""white"">ID</td>
            <td bgcolor=""white"">Emri</td>
            <td bgcolor=""white"">Email</td>
            <td bgcolor=""white"">Tel</td>
            <td bgcolor=""white"">Aktiv</td>
            <td bgcolor=""white"">Created At</td>

        </tr>
        <tr>
            <td bgcolor=""white"">");
#nullable restore
#line 17 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Details.cshtml"
                           Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td bgcolor=\"white\">");
#nullable restore
#line 18 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Details.cshtml"
                           Write(Model.Emri);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td bgcolor=\"white\">");
#nullable restore
#line 19 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Details.cshtml"
                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td bgcolor=\"white\">");
#nullable restore
#line 20 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Details.cshtml"
                           Write(Model.NumriTel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td bgcolor=\"white\">");
#nullable restore
#line 21 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Details.cshtml"
                           Write(Model.Aktiv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td bgcolor=\"white\">");
#nullable restore
#line 22 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Details.cshtml"
                           Write(Model.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Libraryms.Models.Klienti> Html { get; private set; }
    }
}
#pragma warning restore 1591
