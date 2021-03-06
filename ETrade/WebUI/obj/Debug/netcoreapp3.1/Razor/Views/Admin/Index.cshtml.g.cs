#pragma checksum "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bee233d8be49c55e94c5b8431bcc992a522c97e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 2 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
using Business.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bee233d8be49c55e94c5b8431bcc992a522c97e", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
  
    Layout = "_AdminLayout";
    ViewBag.Title = Context.Session.GetString("Role");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <h3>Merhaba, ");
#nullable restore
#line 11 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                Write(User.Claims.SingleOrDefault(c => c.Type == ClaimTypes.Name).Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
        <p class=""text-justify"">Bu panelde stoğu azalan ve biten ürünleri görüntüleyebilirsiniz ve isterseniz sipariş verebilirsiniz. 
            Sol taraftaki menü sekmelerini kullanarak ilgili işlem sayfasına gidip işlemlerinizi gerçekleştirebilirsiniz.</p>
");
#nullable restore
#line 14 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
         if (TempData[TempDataTypes.ProductBought] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-info\">");
#nullable restore
#line 16 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                                     Write(TempData[TempDataTypes.ProductBought].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 17 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <button type=\"button\" class=\"btn btn-warning\" style=\"width: 100%\" data-toggle=\"collapse\" data-target=\"#div1\">Stoğu Azalan Ürünleri Görüntüle (");
#nullable restore
#line 19 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                                                                                                                                                     Write(Model.LowStock.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</button>\r\n            <div id=\"div1\" class=\"collapse col-12\">\r\n");
#nullable restore
#line 21 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                 if (Model.LowStock.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table style=""width: 100%"" class=""table table-striped table-hover"">
                        <thead class=""thead-dark"">
                        <tr>
                            <th>Ürün Numarası</th>
                            <th>Ürün Adı</th>
                            <th>Stok Durumu</th>
                            <th>Satış Fiyatı</th>
                            <th></th>
                        </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 34 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                             foreach (var lowStock in Model.LowStock)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 37 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                               Write(lowStock.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                               Write(lowStock.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-danger\">");
#nullable restore
#line 39 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                                                   Write(lowStock.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>₺");
#nullable restore
#line 40 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                                Write(lowStock.UnitPrice.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 2114, "\"", 2168, 2);
            WriteAttributeValue("", 2121, "/AdminProduct/Buy?productId=", 2121, 28, true);
#nullable restore
#line 41 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
WriteAttributeValue("", 2149, lowStock.ProductId, 2149, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Satın Al</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 43 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 46 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <button type=\"button\" class=\"btn btn-danger\" style=\"width: 100%\" data-toggle=\"collapse\" data-target=\"#div2\">Stoğu Biten Ürünleri Görüntüle (");
#nullable restore
#line 50 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                                                                                                                                                   Write(Model.OutOfStock.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</button>\r\n            <div id=\"div2\" class=\"collapse col-12\">\r\n");
#nullable restore
#line 52 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                 if (Model.OutOfStock.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table style=""width: 100%"" class=""table table-striped table-hover"">
                        <thead class=""thead-dark"">
                        <tr>
                            <th>Ürün Numarası</th>
                            <th>Ürün Adı</th>
                            <th>Stok Durumu</th>
                            <th>Satış Fiyatı</th>
                            <th></th>
                        </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 65 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                         foreach (var outOfStock in Model.OutOfStock)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 68 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                               Write(outOfStock.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 69 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                               Write(outOfStock.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-danger\">");
#nullable restore
#line 70 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                                                   Write(outOfStock.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>₺");
#nullable restore
#line 71 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                                Write(outOfStock.UnitPrice.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 3711, "\"", 3767, 2);
            WriteAttributeValue("", 3718, "/AdminProduct/Buy?productId=", 3718, 28, true);
#nullable restore
#line 72 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
WriteAttributeValue("", 3746, outOfStock.ProductId, 3746, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Satın Al</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 74 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 77 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
