#pragma checksum "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d16a7916f726d2d226eac5d01987e67a7e61626b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_GetListofBooks), @"mvc.1.0.view", @"/Views/Books/GetListofBooks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d16a7916f726d2d226eac5d01987e67a7e61626b", @"/Views/Books/GetListofBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9260996a7399be55738149913bed035925071464", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_GetListofBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetBookById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
   ViewData["Title"] = "GetListofBooks"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    <h1>GetListofBooks</h1>\n\n    <p>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d16a7916f726d2d226eac5d01987e67a7e61626b4666", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </p>\n\n\n    <table class=\"table\">\n");
#nullable restore
#line 14 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
         try
        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
 for (int item = 0; item < Model.Count(); item = item + 4)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr class=\"row\">\n    <td class=\"col-md-3 h-100\">\n        <div class=\"card-group\">\n            <div class=\"card\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d16a7916f726d2d226eac5d01987e67a7e61626b6655", async() => {
                WriteLiteral("\n                    <img");
                BeginWriteAttribute("src", " src=", 548, "", 617, 1);
#nullable restore
#line 23 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
WriteAttributeValue("", 553, Html.DisplayFor(modelItem => Model.ToList()[item].ThumbnailUrl), 553, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
                                              WriteLiteral(Model.ToList()[item].BookId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 26 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
                                      Write(Html.DisplayFor(modelItem => Model.ToList()[item].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                </div>\n            </div>\n        </div>\n    </td>\n    <td class=\"col-md-3 h-100\">\n        <div class=\"card-group\">\n            <div class=\"card\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d16a7916f726d2d226eac5d01987e67a7e61626b10095", async() => {
                WriteLiteral("\n                    <img");
                BeginWriteAttribute("src", " src=", 1095, "", 1166, 1);
#nullable restore
#line 35 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
WriteAttributeValue("", 1100, Html.DisplayFor(modelItem => Model.ToList()[item+1].ThumbnailUrl), 1100, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
                                              WriteLiteral(Model.ToList()[item+1].BookId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 38 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
                                      Write(Html.DisplayFor(modelItem => Model.ToList()[item + 1].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                </div>\n            </div>\n        </div>\n    </td>\n    <td class=\"col-md-3 h-100\">\n        <div class=\"card-group\">\n            <div class=\"card\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d16a7916f726d2d226eac5d01987e67a7e61626b13548", async() => {
                WriteLiteral("\n                    <img");
                BeginWriteAttribute("src", " src=", 1648, "", 1719, 1);
#nullable restore
#line 47 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
WriteAttributeValue("", 1653, Html.DisplayFor(modelItem => Model.ToList()[item+2].ThumbnailUrl), 1653, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
                                              WriteLiteral(Model.ToList()[item+2].BookId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 50 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
                                      Write(Html.DisplayFor(modelItem => Model.ToList()[item + 2].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                </div>\n            </div>\n        </div>\n    </td>\n    <td class=\"col-md-3 h-100\">\n        <div class=\"card-group\">\n            <div class=\"card\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d16a7916f726d2d226eac5d01987e67a7e61626b17001", async() => {
                WriteLiteral("\n                    <img");
                BeginWriteAttribute("src", " src=", 2201, "", 2272, 1);
#nullable restore
#line 59 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
WriteAttributeValue("", 2206, Html.DisplayFor(modelItem => Model.ToList()[item+3].ThumbnailUrl), 2206, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
                                              WriteLiteral(Model.ToList()[item+3].BookId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 62 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
                                      Write(Html.DisplayFor(modelItem => Model.ToList()[item + 3].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                </div>\n            </div>\n        </div>\n    </td>\n</tr>");
#nullable restore
#line 67 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\main-project\web-Application\LibraryManagementWebApplication-master\LibraryManagementWebApplication-master\Views\Books\GetListofBooks.cshtml"
      }
            catch { }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
