#pragma checksum "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b08116100dd582ed5c337fc3e7bb737a2d759a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_WatchProducts), @"mvc.1.0.view", @"/Views/CustomerHome/WatchProducts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b08116100dd582ed5c337fc3e7bb737a2d759a1", @"/Views/CustomerHome/WatchProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"512db9b44bf060f11a2f76a0a5f25ead97ef8845", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_WatchProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CustomerHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/js/CustomerCart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml"
  
    var MaxSale = context.Products.ToList().Max(x => x.SaleCount);
    Product ProductTop = context.Products.FirstOrDefault(el => el.SaleCount == MaxSale);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"mt-4 mb-3\">\r\n        ");
#nullable restore
#line 13 "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml"
   Write(context.Categories.FirstOrDefault(el => el.Id == Model[0].CategoryId).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b08116100dd582ed5c337fc3e7bb737a2d759a17848", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <li class=\"breadcrumb-item active\">");
#nullable restore
#line 19 "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml"
                                      Write(context.Categories.FirstOrDefault(el => el.Id == Model[0].CategoryId).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ol>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 22 "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-2 portfolio-item\">\r\n                <div class=\"card h-100\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3b08116100dd582ed5c337fc3e7bb737a2d759a19948", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 884, "~/img/ProductImages/", 884, 20, true);
#nullable restore
#line 26 "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml"
AddHtmlAttributeValue("", 904, item.ImagePath, 904, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"card-body\">\r\n                        <p class=\"text-info\" style=\"text-align:center\">");
#nullable restore
#line 28 "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml"
                                                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div style=\"text-align: center\">\r\n                            <p class=\"text-info\" style=\"text-align:center\">Gi?? S???n Ph???m: ");
#nullable restore
#line 30 "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml"
                                                                                    Write(item.PricePerUnit.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <small>S??? L?????ng</small><input type=\"number\" class=\"btn btn-style border-btn text-info\"");
            BeginWriteAttribute("id", " id=\"", 1362, "\"", 1375, 1);
#nullable restore
#line 31 "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml"
WriteAttributeValue("", 1367, item.Id, 1367, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\" value=\"1\" />\r\n                        </div>\r\n                        <h4 class=\"card-title\" style=\"text-align:center\">\r\n                            <a href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1574, "\"", 1614, 3);
            WriteAttributeValue("", 1584, "CustomerCart.AddItem(", 1584, 21, true);
#nullable restore
#line 34 "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml"
WriteAttributeValue("", 1605, item.Id, 1605, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1613, ")", 1613, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-style btn-primary\">\r\n                                Th??m V??o Gi??? H??ng\r\n                            </a>\r\n                        </h4>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 41 "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 43 "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<hr />\r\n\r\n");
#nullable restore
#line 47 "H:\MVC\WebShopIP\Views\CustomerHome\WatchProducts.cshtml"
Write(await Html.PartialAsync("_TopSaleProductView", ProductTop));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b08116100dd582ed5c337fc3e7bb737a2d759a114453", async() => {
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
            WriteLiteral("\r\n ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AppDbContexts context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
