#pragma checksum "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c37d89e4ec3c1e328b74f624254791fc722617"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicantProfiles_Delete), @"mvc.1.0.view", @"/Views/ApplicantProfiles/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c37d89e4ec3c1e328b74f624254791fc722617", @"/Views/ApplicantProfiles/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b87fd65caef70895217929789aa11bcc98909c83", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicantProfiles_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CareerCloudMVCCore2.Models.ApplicantProfiles>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>ApplicantProfiles</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 15 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 18 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CurrentSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 21 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 24 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CurrentRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 27 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 30 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 33 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StateProvinceCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 36 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StateProvinceCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 39 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StreetAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 42 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StreetAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 45 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CityTown));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 48 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CityTown));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 51 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ZipPostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 54 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ZipPostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 57 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 60 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 63 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CountryCodeNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 66 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CountryCodeNavigation.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd class>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 69 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LoginNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 72 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LoginNavigation.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd class>\n    </dl>\n    \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9c37d89e4ec3c1e328b74f624254791fc72261712557", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9c37d89e4ec3c1e328b74f624254791fc72261712822", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 77 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\ApplicantProfiles\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9c37d89e4ec3c1e328b74f624254791fc72261714658", async() => {
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
                WriteLiteral("\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CareerCloudMVCCore2.Models.ApplicantProfiles> Html { get; private set; }
    }
}
#pragma warning restore 1591
