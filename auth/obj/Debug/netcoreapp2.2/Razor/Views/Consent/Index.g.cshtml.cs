#pragma checksum "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4fd6f92bf670adc876d05c406a79634dccc90d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent_Index), @"mvc.1.0.view", @"/Views/Consent/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/Index.cshtml", typeof(AspNetCore.Views_Consent_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4fd6f92bf670adc876d05c406a79634dccc90d7", @"/Views/Consent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea858037201615ee4c1dca99dcb565cc9ff3b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<auth.Models.ConsentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-scopecheck big_checkbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 111, true);
            WriteLiteral("\r\n<div class=\"page-consent\">\r\n    <div class=\"row page-header consent-form\">\r\n        <div class=\"col-sm-10\">\r\n");
            EndContext();
#line 6 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
             if (Model.ClientLogoUrl != null)
            {

#line default
#line hidden
            BeginContext(210, 45, true);
            WriteLiteral("                <div class=\"client-logo\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 255, "\"", 281, 1);
#line 8 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
WriteAttributeValue("", 261, Model.ClientLogoUrl, 261, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(282, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 9 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(306, 34, true);
            WriteLiteral("            <h1>\r\n                ");
            EndContext();
            BeginContext(341, 16, false);
#line 11 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
           Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(357, 168, true);
            WriteLiteral("\r\n\t\t\t\t<small>is requesting your permission</small>\r\n            </h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(526, 45, false);
#line 19 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
       Write(await Html.PartialAsync("_ValidationSummary"));

#line default
#line hidden
            EndContext();
            BeginContext(571, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(587, 2774, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4fd6f92bf670adc876d05c406a79634dccc90d77014", async() => {
                BeginContext(633, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(651, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4fd6f92bf670adc876d05c406a79634dccc90d77412", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 22 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(694, 72, true);
                WriteLiteral("\r\n\r\n\t\t\t\t<div>Uncheck the permissions you do not wish to grant.</div>\r\n\r\n");
                EndContext();
#line 26 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                 if (Model.IdentityScopes.Any())
                {

#line default
#line hidden
                BeginContext(835, 347, true);
                WriteLiteral(@"                    <div class=""panel panel-default consent-buttons"">
                        <div class=""panel-heading consent-title-spacing-bottom"">
                            <span class=""fas fa-user""></span>
                            Personal Information
                        </div>
                        <ul class=""list-group"">
");
                EndContext();
#line 34 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                             foreach (var scope in Model.IdentityScopes)
                            {
                                

#line default
#line hidden
                BeginContext(1320, 48, false);
#line 36 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                           Write(await Html.PartialAsync("_ScopeListItem", scope));

#line default
#line hidden
                EndContext();
#line 36 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                                                                                 
                            }

#line default
#line hidden
                BeginContext(1401, 59, true);
                WriteLiteral("                        </ul>\r\n                    </div>\r\n");
                EndContext();
#line 40 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1479, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 42 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                 if (Model.ResourceScopes.Any())
                {

#line default
#line hidden
                BeginContext(1550, 278, true);
                WriteLiteral(@"                    <div class=""panel panel-default"">
						<div class=""panel-heading consent-title-spacing-bottom consent-title-spacing-top"">
							<span class=""fas fa-tasks""></span>
							Application Access
						</div>
                        <ul class=""list-group"">
");
                EndContext();
#line 50 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                             foreach (var scope in Model.ResourceScopes)
                            {
                                

#line default
#line hidden
                BeginContext(1966, 48, false);
#line 52 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                           Write(await Html.PartialAsync("_ScopeListItem", scope));

#line default
#line hidden
                EndContext();
#line 52 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                                                                                 
                            }

#line default
#line hidden
                BeginContext(2047, 59, true);
                WriteLiteral("                        </ul>\r\n                    </div>\r\n");
                EndContext();
#line 56 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2125, 50, true);
                WriteLiteral("\r\n                <div class=\"consent-remember\">\r\n");
                EndContext();
#line 59 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                     if (Model.AllowRememberConsent)
                    {

#line default
#line hidden
                BeginContext(2252, 156, true);
                WriteLiteral("                        <div class=\"consent-title-spacing consent-title-spacing-top\">\r\n                            <label>\r\n                                ");
                EndContext();
                BeginContext(2408, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4fd6f92bf670adc876d05c406a79634dccc90d713225", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 63 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2483, 142, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<strong class=\"consent-middle\">Remember My Decision</strong>\r\n                            </label>\r\n                        </div>\r\n");
                EndContext();
#line 67 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(2648, 226, true);
                WriteLiteral("\r\n                    <div class=\"consent-buttons\">\r\n\t\t\t\t\t\t<button name=\"button\" value=\"yes\" class=\"btn btn-primary\" autofocus>Yes, Allow</button>\r\n\t\t\t\t\t\t<button name=\"button\" value=\"no\" class=\"btn\">No, Do Not Allow</button>\r\n");
                EndContext();
#line 72 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                         if (Model.ClientUrl != null)
                        {

#line default
#line hidden
                BeginContext(2956, 81, true);
                WriteLiteral("                            <a class=\"pull-right btn btn-primary\" target=\"_blank\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3037, "\"", 3060, 1);
#line 74 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
WriteAttributeValue("", 3044, Model.ClientUrl, 3044, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3061, 140, true);
                WriteLiteral(">\r\n                                <span class=\"fas fa-info-circle\"></span>\r\n                                <strong class=\"consent-middle\">");
                EndContext();
                BeginContext(3202, 16, false);
#line 76 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                                                          Write(Model.ClientName);

#line default
#line hidden
                EndContext();
                BeginContext(3218, 45, true);
                WriteLiteral("</strong>\r\n                            </a>\r\n");
                EndContext();
#line 78 "C:\Dev\dariel\idsHell\auth\Views\Consent\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(3290, 64, true);
                WriteLiteral("                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3361, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<auth.Models.ConsentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
