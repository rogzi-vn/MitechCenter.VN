#pragma checksum "F:\MitechCenter.vn\Views\Shared\Components\HeaderMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e17a9239cf207c52a6f883f2e500348906a9830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderMenu/Default.cshtml")]
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
#line 1 "F:\MitechCenter.vn\Views\_ViewImports.cshtml"
using MitechCenter.vn;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e17a9239cf207c52a6f883f2e500348906a9830", @"/Views/Shared/Components/HeaderMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c74aad799e1d51f7d91cfc76d5d0e34100e56c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HeaderMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MitechCenter.vn.Models.NewsCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\MitechCenter.vn\Views\Shared\Components\HeaderMenu\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<ul class=""navbar-nav align-items-center"">
    <li class=""nav-item"" id=""Home"">
        <a class=""nav-link"" href=""/"">Trang Chủ</a>
    </li>
    <li class=""nav-item"" id=""AboutUs"">
        <a class=""nav-link"" href=""/AboutUs"">Giới thiệu</a>
    </li>
    <li class=""nav-item dropdown"" id=""News"">
        <a class=""nav-link dropdown-toggle"" href=""blog.html"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Mở rộng
        </a>
        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
");
#nullable restore
#line 17 "F:\MitechCenter.vn\Views\Shared\Components\HeaderMenu\Default.cshtml"
             foreach (MitechCenter.vn.Models.NewsCategory newsCategory in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 790, "\"", 830, 2);
            WriteAttributeValue("", 797, "/Category/", 797, 10, true);
#nullable restore
#line 19 "F:\MitechCenter.vn\Views\Shared\Components\HeaderMenu\Default.cshtml"
WriteAttributeValue("", 807, newsCategory.getPath(), 807, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "F:\MitechCenter.vn\Views\Shared\Components\HeaderMenu\Default.cshtml"
                                                                             Write(newsCategory.ncName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 20 "F:\MitechCenter.vn\Views\Shared\Components\HeaderMenu\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </li>\r\n    <li class=\"nav-item\" id=\"Course\">\r\n        <a class=\"nav-link\" href=\"/Course\">Khóa học</a>\r\n    </li>\r\n    <li class=\"d-none d-lg-block\">\r\n        <a class=\"btn_1\" href=\"/Contact\">Liên hệ</a>\r\n    </li>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MitechCenter.vn.Models.NewsCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
