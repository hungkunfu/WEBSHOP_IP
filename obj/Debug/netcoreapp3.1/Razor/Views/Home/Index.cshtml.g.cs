#pragma checksum "H:\MVC\WebShopIP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c60878e0be97b1ce634e95d78bafe15975d6d071"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c60878e0be97b1ce634e95d78bafe15975d6d071", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"512db9b44bf060f11a2f76a0a5f25ead97ef8845", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:370px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "WatchProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
  
    var ListProduct = context.Products.ToList().FindAll(el => el.Status == Status.Active);
    Layout = "_LayoutAdminPage";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<nav aria-label=""breadcrumb"" class=""mb-4"">
    <ol class=""breadcrumb my-breadcrumb"">
        <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
        <li class=""breadcrumb-item""><a href=""#"">Elements</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Carousels</li>
    </ol>
</nav>

<div class=""row"">
");
#nullable restore
#line 18 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c60878e0be97b1ce634e95d78bafe15975d6d0717679", async() => {
                WriteLiteral("\r\n            <div class=\"col-lg-6 mt-5\">\r\n                <div class=\"p-3 card card_border\">\r\n                    <div class=\"pl-0 pt-0 card-header chart-grid__header\" style=\"text-align:center\">\r\n                        ");
#nullable restore
#line 24 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 26 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                      
                        var productsInCategory = ListProduct.FindAll(el => el.CategoryId == item.Id);
                        int i = 0;
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div id=\"carouselExampleCaptions\" class=\"carousel slide\" data-ride=\"carousel\">\r\n                        <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 32 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                             if (i == 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                                 for (int j = 0; j < productsInCategory.Count - 1; j++)
                                {
                                    if (j == 0)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li data-target=\"#carouselExampleCaptions\" data-slide-to=\"");
#nullable restore
#line 38 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                                                                                             Write(j);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"active\"></li>\r\n");
#nullable restore
#line 39 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li data-target=\"#carouselExampleCaptions\" data-slide-to=\"");
#nullable restore
#line 40 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                                                                                         Write(j);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"></li>\r\n");
#nullable restore
#line 41 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ol>\r\n                        <div class=\"carousel-inner\">\r\n\r\n");
#nullable restore
#line 46 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                             foreach (var product in productsInCategory)
                            {
                                if (i == 0)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"carousel-item active layer\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c60878e0be97b1ce634e95d78bafe15975d6d07111398", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2285, "~/Images/ProductImages/", 2285, 23, true);
#nullable restore
#line 51 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2308, product.ImagePath, 2308, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                        <div class=\"carousel-caption d-none d-md-block\">\r\n                                            <h4 style=\"color:red\">");
#nullable restore
#line 55 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                                                             Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
                WriteLiteral("                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 59 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"carousel-item layer\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c60878e0be97b1ce634e95d78bafe15975d6d07114112", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3045, "~/Images/ProductImages/", 3045, 23, true);
#nullable restore
#line 63 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3068, product.ImagePath, 3068, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        <div class=\"carousel-caption d-none d-md-block\">\r\n                                            <h4 style=\"color:red\">");
#nullable restore
#line 66 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                                                             Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
                WriteLiteral("                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 70 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                                }
                                { i++; }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                        <a class=""carousel-control-prev"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""prev"">
                            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only""></span>
                        </a>
                        <a class=""carousel-control-next"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""next"">
                            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only""></span>
                        </a>
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
                                                             WriteLiteral(item.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 86 "H:\MVC\WebShopIP\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
