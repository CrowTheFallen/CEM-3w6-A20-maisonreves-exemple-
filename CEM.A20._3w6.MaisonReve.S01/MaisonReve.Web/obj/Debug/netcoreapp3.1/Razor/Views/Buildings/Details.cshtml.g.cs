#pragma checksum "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27e2a249f63a5b79745a1fb584e38b7e36e0fc98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buildings_Details), @"mvc.1.0.view", @"/Views/Buildings/Details.cshtml")]
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
#nullable restore
#line 3 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\_ViewImports.cshtml"
using MaisonReve.Database.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27e2a249f63a5b79745a1fb584e38b7e36e0fc98", @"/Views/Buildings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ebedff162f6b041453f499081bdee239b61d1f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Buildings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MaisonReve.Database.Models.Building>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Building</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OwnerFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayFor(model => model.OwnerFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OwnerLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayFor(model => model.OwnerLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Published));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Published));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27e2a249f63a5b79745a1fb584e38b7e36e0fc989980", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\bigue\Desktop\Web\Travail\CEM-3w6-A20-maisonreves-exemple-\CEM.A20._3w6.MaisonReve.S01\MaisonReve.Web\Views\Buildings\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27e2a249f63a5b79745a1fb584e38b7e36e0fc9812184", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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