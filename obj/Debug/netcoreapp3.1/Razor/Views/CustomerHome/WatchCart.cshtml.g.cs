#pragma checksum "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7394566e53de52f94b316b404d86040447250b49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerHome_WatchCart), @"mvc.1.0.view", @"/Views/CustomerHome/WatchCart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7394566e53de52f94b316b404d86040447250b49", @"/Views/CustomerHome/WatchCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"512db9b44bf060f11a2f76a0a5f25ead97ef8845", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerHome_WatchCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FormGetInfo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:70px;width:70px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
  
    List<Product> products = context.Products.ToList();
    var CurrentAccount = _signInManager.UserManager.GetUserAsync(User).Result;
    double totalOrder = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
 if (_signInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <br />
    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"" data-whatever=""""
            style=""margin-left:926px;margin-bottom:30px;padding:10px;"">
       Xác Nhận Mua Hàng 
    </button>
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Thông Tin Khách Hàng</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" id=""close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7394566e53de52f94b316b404d86040447250b497758", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""recipient-name"" class=""col-form-label"">Tên Khách Hàng:</label>
                            <input type=""text"" class=""form-control"" id=""Name"" required>
                            <span id=""validateName"" class=""text-danger""></span>
                        </div>
                        <div class=""form-group"">
                            <label for=""recipient-name"" class=""col-form-label"">Số Điện Thoại:</label>
                            <input type=""text"" class=""form-control"" id=""PhoneNum"" required>
                            <span id=""validatePhoneNum"" class=""text-danger""></span>
                        </div>
                        <div class=""form-group"">
                            <label for=""recipient-name"" class=""col-form-label"">Email:</label>
                            <input type=""email"" class=""form-control"" id=""Email"" required>
                            <span id=""validateEmail"" class=""text-da");
                WriteLiteral(@"nger""></span>
                        </div>
                        <div class=""form-group"">
                            <label for=""recipient-name"" class=""col-form-label"">Địa Chỉ Nhận Hàng:</label>
                            <input type=""text"" class=""form-control"" id=""Address"" required>
                            <span id=""validateAddress"" class=""text-danger""></span>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
                    <button type=""button"" class=""btn btn-primary"" onclick=""CustomerCart.OrderWithoutAccount()"">Đặt Đơn Hàng</button>
                </div>
            </div>
        </div>
    </div>

</div>
");
#nullable restore
#line 64 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModal\" data-whatever=\"\"\r\n        style=\"margin-left:865px;margin-bottom:30px;padding:10px;\">\r\n    Mua hàng không Có Tài Khoản\r\n</button>\r\n");
            WriteLiteral(@"<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Thông Tin Khách Hàng</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" id=""close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7394566e53de52f94b316b404d86040447250b4912149", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""recipient-name"" class=""col-form-label"">Tên Khách Hàng:</label>
                        <input type=""text"" class=""form-control"" id=""Name"" required>
                        <span id=""validateName"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""recipient-name"" class=""col-form-label"">Số Điện Thoại:</label>
                        <input type=""text"" class=""form-control"" id=""PhoneNum"" required>
                        <span id=""validatePhoneNum"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""recipient-name"" class=""col-form-label"">Email:</label>
                        <input type=""email"" class=""form-control"" id=""Email"" required>
                        <span id=""validateEmail"" class=""text-danger""></span>
                    </div>
             ");
                WriteLiteral(@"       <div class=""form-group"">
                        <label for=""recipient-name"" class=""col-form-label"">Địa Chỉ Nhận Hàng:</label>
                        <input type=""text"" class=""form-control"" id=""Address"" required>
                        <span id=""validateAddress"" class=""text-danger""></span>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""CustomerCart.OrderWithoutAccount()"">Đặt Đơn Hàng</button>
            </div>
        </div>
    </div>
</div>
");
#nullable restore
#line 113 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"" id=""ProductIndex"">
    <thead class=""thead-dark"" style=""text-align:center"">
        <tr>
            <th scope=""col"">Tên sản phẩm</th>
            <th scope=""col"">Số Lượng</th>
            <th scope=""col"">Hình ảnh</th>
            <th scope=""col"">Giá</th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody style=""text-align:center"">
");
#nullable restore
#line 126 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
         foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 129 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
               double total = item.Amount * products.Find(el => el.Id == item.ProductId).PricePerUnit; 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 130 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
           Write(products.Find(el => el.Id == item.ProductId).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><input type=\"number\" onclick=\"ChangeAmount(this.value)\"");
            BeginWriteAttribute("value", " value=\"", 6502, "\"", 6522, 1);
#nullable restore
#line 131 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
WriteAttributeValue("", 6510, item.Amount, 6510, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7394566e53de52f94b316b404d86040447250b4917104", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6577, "~/Img/ProductImages/", 6577, 20, true);
#nullable restore
#line 133 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
AddHtmlAttributeValue("", 6597, products.Find(el => el.Id == item.ProductId).ImagePath, 6597, 55, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 136 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
           Write(total.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6818, "\"", 6868, 3);
            WriteAttributeValue("", 6828, "CustomerCart.RemoveItem(", 6828, 24, true);
#nullable restore
#line 137 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
WriteAttributeValue("", 6852, item.ProductId, 6852, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6867, ")", 6867, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Xóa</a></td>\r\n");
#nullable restore
#line 138 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
              totalOrder += total; 

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 140 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>Tổng Tiền: <span class=\"text-danger\">");
#nullable restore
#line 146 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
                                                Write(totalOrder.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
#nullable restore
#line 150 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""clearfix""></div>
<div style=""text-align:center; padding:30px;"">
    <h2 class=""table-warning"" style=""text-align:center;margin-left:220px"">Bạn Chưa Có Sản Phẩm Nào Trong Giỏ Hàng</h2>
</div>
<div style=""height:100px""></div>
<div class=""clearfix""></div>
");
#nullable restore
#line 159 "H:\MVC\WebShopIP\Views\CustomerHome\WatchCart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.SignInManager<ApplicationUser> _signInManager { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591