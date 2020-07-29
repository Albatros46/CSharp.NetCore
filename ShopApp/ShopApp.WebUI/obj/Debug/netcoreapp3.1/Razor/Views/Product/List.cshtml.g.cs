#pragma checksum "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c9242db91a35537e239a9b7d1310d269187f503"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c9242db91a35537e239a9b7d1310d269187f503", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bd27140c2ffada14d172b3e8ee0244eb37f07a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopApp.WebUI.ViewModels.ProductViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--model List<Product>-->\r\n<!--ProductController de list metodu List olarak tanımlandığı için modelde de List olduğunu belirteceğiz.-->\r\n\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c9242db91a35537e239a9b7d1310d269187f5033311", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Ürün Listesi</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c9242db91a35537e239a9b7d1310d269187f5034426", async() => {
                WriteLiteral("\r\n    <h2>Product/List</h2>\r\n    <h1>");
#nullable restore
#line 15 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
   Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
    <div>
        <table border=""1"">
            <thead>
                <tr>
                    <td>Ürün Adı</td>
                    <td>Fiyatı</td>
                    <td>Hakkında</td>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
#nullable restore
#line 27 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[0].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[0].Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[0].Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 32 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[1].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[1].Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[1].Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 37 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[2].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[2].Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[2].Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 42 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[3].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[3].Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[3].Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 47 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[4].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[4].Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                   Write(Model.Products[4].Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <p>ProductViewModel.cs de kategory ile product u birleştirdikten sonra model üzerinden\r\n    ProductViewModel ile verileri çekiyoruz.</p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopApp.WebUI.ViewModels.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
