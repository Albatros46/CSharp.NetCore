#pragma checksum "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8c7d19ff62c5ced80b116ffef4f5bc31b31193c"
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
#line 2 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\_ViewImports.cshtml"
using ShopApp2.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8c7d19ff62c5ced80b116ffef4f5bc31b31193c", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb86931034c6ccde1721560946ba4b30b339aac", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopApp2.WebUI.ViewModels.ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--model List<Product>-->\r\n<!--ProductController de list metodu List olarak tanımlandığı için modelde de List olduğunu belirteceğiz.-->\r\n\r\n");
#nullable restore
#line 5 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\List.cshtml"
  
    var popularClass=Model.Products.Count>4?"popular":"popularDegil";
     //model üzerinden çağirmak yerine ;
    var product = Model.Products;
    var category = Model.Category;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8c7d19ff62c5ced80b116ffef4f5bc31b31193c4101", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Ürün Listesi</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
    <style>
        .popular{
            color:green;
            font-weight: 700;
        } 
        .popularDegil{
            color:yellow;
        }
    </style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8c7d19ff62c5ced80b116ffef4f5bc31b31193c5611", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 29 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\List.cshtml"
Write(await Html.PartialAsync("_Navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--partial sayfalar yukarıda ki gibi çağırıldığı gibi -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8c7d19ff62c5ced80b116ffef4f5bc31b31193c6197", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" <!--veya -->\r\n");
                WriteLiteral("    <main>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <h1");
                BeginWriteAttribute("class", " class=\"", 1307, "\"", 1328, 1);
#nullable restore
#line 37 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\List.cshtml"
WriteAttributeValue("", 1315, popularClass, 1315, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 37 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\List.cshtml"
                                         Write(category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n   \r\n");
#nullable restore
#line 41 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\List.cshtml"
             if (Model.Products.Count == 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""alert alert-danger"">
                            Listelenecek Ürün Yok!
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 50 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\List.cshtml"
                
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"row\">\r\n                   \r\n");
#nullable restore
#line 56 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\List.cshtml"
                         foreach (var p in product)
                        {   

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-md-3\">\r\n                                <div class=\"card\">\r\n                                    <img class=\"card-img-top\" src=\"https://productimages.hepsiburada.net/s/31/375/10352775823410.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 2176, "\"", 2182, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <div class=\"card-body\">\r\n                                        <h5 class=\"card-title\">");
#nullable restore
#line 62 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\List.cshtml"
                                                          Write(p.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                        <p class=\"card-text\">");
#nullable restore
#line 63 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\List.cshtml"
                                                        Write(p.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 2447, "\"", 2454, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\">İncele</a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 68 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\List.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    \r\n                </div>\r\n");
#nullable restore
#line 71 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Product\List.cshtml"
               
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("       </div>\r\n    </main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopApp2.WebUI.ViewModels.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
