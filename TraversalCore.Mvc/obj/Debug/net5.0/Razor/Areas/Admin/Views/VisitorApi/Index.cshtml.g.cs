#pragma checksum "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\VisitorApi\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b06930f56d08d7a365eb6299c2d5111d1d9c8ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_VisitorApi_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/VisitorApi/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b06930f56d08d7a365eb6299c2d5111d1d9c8ae", @"/Areas/Admin/Views/VisitorApi/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e377ecca154f7cf523c761df4ed3071ebe792fe2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_VisitorApi_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VisitorViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\VisitorApi\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-2"">

        </div>
        <div class=""col-md-8"">
            <table class=""table table-bordered table-striped"">
                <tr> 
                    <th>#</th>
                    <th>Ad</th>
                    <th>Soyad</th>
                    <th>Şehir</th>
                    <th>E-Mail</th>
                    <th>Sil</th>
                    <th>Güncelle</th>
                </tr>
");
#nullable restore
#line 24 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\VisitorApi\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\VisitorApi\Index.cshtml"
                       Write(item.VisitorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\VisitorApi\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\VisitorApi\Index.cshtml"
                       Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\VisitorApi\Index.cshtml"
                       Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\VisitorApi\Index.cshtml"
                       Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 979, "\"", 1034, 3);
            WriteAttributeValue("", 986, "/Admin/VisitorApi/DeleteVisitor/", 986, 32, true);
#nullable restore
#line 32 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\VisitorApi\Index.cshtml"
WriteAttributeValue("", 1018, item.VisitorId, 1018, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1033, "/", 1033, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1111, "\"", 1166, 3);
            WriteAttributeValue("", 1118, "/Admin/VisitorApi/UpdateVisitor/", 1118, 32, true);
#nullable restore
#line 33 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\VisitorApi\Index.cshtml"
WriteAttributeValue("", 1150, item.VisitorId, 1150, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1165, "/", 1165, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Güncelle</a></td>\r\n                    </tr>\n");
#nullable restore
#line 35 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Areas\Admin\Views\VisitorApi\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n            </table>\r\n          </div>\r\n        <div class=\"col-md-2\">\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VisitorViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591