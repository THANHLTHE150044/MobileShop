#pragma checksum "C:\Users\ADMIN\Desktop\MobileShop\MobileShop\Views\Admin\MauIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b80f905011836268132cd119c6814f8226bbec1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_MauIndex), @"mvc.1.0.view", @"/Views/Admin/MauIndex.cshtml")]
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
#line 1 "C:\Users\ADMIN\Desktop\MobileShop\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Desktop\MobileShop\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Desktop\MobileShop\MobileShop\Views\Admin\MauIndex.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b80f905011836268132cd119c6814f8226bbec1", @"/Views/Admin/MauIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_MauIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<MobileShop.Models.Mau>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ADMIN\Desktop\MobileShop\MobileShop\Views\Admin\MauIndex.cshtml"
  
    ViewBag.Title = "MauIndex";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2 class=""mt-2"" style=""text-align:center"">Quản lý màu sản phẩm</h2>
<p>
    <a href=""/Admin/AddMau""><button class=""btn btn-success"">Thêm màu mới</button></a>
</p>
<table class=""table table-bordered  mt-3"">
    <tr class=""thead-light"">
        <th>Mã màu</th>
        <th>Tên màu</th>
        <th>Sửa</th>
    </tr>
");
#nullable restore
#line 17 "C:\Users\ADMIN\Desktop\MobileShop\MobileShop\Views\Admin\MauIndex.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\ADMIN\Desktop\MobileShop\MobileShop\Views\Admin\MauIndex.cshtml"
           Write(item.Mamau);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\ADMIN\Desktop\MobileShop\MobileShop\Views\Admin\MauIndex.cshtml"
           Write(item.Tenmau);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 673, "\"", 706, 2);
            WriteAttributeValue("", 680, "/Admin/EditMau/", 680, 15, true);
#nullable restore
#line 24 "C:\Users\ADMIN\Desktop\MobileShop\MobileShop\Views\Admin\MauIndex.cshtml"
WriteAttributeValue("", 695, item.Mamau, 695, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\ADMIN\Desktop\MobileShop\MobileShop\Views\Admin\MauIndex.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\nTrang ");
#nullable restore
#line 30 "C:\Users\ADMIN\Desktop\MobileShop\MobileShop\Views\Admin\MauIndex.cshtml"
  Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 30 "C:\Users\ADMIN\Desktop\MobileShop\MobileShop\Views\Admin\MauIndex.cshtml"
                                                              Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\ADMIN\Desktop\MobileShop\MobileShop\Views\Admin\MauIndex.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<MobileShop.Models.Mau>> Html { get; private set; }
    }
}
#pragma warning restore 1591
