#pragma checksum "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a096779fb40d4f0f5725ae06ea0f48b2eea9cb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Donate_Index), @"mvc.1.0.view", @"/Areas/admin/Views/Donate/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a096779fb40d4f0f5725ae06ea0f48b2eea9cb0", @"/Areas/admin/Views/Donate/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0123ff20ca18bd566b9dce902e61ea6e6e844492", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Donate_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Donate>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Donate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n");
            WriteLiteral(@"        </div>
        <div class=""col-lg-12"">
            <table class=""table"">
                <thead style=""text-align:center;"">
                    <tr>
                        <th style=""text-align:center"" scope=""col"">#</th>
                        <th style=""text-align:center"" scope=""col"">First Name</th>
                        <th style=""text-align:center"" scope=""col"">Last Name</th>
                        <th style=""text-align:center"" scope=""col"">Email</th>
                        <th style=""text-align:center"" scope=""col"">Phone</th>
                        <th style=""text-align:center"" scope=""col"">Address</th>
                        <th style=""text-align:center"" scope=""col"">Not</th>
                        <th style=""text-align:center"" scope=""col"">Price</th>
                        <th style=""text-align:center"" scope=""col"">Created Date</th>
                        <th style=""text-align:center"" scope=""col""><i class=""icon-note menu-icon""></i></th>
                    </tr>
             ");
            WriteLiteral("   </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                     for (int i = 1; i < Model.Count + 1; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr style=\"position:relative\">\r\n                        <th scope=\"row\" style=\"vertical-align:middle;\">");
#nullable restore
#line 31 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td style=\"text-align:center\">");
#nullable restore
#line 32 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                                 Write(Model[i - 1].FName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
#nullable restore
#line 33 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                                 Write(Model[i - 1].LName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
#nullable restore
#line 34 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                                 Write(Model[i - 1].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
#nullable restore
#line 35 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                                 Write(Model[i - 1].Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
#nullable restore
#line 36 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                                 Write(Model[i - 1].Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">");
#nullable restore
#line 37 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                                 Write(Model[i - 1].Not);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td data-field=\"\" class=\"datatable-cell\">\r\n                            <span style=\"width: 146px;\">\r\n");
#nullable restore
#line 40 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                  
                                    if (Model[i - 1] != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                         foreach (var item in Model[i - 1].DonatePrices)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"font-weight-bolder font-size-lg mb-0\">");
#nullable restore
#line 45 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                                                                         Write(item?.Priceee.Money);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 46 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                         
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </span>\r\n                        </td>\r\n                        <td style=\"text-align:center\">");
#nullable restore
#line 51 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                                 Write(Model[i - 1].CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">\r\n");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a096779fb40d4f0f5725ae06ea0f48b2eea9cb013036", async() => {
                WriteLiteral("Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                                                                                                      WriteLiteral(Model[i - 1].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a096779fb40d4f0f5725ae06ea0f48b2eea9cb015815", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                                                                                                                     WriteLiteral(Model[i - 1].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"card-content\">\r\n                                <div class=\"sweetalert m-t-30\">\r\n");
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Sahib\Desktop\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Donate\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Donate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
