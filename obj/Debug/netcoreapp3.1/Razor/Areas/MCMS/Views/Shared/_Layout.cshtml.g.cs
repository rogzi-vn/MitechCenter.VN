#pragma checksum "F:\MitechCenter.vn\Areas\MCMS\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6564bf64165de61400b5ee379b91cdb90359af60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MCMS_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/MCMS/Views/Shared/_Layout.cshtml")]
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
#line 1 "F:\MitechCenter.vn\Areas\MCMS\Views\_ViewImports.cshtml"
using MitechCenter.vn;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6564bf64165de61400b5ee379b91cdb90359af60", @"/Areas/MCMS/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c74aad799e1d51f7d91cfc76d5d0e34100e56c7", @"/Areas/MCMS/Views/_ViewImports.cshtml")]
    public class Areas_MCMS_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/MCMS/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6564bf64165de61400b5ee379b91cdb90359af603732", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""description"" content=""Trang quản trị dành cho MitechCenter.vn"">
    <meta name=""author"" content=""Nguyễn Trọng Nghĩa"">
    <!-- Favicon icon -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("base", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6564bf64165de61400b5ee379b91cdb90359af604399", async() => {
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
                WriteLiteral("\r\n    <link rel=\"icon\" type=\"image/png\" sizes=\"16x16\" href=\"assets/images/favicon.png\">\r\n    <title>");
#nullable restore
#line 14 "F:\MitechCenter.vn\Areas\MCMS\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" | MITIECHCENTER.VN</title>
    <!-- Custom CSS -->
    <link href=""assets/extra-libs/c3/c3.min.css"" rel=""stylesheet"">
    <link href=""assets/libs/chartist/dist/chartist.min.css"" rel=""stylesheet"">
    <link href=""assets/extra-libs/jvector/jquery-jvectormap-2.0.2.css"" rel=""stylesheet"" />
    <!-- Custom CSS -->
    <link href=""dist/css/style.min.css"" rel=""stylesheet"">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src=""https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>
        <script src=""https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js""></script>
    <![endif]-->
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6564bf64165de61400b5ee379b91cdb90359af607303", async() => {
                WriteLiteral(@"
    <!-- ============================================================== -->
    <!-- Preloader - style you can find in spinners.css -->
    <!-- ============================================================== -->
    <div class=""preloader"">
        <div class=""lds-ripple"">
            <div class=""lds-pos""></div>
            <div class=""lds-pos""></div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- Main wrapper - style you can find in pages.scss -->
    <!-- ============================================================== -->
    <div id=""main-wrapper"" data-theme=""light"" data-layout=""vertical"" data-navbarbg=""skin6"" data-sidebartype=""full"" data-sidebar-position=""fixed"" data-header-position=""fixed"" data-boxed-layout=""full"">
        <!-- ============================================================== -->
        <!-- Topbar header - style you can find in pages.scss -->
        <!-- ========================================================");
                WriteLiteral(@"====== -->
        <header class=""topbar"" data-navbarbg=""skin6"">
            <nav class=""navbar top-navbar navbar-expand-md nav-custom"">
                <div class=""navbar-header"" data-logobg=""skin6"">
                    <!-- This is for the sidebar toggle which is visible on mobile only -->
                    <a class=""nav-toggler waves-effect waves-light d-block d-md-none"" href=""javascript:void(0)"">
                        <i class=""ti-menu ti-close""></i>
                    </a>
                    <!-- ============================================================== -->
                    <!-- Logo -->
                    <!-- ============================================================== -->
                    <div class=""navbar-brand"">
                        <!-- Logo icon -->
                        <a href=""index.html"">
                            <b class=""logo-icon"">
                                <!-- Dark Logo icon -->
                                <img src=""assets/images/logo");
                WriteLiteral(@"-icon.png"" alt=""homepage"" class=""dark-logo"" />
                                <!-- Light Logo icon -->
                                <img src=""assets/images/logo-icon.png"" alt=""homepage"" class=""light-logo"" />
                            </b>
                            <!--End Logo icon -->
                            <!-- Logo text -->
                            <span class=""logo-text"">
                                <!-- dark Logo text -->
                                <img src=""assets/images/logo-text.png"" alt=""homepage"" class=""dark-logo"" />
                                <!-- Light Logo text -->
                                <img src=""assets/images/logo-light-text.png"" class=""light-logo"" alt=""homepage"" />
                            </span>
                        </a>
                    </div>
                    <!-- ============================================================== -->
                    <!-- End Logo -->
                    <!-- ================================");
                WriteLiteral(@"============================== -->
                    <!-- ============================================================== -->
                    <!-- Toggle which is visible on mobile only -->
                    <!-- ============================================================== -->
                    <a class=""topbartoggler d-block d-md-none waves-effect waves-light"" href=""javascript:void(0)"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <i class=""ti-more""></i>
                    </a>
                </div>
                <!-- ============================================================== -->
                <!-- End Logo -->
                <!-- ============================================================== -->
                <div class=""navbar-collapse collapse"" id=""navbarSupportedContent"">
                    <!-- ===========================================");
                WriteLiteral(@"=================== -->
                    <!-- toggle and nav items -->
                    <!-- ============================================================== -->
                    <ul class=""navbar-nav float-left mr-auto ml-3 pl-1"">
                        <!-- ============================================================== -->
                        <!-- create new -->
                        <!-- ============================================================== -->
");
                WriteLiteral(@"                        <li class=""nav-item d-none d-md-block"">
                            <a class=""nav-link"" href=""javascript:void(0)"">
                                <div class=""customize-input"">
                                    <select class=""custom-select form-control bg-white custom-radius custom-shadow border-0"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6564bf64165de61400b5ee379b91cdb90359af6012791", async() => {
                    WriteLiteral("VI");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                </div>
                            </a>
                        </li>
                    </ul>
                    <!-- ============================================================== -->
                    <!-- Right side toggle and nav items -->
                    <!-- ============================================================== -->
                    <ul class=""navbar-nav float-right"">
                        <!-- ============================================================== -->
                        <!-- Search -->
                        <!-- ============================================================== -->
                        <li class=""nav-item d-none d-md-block"">
                            <a class=""nav-link"" href=""javascript:void(0)"">
");
                WriteLiteral(@"                            </a>
                        </li>
                        <!-- ============================================================== -->
                        <!-- User profile and search -->
                        <!-- ============================================================== -->
");
#nullable restore
#line 138 "F:\MitechCenter.vn\Areas\MCMS\Views\Shared\_Layout.cshtml"
                       Write(await Component.InvokeAsync("LoggedUser"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "F:\MitechCenter.vn\Areas\MCMS\Views\Shared\_Layout.cshtml"
                                                                      ;
                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <!-- ============================================================== -->
                        <!-- User profile and search -->
                        <!-- ============================================================== -->
                    </ul>
                </div>
            </nav>
        </header>
        <!-- ============================================================== -->
        <!-- End Topbar header -->
        <!-- ============================================================== -->
        <!-- ============================================================== -->
        <!-- Left Sidebar - style you can find in sidebar.scss  -->
        <!-- ============================================================== -->
        <aside class=""left-sidebar"" data-sidebarbg=""skin6"">
            <!-- Sidebar scroll-->
            <div class=""scroll-sidebar"" data-sidebarbg=""skin6"">
                <!-- Sidebar navigation-->
                <nav class=""sidebar-nav"">

");
#nullable restore
#line 160 "F:\MitechCenter.vn\Areas\MCMS\Views\Shared\_Layout.cshtml"
                   Write(await Component.InvokeAsync("RoleMenu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 160 "F:\MitechCenter.vn\Areas\MCMS\Views\Shared\_Layout.cshtml"
                                                                ;
                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </nav>
                <!-- End Sidebar navigation -->
            </div>
            <!-- End Sidebar scroll-->
        </aside>
        <!-- ============================================================== -->
        <!-- End Left Sidebar - style you can find in sidebar.scss  -->
        <!-- ============================================================== -->
        <!-- ============================================================== -->
        <!-- Page wrapper  -->
        <!-- ============================================================== -->
        <div class=""page-wrapper"">
            ");
#nullable restore
#line 175 "F:\MitechCenter.vn\Areas\MCMS\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <!-- ============================================================== -->
            <!-- footer -->
            <!-- ============================================================== -->
            <footer class=""footer text-center text-muted"">
                &copy; Mitechcenter.vn - Được tạo bởi
                <a href=""https://fb.com/tx.trongnghia98""><img src=""assets/images/watermark_200.png"" width=""60""></a>.
            </footer>
            <!-- ============================================================== -->
            <!-- End footer -->
            <!-- ============================================================== -->
        </div>
        <!-- ============================================================== -->
        <!-- End Page wrapper  -->
        <!-- ============================================================== -->
    </div>
    <!-- ============================================================== -->
    <!-- End Wrapper -->
    <!-- ==========================");
                WriteLiteral(@"==================================== -->
    <!-- End Wrapper -->
    <!-- ============================================================== -->
    <!-- All Jquery -->
    <!-- ============================================================== -->
    <script src=""assets/libs/jquery/dist/jquery.min.js""></script>
    <script src=""assets/libs/popper.js/dist/umd/popper.min.js""></script>
    <script src=""assets/libs/bootstrap/dist/js/bootstrap.min.js""></script>
    <!-- apps -->
    <!-- apps -->
    <script src=""dist/js/app-style-switcher.js""></script>
    <script src=""dist/js/feather.min.js""></script>
    <script src=""assets/libs/perfect-scrollbar/dist/perfect-scrollbar.jquery.min.js""></script>
    <script src=""dist/js/sidebarmenu.js""></script>
    <!--Custom JavaScript -->
    <script src=""dist/js/custom.min.js""></script>
    <!--This page JavaScript -->
    <script src=""assets/extra-libs/c3/d3.min.js""></script>
    <script src=""assets/extra-libs/c3/c3.min.js""></script>
    <script src=""assets/lib");
                WriteLiteral(@"s/chartist/dist/chartist.min.js""></script>
    <script src=""assets/libs/chartist-plugin-tooltips/dist/chartist-plugin-tooltip.min.js""></script>
    <script src=""assets/extra-libs/jvector/jquery-jvectormap-2.0.2.min.js""></script>
    <script src=""assets/extra-libs/jvector/jquery-jvectormap-world-mill-en.js""></script>
    <script src=""dist/js/pages/dashboards/dashboard1.min.js""></script>
    ");
#nullable restore
#line 217 "F:\MitechCenter.vn\Areas\MCMS\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

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
            WriteLiteral("\r\n\r\n<style>\r\n    .nav-custom {\r\n        background: linear-gradient(to right, #00c6ff, #0072ff);\r\n    }\r\n</style>\r\n\r\n</html>");
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
