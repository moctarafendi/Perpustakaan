#pragma checksum "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84701d723a17b4be163f3c160328f34bf9b3a707"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GetBuku), @"mvc.1.0.view", @"/Views/Shared/_GetBuku.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_GetBuku.cshtml", typeof(AspNetCore.Views_Shared__GetBuku))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 1 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
using System.Linq;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84701d723a17b4be163f3c160328f34bf9b3a707", @"/Views/Shared/_GetBuku.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c74b33c4ad70c8476eb8cc59c71ee72230dc35", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GetBuku : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 19, true);
            WriteLiteral("<div class=\"row\">\r\n");
            EndContext();
#line 4 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
     if (Model != null && Model.Any())
    {
        foreach (var book in Model)
        {


#line default
#line hidden
            BeginContext(182, 137, true);
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"thumbnail\" style=\"height: 450px;\" align=\"center\">\r\n\r\n                    ");
            EndContext();
            BeginContext(319, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84701d723a17b4be163f3c160328f34bf9b3a7074213", async() => {
                BeginContext(370, 30, true);
                WriteLiteral("\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 400, "\"", 426, 2);
                WriteAttributeValue("", 406, "/images/", 406, 8, true);
#line 13 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
WriteAttributeValue("", 414, book.Gambar, 414, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(427, 50, true);
                WriteLiteral(" height=\"250\" width=\"200\" />\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
                                                 WriteLiteral(book.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(481, 102, true);
            WriteLiteral("\r\n\r\n                    <div class=\"caption\">\r\n                        <h5 style=\"text-align: center\">");
            EndContext();
            BeginContext(584, 10, false);
#line 17 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
                                                  Write(book.Judul);

#line default
#line hidden
            EndContext();
            BeginContext(594, 62, true);
            WriteLiteral("</h5>\r\n                        <h4 style=\"text-align: center\">");
            EndContext();
            BeginContext(657, 12, false);
#line 18 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
                                                  Write(book.Penulis);

#line default
#line hidden
            EndContext();
            BeginContext(669, 62, true);
            WriteLiteral("</h4>\r\n                        <h5 style=\"text-align: center\">");
            EndContext();
            BeginContext(732, 13, false);
#line 19 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
                                                  Write(book.Penerbit);

#line default
#line hidden
            EndContext();
            BeginContext(745, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 20 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
                          
                            if (book.Status)
                            {

#line default
#line hidden
            BeginContext(857, 194, true);
            WriteLiteral("                                <p style=\"text-align: center\">\r\n                                    <a class=\"btn btn-success\" role=\"button\"\r\n                                       data-bukuId=\"");
            EndContext();
            BeginContext(1052, 7, false);
#line 25 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
                                               Write(book.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1059, 58, true);
            WriteLiteral("\"\r\n                                       data-bukuImage=\"");
            EndContext();
            BeginContext(1118, 11, false);
#line 26 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
                                                  Write(book.Gambar);

#line default
#line hidden
            EndContext();
            BeginContext(1129, 58, true);
            WriteLiteral("\"\r\n                                       data-bukuJudul=\"");
            EndContext();
            BeginContext(1188, 10, false);
#line 27 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
                                                  Write(book.Judul);

#line default
#line hidden
            EndContext();
            BeginContext(1198, 60, true);
            WriteLiteral("\"\r\n                                       data-bukuPenulis=\"");
            EndContext();
            BeginContext(1259, 12, false);
#line 28 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
                                                    Write(book.Penulis);

#line default
#line hidden
            EndContext();
            BeginContext(1271, 260, true);
            WriteLiteral(@"""
                                       style=""margin-top: 10px;"">
                                        <span class=""glyphicon glyphicon-shopping-cart""></span>  Add To Cart
                                    </a>
                                </p>
");
            EndContext();
#line 33 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"

                            }
                        

#line default
#line hidden
            BeginContext(1591, 80, true);
            WriteLiteral("\r\n                    </div>\r\n                </div><br />\r\n            </div>\r\n");
            EndContext();
#line 40 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1689, 637, true);
            WriteLiteral(@"</div>
<script type=""text/javascript"">


    $(document)
          .ready(function() {


                $('.btn-success')
                    .click(function() {

                        var selectedProduct = {
                            Id: $(this).attr('data-bukuId'),
                            Gambar: $(this).attr('data-bukuImage'),
                            Judul: $(this).attr('data-bukuJudul'),
                            Penulis: $(this).attr('data-bukuPenulis')
                        };


                        $.ajax({
                            type: 'POST',
                            url: '");
            EndContext();
            BeginContext(2327, 37, false);
#line 63 "C:\_Moctar\4. My File\Trial NET Core\Perpustakaan\Perpustakaan\Views\Shared\_GetBuku.cshtml"
                             Write(Url.Action("AddShoppingCart", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(2364, 532, true);
            WriteLiteral(@"',
                            data: selectedProduct,
                            success: function(response) {
                                alert(response.message );
                                $('#myOrder').text(""My Order("" + response.jumlah + "")"");
                            },
                            error: function(response) {
                                alert(response.message);
                            }

                        });

                    });


          });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
