#pragma checksum "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a2e1a57d7e1499abd02a4b2cdda1d727ecbf515"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_TwoFactorAuthentication), @"mvc.1.0.view", @"/Views/Manage/TwoFactorAuthentication.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/TwoFactorAuthentication.cshtml", typeof(AspNetCore.Views_Manage_TwoFactorAuthentication))]
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
#line 1 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
using StsServerIdentity.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2e1a57d7e1499abd02a4b2cdda1d727ecbf515", @"/Views/Manage/TwoFactorAuthentication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb4a04f4a80204e19bfa929c1176379d28e4671", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec3bbe089bad6ebf0a22e3265e9a50ad63580976", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_TwoFactorAuthentication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TwoFactorAuthenticationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateRecoveryCodes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Disable2faWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateRecoveryCodesWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("enable-authenticator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnableAuthenticator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("reset-authenticator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResetAuthenticatorWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 4 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
  
    ViewData["Title"] = @SharedLocalizer.GetLocalizedHtmlString("2FA_AUTHENTICATION_TITLE");
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
            BeginContext(283, 6, true);
            WriteLiteral("\r\n<h4>");
            EndContext();
            BeginContext(290, 17, false);
#line 9 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(307, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 10 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
 if (Model.Is2faEnabled)
{
    if (Model.RecoveryCodesLeft == 0)
    {

#line default
#line hidden
            BeginContext(389, 62, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>");
            EndContext();
            BeginContext(452, 59, false);
#line 15 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("2FA_NO_CODES_LEFT"));

#line default
#line hidden
            EndContext();
            BeginContext(511, 26, true);
            WriteLiteral("</strong>\r\n            <p>");
            EndContext();
            BeginContext(538, 64, false);
#line 16 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
          Write(SharedLocalizer.GetLocalizedHtmlString("2FA_NO_CODES_LEFT_TEXT"));

#line default
#line hidden
            EndContext();
            BeginContext(602, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(603, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a2e1a57d7e1499abd02a4b2cdda1d727ecbf5158532", async() => {
                BeginContext(642, 50, false);
#line 16 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                                                  Write(SharedLocalizer.GetLocalizedHtmlString("GENERATE"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(696, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 18 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
    }
    else if (Model.RecoveryCodesLeft == 1)
    {

#line default
#line hidden
            BeginContext(776, 62, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>");
            EndContext();
            BeginContext(839, 60, false);
#line 22 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("2FA_ONE_CODES_LEFT"));

#line default
#line hidden
            EndContext();
            BeginContext(899, 26, true);
            WriteLiteral("</strong>\r\n            <p>");
            EndContext();
            BeginContext(926, 65, false);
#line 23 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
          Write(SharedLocalizer.GetLocalizedHtmlString("2FA_ONE_CODES_LEFT_TEXT"));

#line default
#line hidden
            EndContext();
            BeginContext(991, 48, true);
            WriteLiteral("  You can generate a new set of recovery codes. ");
            EndContext();
            BeginContext(1039, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a2e1a57d7e1499abd02a4b2cdda1d727ecbf51511326", async() => {
                BeginContext(1078, 50, false);
#line 23 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                                                                                                  Write(SharedLocalizer.GetLocalizedHtmlString("GENERATE"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1132, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 25 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
    }
    else if (Model.RecoveryCodesLeft <= 3)
    {

#line default
#line hidden
            BeginContext(1212, 63, true);
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            <strong>");
            EndContext();
            BeginContext(1276, 95, false);
#line 29 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
               Write(SharedLocalizer.GetLocalizedHtmlString("2FA_N_CODES_LEFT", @Model.RecoveryCodesLeft.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 26, true);
            WriteLiteral("</strong>\r\n            <p>");
            EndContext();
            BeginContext(1398, 63, false);
#line 30 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
          Write(SharedLocalizer.GetLocalizedHtmlString("2FA_N_CODES_LEFT_TEXT"));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1462, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a2e1a57d7e1499abd02a4b2cdda1d727ecbf51514162", async() => {
                BeginContext(1501, 50, false);
#line 30 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                                                 Write(SharedLocalizer.GetLocalizedHtmlString("GENERATE"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1555, 22, true);
            WriteLiteral("</p>\r\n        </div>\r\n");
            EndContext();
#line 32 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
    }


#line default
#line hidden
            BeginContext(1586, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1590, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a2e1a57d7e1499abd02a4b2cdda1d727ecbf51516034", async() => {
                BeginContext(1649, 60, false);
#line 34 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
                                                         Write(SharedLocalizer.GetLocalizedHtmlString("DISABLE_2FA_BUTTON"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1713, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1719, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a2e1a57d7e1499abd02a4b2cdda1d727ecbf51517697", async() => {
                BeginContext(1789, 62, false);
#line 35 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                    Write(SharedLocalizer.GetLocalizedHtmlString("RESET_RECOVERY_CODES"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1855, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 36 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
}

#line default
#line hidden
            BeginContext(1860, 6, true);
            WriteLiteral("\r\n<h5>");
            EndContext();
            BeginContext(1867, 59, false);
#line 38 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("AUTHENTICATOR_APP"));

#line default
#line hidden
            EndContext();
            BeginContext(1926, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 39 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
 if (!Model.HasAuthenticator)
{

#line default
#line hidden
            BeginContext(1967, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1971, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a2e1a57d7e1499abd02a4b2cdda1d727ecbf51520209", async() => {
                BeginContext(2059, 82, false);
#line 41 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                      Write(SharedLocalizer.GetLocalizedHtmlString("2FA_AUTHENTICATION_ADD_AUTHENTICATOR_APP"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 42 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2159, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(2163, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a2e1a57d7e1499abd02a4b2cdda1d727ecbf51522232", async() => {
                BeginContext(2250, 74, false);
#line 45 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                     Write(SharedLocalizer.GetLocalizedHtmlString("2FA_AUTHENTICATION_ADD_SETUP_APP"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2328, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2334, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a2e1a57d7e1499abd02a4b2cdda1d727ecbf51524020", async() => {
                BeginContext(2426, 74, false);
#line 46 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
                                                                                          Write(SharedLocalizer.GetLocalizedHtmlString("2FA_AUTHENTICATION_ADD_RESET_APP"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2504, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
}

#line default
#line hidden
            BeginContext(2509, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2529, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2536, 52, false);
#line 50 "C:\Dev\dariel\idsHell\auth\Views\Manage\TwoFactorAuthentication.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(2588, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TwoFactorAuthenticationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591