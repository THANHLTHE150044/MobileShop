#pragma checksum "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fac7034acacd70c2835445686574a68ea894087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fac7034acacd70c2835445686574a68ea894087", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<MobileShop.Models.Sanpham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"mt-2\" style=\"text-align:center\">Quản lý sản phẩm</h2>\r\n<p>\r\n    <a href=\"/Admin/AddProduct\"><button class=\"btn btn-success\">Thêm sản phẩm mới</button></a>\r\n</p>\r\n");
#nullable restore
#line 11 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2>Không có sản phẩm </h2>\r\n");
#nullable restore
#line 14 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
}
else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-bordered"">
    <tr class=""thead-light"">
        <th>Tên sản phẩm</th>
        <th>Giá tiền</th>
        <th>Số lượng</th>
        <th>Bộ nhớ trong (GB)</th>
        <th>Ram (GB)</th>
        <th>Ảnh bìa</th>
        <th>Tên hãng</th>
        <th>Chỉnh sửa</th>
    </tr>
");
#nullable restore
#line 27 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
           Write(item.Tensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
           Write(item.Giatien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
           Write(item.Soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
           Write(item.Bonhotrong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
           Write(item.Ram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1018, "\"", 1049, 1);
#nullable restore
#line 36 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1024, Url.Content(item.Anhbia), 1024, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" />\r\n            </td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
            Write((ViewBag.Hangsanxuats as IList<MobileShop.Models.Hangsanxuat>).FirstOrDefault(c => c.Mahang == item.Mahang).Tenhang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1274, "\"", 1310, 2);
            WriteAttributeValue("", 1281, "/Admin/EditProduct/", 1281, 19, true);
#nullable restore
#line 40 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1300, item.Masp, 1300, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 45 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\nTrang ");
#nullable restore
#line 47 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
  Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 47 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
                                                              Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\This PC\Documents\GitHub\MobileShop\MobileShop\Views\Admin\Index.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index",new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<MobileShop.Models.Sanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
