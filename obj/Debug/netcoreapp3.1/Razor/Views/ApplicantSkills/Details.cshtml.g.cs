#pragma checksum "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d7e6dc062f16206d373e6d3b56f5a9d4c086f73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicantSkills_Details), @"mvc.1.0.view", @"/Views/ApplicantSkills/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7e6dc062f16206d373e6d3b56f5a9d4c086f73", @"/Views/ApplicantSkills/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b87fd65caef70895217929789aa11bcc98909c83", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicantSkills_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CareerCloudMVCCore2.Models.ApplicantSkills>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>ApplicantSkills</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 14 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Skill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayFor(model => model.Skill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SkillLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayFor(model => model.SkillLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 32 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 35 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 38 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 41 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 44 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 47 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 50 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 53 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayFor(model => model.TimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 56 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicantNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 59 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApplicantNavigation.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d7e6dc062f16206d373e6d3b56f5a9d4c086f7310214", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d7e6dc062f16206d373e6d3b56f5a9d4c086f7312407", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CareerCloudMVCCore2.Models.ApplicantSkills> Html { get; private set; }
    }
}
#pragma warning restore 1591
