#pragma checksum "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd7fc98e8db14f207b2358c0ac2f649138f70f6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditDonhang), @"mvc.1.0.view", @"/Views/Admin/EditDonhang.cshtml")]
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
#line 1 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd7fc98e8db14f207b2358c0ac2f649138f70f6b", @"/Views/Admin/EditDonhang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditDonhang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MobileShop.Models.Donhang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control col-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Tinhtrang"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Tinhtrang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
  
    ViewBag.Title = "EditDonhang";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"mt-2\" style=\"text-align:center\">Chi tiết đơn hàng</h2>\r\n");
#nullable restore
#line 7 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <div class=\"row\">\r\n            <label class=\"col-4\">Mã đơn: ");
#nullable restore
#line 11 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
                                     Write(Model.Madon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            ");
#nullable restore
#line 12 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
       Write(Html.HiddenFor(model => model.Madon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <label class=\"col-4\">Ngày đặt: ");
#nullable restore
#line 13 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
                                        Write(Model.Ngaydat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            ");
#nullable restore
#line 14 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
       Write(Html.HiddenFor(model => model.Ngaydat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <label class=\"col-4\">Người dùng: ");
#nullable restore
#line 15 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
                                          Write(Model.Madon);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 15 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
                                                          Write((ViewBag.Nguoidungs as IList<MobileShop.Models.Nguoidung>).FirstOrDefault(c => c.MaNguoiDung == Model.MaNguoidung).Hoten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            ");
#nullable restore
#line 16 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
       Write(Html.HiddenFor(model => model.MaNguoidung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 19 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
              
                int soluong = 0;
                int tongtien = 0;
                foreach (var chitiet in ViewBag.Chitietdonhangs)
                {
                    if (chitiet.Madon == Model.Madon)
                    {
                        soluong += chitiet.Soluong;
                        tongtien += chitiet.Thanhtien;
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label class=\"col-4\">Số lượng sản phẩm: ");
#nullable restore
#line 30 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
                                                       Write(soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                <label class=\"col-4\">Tổng tiền: ");
#nullable restore
#line 31 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
                                             Write(tongtien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
            WriteLiteral("            <label class=\"col-1\">Trạng thái:</label>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd7fc98e8db14f207b2358c0ac2f649138f70f6b9354", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd7fc98e8db14f207b2358c0ac2f649138f70f6b9630", async() => {
                    WriteLiteral("Đang xử lý");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd7fc98e8db14f207b2358c0ac2f649138f70f6b10875", async() => {
                    WriteLiteral("Hoàn thành");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd7fc98e8db14f207b2358c0ac2f649138f70f6b12121", async() => {
                    WriteLiteral("Đã hủy");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 34 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Tinhtrang);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <input type=""submit"" value=""OK"" class=""btn btn-success col-1"" />
        </div>
    </div>
    <table class=""table table-bordered mt-2"">
        <tr>
            <th>Tên sản phẩm</th>
            <th>Hình ảnh</th>
            <th>Màu</th>
            <th>Số lượng</th>
            <th>Giá</th>
            <th>Thành tiền</th>
        </tr>
");
#nullable restore
#line 51 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
         foreach (var item in ViewBag.Chitietdonhangs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 54 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
                Write((ViewBag.Sanphams as IList<MobileShop.Models.Sanpham>).FirstOrDefault(c => c.Masp == item.Masp).Tensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2340, "\"", 2462, 1);
#nullable restore
#line 56 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
WriteAttributeValue("", 2346, Url.Content((ViewBag.Sanphams as IList<MobileShop.Models.Sanpham>).FirstOrDefault(c => c.Masp == item.Masp).Anhbia), 2346, 116, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" />\r\n                </td>\r\n                <td>");
#nullable restore
#line 58 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
                Write((ViewBag.Maus as IList<MobileShop.Models.Mau>).FirstOrDefault(c => c.Mamau == item.Mamau).Tenmau);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 59 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
               Write(item.Soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 60 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
               Write(item.Dongia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 61 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
               Write(item.Thanhtien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 63 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <br />\r\n");
#nullable restore
#line 66 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditDonhang.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MobileShop.Models.Donhang> Html { get; private set; }
    }
}
#pragma warning restore 1591
