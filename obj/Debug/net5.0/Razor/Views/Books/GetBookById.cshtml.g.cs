#pragma checksum "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9485bce811da06d952437c0a82d733c70ac6b61a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_GetBookById), @"mvc.1.0.view", @"/Views/Books/GetBookById.cshtml")]
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
#line 1 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\_ViewImports.cshtml"
using LibraryManagementWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\_ViewImports.cshtml"
using LibraryManagementWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9485bce811da06d952437c0a82d733c70ac6b61a", @"/Views/Books/GetBookById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9260996a7399be55738149913bed035925071464", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_GetBookById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary p-2 mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetListofBooks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
  
    ViewData["Title"] = "GetBookById";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n\n    <div class=\"container\">\n\n        <div class=\"row\">\n            <div class=\"col-md-8\"><h4>");
#nullable restore
#line 12 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                                 Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\n            <div class=\"col-md-4\" align=\"right\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9485bce811da06d952437c0a82d733c70ac6b61a4779", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("</div>\n        </div>\n        <div class=\"row\">\n\n            <div class=\"col-lg-5\">\n                <img");
            BeginWriteAttribute("src", " src=", 440, "", 490, 1);
#nullable restore
#line 18 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
WriteAttributeValue("", 445, Html.DisplayFor(model => model.ThumbnailUrl), 445, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" />\n            </div>\n            <div class=\"col-lg-7\">\n                <table class=\"table table-striped\">\n                    <tr>\n                        <th>\n                            ");
#nullable restore
#line 24 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayNameFor(model => model.BookId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <td>\n                            ");
#nullable restore
#line 27 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayFor(model => model.BookId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n                    <tr>\n                        <th>\n                            ");
#nullable restore
#line 32 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayNameFor(model => model.Isbn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <td>\n                            ");
#nullable restore
#line 35 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayFor(model => model.Isbn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n                    <tr>\n                        <th>\n                            ");
#nullable restore
#line 40 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <td>\n                            ");
#nullable restore
#line 43 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n                    <tr>\n                        <th>\n                            ");
#nullable restore
#line 48 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayNameFor(model => model.PageCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <td>\n                            ");
#nullable restore
#line 51 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayFor(model => model.PageCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n                    <tr>\n                        <th>\n                            ");
#nullable restore
#line 56 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayNameFor(model => model.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <td>\n                            ");
#nullable restore
#line 59 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayFor(model => model.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n                    <tr>\n                        <th>\n                            ");
#nullable restore
#line 64 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayNameFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <td>\n                            ");
#nullable restore
#line 67 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n                    <tr>\n                        <th>\n                            ");
#nullable restore
#line 72 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayNameFor(model => model.Authors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <td>\n                            ");
#nullable restore
#line 75 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayFor(model => model.Authors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n                    <tr>\n                        <th>\n                            ");
#nullable restore
#line 80 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayNameFor(model => model.Categories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <td>\n                            ");
#nullable restore
#line 83 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
                       Write(Html.DisplayFor(model => model.Categories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                    </tr>\n                </table>\n            </div>\n            <div class=\"col-md-12 long-des\">\n                <h5>");
#nullable restore
#line 89 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
               Write(Html.DisplayNameFor(model => model.LongDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <p>");
#nullable restore
#line 90 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetBookById.cshtml"
              Write(Html.DisplayFor(model => model.LongDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            </div>\n\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
