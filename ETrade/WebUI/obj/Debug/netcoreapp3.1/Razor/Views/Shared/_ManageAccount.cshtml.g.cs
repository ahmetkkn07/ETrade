#pragma checksum "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\_ManageAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55620ca157041b5ad6e125ce963c629686cc5b20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ManageAccount), @"mvc.1.0.view", @"/Views/Shared/_ManageAccount.cshtml")]
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
#line 1 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\_ManageAccount.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\_ManageAccount.cshtml"
using Business.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55620ca157041b5ad6e125ce963c629686cc5b20", @"/Views/Shared/_ManageAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ManageAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\_ManageAccount.cshtml"
  
    Layout = "_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-3\">\r\n        <ul id=\"leftnav\" class=\"list-group\">\r\n            <li class=\"list-group-item\"><a");
            BeginWriteAttribute("href", " href=\"", 231, "\"", 329, 2);
            WriteAttributeValue("", 238, "/Order/GetByEmail?email=", 238, 24, true);
#nullable restore
#line 10 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\_ManageAccount.cshtml"
WriteAttributeValue("", 262, User.Claims.SingleOrDefault(c => c.Type == ClaimTypes.Email).Value, 262, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Sipariş Bilgilerim</a></li>
            <li class=""list-group-item""><a href=""/Account/ManageProfile"">Kişisel Bilgilerim</a></li>
            <li class=""list-group-item""><a href=""/Account/ChangePassword"">Şifre Güncelleme</a></li>
        </ul>
    </div>
    <div class=""col-9"">
");
#nullable restore
#line 16 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\_ManageAccount.cshtml"
         if (TempData[TempDataTypes.ManageInfo] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-info\">");
#nullable restore
#line 18 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\_ManageAccount.cshtml"
                                     Write(TempData[TempDataTypes.ManageInfo].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 19 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\_ManageAccount.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Shared\_ManageAccount.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
