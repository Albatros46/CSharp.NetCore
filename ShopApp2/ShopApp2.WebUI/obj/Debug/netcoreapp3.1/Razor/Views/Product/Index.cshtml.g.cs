#pragma checksum "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "141b1dee64428831e50a35617654e97b245698e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\_ViewImports.cshtml"
using ShopApp2.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"141b1dee64428831e50a35617654e97b245698e2", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c799f27c4a24f9e1a1ff1d6b529c9de29c1cd06", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
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
            WriteLiteral("<!--Modelin bulunduğu yer _ViewImport ile berlitildiği için direkt objenin adını yazmak yeterli-->\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "141b1dee64428831e50a35617654e97b245698e23208", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Product</title>
     <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "141b1dee64428831e50a35617654e97b245698e24537", async() => {
                WriteLiteral(" \r\n    ");
#nullable restore
#line 12 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
Write(await Html.PartialAsync("_Navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <h2>Product/Index</h2>\r\n    <h3>");
#nullable restore
#line 14 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
   Write(ViewData["Category"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>

    <!--_ViewImports a model in tam tolunu girdikten sonra asagidaki gibi model içindeki verileri çekebiliriz-->
    <p>ViewImports a model in tam tolunu girdikten sonra asagidaki gibi model içindeki verileri çekebiliriz</p>
    <p>ViewData ile veri aktarımı</p>
    <h3>");
#nullable restore
#line 19 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
    Write(((Product)ViewData["Product"]).Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <h3>");
#nullable restore
#line 20 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
    Write(((Product)ViewData["Product"]).Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <h3>");
#nullable restore
#line 21 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
    Write(((Product)ViewData["Product"]).Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\r\n    <p>ViewBag ile veri aktarımı</p>\r\n    <h3>");
#nullable restore
#line 24 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
    Write(((Product)ViewBag.Product).Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <h3>");
#nullable restore
#line 25 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
    Write(((Product)ViewBag.Product).Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <h3>");
#nullable restore
#line 26 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
    Write(((Product)ViewBag.Product).Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\r\n     <p>ViewBag diğer kullanımı</p>\r\n    <h3>");
#nullable restore
#line 29 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
   Write(ViewBag.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <h3>");
#nullable restore
#line 30 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
   Write(ViewBag.Product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <h3>");
#nullable restore
#line 31 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
   Write(ViewBag.Product.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\r\n    <p>Model ile veri goruntuleme</p>\r\n    <h3>");
#nullable restore
#line 34 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <h3>");
#nullable restore
#line 35 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
   Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <h3>");
#nullable restore
#line 36 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Index.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
