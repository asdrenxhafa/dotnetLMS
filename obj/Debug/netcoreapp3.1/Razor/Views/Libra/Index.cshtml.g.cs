#pragma checksum "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "963322d3ba75b8b8b01fcfae1725b73a28931d2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Libra_Index), @"mvc.1.0.view", @"/Views/Libra/Index.cshtml")]
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
#line 1 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\_ViewImports.cshtml"
using Libraryms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\_ViewImports.cshtml"
using Libraryms.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
using Libraryms.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"963322d3ba75b8b8b01fcfae1725b73a28931d2d", @"/Views/Libra/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9772b91d4c7d72fb89dffe9f162861797fdfb849", @"/Views/_ViewImports.cshtml")]
    public class Views_Libra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedList<Libraryms.Models.Libra>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rezervimi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rezervo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("dataTable"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-dt-idx", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-dt-idx", new global::Microsoft.AspNetCore.Html.HtmlString("2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<title>Index</title>\r\n\r\n<!-- Page Heading -->\r\n<h1 class=\"h3 mb-2 text-gray-800\">Librat</h1>\r\n\r\n<!-- DataTales Example -->\r\n<div class=\"card shadow mb-4\">\r\n    <div class=\"card-header py-3\">\r\n        <div class=\"float-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "963322d3ba75b8b8b01fcfae1725b73a28931d2d6906", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "963322d3ba75b8b8b01fcfae1725b73a28931d2d8381", async() => {
                WriteLiteral("\r\n                    <div class=\"form-actions no-color\">\r\n                        <p>\r\n                            Find by name: <input type=\"text\" name=\"SearchString\" class=\"form-control form-control-sm\"");
                BeginWriteAttribute("value", " value=\"", 873, "\"", 907, 1);
#nullable restore
#line 27 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
WriteAttributeValue("", 881, ViewData["CurrentFilter"], 881, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"submit\" value=\"Search\" class=\"btn btn-default\" /> |\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "963322d3ba75b8b8b01fcfae1725b73a28931d2d9365", async() => {
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
                        <th>Titulli</th>
                        <th>Autori</th>
                        <th>E Lire</th>
                        <th>Veprime</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>#</th>
                        <th>Titulli</th>
                        <th>Autori</th>
                        <th>E Lire</th>
                        <th>Veprime</th>
                    </tr>
                </tfoot>
                <tbody>");
#nullable restore
#line 53 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                         foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n                    <td>");
#nullable restore
#line 55 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                   Write(Html.DisplayFor(model => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                   Write(Html.DisplayFor(model => item.Titulli));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                   Write(Html.DisplayFor(model => item.Autori));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                   Write(Html.DisplayFor(model => item.E_Lire));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 60 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                         if (item.E_Lire)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "963322d3ba75b8b8b01fcfae1725b73a28931d2d14476", async() => {
                WriteLiteral("Rezervo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-libriId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                                                                                                              WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["libriId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-libriId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["libriId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2557, "\"", 2605, 1);
#nullable restore
#line 64 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
WriteAttributeValue("", 2564, Url.Action("Edit", new { id = item.id }), 2564, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                        <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2666, "\"", 2717, 1);
#nullable restore
#line 65 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
WriteAttributeValue("", 2673, Url.Action("Details", new { id = item.id }), 2673, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a>\r\n                        <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2781, "\"", 2831, 1);
#nullable restore
#line 66 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
WriteAttributeValue("", 2788, Url.Action("Delete", new { id = item.id }), 2788, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                      \r\n                    </td>\r\n                    </tr>\r\n");
#nullable restore
#line 70 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 75 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
      
        var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
        var nextDisabled = !Model.HasNextPage ? "disabled" : "";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"pr-4\">\r\n        <ul style=\"display: flex; float:right; list-style: none; border-radius: .35rem\">\r\n            <li class=\"paginate_button page-item previous\" id=\"dataTable_previous\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "963322d3ba75b8b8b01fcfae1725b73a28931d2d19468", async() => {
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
#line 84 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                              WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3703, "btn", 3703, 3, true);
            AddHtmlAttributeValue(" ", 3706, "page-link", 3707, 10, true);
#nullable restore
#line 88 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
AddHtmlAttributeValue(" ", 3716, prevDisabled, 3717, 13, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "963322d3ba75b8b8b01fcfae1725b73a28931d2d24003", async() => {
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
#line 94 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                              WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
                                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4215, "btn", 4215, 3, true);
            AddHtmlAttributeValue(" ", 4218, "page-link", 4219, 10, true);
#nullable restore
#line 98 "C:\Users\FatlindaFejzaj\Desktop\dotnetLMS\Views\Libra\Index.cshtml"
AddHtmlAttributeValue(" ", 4228, nextDisabled, 4229, 13, false);

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
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedList<Libraryms.Models.Libra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
