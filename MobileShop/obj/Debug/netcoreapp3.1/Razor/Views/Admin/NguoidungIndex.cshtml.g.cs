#pragma checksum "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5d3a251383e80486e4b812b13d66afc80242d0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_NguoidungIndex), @"mvc.1.0.view", @"/Views/Admin/NguoidungIndex.cshtml")]
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
#nullable restore
#line 2 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5d3a251383e80486e4b812b13d66afc80242d0c", @"/Views/Admin/NguoidungIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_NguoidungIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<MobileShop.Models.Nguoidung>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
  
    ViewBag.Title = "NguoidungIndex";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"mt-2\" style=\"text-align:center\">Quản lý người dùng</h2>\r\n");
#nullable restore
#line 8 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("               <h2> Chưa có người dùng</h2>\r\n");
#nullable restore
#line 11 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
}
else {


#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered mt-3\">\r\n    <tr class=\"thead-light\">\r\n        <th>Họ Tên</th>\r\n        <th>Email</th>\r\n        <th>Điện thoại</th>\r\n        <th>Địa chỉ </th>\r\n        <th>Tên quyền </th>\r\n        <th>Hành động</th>\r\n    </tr>\r\n");
#nullable restore
#line 23 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
           Write(item.Hoten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
           Write(item.Dienthoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
           Write(item.Diachi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
           Write(item.IdquyenNavigation.TenQuyen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 856, "\"", 901, 2);
            WriteAttributeValue("", 863, "/Admin/EditNguoidung/", 863, 21, true);
#nullable restore
#line 31 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
WriteAttributeValue("", 884, item.MaNguoiDung, 884, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 35 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\nTrang ");
#nullable restore
#line 37 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
  Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 37 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
                                                              Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 38 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\NguoidungIndex.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<MobileShop.Models.Nguoidung>> Html { get; private set; }
    }
}
#pragma warning restore 1591
