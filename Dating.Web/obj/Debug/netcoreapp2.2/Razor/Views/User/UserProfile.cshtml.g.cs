#pragma checksum "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ad1f411be5fc49303720f550ef2dcc607d496a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserProfile), @"mvc.1.0.view", @"/Views/User/UserProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UserProfile.cshtml", typeof(AspNetCore.Views_User_UserProfile))]
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
#line 1 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\_ViewImports.cshtml"
using Dating.Web;

#line default
#line hidden
#line 2 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\_ViewImports.cshtml"
using Dating.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ad1f411be5fc49303720f550ef2dcc607d496a3", @"/Views/User/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2c69ad9a619bb85783273b0ab811282a458d6bb", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dating.Entities.Profile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml"
  
    ViewData["Title"] = "User Profile";

#line default
#line hidden
            BeginContext(82, 143, true);
            WriteLiteral("\r\n<h1>UserProfile</h1>\r\n\r\n<div>\r\n    <h4>Profile</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n       \r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(226, 45, false);
#line 15 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(271, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(335, 41, false);
#line 18 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(376, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(439, 44, false);
#line 21 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(483, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(547, 40, false);
#line 24 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(587, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(650, 42, false);
#line 27 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(692, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(756, 38, false);
#line 30 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(794, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(857, 46, false);
#line 33 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml"
       Write(Html.DisplayNameFor(model => model.Occupation));

#line default
#line hidden
            EndContext();
            BeginContext(903, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(967, 42, false);
#line 36 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml"
       Write(Html.DisplayFor(model => model.Occupation));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1072, 50, false);
#line 39 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml"
       Write(Html.DisplayNameFor(model => model.AlternateEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1186, 46, false);
#line 42 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml"
       Write(Html.DisplayFor(model => model.AlternateEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1232, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1295, 48, false);
#line 45 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml"
       Write(Html.DisplayNameFor(model => model.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1407, 44, false);
#line 48 "F:\f\varsha_Kone\IIHT\CaseStudy\Revised\FSEPA\CodeSolution\DatingApp\Dating.Web\Views\User\UserProfile.cshtml"
       Write(Html.DisplayFor(model => model.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dating.Entities.Profile> Html { get; private set; }
    }
}
#pragma warning restore 1591
