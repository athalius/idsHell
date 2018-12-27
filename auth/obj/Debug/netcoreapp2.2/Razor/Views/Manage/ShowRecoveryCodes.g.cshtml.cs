#pragma checksum "C:\Dev\dariel\idsHell\auth\Views\Manage\ShowRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "023809a4d56090513dea2c9d5422c027acdb8787"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ShowRecoveryCodes), @"mvc.1.0.view", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/ShowRecoveryCodes.cshtml", typeof(AspNetCore.Views_Manage_ShowRecoveryCodes))]
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
#line 1 "C:\Dev\dariel\idsHell\auth\Views\_ViewImports.cshtml"
using StsServerIdentity;

#line default
#line hidden
#line 2 "C:\Dev\dariel\idsHell\auth\Views\_ViewImports.cshtml"
using StsServerIdentity.Models;

#line default
#line hidden
#line 3 "C:\Dev\dariel\idsHell\auth\Views\_ViewImports.cshtml"
using StsServerIdentity.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Dev\dariel\idsHell\auth\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Dev\dariel\idsHell\auth\Views\Manage\_ViewImports.cshtml"
using StsServerIdentity.Models.ManageViewModels;

#line default
#line hidden
#line 2 "C:\Dev\dariel\idsHell\auth\Views\Manage\_ViewImports.cshtml"
using StsServerIdentity.Views.Manage;

#line default
#line hidden
#line 1 "C:\Dev\dariel\idsHell\auth\Views\Manage\ShowRecoveryCodes.cshtml"
using StsServerIdentity.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"023809a4d56090513dea2c9d5422c027acdb8787", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb4a04f4a80204e19bfa929c1176379d28e4671", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec3bbe089bad6ebf0a22e3265e9a50ad63580976", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_ShowRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShowRecoveryCodesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Dev\dariel\idsHell\auth\Views\Manage\ShowRecoveryCodes.cshtml"
  
    ViewData["Title"] = @SharedLocalizer.GetLocalizedHtmlString("Recovery codes");
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
            BeginContext(267, 6, true);
            WriteLiteral("\r\n<h4>");
            EndContext();
            BeginContext(274, 17, false);
#line 9 "C:\Dev\dariel\idsHell\auth\Views\Manage\ShowRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(291, 139, true);
            WriteLiteral("</h4>\r\n<div class=\"alert alert-warning\" role=\"alert\">\r\n    <p>\r\n        <span class=\"fas fa-exclamation-triangle\"></span>\r\n        <strong>");
            EndContext();
            BeginContext(431, 74, false);
#line 13 "C:\Dev\dariel\idsHell\auth\Views\Manage\ShowRecoveryCodes.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Put these codes in a safe place."));

#line default
#line hidden
            EndContext();
            BeginContext(505, 38, true);
            WriteLiteral("</strong>\r\n    </p>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(544, 137, false);
#line 16 "C:\Dev\dariel\idsHell\auth\Views\Manage\ShowRecoveryCodes.cshtml"
   Write(SharedLocalizer.GetLocalizedHtmlString("If you lose your device and don't have the recovery codes you will lose access to your account."));

#line default
#line hidden
            EndContext();
            BeginContext(681, 68, true);
            WriteLiteral("\r\n    </p>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
            EndContext();
#line 21 "C:\Dev\dariel\idsHell\auth\Views\Manage\ShowRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Length; row += 2)
        {

#line default
#line hidden
            BeginContext(832, 18, true);
            WriteLiteral("            <code>");
            EndContext();
            BeginContext(851, 24, false);
#line 23 "C:\Dev\dariel\idsHell\auth\Views\Manage\ShowRecoveryCodes.cshtml"
             Write(Model.RecoveryCodes[row]);

#line default
#line hidden
            EndContext();
            BeginContext(875, 7, true);
            WriteLiteral("</code>");
            EndContext();
            BeginContext(888, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(901, 6, true);
            WriteLiteral("<code>");
            EndContext();
            BeginContext(908, 28, false);
#line 23 "C:\Dev\dariel\idsHell\auth\Views\Manage\ShowRecoveryCodes.cshtml"
                                                                      Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
            EndContext();
            BeginContext(936, 15, true);
            WriteLiteral("</code><br />\r\n");
            EndContext();
#line 24 "C:\Dev\dariel\idsHell\auth\Views\Manage\ShowRecoveryCodes.cshtml"
        }

#line default
#line hidden
            BeginContext(962, 18, true);
            WriteLiteral("    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowRecoveryCodesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591