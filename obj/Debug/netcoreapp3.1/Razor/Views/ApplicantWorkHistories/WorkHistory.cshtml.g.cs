#pragma checksum "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e9c4a85a9a3e2fc3a0e3a6b727610c5ed55868"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicantWorkHistories_WorkHistory), @"mvc.1.0.view", @"/Views/ApplicantWorkHistories/WorkHistory.cshtml")]
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
#line 1 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\_ViewImports.cshtml"
using CareerCloudMVCCore2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\_ViewImports.cshtml"
using CareerCloudMVCCore2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e9c4a85a9a3e2fc3a0e3a6b727610c5ed55868", @"/Views/ApplicantWorkHistories/WorkHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b87fd65caef70895217929789aa11bcc98909c83", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicantWorkHistories_WorkHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CareerCloudMVCCore2.Models.ApplicantWorkHistory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ApplicantProfiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
  
    ViewData["Title"] = "WorkHistory";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>WorkHistory</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 13 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.JobDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.StartMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.StartYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.EndMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 34 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.EndYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 40 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 44 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 47 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 50 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 53 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.JobDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 56 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 59 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 62 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.EndMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 65 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
               Write(Html.DisplayFor(modelItem => item.EndYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8e9c4a85a9a3e2fc3a0e3a6b727610c5ed5586810963", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                </td>\n            </tr>\n");
#nullable restore
#line 75 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantWorkHistories\WorkHistory.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CareerCloudMVCCore2.Models.ApplicantWorkHistory>> Html { get; private set; }
    }
}
#pragma warning restore 1591