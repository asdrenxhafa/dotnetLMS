<<<<<<< HEAD
#pragma checksum "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ec274c8d2e8a25472e1d4b4dde5563a7d6cd216"
=======
#pragma checksum "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ec274c8d2e8a25472e1d4b4dde5563a7d6cd216"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Klienti_Index), @"mvc.1.0.view", @"/Views/Klienti/Index.cshtml")]
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
#nullable restore
<<<<<<< HEAD
#line 1 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 1 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
using Libraryms.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ec274c8d2e8a25472e1d4b4dde5563a7d6cd216", @"/Views/Klienti/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9772b91d4c7d72fb89dffe9f162861797fdfb849", @"/Views/_ViewImports.cshtml")]
    public class Views_Klienti_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedList<Libraryms.Models.Klienti>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("dataTable"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-dt-idx", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-dt-idx", new global::Microsoft.AspNetCore.Html.HtmlString("2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 6 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 6 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<title>Index</title>\r\n\r\n<!-- Page Heading -->\r\n<h1 class=\"h3 mb-2 text-gray-800\">Klientet</h1>\r\n\r\n\r\n\r\n\r\n<!-- DataTales Example -->\r\n<div class=\"card shadow mb-4\">\r\n    <div class=\"card-header py-3\">\r\n        <div class=\"float-right\">\r\n            ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ec274c8d2e8a25472e1d4b4dde5563a7d6cd2166365", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ec274c8d2e8a25472e1d4b4dde5563a7d6cd2166335", async() => {
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                WriteLiteral("Create new");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <h6 class=\"m-0 font-weight-bold text-primary\"></h6>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div class=\"table-responsive\">\r\n            <div class=\"float-right\">\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ec274c8d2e8a25472e1d4b4dde5563a7d6cd2167840", async() => {
                WriteLiteral("\r\n                    <div class=\"form-actions no-color\">\r\n                        <p>\r\n                            Find by name: <input type=\"text\" name=\"SearchString\" class=\"form-control form-control-sm\"");
                BeginWriteAttribute("value", " value=\"", 887, "\"", 921, 1);
#nullable restore
#line 32 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ec274c8d2e8a25472e1d4b4dde5563a7d6cd2167810", async() => {
                WriteLiteral("\r\n                    <div class=\"form-actions no-color\">\r\n                        <p>\r\n                            Find by name: <input type=\"text\" name=\"SearchString\" class=\"form-control form-control-sm\"");
                BeginWriteAttribute("value", " value=\"", 887, "\"", 921, 1);
#nullable restore
#line 32 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
WriteAttributeValue("", 895, ViewData["CurrentFilter"], 895, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"submit\" value=\"Search\" class=\"btn btn-default\" /> |\r\n                            ");
<<<<<<< HEAD
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ec274c8d2e8a25472e1d4b4dde5563a7d6cd2168826", async() => {
=======
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ec274c8d2e8a25472e1d4b4dde5563a7d6cd2168790", async() => {
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                    WriteLiteral("Back to Full List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Emri</th>
                        <th>Email</th>
                        <th>NumriTel</th>
                        <th>Aktiv</th>
                        <th>Created</th>

                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>#</th>
                        <th>Emri</th>
                        <th>Email</th>
                        <th>NumriTel</th>
                        <th>Aktiv</th>
                        <th>Created</th>
                    </tr>
                </tfoot>
                <tbody>
");
#nullable restore
<<<<<<< HEAD
#line 62 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 62 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
<<<<<<< HEAD
#line 65 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 65 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                           Write(Html.DisplayFor(model => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
<<<<<<< HEAD
#line 66 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 66 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                           Write(Html.DisplayFor(model => item.Emri));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
<<<<<<< HEAD
#line 67 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 67 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                           Write(Html.DisplayFor(model => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
<<<<<<< HEAD
#line 68 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 68 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                           Write(Html.DisplayFor(model => item.NumriTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
<<<<<<< HEAD
#line 69 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 69 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                           Write(Html.DisplayFor(model => item.Aktiv));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
<<<<<<< HEAD
#line 70 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 70 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                           Write(Html.DisplayFor(model => item.created_at));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2661, "\"", 2709, 1);
#nullable restore
<<<<<<< HEAD
#line 72 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 72 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
WriteAttributeValue("", 2668, Url.Action("Edit", new { id = item.id }), 2668, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                                <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2778, "\"", 2829, 1);
#nullable restore
<<<<<<< HEAD
#line 73 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 73 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
WriteAttributeValue("", 2785, Url.Action("Details", new { id = item.id }), 2785, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a>\r\n                                <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2901, "\"", 2951, 1);
#nullable restore
<<<<<<< HEAD
#line 74 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 74 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
WriteAttributeValue("", 2908, Url.Action("Delete", new { id = item.id }), 2908, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 77 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 77 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
<<<<<<< HEAD
#line 82 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 82 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
      
        var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
        var nextDisabled = !Model.HasNextPage ? "disabled" : "";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"pr-4\">\r\n        <ul style=\"display: flex; float:right; list-style: none; border-radius: .35rem\">\r\n            <li class=\"paginate_button page-item previous\" id=\"dataTable_previous\">\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ec274c8d2e8a25472e1d4b4dde5563a7d6cd21616731", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ec274c8d2e8a25472e1d4b4dde5563a7d6cd21616623", async() => {
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                WriteLiteral("\r\n                    Previous\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 91 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 91 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 92 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 92 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                              WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 93 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 93 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3815, "btn", 3815, 3, true);
            AddHtmlAttributeValue(" ", 3818, "page-link", 3819, 10, true);
#nullable restore
<<<<<<< HEAD
#line 95 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 95 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
AddHtmlAttributeValue(" ", 3828, prevDisabled, 3829, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n            <li class=\"paginate_button page-item next\" id=\"dataTable_next\">\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ec274c8d2e8a25472e1d4b4dde5563a7d6cd21621274", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ec274c8d2e8a25472e1d4b4dde5563a7d6cd21621142", async() => {
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                WriteLiteral("\r\n                    Next\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 101 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 101 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 102 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 102 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                              WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 103 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 103 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4327, "btn", 4327, 3, true);
            AddHtmlAttributeValue(" ", 4330, "page-link", 4331, 10, true);
#nullable restore
<<<<<<< HEAD
#line 105 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Klienti\Index.cshtml"
=======
#line 105 "C:\Users\leu\source\repos\dotnetLMS\Views\Klienti\Index.cshtml"
>>>>>>> 1443704e9a92fe38a535fd2b7be58aea87e6e2e5
AddHtmlAttributeValue(" ", 4340, nextDisabled, 4341, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedList<Libraryms.Models.Klienti>> Html { get; private set; }
    }
}
#pragma warning restore 1591
