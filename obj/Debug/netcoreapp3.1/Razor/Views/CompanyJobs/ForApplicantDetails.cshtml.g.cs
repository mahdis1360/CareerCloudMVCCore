#pragma checksum "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\CompanyJobs\ForApplicantDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1d5e8b9306732c7ffcf7b4af56c45f02050adbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompanyJobs_ForApplicantDetails), @"mvc.1.0.view", @"/Views/CompanyJobs/ForApplicantDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d5e8b9306732c7ffcf7b4af56c45f02050adbb", @"/Views/CompanyJobs/ForApplicantDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b87fd65caef70895217929789aa11bcc98909c83", @"/Views/_ViewImports.cshtml")]
    public class Views_CompanyJobs_ForApplicantDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CareerCloudMVCCore2.Models.CompanyJobs>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\CompanyJobs\ForApplicantDetails.cshtml"
  
    ViewData["Title"] = "ForApplicantDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("<div>\n    ");
#nullable restore
#line 34 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\CompanyJobs\ForApplicantDetails.cshtml"
Write(Html.Partial("_CompanyJobDescriptions", Model.CompanyJobsDescriptions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    ");
#nullable restore
#line 37 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\CompanyJobs\ForApplicantDetails.cshtml"
Write(Html.Partial("_CompanyJobSkills", Model.CompanyJobSkills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    ");
#nullable restore
#line 40 "C:\Users\mahdi\Desktop\CareerCloudMVCCore-master\CareerCloudMVCCore-master\CareerCloudMVCCore2\Views\CompanyJobs\ForApplicantDetails.cshtml"
Write(Html.Partial("_CompanyJobEducations", Model.CompanyJobEducations));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CareerCloudMVCCore2.Models.CompanyJobs> Html { get; private set; }
    }
}
#pragma warning restore 1591
