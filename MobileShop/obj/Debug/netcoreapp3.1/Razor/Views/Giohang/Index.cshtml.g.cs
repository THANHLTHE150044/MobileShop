#pragma checksum "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b42b0f307864b07b0cae349776618e9cd6a391e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Giohang_Index), @"mvc.1.0.view", @"/Views/Giohang/Index.cshtml")]
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
#line 1 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b42b0f307864b07b0cae349776618e9cd6a391e", @"/Views/Giohang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Giohang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MobileShop.Models.Giohang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DatHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GioHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
  
    ViewBag.Title = "Gio hang";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""product-big-title-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""product-bit-title text-center"">
                    <h2>Shopping Cart</h2>
                </div>
            </div>
        </div>
    </div>
</div> <!-- End Page title area -->


<div class=""single-product-area"">

    <div class=""container"">
        <div class=""row"">
            <div>
                <div class=""product-content-right"">
                    <div class=""woocommerce"">
                       
                            <table cellspacing=""0"" class=""shop_table cart"">

                                <thead>
                                    <tr>
                                        <th class=""product-remove"">&nbsp;</th>
                                        <th class=""product-thumbnail"">&nbsp;</th>
                                        <th class=""product-name"">Tên Sản Phẩm</th>
                             ");
            WriteLiteral(@"           <th class=""product-price"">Đơn giá</th>
                                        <th class=""product-quantity"">Số lượng</th>
                                        <th class=""product-subtotal"">Thành tiền</th>
                                    </tr>
                                </thead>

                                <tbody>
");
#nullable restore
#line 42 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
                                       int Total = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
                                     foreach (var item in Model)
                                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"cart_item\">\r\n                                            <td class=\"product-remove\">\r\n");
#nullable restore
#line 49 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
                                                 using (Html.BeginForm("Xoagiohang", "GioHang", new { @Masp = item.Masp }))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <input type=\"submit\" value=\"Xoa\" name=\"delete_cart\" class=\"button\">\r\n");
#nullable restore
#line 52 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </td>

                                            <td class=""product-thumbnail"">
                                            </td>

                                            <td class=""product-name"">
                                                <a href=""single-product.html"">");
#nullable restore
#line 60 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
                                                                         Write(item.Masp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                                            </td>\r\n\r\n                                            <td class=\"product-price\">\r\n                                                <span class=\"amount\">");
#nullable restore
#line 65 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
                                                                Write(item.Dongia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            </td>

                                            <td class=""product-quantity"">
                                                <div class=""quantity buttons_added"">

                                                    <input type=""number"" size=""4"" class=""input-text qty text"" title=""Qty""");
            BeginWriteAttribute("value", " value=\"", 3034, "\"", 3055, 1);
#nullable restore
#line 71 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
WriteAttributeValue("", 3042, item.Soluong, 3042, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"0\" step=\"1\">\r\n\r\n\r\n                                                </div>\r\n                                            </td>\r\n");
#nullable restore
#line 76 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
                                               var THanhtien = item.Dongia * item.Soluong;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
                                               Total = Total + (int)THanhtien;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            <td class=\"product-subtotal\">\r\n                                                <span class=\"amount\">");
#nullable restore
#line 82 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
                                                                Write(THanhtien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td>\r\n");
#nullable restore
#line 85 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
                                                 using (Html.BeginForm("CapnhatGiohang", "GioHang", new { @Masp = item.Masp, @Soluong = item.Soluong }))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <input type=\"submit\" value=\"Update Cart\" name=\"update_cart\" class=\"button\">\r\n");
#nullable restore
#line 88 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 92 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   \r\n                                <tr>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b42b0f307864b07b0cae349776618e9cd6a391e11226", async() => {
                WriteLiteral(@"


                                        <input type=""submit"" value=""Checkout"" name=""proceed"" class=""checkout-button button alt wc-forward"">

                                        <label style=""min-width:100px"">Người Nhận :</label>
                                        <input name=""name"" style=""min-width:50px"" placeholder=""Người nhận :"" />
                                        <br />
                                        <label style=""min-width:100px"">Địa chỉ :</label>
                                        <input name=""address"" style=""min-width:50px"" placeholder=""Địa chỉ người nhận :"" />
                                        <br />
                                        <label style=""min-width:100px""> Số điện thoại :</label>
                                        <input name=""phone"" style=""min-width:50px"" placeholder=""Số điện thoại :"" />
                                    <td class=""actions"" colspan=""6"">

                                        <h2>Total: ");
#nullable restore
#line 111 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Giohang\Index.cshtml"
                                              Write(Total);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n\r\n                                    </td>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"



                                </tr>
                                </tbody>
                            </table>
                       <
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MobileShop.Models.Giohang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
