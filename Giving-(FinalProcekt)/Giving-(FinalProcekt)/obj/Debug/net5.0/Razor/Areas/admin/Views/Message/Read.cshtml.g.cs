#pragma checksum "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9972e760db3f021e365e4253bbead70dedd2794"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Message_Read), @"mvc.1.0.view", @"/Areas/admin/Views/Message/Read.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9972e760db3f021e365e4253bbead70dedd2794", @"/Areas/admin/Views/Message/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0123ff20ca18bd566b9dce902e61ea6e6e844492", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Message_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contact>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
   ViewData["Title"] = "Read";
    Layout = "~/Areas/admin/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row justify-content-center"">
        <div class=""alert col-lg-10 my-5"" style=""background-color: #d8d8d8d1; border-radius: 20px !important;"">
            <div class=""align-items-center d-flex flex-lg-row justify-content-between"">
                <h2 class=""m-0""> ");
#nullable restore
#line 10 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <span style=\"font-size: 13px; color: #fff; background: #7b77fc; border-radius: 6px;\">\r\n");
#nullable restore
#line 12 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                       var date = (DateTime.Now - Model.CreatedDate);
                        if (date.Days == 0)
                        {
                            if (date.Hours == 0)
                            {
                                if (date.Minutes == 0)
                                { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                              Write(date.Seconds);

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                                              Write(" seconds before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                                                                       }
                                else
                                { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                              Write(date.Minutes);

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                                              Write(" minutes before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                                                                       }
                            }
                            else
                            { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                          Write(date.Hours);

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                                        Write(" hours before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                                                               }
                        }
                        else
                        { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                      Write(date.Days);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                                   Write(" days before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                                                         } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                </span>\r\n            </div>\r\n            <span class=\"text-facebook\">");
#nullable restore
#line 29 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                                   Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <h6 class=\"mt-3 text-lg-center\" style=\"font-size: 22px !important; color: darkblue !important;\"> ");
#nullable restore
#line 30 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                                                                                                        Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n            <p class=\"m-0 alert alert-link text-center\" style=\"font-size: 18px !important;font-weight: 600 !important;font-style: italic !important;color: steelblue !important;\"> ");
#nullable restore
#line 31 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Message\Read.cshtml"
                                                                                                                                                                              Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9972e760db3f021e365e4253bbead70dedd279411717", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
