#pragma checksum "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dcfa82b9c88af1c24bf0a979a708a878c808793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderDetails), @"mvc.1.0.view", @"/Views/Order/OrderDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dcfa82b9c88af1c24bf0a979a708a878c808793", @"/Views/Order/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDetailsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\OrderDetails.cshtml"
  
    Layout = "_ManageAccount";
    ViewBag.Title = "Sipariş Detayı";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\OrderDetails.cshtml"
Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Numaralı Siparişinizin Detayı</h2>\r\n<table class=\"table table-hover table-striped\">\r\n    <thead class=\"thead-dark\">\r\n    <th>Ürünün Adı</th>\r\n    <th>Satış Adedi</th>\r\n    <th>Birim Fiyatı</th>\r\n    <th>Toplam Fiyat</th>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\OrderDetails.cshtml"
         foreach (var orderDetail in Model.OrderDetails)
        {
            var sum = (orderDetail.Quantity * orderDetail.UnitPrice).ToString("#.##"); 
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 594, "\"", 649, 2);
            WriteAttributeValue("", 601, "/Product/Detail?productId=", 601, 26, true);
#nullable restore
#line 21 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\OrderDetails.cshtml"
WriteAttributeValue("", 627, orderDetail.ProductId, 627, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration: none\">");
#nullable restore
#line 21 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\OrderDetails.cshtml"
                                                                                                        Write(orderDetail.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                <td>");
#nullable restore
#line 22 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\OrderDetails.cshtml"
               Write(orderDetail.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>₺");
#nullable restore
#line 23 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\OrderDetails.cshtml"
                Write(orderDetail.UnitPrice.ToString("#.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>₺");
#nullable restore
#line 24 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\OrderDetails.cshtml"
                Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "Y:\Documents\GitHub\ETrade\ETrade\WebUI\Views\Order\OrderDetails.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDetailsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591