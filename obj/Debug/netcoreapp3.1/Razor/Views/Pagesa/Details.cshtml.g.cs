#pragma checksum "C:\Users\Asdren\Desktop\Libraryms\Views\Pagesa\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e42eb30d344adbdb1fcc63d0f7c1d945471edc55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagesa_Details), @"mvc.1.0.view", @"/Views/Pagesa/Details.cshtml")]
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
#line 1 "C:\Users\Asdren\Desktop\Libraryms\Views\_ViewImports.cshtml"
using Libraryms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asdren\Desktop\Libraryms\Views\_ViewImports.cshtml"
using Libraryms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42eb30d344adbdb1fcc63d0f7c1d945471edc55", @"/Views/Pagesa/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9772b91d4c7d72fb89dffe9f162861797fdfb849", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagesa_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Libraryms.Models.Pagesa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Asdren\Desktop\Libraryms\Views\Pagesa\Details.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>


    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"" style=""color:black;"">
        <tr>
            <td bgcolor=""white"">ID</td>
            <td bgcolor=""white"">Shuma</td>
            <td bgcolor=""white"">Aktiv</td>
            <td bgcolor=""white"">Klienti ID</td>
            <td bgcolor=""white"">Data E Pageses</td>
            <td bgcolor=""white"">Data E Skadimit</td>

        </tr>
        <tr>
            <td bgcolor=""white"">");
#nullable restore
#line 19 "C:\Users\Asdren\Desktop\Libraryms\Views\Pagesa\Details.cshtml"
                           Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td bgcolor=\"white\">");
#nullable restore
#line 20 "C:\Users\Asdren\Desktop\Libraryms\Views\Pagesa\Details.cshtml"
                           Write(Model.Shuma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td bgcolor=\"white\">");
#nullable restore
#line 21 "C:\Users\Asdren\Desktop\Libraryms\Views\Pagesa\Details.cshtml"
                           Write(Model.Active);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td bgcolor=\"white\">");
#nullable restore
#line 22 "C:\Users\Asdren\Desktop\Libraryms\Views\Pagesa\Details.cshtml"
                           Write(Model.Klienti_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td bgcolor=\"white\">");
#nullable restore
#line 23 "C:\Users\Asdren\Desktop\Libraryms\Views\Pagesa\Details.cshtml"
                           Write(Model.DataEPageses);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td bgcolor=\"white\">");
#nullable restore
#line 24 "C:\Users\Asdren\Desktop\Libraryms\Views\Pagesa\Details.cshtml"
                           Write(Model.DataESkadimit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Libraryms.Models.Pagesa> Html { get; private set; }
    }
}
#pragma warning restore 1591
