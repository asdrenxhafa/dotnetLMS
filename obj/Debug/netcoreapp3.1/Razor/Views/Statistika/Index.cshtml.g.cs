#pragma checksum "C:\Users\leu\source\repos\dotnetLMS\Views\Statistika\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a654d8553e843056c73be59fc42e9d782d50b796"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistika_Index), @"mvc.1.0.view", @"/Views/Statistika/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a654d8553e843056c73be59fc42e9d782d50b796", @"/Views/Statistika/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9772b91d4c7d72fb89dffe9f162861797fdfb849", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistika_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"



<!-- Page Heading -->
<h1 style=""color:white"">Statistika</h1>
<p class=""mb-4"" style=""color:white;"">
    Statistikat per te gjithe aplikacionin
    </a>.
</p>

<!-- Content Row -->
<div class=""row"">

    <div class=""col-xl-8 col-lg-7"">

        <!-- Area Chart -->
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Area Chart</h6>
            </div>
            <div class=""card-body"">
                <div class=""chart-area"">
                    <canvas id=""myAreaChart""></canvas>
                </div>
            </div>
        </div>

        <!-- Bar Chart -->
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Bar Chart</h6>
            </div>
            <div class=""card-body"">
                <div class=""chart-bar"">
                    <canvas id=""myBarChart""></canvas>
                ");
            WriteLiteral(@"</div>
            </div>
        </div>

    </div>

    <!-- Donut Chart -->
    <div class=""col-xl-4 col-lg-5"">
        <div class=""card shadow mb-4"">
            <!-- Card Header - Dropdown -->
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Donut Chart</h6>
            </div>
            <!-- Card Body -->
            <div class=""card-body"">
                <div class=""chart-pie pt-4"">
                    <canvas id=""myPieChart""></canvas>
                </div>
            </div>
        </div>
    </div>
</div>");
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
