#pragma checksum "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35c48f8fececea5e97084fd1701a75625953ff1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicantSkills_Skills), @"mvc.1.0.view", @"/Views/ApplicantSkills/Skills.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35c48f8fececea5e97084fd1701a75625953ff1e", @"/Views/ApplicantSkills/Skills.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b87fd65caef70895217929789aa11bcc98909c83", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicantSkills_Skills : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<CareerCloudMVCCore2.Models.ApplicantSkills>>
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
#line 3 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
  
    ViewData["Title"] = "Skills";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Skills</h1>\n\n");
#nullable restore
#line 9 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <hr />\n        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 15 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
           Write(Html.DisplayNameFor(model => item.Skill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 18 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
           Write(Html.DisplayFor(model => item.Skill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 21 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
           Write(Html.DisplayNameFor(model => item.SkillLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 24 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
           Write(Html.DisplayFor(model => item.SkillLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 27 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
           Write(Html.DisplayNameFor(model => item.StartMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 30 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
           Write(Html.DisplayFor(model => item.StartMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 33 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
           Write(Html.DisplayNameFor(model => item.StartYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 36 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
           Write(Html.DisplayFor(model => item.StartYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 39 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
           Write(Html.DisplayNameFor(model => item.EndMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 42 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
           Write(Html.DisplayFor(model => item.EndMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 45 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
           Write(Html.DisplayNameFor(model => item.EndYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 48 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
           Write(Html.DisplayFor(model => item.EndYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n        </dl>\n    </div>\n");
#nullable restore
#line 52 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantSkills\Skills.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35c48f8fececea5e97084fd1701a75625953ff1e9422", async() => {
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
            WriteLiteral("\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<CareerCloudMVCCore2.Models.ApplicantSkills>> Html { get; private set; }
    }
}
#pragma warning restore 1591
