#pragma checksum "H:\MVC\WebShopIP\Views\Product\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb80b025035eec71764be31cb47c1166cc49b02a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Cart), @"mvc.1.0.view", @"/Views/Product/Cart.cshtml")]
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
#line 1 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using WebShopIP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using WebShopIP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using WebShopIP.Models.LoginViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using WebShopIP.Models.RegisterViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using WebShopIP.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using WebShopIP.Models.RoleModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using WebShopIP.Models.UserModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using WebShopIP.Dbcontexts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using WebShopIP.Models.CartSession;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using WebShopIP.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using WebShopIP.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using WebShopIP.Models.ProductPagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "H:\MVC\WebShopIP\Views\_ViewImports.cshtml"
using WebShopIP.Models.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb80b025035eec71764be31cb47c1166cc49b02a", @"/Views/Product/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"512db9b44bf060f11a2f76a0a5f25ead97ef8845", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootbox/bootbox.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
  
    ViewBag.Title = "Cart info";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Cart Infomation</h2>\r\n\r\n");
#nullable restore
#line 8 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
 if (Model.Count > 0)
{
    double totalAmount = 0;
    int increment = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered table-responsive-lg"">
        <tr class=""thead-dark"">
            <th>#</th>
            <th class=""text-center"">Product Name</th>
            <th class=""text-center"">Price</th>
            <th class=""text-center"">Quantity</th>
            <th class=""text-center"">Amount</th>
            <th></th>
        </tr>
");
#nullable restore
#line 22 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
         foreach (var cartitem in Model)
        {
            var amount = cartitem.Quantity * cartitem.Product.PricePerUnit;
            totalAmount += amount;


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
                Write(increment++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
               Write(cartitem.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-right\">");
#nullable restore
#line 30 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
                                   Write($"{cartitem.Product.PricePerUnit.ToString("n0")} vnd");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb80b025035eec71764be31cb47c1166cc49b02a8932", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 31 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => cartitem.Quantity);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
AddHtmlAttributeValue("", 1013, $"quantity-{cartitem.Product.Id}", 1013, 36, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td class=\"text-right\">");
#nullable restore
#line 32 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
                                   Write($"{amount.ToString("n0")} vnd");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button class=\"btn btn-success updatecartitem\" data-productid=\"");
#nullable restore
#line 34 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
                                                                              Write(cartitem.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        Update\r\n                    </button>\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1353, "\"", 1399, 3);
            WriteAttributeValue("", 1363, "removeCartItem(", 1363, 15, true);
#nullable restore
#line 37 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
WriteAttributeValue("", 1378, cartitem.Product.Id, 1378, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1398, ")", 1398, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Remove</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td colspan=\"4\" class=\"text-right\">Total amount</td>\r\n            <td class=\"text-right\">");
#nullable restore
#line 43 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
                               Write($"{totalAmount.ToString("n0")} vnd");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb80b025035eec71764be31cb47c1166cc49b02a12742", async() => {
                WriteLiteral("Submit Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb80b025035eec71764be31cb47c1166cc49b02a14347", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <script>
          $(document).ready(function () {
              $("".updatecartitem"").click(function (event) {
                  event.preventDefault();
                  var productid = $(this).attr(""data-productid"");
                  var quantity = $(""#quantity-"" + productid).val();
                  $.ajax({
                      type: ""POST"",
                      url:""");
#nullable restore
#line 60 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
                      Write(Url.RouteUrl("updatecart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                      data: {
                          productid: parseInt(productid),
                          quantity: parseInt(quantity)
                      },
                      success: function (result) {
                          window.location.href = """);
#nullable restore
#line 66 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
                                             Write(Url.RouteUrl("cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                      }
                  });
              });
          });
            function removeCartItem(productId) {
                bootbox.confirm({
                    title: ""Remove cart item?"",
                    message: ""Do you want to remove this item on cart."",
                    buttons: {
                        cancel: {
                            label: '<i class=""fa fa-times""></i> No'
                        },
                        confirm: {
                            label: '<i class=""fa fa-check""></i> Yes'
                        }
                    },
                    callback: function (result) {
                        if (result) {
                            $.ajax({
                                type: ""GET"",
                                url:`/Product/RemoveCartItem/${productId}`,
                                success: function (result) {
                                    window.location.href = """);
#nullable restore
#line 89 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
                                                       Write(Url.RouteUrl("cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                                }\r\n                            });\r\n                        }\r\n                    }\r\n                });\r\n            }\r\n        </script>\r\n    ");
            }
            );
#nullable restore
#line 97 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
     

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-danger\">Cart empty</p>\r\n");
#nullable restore
#line 103 "H:\MVC\WebShopIP\Views\Product\Cart.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
