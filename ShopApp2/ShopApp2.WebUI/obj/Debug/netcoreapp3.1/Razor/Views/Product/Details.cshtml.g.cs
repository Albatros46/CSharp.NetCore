#pragma checksum "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2f72163b00c76bb380683796e3a7870f5c9b03c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f72163b00c76bb380683796e3a7870f5c9b03c", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c799f27c4a24f9e1a1ff1d6b529c9de29c1cd06", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopApp2.WebUI.Models.Product>
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
            WriteLiteral("<!--Kullanacağımız model in tam yolunu yazarak tanımlıyoruz-->\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2f72163b00c76bb380683796e3a7870f5c9b03c3204", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Ürün Detayı</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2f72163b00c76bb380683796e3a7870f5c9b03c4537", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 12 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Details.cshtml"
Write(await Html.PartialAsync("_Navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <h2>Product/Details</h2>\r\n    <p>ViewBag ile tasarımı </p>\r\n    <p>Ürün Adı :");
#nullable restore
#line 15 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Details.cshtml"
            Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>Ürün Fiyatı :");
#nullable restore
#line 16 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Details.cshtml"
               Write(ViewBag.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>Ürün Hakkında :");
#nullable restore
#line 17 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Details.cshtml"
                 Write(ViewBag.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>Model ile tasarımı</p>\r\n    <p>Ürün Adı :");
#nullable restore
#line 19 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Details.cshtml"
            Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>Ürün Fiyatı :");
#nullable restore
#line 20 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Details.cshtml"
               Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>Ürün Hakkında :");
#nullable restore
#line 21 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\Details.cshtml"
                 Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopApp2.WebUI.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
