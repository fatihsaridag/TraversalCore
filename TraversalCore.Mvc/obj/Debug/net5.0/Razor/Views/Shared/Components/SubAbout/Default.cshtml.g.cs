#pragma checksum "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Views\Shared\Components\SubAbout\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abdcd8afa519b34e895afd9b52fd8a68b4926b49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SubAbout_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SubAbout/Default.cshtml")]
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
#line 1 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Views\_ViewImports.cshtml"
using TraversalCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Views\_ViewImports.cshtml"
using TraversalCore.Mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Views\Shared\Components\SubAbout\Default.cshtml"
using TraversalCore.Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abdcd8afa519b34e895afd9b52fd8a68b4926b49", @"/Views/Shared/Components/SubAbout/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8ba70adfb94f3ba894fb705149ca11d7c3a5f5d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SubAbout_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SubAbout>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<section class=""w3l-bottom py-5"">
    <div class=""container py-md-4 py-3 text-center"">
        <div class=""row my-lg-4 mt-4"">
            <div class=""col-lg-9 col-md-10 ml-auto"">
                <div class=""bottom-info ml-auto"">
                    <div class=""header-section text-left"">
");
#nullable restore
#line 11 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Views\Shared\Components\SubAbout\Default.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3 class=\"hny-title two\">");
#nullable restore
#line 13 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Views\Shared\Components\SubAbout\Default.cshtml"
                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p class=\"mt-3 pr-lg-5\">\r\n                                ");
#nullable restore
#line 15 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Views\Shared\Components\SubAbout\Default.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <a href=\"about.html\" class=\"btn btn-style btn-secondary mt-5\">Daha Fazlası</a>\r\n");
#nullable restore
#line 18 "C:\Users\fatih\source\repos\TraversalCore\TraversalCore.Mvc\Views\Shared\Components\SubAbout\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SubAbout>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
