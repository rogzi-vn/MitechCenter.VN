#pragma checksum "F:\MitechCenter.vn\Views\Shared\_MetaLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6f5eb276b1a3838c16048f08db702c08a5afe89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MetaLayout), @"mvc.1.0.view", @"/Views/Shared/_MetaLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6f5eb276b1a3838c16048f08db702c08a5afe89", @"/Views/Shared/_MetaLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c74aad799e1d51f7d91cfc76d5d0e34100e56c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MetaLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/landing/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6f5eb276b1a3838c16048f08db702c08a5afe893546", async() => {
                WriteLiteral("\r\n    <!-- Required meta tags -->\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("base", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d6f5eb276b1a3838c16048f08db702c08a5afe893973", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 9 "F:\MitechCenter.vn\Views\Shared\_MetaLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
#line 9 "F:\MitechCenter.vn\Views\Shared\_MetaLayout.cshtml"
                            Write(ViewData["SuperTitle"] == null?"MITECHCENTER.VN":ViewData["SuperTitle"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <link rel=""icon"" href=""img/favicon.png"">
    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""css/bootstrap.min.css"">
    <!-- animate CSS -->
    <link rel=""stylesheet"" href=""css/animate.css"">
    <!-- owl carousel CSS -->
    <link rel=""stylesheet"" href=""css/owl.carousel.min.css"">
    <!-- themify CSS -->
    <link rel=""stylesheet"" href=""css/themify-icons.css"">
    <!-- flaticon CSS -->
    <link rel=""stylesheet"" href=""css/flaticon.css"">
    <!-- font awesome CSS -->
    <link rel=""stylesheet"" href=""css/magnific-popup.css"">
    <!-- swiper CSS -->
    <link rel=""stylesheet"" href=""css/slick.css"">
    <!-- style CSS -->
    <link rel=""stylesheet"" href=""css/style.css"">
    ");
#nullable restore
#line 27 "F:\MitechCenter.vn\Views\Shared\_MetaLayout.cshtml"
Write(RenderSection("styles", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6f5eb276b1a3838c16048f08db702c08a5afe897237", async() => {
                WriteLiteral("\r\n    <!--::header part start::-->\r\n    <header class=\"main_menu home_menu\">\r\n        <div class=\"header_top\">\r\n            <div class=\"container\">\r\n                <div class=\"justify-content-between d-flex py-2 text-white\">\r\n                    ");
#nullable restore
#line 36 "F:\MitechCenter.vn\Views\Shared\_MetaLayout.cshtml"
               Write(ViewData["HeaderCompanyOwner"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-lg-12"">
                    <nav class=""navbar navbar-expand-lg navbar-light"">
                        <a class=""navbar-brand"" href=""index.html""> <img src=""img/logo.png"" alt=""logo"" height=""47""> </a>
                        <button class=""navbar-toggler trans"" type=""button"" data-toggle=""collapse""
                            data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent""
                            aria-expanded=""false"" aria-label=""Toggle navigation"">
                            <span class=""navbar-toggler-icon""></span>
                        </button>

                        <div class=""collapse navbar-collapse main-menu-item justify-content-end""
                            id=""navbarSupportedContent"">
                            <ul class=""navbar-nav align-items-center"">
                     ");
                WriteLiteral(@"           <li class=""nav-item active"">
                                    <a class=""nav-link"" href=""/"">Trang Chủ</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""about.html"">Giới thiệu</a>
                                </li>
                                <li class=""nav-item dropdown"">
                                    <a class=""nav-link dropdown-toggle"" href=""blog.html"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                        Tin tức
                                    </a>
                                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                                        <a class=""dropdown-item"" href=""single-blog.html"">Tin tức - Sự kiện</a>
                                        <a class=""dropdown-item"" href=""elements.html"">Chia sẻ kiến thức</a>
               ");
                WriteLiteral(@"                         <a class=""dropdown-item"" href=""elements.html"">Công nghệ thông tin</a>
                                        <a class=""dropdown-item"" href=""elements.html"">TIẾNG ANH</a>
                                    </div>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""cource.html"">Khóa học</a>
                                </li>
                                <li class=""d-none d-lg-block"">
                                    <a class=""btn_1"" href=""#"">Liên hệ</a>
                                </li>
                            </ul>
                        </div>
                    </nav>
                </div>
            </div>
        </div>
    </header>
    <!-- Header part end-->
    ");
#nullable restore
#line 85 "F:\MitechCenter.vn\Views\Shared\_MetaLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- footer part start-->
    <footer class=""footer-area"">
        <div class=""container"">
            <div class=""row justify-content-between"">
                <div class=""col-sm-6 col-md-4 col-xl-3"">
                    <div class=""single-footer-widget footer_1"">
                        <a href=""index.html""> <img src=""img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 4644, "\"", 4650, 0);
                EndWriteAttribute();
                WriteLiteral(@"> </a>
                        <p class=""text-justify"">Trung tâm CNTT & NN - Trường ĐH Thông Tin Liên Lạc (Mitech Center) thành lập theo Quyết định số 988/QĐ-BQP ngày 28/3/2015 của BQP, có chức năng đào tạo, nghiên cứu và cung cấp dịch vụ CNTT.</p>
                    </div>
                </div>
                <div class=""col-sm-6 col-md-4 col-xl-4"">
                    <div class=""single-footer-widget footer_2"">
                        <h4>Thông tin liên hệ</h4>
                        </p>
                        <div class=""contact_info"">
                            <p><span> Mitech Center :</span> 101B Mai Xuân Thưởng, Vĩnh Hải, Nha Trang, Khánh Hòa </p>
                            <p><span> Điện thoại :</span> +84 989 225 256</p>
                            <p><span> Thư điện tử : </span>info@mitechcenter.vn</p>
                        </div>
                        <div class=""social_icon"">
                            <a href=""#""> <i class=""ti-facebook""></i> </a>
                      ");
                WriteLiteral(@"      <a href=""#""> <i class=""ti-twitter-alt""></i> </a>
                            <a href=""#""> <i class=""ti-instagram""></i> </a>
                            <a href=""#""> <i class=""ti-skype""></i> </a>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-sm-6 col-md-4"">
                    <div class=""single-footer-widget footer_2"">
                        <h4>Theo dõi chúng tôi</h4>
                        <div class=""fb-page fb_iframe_widget"" data-href=""https://www.facebook.com/mitechcenter/"" data-tabs=""timeline"" data-width=""600"" data-height=""300"" data-small-header=""false"" data-adapt-container-width=""true"" data-hide-cover=""false"" data-show-facepile=""true"" fb-xfbml-state=""rendered"" fb-iframe-plugin-query=""adapt_container_width=true&amp;app_id=2053392824883245&amp;container_width=350&amp;height=300&amp;hide_cover=false&amp;href=https%3A%2F%2Fwww.facebook.com%2Fmitechcenter%2F&amp;locale=vi_VN&amp;sdk=joey&amp;show_facepile=true&amp;s");
                WriteLiteral(@"mall_header=false&amp;tabs=timeline&amp;width=600""><span style=""vertical-align: bottom; width: 350px; height: 300px;""><iframe name=""f1658f3b20248ac"" width=""600px"" height=""300px"" data-testid=""fb:page Facebook Social Plugin"" title=""fb:page Facebook Social Plugin"" frameborder=""0"" allowtransparency=""true"" allowfullscreen=""true"" scrolling=""no"" allow=""encrypted-media"" src=""https://www.facebook.com/v3.3/plugins/page.php?adapt_container_width=true&amp;app_id=2053392824883245&amp;channel=https%3A%2F%2Fstaticxx.facebook.com%2Fconnect%2Fxd_arbiter.php%3Fversion%3D46%23cb%3Dfa1e23cb5e5348%26domain%3Dmitechcenter.vn%26origin%3Dhttps%253A%252F%252Fmitechcenter.vn%252Ff547f38096c1c4%26relation%3Dparent.parent&amp;container_width=350&amp;height=300&amp;hide_cover=false&amp;href=https%3A%2F%2Fwww.facebook.com%2Fmitechcenter%2F&amp;locale=vi_VN&amp;sdk=joey&amp;show_facepile=true&amp;small_header=false&amp;tabs=timeline&amp;width=600"" style=""border: none; visibility: visible; width: 350px; height: 300px;""");
                BeginWriteAttribute("class", " class=\"", 7701, "\"", 7709, 0);
                EndWriteAttribute();
                WriteLiteral(@"></iframe></span></div>
                    </div>
                </div>
            </div>

        </div>
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""copyright_part_text text-center"">
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <p class=""footer-text m-0"">Copyright © Trung Tâm CNTT & NN Đại học Thông Tin Liên Lạc</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!-- footer part end-->

    <!-- jquery plugins here-->
    <!-- jquery -->
    <script src=""js/jquery-1.12.1.min.js""></script>
    <!-- popper js -->
    <script src=""js/popper.min.js""></script>
    <!-- bootstrap js -->
    <script src=""js/bootstrap.min.js""></script>
    <!-- easing js -->
    <script src=""js/jquery.magnif");
                WriteLiteral(@"ic-popup.js""></script>
    <!-- swiper js -->
    <script src=""js/swiper.min.js""></script>
    <!-- swiper js -->
    <script src=""js/masonry.pkgd.js""></script>
    <!-- particles js -->
    <script src=""js/owl.carousel.min.js""></script>
    <script src=""js/jquery.nice-select.min.js""></script>
    <!-- swiper js -->
    <script src=""js/slick.min.js""></script>
    <script src=""js/jquery.counterup.min.js""></script>
    <script src=""js/waypoints.min.js""></script>
    <!-- custom js -->
    <script src=""js/custom.js""></script>
    ");
#nullable restore
#line 160 "F:\MitechCenter.vn\Views\Shared\_MetaLayout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral(@"

<style>
    .menu_fixed .header_top {
        display: none;
    }
    .header_top {
        background: #0078c0;
    }
    .main_menu {
        -webkit-box-shadow: 0 0 15px 0 rgba(0,0,0,.12);
        box-shadow: 0 0 15px 0 rgba(0,0,0,.12);
        background: #fff;
    }
</style>

</html>");
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
