#pragma checksum "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c52040662a3971a3e5ae8a94d2e74d7d4b8507d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Cause_Detail), @"mvc.1.0.view", @"/Areas/admin/Views/Cause/Detail.cshtml")]
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
#line 1 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\_ViewImports.cshtml"
using Giving__FinalProcekt_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\_ViewImports.cshtml"
using Giving__FinalProcekt_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\_ViewImports.cshtml"
using Giving__FinalProcekt_.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\_ViewImports.cshtml"
using Giving__FinalProcekt_.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c52040662a3971a3e5ae8a94d2e74d7d4b8507d", @"/Areas/admin/Views/Cause/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0123ff20ca18bd566b9dce902e61ea6e6e844492", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Cause_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cause>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100% !important;height: auto !important;object-fit: contain;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top pt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row my-4\">\r\n");
#nullable restore
#line 9 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Detail.cshtml"
           if (TempData["CommentError2"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p style=\"font-size: 20px !important;\" class=\"alert alert-danger col-lg-12 text-center\">");
#nullable restore
#line 11 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Detail.cshtml"
                                                                                                   Write(TempData["CommentError2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> ");
#nullable restore
#line 11 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Detail.cshtml"
                                                                                                                                       TempData["CommentError2"] = null;
            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12\">\r\n            <div class=\"card text-center\">\r\n                <div class=\"card-header\">\r\n                    <span class=\"text-linkedin\" style=\"font-size: 22px !important; font-weight: 600 !important;\">");
#nullable restore
#line 16 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Detail.cshtml"
                                                                                                            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div>\r\n");
            WriteLiteral("                    <div style=\"width: 500px !important; height: auto !important; margin-left: auto !important; margin-right: auto !important;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c52040662a3971a3e5ae8a94d2e74d7d4b8507d7375", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1531, "~/Uploads/", 1531, 10, true);
#nullable restore
#line 26 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Detail.cshtml"
AddHtmlAttributeValue("", 1541, Model.Image, 1541, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral("                    <div>\r\n                        <p class=\"py-3 text-facebook\" style=\"font-size: 18px !important; font-weight: 600 !important;\"> <span class=\"text-body\" style=\"font-size: 22px !important;\">Address</span>: ");
#nullable restore
#line 36 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Detail.cshtml"
                                                                                                                                                                                               Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                    <div>
                        <p class=""py-3 text-facebook"" style=""font-size: 18px !important; font-weight: 600 !important;""> <span class=""text-body"" style=""font-size: 22px !important;"">Created Date</span>: ");
#nullable restore
#line 39 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Detail.cshtml"
                                                                                                                                                                                                    Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                    <div>
                        <p class=""py-3 text-facebook"" style=""font-size: 18px !important; font-weight: 600 !important;""> <span class=""text-body"" style=""font-size: 22px !important;"">CauseNeed</span>: ");
#nullable restore
#line 42 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Detail.cshtml"
                                                                                                                                                                                                 Write(Model.CauseNeed);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>

                </div>
                <div class=""card-body"">
                    <p class=""alert alert-light border card-text shadow-sm text-facebook"" style=""font-size: 17px !important; font-weight: 500 !important;"">");
#nullable restore
#line 47 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Detail.cshtml"
                                                                                                                                                      Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cause> Html { get; private set; }
    }
}
#pragma warning restore 1591
