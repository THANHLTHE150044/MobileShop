#pragma checksum "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f03a15afe1c160a1402cedb18578e9d4ffbb7eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Donhang_Index), @"mvc.1.0.view", @"/Views/Donhang/Index.cshtml")]
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
#line 2 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f03a15afe1c160a1402cedb18578e9d4ffbb7eb", @"/Views/Donhang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Donhang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MobileShop.Models.Donhang>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Danh sách đơn hàng</h2>
<table class=""table"">
    <tr>
        <th>
            Người đặt
        </th>
        <th>
            Ngày đặt
        </th>
        <th>
            Tình trạng đơn hàng
        </th>
        <th>
            Người nhận
        </th>
        <th>
            Số điện thoại
        </th>
        <th>
            Địa chỉ
        </th>
        <th>
        </th>
    </tr>

");
#nullable restore
#line 33 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 37 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml"
   Write(item.MaNguoidungNavigation.Hoten);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 40 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml"
   Write(item.Ngaydat);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n");
#nullable restore
#line 42 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml"
     switch (item.Tinhtrang)
    {
        case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Hoàn thành</td>\r\n");
#nullable restore
#line 46 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml"
            break;
        case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Đã hủy</td>\r\n");
#nullable restore
#line 49 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml"
            break;
        default:

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Đang xử lý</td>\r\n");
#nullable restore
#line 52 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml"
            break;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td>\r\n        ");
#nullable restore
#line 55 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml"
   Write(item.Nguoinhan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 58 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml"
   Write(item.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 61 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml"
   Write(item.Diachi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        <button class=\"btn-primary\">\r\n            ");
#nullable restore
#line 65 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml"
       Write(Html.ActionLink("Chi tiết", "Details", new { id = item.Madon }, new { @style = "color:white;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </button>\r\n\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 70 "C:\Users\This PC\Documents\GitHub\Project\MobileShop\Views\Donhang\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MobileShop.Models.Donhang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
