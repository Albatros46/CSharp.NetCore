#pragma checksum "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Shared\_Navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81cb1b8fbdc6ae4c32fd642532f457ce9198c271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navbar), @"mvc.1.0.view", @"/Views/Shared/_Navbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81cb1b8fbdc6ae4c32fd642532f457ce9198c271", @"/Views/Shared/_Navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb86931034c6ccde1721560946ba4b30b339aac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""navbar bg-primary navbar-dark navbar-expand-sm"">
        <div class=""container"">
            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    <a href=""#"" class=""nav-link"">Ana Sayfa</a>
                </li>
                <li class=""nav-item"">
                    <a href=""#"" class=""nav-link"">Ürünler</a>
                </li>
                <li class=""nav-item"">
                    <a href=""#"" class=""nav-link"">Kategoriler</a>
                </li>
            </ul>
        </div>
    </div>
    <!--Shared klasörü içine diğer sayfalarda da ortak olarak kullanılan 
    objeyi yazıyoruz navbar objesi bütün sayfalarda var olan obje
    kullnacağımız safalarda ise ");
#nullable restore
#line 18 "E:\Dersler\Udemy-Sadık Turan\DotNetCore\ShopApp2\ShopApp2.WebUI\Views\Shared\_Navbar.cshtml"
                           Write(await Html.PartialAsync("_Navbar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" şeklinde çağırıp kullanabiliriz.-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591