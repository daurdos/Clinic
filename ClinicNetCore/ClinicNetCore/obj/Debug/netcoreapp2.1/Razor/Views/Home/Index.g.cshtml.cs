#pragma checksum "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicGit\ClinicNetCore\ClinicNetCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eb00961d2b4fcd242796f77f4e50c665add97bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicGit\ClinicNetCore\ClinicNetCore\Views\_ViewImports.cshtml"
using ClinicNetCore;

#line default
#line hidden
#line 2 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicGit\ClinicNetCore\ClinicNetCore\Views\_ViewImports.cshtml"
using ClinicNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb00961d2b4fcd242796f77f4e50c665add97bc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a1f0fd4369c7897952ffb2965e224352a314fff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClinicNetCore.Models.Patient>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/FillPatient"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/SearchPatient"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicGit\ClinicNetCore\ClinicNetCore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Каталог товаров";

#line default
#line hidden
            BeginContext(101, 165, true);
            WriteLiteral("<h3>Patients</h3>\r\n<table class=\"table-condensed\">\r\n    <tr>\r\n        <td>Name</td>\r\n        <td>Address</td>\r\n        <td>Phone</td>\r\n        <td></td>\r\n    </tr>\r\n");
            EndContext();
#line 13 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicGit\ClinicNetCore\ClinicNetCore\Views\Home\Index.cshtml"
     foreach (var patient in Model)
    {

#line default
#line hidden
            BeginContext(310, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(341, 13, false);
#line 16 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicGit\ClinicNetCore\ClinicNetCore\Views\Home\Index.cshtml"
           Write(patient.FName);

#line default
#line hidden
            EndContext();
            BeginContext(354, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(378, 15, false);
#line 17 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicGit\ClinicNetCore\ClinicNetCore\Views\Home\Index.cshtml"
           Write(patient.Address);

#line default
#line hidden
            EndContext();
            BeginContext(393, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(417, 13, false);
#line 18 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicGit\ClinicNetCore\ClinicNetCore\Views\Home\Index.cshtml"
           Write(patient.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(430, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(453, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "435153a7917240549482b8b479b03449", async() => {
                BeginContext(492, 4, true);
                WriteLiteral("Fill");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 462, "~/Home/FillVisit/", 462, 17, true);
#line 19 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicGit\ClinicNetCore\ClinicNetCore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 479, patient.Id, 479, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(500, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 21 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicGit\ClinicNetCore\ClinicNetCore\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(529, 24, true);
            WriteLiteral("\r\n    <tr>\r\n        <td>");
            EndContext();
            BeginContext(553, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7d5b2fb2edd4872a70bf96de06841f0", async() => {
                BeginContext(582, 3, true);
                WriteLiteral("Add");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(589, 42, true);
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>");
            EndContext();
            BeginContext(631, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f04f59d02d874efcbf5b2e955948d26b", async() => {
                BeginContext(662, 6, true);
                WriteLiteral("Search");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(672, 30, true);
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClinicNetCore.Models.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
