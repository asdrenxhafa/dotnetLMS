<<<<<<< HEAD
#pragma checksum "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "306b21809534b7e2a400115aaca606a2e41757d5"
=======
#pragma checksum "C:\Users\leu\source\repos\dotnetLMS\Views\Libra\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "306b21809534b7e2a400115aaca606a2e41757d5"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Libra_Create), @"mvc.1.0.view", @"/Views/Libra/Create.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\leu\source\repos\dotnetLMS\Views\_ViewImports.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
using Libraryms;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\leu\source\repos\dotnetLMS\Views\_ViewImports.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
using Libraryms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"306b21809534b7e2a400115aaca606a2e41757d5", @"/Views/Libra/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9772b91d4c7d72fb89dffe9f162861797fdfb849", @"/Views/_ViewImports.cshtml")]
    public class Views_Libra_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Create.cshtml"
=======
#line 2 "C:\Users\leu\source\repos\dotnetLMS\Views\Libra\Create.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n\r\n<div class=\"modal-dialog\">\r\n    <div class=\"modal-content\">\r\n        ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "306b21809534b7e2a400115aaca606a2e41757d54449", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "306b21809534b7e2a400115aaca606a2e41757d54425", async() => {
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                WriteLiteral(@"
            <div class=""modal-header"">
                <h4 class=""modal-title"">Edito Automjetin</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"" onclick=""window.location='/libra';"">&times;</button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label>Titulli:</label>
                    <input name=""Titulli"" id=""Titulli"" type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 672, "\"", 680, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Autori</label>\r\n                    <input name=\"Autori\" id=\"Autori\" type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 887, "\"", 895, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                </div>
            </div>
            <div class=""modal-footer"">
                <input type=""button"" class=""btn btn-default"" value=""Anulo"" onclick=""window.location='/libra';"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary float-right"">
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
