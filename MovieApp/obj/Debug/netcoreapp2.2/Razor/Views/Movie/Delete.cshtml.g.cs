#pragma checksum "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e34ee0df5e1e5002c9883c2ae553bc9b4ace1d8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Delete), @"mvc.1.0.view", @"/Views/Movie/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Delete.cshtml", typeof(AspNetCore.Views_Movie_Delete))]
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
#line 1 "C:\Users\santo\source\repos\MovieApp\Views\_ViewImports.cshtml"
using MovieApp;

#line default
#line hidden
#line 2 "C:\Users\santo\source\repos\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e34ee0df5e1e5002c9883c2ae553bc9b4ace1d8d", @"/Views/Movie/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0301d5cca4a9345895d039cc67d16e7b77f0437f", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieApp.Models.MovieModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(79, 180, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>MovieModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(260, 47, false);
#line 15 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseYear));

#line default
#line hidden
            EndContext();
            BeginContext(307, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(371, 43, false);
#line 18 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseYear));

#line default
#line hidden
            EndContext();
            BeginContext(414, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(477, 41, false);
#line 21 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(518, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(582, 37, false);
#line 24 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(619, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(682, 52, false);
#line 27 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OriginEthinicity));

#line default
#line hidden
            EndContext();
            BeginContext(734, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(798, 48, false);
#line 30 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OriginEthinicity));

#line default
#line hidden
            EndContext();
            BeginContext(846, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(909, 44, false);
#line 33 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
            EndContext();
            BeginContext(953, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1017, 40, false);
#line 36 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Director));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1120, 40, false);
#line 39 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cast));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1224, 36, false);
#line 42 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cast));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1323, 41, false);
#line 45 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1364, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1428, 37, false);
#line 48 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1465, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1528, 44, false);
#line 51 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.WikiPage));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1636, 40, false);
#line 54 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayFor(model => model.WikiPage));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1739, 40, false);
#line 57 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Plot));

#line default
#line hidden
            EndContext();
            BeginContext(1779, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1843, 36, false);
#line 60 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Plot));

#line default
#line hidden
            EndContext();
            BeginContext(1879, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1917, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e34ee0df5e1e5002c9883c2ae553bc9b4ace1d8d11377", async() => {
                BeginContext(1943, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1953, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e34ee0df5e1e5002c9883c2ae553bc9b4ace1d8d11770", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "C:\Users\santo\source\repos\MovieApp\Views\Movie\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1989, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2072, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e34ee0df5e1e5002c9883c2ae553bc9b4ace1d8d13659", async() => {
                    BeginContext(2094, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2110, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2123, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieApp.Models.MovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591