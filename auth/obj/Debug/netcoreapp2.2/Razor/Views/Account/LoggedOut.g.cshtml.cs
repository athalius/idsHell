#pragma checksum "C:\Dev\dariel\idsHell\auth\Views\Account\LoggedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd8af0a2ba2816201125b109711460282bf5fb9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_LoggedOut), @"mvc.1.0.view", @"/Views/Account/LoggedOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/LoggedOut.cshtml", typeof(AspNetCore.Views_Account_LoggedOut))]
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
using auth;

#line default
#line hidden
#line 2 "C:\Dev\dariel\idsHell\auth\Views\_ViewImports.cshtml"
using auth.Models;

#line default
#line hidden
#line 3 "C:\Dev\dariel\idsHell\auth\Views\_ViewImports.cshtml"
using auth.Models.AccountViewModels;

#line default
#line hidden
#line 4 "C:\Dev\dariel\idsHell\auth\Views\_ViewImports.cshtml"
using auth.Models.ManageViewModels;

#line default
#line hidden
#line 5 "C:\Dev\dariel\idsHell\auth\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd8af0a2ba2816201125b109711460282bf5fb9e", @"/Views/Account/LoggedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea858037201615ee4c1dca99dcb565cc9ff3b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_LoggedOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<auth.Models.AccountViewModels.LoggedOutViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 123, true);
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <h1>\r\n\t\t<small>You have successfully logged out of the application.</small>\r\n    </h1>\r\n\r\n");
            EndContext();
#line 8 "C:\Dev\dariel\idsHell\auth\Views\Account\LoggedOut.cshtml"
     if (Model.PostLogoutRedirectUri != null)
    {

#line default
#line hidden
            BeginContext(234, 22, true);
            WriteLiteral("\t<div>\r\n\t\tReturn to <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 256, "\"", 291, 1);
#line 11 "C:\Dev\dariel\idsHell\auth\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 263, Model.PostLogoutRedirectUri, 263, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(292, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(294, 16, false);
#line 11 "C:\Dev\dariel\idsHell\auth\Views\Account\LoggedOut.cshtml"
                                                    Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(310, 15, true);
            WriteLiteral("</a>\r\n\t</div>\r\n");
            EndContext();
#line 13 "C:\Dev\dariel\idsHell\auth\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            BeginContext(332, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Dev\dariel\idsHell\auth\Views\Account\LoggedOut.cshtml"
     if (Model.SignOutIframeUrl != null)
    {

#line default
#line hidden
            BeginContext(383, 73, true);
            WriteLiteral("        <iframe style=\"display:none\" width=\"0\" height=\"0\" class=\"signout\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 456, "\"", 485, 1);
#line 17 "C:\Dev\dariel\idsHell\auth\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 462, Model.SignOutIframeUrl, 462, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(486, 12, true);
            WriteLiteral("></iframe>\r\n");
            EndContext();
#line 18 "C:\Dev\dariel\idsHell\auth\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            BeginContext(505, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<auth.Models.AccountViewModels.LoggedOutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
