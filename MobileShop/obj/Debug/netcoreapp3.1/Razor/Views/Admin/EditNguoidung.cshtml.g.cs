#pragma checksum "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae772462e78d781e2d41adc1c844e09de93518fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditNguoidung), @"mvc.1.0.view", @"/Views/Admin/EditNguoidung.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae772462e78d781e2d41adc1c844e09de93518fd", @"/Views/Admin/EditNguoidung.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditNguoidung : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MobileShop.Models.Nguoidung>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
  
    ViewBag.Title = "EditNguoidung";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"mt-2\" style=\"text-align:center\">Sửa sản phẩm</h2>\r\n");
#nullable restore
#line 7 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 11 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
   Write(Html.HiddenFor(model => model.MaNguoiDung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label>Họ Tên</label>\r\n            ");
#nullable restore
#line 15 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
       Write(Html.EditorFor(model => model.Hoten, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
       Write(Html.ValidationMessageFor(model => model.Hoten, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Email</label>\r\n            ");
#nullable restore
#line 20 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 21 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Điện thoại</label>\r\n            ");
#nullable restore
#line 25 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
       Write(Html.EditorFor(model => model.Dienthoai, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 26 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
       Write(Html.ValidationMessageFor(model => model.Dienthoai, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Mật khẩu</label>\r\n            ");
#nullable restore
#line 30 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
       Write(Html.EditorFor(model => model.Matkhau, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 31 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
       Write(Html.ValidationMessageFor(model => model.Matkhau, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Tên quyền</label>\r\n            ");
#nullable restore
#line 35 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
       Write(Html.DropDownList("Idquyen", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 36 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
       Write(Html.ValidationMessageFor(model => model.Idquyen, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        
        <div class=""form-group"">
            <div class=""col-md-offset-2 mb-1"">
                <input type=""submit"" value=""Sửa"" class=""btn btn-success"" />
                <a href=""/Admin/NguoidungIndex""><button class=""btn btn-danger"">Hủy</button></a>
            </div>
            ");
#nullable restore
#line 44 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
       Write(Html.ActionLink("Xoá người dùng", "DeleteNguoidung", new { id = Model.MaNguoiDung }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 47 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop\MobileShop\Views\Admin\EditNguoidung.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MobileShop.Models.Nguoidung> Html { get; private set; }
    }
}
#pragma warning restore 1591
