#pragma checksum "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a209e5d277f323f645bebb1a1feaf45d5defe7c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Giohang_SuaGioHang), @"mvc.1.0.view", @"/Views/Giohang/SuaGioHang.cshtml")]
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
#line 1 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a209e5d277f323f645bebb1a1feaf45d5defe7c5", @"/Views/Giohang/SuaGioHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Giohang_SuaGioHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GioHang>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml"
   ViewBag.Title = "GioHang";
                Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center><h2 class=""text-info""> GIỎ HÀNG</h2></center>

<table class=""table-bordered font-italic divGioHang"">
    <tr>
        <th> Mã SP</th>

        <th> Tên SP</th>

        <th> Ảnh bìa</th>

        <th> Đơn giá</th>

        <th> Số lượng</th>

        <th> Thành tiền</th>
    </tr>



");
#nullable restore
#line 25 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td> ");
#nullable restore
#line 28 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml"
    Write(item.iMasp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    <td> ");
#nullable restore
#line 30 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml"
    Write(item.sTensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    <td> <img");
            BeginWriteAttribute("src", " src=\"", 574, "\"", 622, 1);
#nullable restore
#line 32 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml"
WriteAttributeValue("", 580, Url.Content("~/HinhanhSP/" +item.sAnhBia), 580, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" /></td>\r\n\r\n    <td>  ");
#nullable restore
#line 34 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml"
     Write(String.Format("{0:0,0}", item.dDonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n\r\n");
#nullable restore
#line 37 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml"
     using (Html.BeginForm("CapNhatGioHang", "GioHang", new { @iMaSP = item.iMasp }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>");
#nullable restore
#line 39 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml"
Write(Html.TextBox("txtSoLuong", item.iSoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 41 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml"
                   Write(String.Format("{0:0,0}", item.ThanhTien));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n                                        <td>\r\n                                            <input type=\"submit\" value=\"Cập nhật\" class=\"btn-secondary\" />\r\n                                            <br />\r\n");
            WriteLiteral("                                            <button class=\"btn-success\">");
#nullable restore
#line 46 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml"
                                                                   Write(Html.ActionLink("Xóa", "XoaGioHang", new { @iMaSP = item.iMasp }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                        </td>");
#nullable restore
#line 47 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml"
                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</tr>");
#nullable restore
#line 49 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Giohang\SuaGioHang.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
            WriteLiteral(@"<style type=""text/css"">
    .divGioHang {
        border: 2px solid #EEEEEE;
        margin-left: 10%;
        font-size: large
    }

        .divGioHang td {
            padding: 10px;
            border: 2px solid #EEEEEE;
            text-align: center
        }

        .divGioHang th {
            text-align: center
        }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GioHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
