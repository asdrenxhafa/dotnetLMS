#pragma checksum "C:\Users\Blerina\Documents\dotnetLMS\Areas\Identity\Pages\Libra\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfa7a97716d6c352ef0722e52f46c43d8e7ec055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Libra_Create), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Libra/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfa7a97716d6c352ef0722e52f46c43d8e7ec055", @"/Areas/Identity/Pages/Libra/Create.cshtml")]
    public class Areas_Identity_Pages_Libra_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Blerina\Documents\dotnetLMS\Areas\Identity\Pages\Libra\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Libra</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Libra.Titulli"" class=""control-label""></label>
                <input asp-for=""Libra.Titulli"" class=""form-control"" />
                <span asp-validation-for=""Libra.Titulli"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Libra.Autori"" class=""control-label""></label>
                <input asp-for=""Libra.Autori"" class=""form-control"" />
                <span asp-validation-for=""Libra.Autori"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""Libra.E_Lire"" /> ");
#nullable restore
#line 28 "C:\Users\Blerina\Documents\dotnetLMS\Areas\Identity\Pages\Libra\Create.cshtml"
                                                                         Write(Html.DisplayNameFor(model => model.Libra.E_Lire));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""Index"">Back to List</a>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Libraryms.Areas.Identity.Pages.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Libraryms.Areas.Identity.Pages.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Libraryms.Areas.Identity.Pages.CreateModel>)PageContext?.ViewData;
        public Libraryms.Areas.Identity.Pages.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
