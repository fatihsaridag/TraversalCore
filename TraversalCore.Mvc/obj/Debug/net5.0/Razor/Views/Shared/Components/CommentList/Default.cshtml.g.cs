#pragma checksum "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Views\Shared\Components\CommentList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3133270f47d33b53fb2d1233cbe6013c764bbe0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CommentList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CommentList/Default.cshtml")]
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
#line 1 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Views\_ViewImports.cshtml"
using TraversalCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Views\_ViewImports.cshtml"
using TraversalCore.Mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Views\Shared\Components\CommentList\Default.cshtml"
using TraversalCore.Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3133270f47d33b53fb2d1233cbe6013c764bbe0", @"/Views/Shared/Components/CommentList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8ba70adfb94f3ba894fb705149ca11d7c3a5f5d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CommentList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Liberty/assets/images/c1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"comments mt-5\">\r\n    <h4 class=\"side-title \">Yorumlar </h4>\r\n");
#nullable restore
#line 6 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Views\Shared\Components\CommentList\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"media mt-4\">\r\n            <div class=\"img-circle\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3133270f47d33b53fb2d1233cbe6013c764bbe05158", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"media-body\">\r\n\r\n                <ul class=\"time-rply mb-2\">\r\n                    <li>\r\n                        <a href=\"#URL\" class=\"name mt-0 mb-2 d-block\">");
#nullable restore
#line 16 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Views\Shared\Components\CommentList\Default.cshtml"
                                                                 Write(item.CommentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                      ");
#nullable restore
#line 17 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Views\Shared\Components\CommentList\Default.cshtml"
                 Write(item.CommentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </li>
                    <li class=""reply-last"">
                        <a href=""#reply"" class=""reply"">
                            Reply
                        </a>
                    </li>
                </ul>
                <p>
                 ");
#nullable restore
#line 27 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Views\Shared\Components\CommentList\Default.cshtml"
            Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\fatih\source\repos\AspNetCore-Mvc-TraversalCore-Project\TraversalCore.Mvc\Views\Shared\Components\CommentList\Default.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
