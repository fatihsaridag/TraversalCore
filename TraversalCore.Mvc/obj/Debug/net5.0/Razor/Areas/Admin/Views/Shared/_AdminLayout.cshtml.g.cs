#pragma checksum "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3813d4683346a78bb65f29613581d08a966b2725"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
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
#line 1 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.Mvc.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.Mvc.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.Mvc.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.Mvc.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCore.Mvc.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3813d4683346a78bb65f29613581d08a966b2725", @"/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"835cf37a47e6333c61750767958262e0331d33c2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!DOCTYPE html>

<html
  lang=""en""
  class=""light-style layout-menu-fixed""
  dir=""ltr""
  data-theme=""theme-default""
  data-assets-path=""../assets/""
  data-template=""vertical-menu-template-free"">

<style>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"" >
</style>



");
#nullable restore
#line 17 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("_HeaderPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3813d4683346a78bb65f29613581d08a966b27255416", async() => {
                WriteLiteral("\r\n    <div class=\"layout-wrapper layout-content-navbar\">\r\n      <div class=\"layout-container\">\r\n\r\n        ");
#nullable restore
#line 22 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("_AppBrandDemoPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <aside id=\"layout-menu\" class=\"layout-menu menu-vertical menu bg-menu-theme\">\r\n          <div class=\"menu-inner-shadow\"></div>\r\n\r\n          ");
#nullable restore
#line 27 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
     Write(await Html.PartialAsync("_SideBarPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </aside>\r\n        <div class=\"layout-page\">\r\n\r\n          ");
#nullable restore
#line 32 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
     Write(await Html.PartialAsync("_NavbarPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n          <div class=\"content-wrapper\">\r\n            <div class=\"container-xxl flex-grow-1 container-p-y\">\r\n\r\n              ");
#nullable restore
#line 37 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
         Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            </div>\r\n\r\n            ");
#nullable restore
#line 41 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
       Write(await Html.PartialAsync("_FooterPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <div class=\"content-backdrop fade\"></div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n\r\n      <div class=\"layout-overlay layout-menu-toggle\"></div>\r\n    </div>\r\n\r\n   ");
#nullable restore
#line 51 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("_ScriptPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n  ");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
