#pragma checksum "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c21e5e2e9c8e65c80276d7313fe7d48b44c2c39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_DetailPeminjaman), @"mvc.1.0.view", @"/Views/Books/DetailPeminjaman.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/DetailPeminjaman.cshtml", typeof(AspNetCore.Views_Books_DetailPeminjaman))]
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
#line 1 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\_ViewImports.cshtml"
using Perpustakaan.Models;

#line default
#line hidden
#line 2 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\_ViewImports.cshtml"
using Perpustakaan.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c21e5e2e9c8e65c80276d7313fe7d48b44c2c39", @"/Views/Books/DetailPeminjaman.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c74b33c4ad70c8476eb8cc59c71ee72230dc35", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_DetailPeminjaman : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PeminjamanDetailVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailPeminjaman", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
  
    ViewData["Title"] = "DetailPeminjaman";

#line default
#line hidden
            BeginContext(92, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(97, 17, false);
#line 5 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(114, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 6 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
 if (Model != null && Model.Any())
{

#line default
#line hidden
            BeginContext(160, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(164, 1275, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c21e5e2e9c8e65c80276d7313fe7d48b44c2c395398", async() => {
                BeginContext(214, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(224, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c21e5e2e9c8e65c80276d7313fe7d48b44c2c395788", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 9 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(284, 308, true);
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-md-12"">
                <table id=""tableOrder"" class=""table table-hover"">
                    <tr>
                        <th></th>
                        <th>Penulis</th>
                        <th>Judul Buku</th>
                    </tr>
");
                EndContext();
#line 18 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
                     foreach (var buku in Model)
                    {

#line default
#line hidden
                BeginContext(665, 100, true);
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 765, "\"", 791, 2);
                WriteAttributeValue("", 771, "/images/", 771, 8, true);
#line 22 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
WriteAttributeValue("", 779, buku.Gambar, 779, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(792, 95, true);
                WriteLiteral(" height=\"60\" width=\"58\" />\r\n                            </td>\r\n                            <td>");
                EndContext();
                BeginContext(888, 12, false);
#line 24 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
                           Write(buku.Penulis);

#line default
#line hidden
                EndContext();
                BeginContext(900, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(940, 10, false);
#line 25 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
                           Write(buku.Judul);

#line default
#line hidden
                EndContext();
                BeginContext(950, 38, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n");
                EndContext();
#line 27 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
                    }

#line default
#line hidden
                BeginContext(1011, 204, true);
                WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n        <div class=\"modal-footer\">\r\n            <button type=\"submit\" name=\"answer\" value=\"Cancel\" class=\"btn btn-secondary\">Cancel</button>\r\n");
                EndContext();
#line 33 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
             if (!Model.FirstOrDefault().Status)
            {

#line default
#line hidden
                BeginContext(1280, 115, true);
                WriteLiteral("                <button type=\"submit\" name=\"answer\" value=\"Save\" class=\"btn btn-primary\">Kembalikan Buku</button>\r\n");
                EndContext();
#line 36 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
            }

#line default
#line hidden
                BeginContext(1410, 22, true);
                WriteLiteral("        </div>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            EndContext();
            BeginContext(1439, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
}
else if (string.IsNullOrEmpty(ViewBag.Success))
{

#line default
#line hidden
            BeginContext(1496, 74, true);
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\"> Tidak ada data.</div>\r\n");
            EndContext();
#line 44 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
}
else if (ViewBag.Success == "Error")
{

#line default
#line hidden
            BeginContext(1614, 104, true);
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\"> Tidak dapat menyimpan. Silahkan hubungi Admin.</div>\r\n");
            EndContext();
            BeginContext(1723, 64, false);
#line 48 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 48 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"
                                                                     
}
else if (ViewBag.Success == "Success")
{

#line default
#line hidden
            BeginContext(1835, 67, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">Berhasil.</div>\r\n");
            EndContext();
#line 53 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Books\DetailPeminjaman.cshtml"

}

#line default
#line hidden
            BeginContext(1907, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PeminjamanDetailVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591