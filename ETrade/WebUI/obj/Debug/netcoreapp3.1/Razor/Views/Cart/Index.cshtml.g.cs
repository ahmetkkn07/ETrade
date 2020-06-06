#pragma checksum "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "633a2231ac315401e37b374ae1d4edd3f98593e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
using Business.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"633a2231ac315401e37b374ae1d4edd3f98593e0", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-removeAll", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
  
    Layout = "_ManageAccount";
    ViewBag.Title = "Sepetim";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Sepetim</h2>\r\n");
#nullable restore
#line 9 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
 if (TempData[TempDataTypes.StockInsufficient] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">");
#nullable restore
#line 11 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
                                Write(TempData[TempDataTypes.StockInsufficient].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
 if (TempData[TempDataTypes.RemovedFromCart] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">");
#nullable restore
#line 15 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
                               Write(TempData[TempDataTypes.RemovedFromCart].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
 if (TempData[TempDataTypes.DecreasedFromCart] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">");
#nullable restore
#line 19 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
                               Write(TempData[TempDataTypes.DecreasedFromCart].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 20 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
 if (Model.Cart.CartLines.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">Sepetiniz Boş</div>\r\n");
#nullable restore
#line 24 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-responsive"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Ürün Adı</th>
                <th>Açıklama</th>
                <th>Fiyat</th>
                <th>Stok Adedi</th>
                <th>Satış Adedi</th>
                <th></th>
                <th></th>
            </tr>
        </thead>
");
#nullable restore
#line 40 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
         foreach (var cartLine in Model.Cart.CartLines)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
                   Write(cartLine.Product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
                   Write(cartLine.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
                   Write(cartLine.Product.ProductDef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
                   Write(cartLine.Product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
                   Write(cartLine.Product.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
                   Write(cartLine.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "633a2231ac315401e37b374ae1d4edd3f98593e09821", async() => {
                WriteLiteral("Azalt");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
                                                                                                                    WriteLiteral(cartLine.Product.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "633a2231ac315401e37b374ae1d4edd3f98593e012407", async() => {
                WriteLiteral("Kaldır");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
                                                                                                                    WriteLiteral(cartLine.Product.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-removeAll", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["removeAll"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <!--Butona tıklayınca Cart controllerındaki addtocart fonksiyonunu çağırsın asp-route sonuna parametre gelince onnu gönderiyor-->\r\n                </tr>\r\n            </tbody>\r\n");
#nullable restore
#line 55 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <a href=\"/Cart/Complete\" class=\"btn btn-success\" role=\"button\">Siparişi Tamamla</a>\r\n");
#nullable restore
#line 58 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
