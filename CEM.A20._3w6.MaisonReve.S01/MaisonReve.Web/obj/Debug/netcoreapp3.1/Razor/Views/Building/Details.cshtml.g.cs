#pragma checksum "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01c543392c10a0a90d42c48eb3449a1540d7a9e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Building_Details), @"mvc.1.0.view", @"/Views/Building/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01c543392c10a0a90d42c48eb3449a1540d7a9e6", @"/Views/Building/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9021b6edecdf8bc6080974f9949c9c2edf8b64f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Building_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MaisonReve.Database.Models.Building>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01c543392c10a0a90d42c48eb3449a1540d7a9e63742", async() => {
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>Building</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 11 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 14 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OwnerFirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayFor(model => model.OwnerFirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OwnerLastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayFor(model => model.OwnerLastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 55 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Building\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new {  id = Model.Id  }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01c543392c10a0a90d42c48eb3449a1540d7a9e69870", async() => {
                    WriteLiteral("Back to List");
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
                WriteLiteral("\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MaisonReve.Database.Models.Building> Html { get; private set; }
    }
}
#pragma warning restore 1591
