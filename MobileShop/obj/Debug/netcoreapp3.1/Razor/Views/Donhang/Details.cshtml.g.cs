#pragma checksum "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Donhang\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f7be1374a89fd5cbacfc054e752c3414493dbf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Donhang_Details), @"mvc.1.0.view", @"/Views/Donhang/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f7be1374a89fd5cbacfc054e752c3414493dbf9", @"/Views/Donhang/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Donhang_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MobileShop.Models.Chitietdonhang>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Donhang\Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Chi tiết đơn hàng</h2>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Sản phẩm</th>\r\n        <th>Số lượng</th>\r\n        <th>Đơn giá / 1 sản phẩm</th>\r\n        <th>Thành tiền</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 18 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Donhang\Details.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Donhang\Details.cshtml"
           Write(item.MaspNavigation.Tensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Donhang\Details.cshtml"
           Write(item.Soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Donhang\Details.cshtml"
           Write(item.Dongia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Donhang\Details.cshtml"
           Write(item.Thanhtien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Donhang\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MobileShop.Models.Chitietdonhang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
