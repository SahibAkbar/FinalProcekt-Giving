#pragma checksum "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcaf3e90cd230de509a2c8bb7cf8b674295dce2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Cause_Index), @"mvc.1.0.view", @"/Areas/admin/Views/Cause/Index.cshtml")]
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
#line 1 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\_ViewImports.cshtml"
using Giving__FinalProcekt_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\_ViewImports.cshtml"
using Giving__FinalProcekt_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\_ViewImports.cshtml"
using Giving__FinalProcekt_.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\_ViewImports.cshtml"
using Giving__FinalProcekt_.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcaf3e90cd230de509a2c8bb7cf8b674295dce2b", @"/Areas/admin/Views/Cause/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"527317d724c3fc8aa1e02ae515f0e392fc1b846b", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Cause_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cause>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3 px-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cause", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: unset !important; width: 100% !important; height: 100% !important; object-fit: contain !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 btn-sm btn btn-facebook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-2 w-100 btn-sm btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 btn-sm btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
   ViewData["Title"] = "Index";
                Layout = "~/Areas/admin/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title text-center"" style=""font-size: 35px !important; font-weight: 600 !important; color: #3b579d !important; "">Causes</h4>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcaf3e90cd230de509a2c8bb7cf8b674295dce2b9396", async() => {
                WriteLiteral("Create New <i class=\"fas fa-plus\"></i>");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 13 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                   if (TempData["CauseError"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-size: 20px !important;\" class=\"alert alert-danger\">");
#nullable restore
#line 15 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                                                                                     Write(TempData["CauseError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> ");
#nullable restore
#line 15 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                                                                                                                      TempData["CauseError"] = null;
                    }
                    if (TempData["CauseError1"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-size: 20px !important;\" class=\"alert alert-danger\">");
#nullable restore
#line 19 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                                                                                     Write(TempData["CauseError1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> ");
#nullable restore
#line 19 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                                                                                                                       TempData["CauseError1"] = null;
                    } 
                 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""table-responsive"">
                    <table class=""table table-bordered text-center"">
                        <thead>
                            <tr>
                                <th class=""tableTrCustom"">
                                    #
                                </th>
                                <th class=""tableTrCustom"">
                                    Image
                                </th>
                                <th class=""tableTrCustom"">
                                    Title
                                </th>
                                <th class=""tableTrCustom"">
                                    Address
                                </th>
                                <th class=""tableTrCustom"">
                                    Cause Need
                                </th>
                                <th class=""tableTrCustom"">
                                    Created Date
                                </th>");
            WriteLiteral("\n                                <th class=\"tableTrCustom\">\n                                    Edit\n                                </th>\n                            </tr>\n                        </thead>\n                        <tbody>\n");
#nullable restore
#line 50 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                               int counter = 0;
                            foreach (var item in Model)
                            {
                                counter++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <tr>\n                                     <td style=\"font-size: 18px !important; font-weight: 500 !important;\">\n                                         ");
#nullable restore
#line 56 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                                    Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                     </td>\n                                     <td class=\"py-1\" style=\" width: 300px !important; height: 150px !important;\">\n                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dcaf3e90cd230de509a2c8bb7cf8b674295dce2b15539", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3057, "~/Uploads/", 3057, 10, true);
#nullable restore
#line 59 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
AddHtmlAttributeValue("", 3067, item.Image, 3067, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                     </td>\n                                     <td style=\"font-size: 18px !important; width: 150px; font-weight: 500 !important;\">\n                                         ");
#nullable restore
#line 62 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                     </td>\n                                     <td style=\"width: 150px !important; font-size: 18px !important; font-weight: 500 !important;\">\n                                         ");
#nullable restore
#line 65 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                                    Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                     </td>\n                                     <td style=\"width: 150px !important; font-size: 18px !important; font-weight: 500 !important;\">\n                                         ");
#nullable restore
#line 68 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                                    Write(item.CauseNeed);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                     </td>\n                                     <td style=\"font-size: 18px !important; width: 150px; font-weight: 500 !important;\">\n                                         ");
#nullable restore
#line 71 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                                    Write(item.CreatedDate.ToString("MMMM,dd,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                     </td>\n                                     <td style=\"width: 150px;\">\n                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcaf3e90cd230de509a2c8bb7cf8b674295dce2b19392", async() => {
                WriteLiteral("<i class=\"fas fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                         <br />\n                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcaf3e90cd230de509a2c8bb7cf8b674295dce2b22218", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                         <br>\n                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcaf3e90cd230de509a2c8bb7cf8b674295dce2b25047", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                     </td>\n                                 </tr>\n");
#nullable restore
#line 81 "C:\Users\Sahib\Desktop\BackEnd\Giving-(FinalProcekt)\Giving-(FinalProcekt)\Areas\admin\Views\Cause\Index.cshtml"
 } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cause>> Html { get; private set; }
    }
}
#pragma warning restore 1591
