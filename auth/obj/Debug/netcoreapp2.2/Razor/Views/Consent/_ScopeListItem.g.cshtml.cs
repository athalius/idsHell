#pragma checksum "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc8ad043457b94b7c006c08c96bdb022bf07203a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent__ScopeListItem), @"mvc.1.0.view", @"/Views/Consent/_ScopeListItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/_ScopeListItem.cshtml", typeof(AspNetCore.Views_Consent__ScopeListItem))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc8ad043457b94b7c006c08c96bdb022bf07203a", @"/Views/Consent/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea858037201615ee4c1dca99dcb565cc9ff3b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<auth.Models.ScopeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(37, 138, true);
            WriteLiteral("\r\n<li class=\"list-group-item\">\r\n    <label>\r\n        <input class=\"consent-scopecheck big_checkbox\" type=\"checkbox\" name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("id", " \r\n               id=\"", 175, "\"", 215, 2);
            WriteAttributeValue("", 197, "scopes_", 197, 7, true);
#line 7 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 204, Model.Name, 204, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 216, "\"", 235, 1);
#line 7 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 224, Model.Name, 224, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 236, "\"", 260, 1);
#line 7 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 246, Model.Checked, 246, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("disabled", " disabled=\"", 261, "\"", 287, 1);
#line 7 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 272, Model.Required, 272, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(288, 7, true);
            WriteLiteral(" />\r\n\r\n");
            EndContext();
#line 9 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
            BeginContext(336, 55, true);
            WriteLiteral("            <input type=\"hidden\" name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 391, "\"", 410, 1);
#line 11 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 399, Model.Name, 399, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(411, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 12 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
        }

#line default
#line hidden
            BeginContext(427, 39, true);
            WriteLiteral("        <strong class=\"consent-middle\">");
            EndContext();
            BeginContext(467, 17, false);
#line 13 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
                                  Write(Model.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(484, 11, true);
            WriteLiteral("</strong>\r\n");
            EndContext();
#line 14 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
            BeginContext(537, 69, true);
            WriteLiteral("            <span class=\"fas fa-exclamation consent-middle\"></span>\r\n");
            EndContext();
#line 17 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
        }

#line default
#line hidden
            BeginContext(617, 16, true);
            WriteLiteral("    </label>\r\n\r\n");
            EndContext();
#line 20 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
            BeginContext(666, 71, true);
            WriteLiteral("        <span class=\"consent-middle\"><em>Consent required</em></span>\r\n");
            EndContext();
#line 23 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
    }

#line default
#line hidden
            BeginContext(744, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 24 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
            BeginContext(788, 42, true);
            WriteLiteral("        <div class=\"\">\r\n            <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 830, "\"", 854, 2);
            WriteAttributeValue("", 836, "scopes_", 836, 7, true);
#line 27 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 843, Model.Name, 843, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(855, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(857, 17, false);
#line 27 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(874, 26, true);
            WriteLiteral("</label>\r\n        </div>\r\n");
            EndContext();
#line 29 "C:\Dev\dariel\idsHell\auth\Views\Consent\_ScopeListItem.cshtml"
    }

#line default
#line hidden
            BeginContext(907, 7, true);
            WriteLiteral("\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<auth.Models.ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
