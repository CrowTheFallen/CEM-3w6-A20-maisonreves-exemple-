#pragma checksum "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba0acd7bf338e75f938d9eb91a0b101328419c10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Building_Index), @"mvc.1.0.view", @"/Views/Building/Index.cshtml")]
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
#line 1 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\_ViewImports.cshtml"
using MaisonReve.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\_ViewImports.cshtml"
using MaisonReve.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0acd7bf338e75f938d9eb91a0b101328419c10", @"/Views/Building/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9021b6edecdf8bc6080974f9949c9c2edf8b64f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Building_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MaisonReve.Database.Models.Building>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba0acd7bf338e75f938d9eb91a0b101328419c103613", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OwnerFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OwnerLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OwnerFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OwnerLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 59 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  id=item.Id  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MaisonReve.Database.Models.Building>> Html { get; private set; }
    }
}
#pragma warning restore 1591
