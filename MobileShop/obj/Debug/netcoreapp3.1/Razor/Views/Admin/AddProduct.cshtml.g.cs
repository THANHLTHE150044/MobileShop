#pragma checksum "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2641232ccce310f0e1757cde19af37766bc40013"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddProduct), @"mvc.1.0.view", @"/Views/Admin/AddProduct.cshtml")]
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
#line 2 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2641232ccce310f0e1757cde19af37766bc40013", @"/Views/Admin/AddProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MobileShop.Models.Sanpham>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Sanphammoi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Sanphammoi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
  
    ViewBag.Title = "AddProduct";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"mt-2\" style=\"text-align:center\">Thêm sản phẩm mới</h2>\r\n\r\n");
#nullable restore
#line 8 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <hr />\r\n    ");
#nullable restore
#line 12 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label>Tên sản phẩm</label>\r\n        ");
#nullable restore
#line 15 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Tensp, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Tensp, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Giá tiền</label>\r\n        ");
#nullable restore
#line 21 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Giatien, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Giatien, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Số lượng</label>\r\n        ");
#nullable restore
#line 26 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Soluong, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 27 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Soluong, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Mô tả</label>\r\n        ");
#nullable restore
#line 31 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Mota, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 32 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Mota, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Thẻ sim</label>\r\n        ");
#nullable restore
#line 36 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Thesim, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 37 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Thesim, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Bộ nhớ trong</label>\r\n        ");
#nullable restore
#line 41 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Bonhotrong, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 42 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Bonhotrong, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"checkbox\">\r\n            <label>Sản phẩm mới</label>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2641232ccce310f0e1757cde19af37766bc400139711", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2641232ccce310f0e1757cde19af37766bc400139987", async() => {
                    WriteLiteral("True");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2641232ccce310f0e1757cde19af37766bc4001311338", async() => {
                    WriteLiteral("False");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
#line 47 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Sanphammoi);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
#nullable restore
#line 51 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
       Write(Html.ValidationMessageFor(model => model.Sanphammoi, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Ram</label>\r\n        ");
#nullable restore
#line 56 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Ram, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 57 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Ram, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Hệ điều hành</label>\r\n        ");
#nullable restore
#line 61 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Hedieuhanh, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 62 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Hedieuhanh, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Màn hình</label>\r\n        ");
#nullable restore
#line 66 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Manhinh, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 67 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Manhinh, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Chip</label>\r\n        ");
#nullable restore
#line 71 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Chip, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 72 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Chip, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Dung lượng pin</label>\r\n        ");
#nullable restore
#line 76 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Dungluongpin, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 77 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Dungluongpin, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Độ sáng tối đa</label>\r\n        ");
#nullable restore
#line 81 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Dosangtoida, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 82 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Dosangtoida, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Độ phân giải</label>\r\n        ");
#nullable restore
#line 86 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Dophangiai, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 87 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Dophangiai, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Kích thước</label>\r\n        ");
#nullable restore
#line 91 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Kichthuoc, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 92 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Kichthuoc, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Ảnh</label>\r\n        ");
#nullable restore
#line 96 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.EditorFor(model => model.Anhbia, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 97 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Anhbia, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Hãng sản xuất</label>\r\n        ");
#nullable restore
#line 101 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.DropDownList("Mahang", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 102 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
   Write(Html.ValidationMessageFor(model => model.Mahang, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div class=""form-group"">
        <div class=""col-md-offset-2"">
            <input type=""submit"" value=""Thêm"" class=""btn btn-success"" />
            <a href=""/Admin/Index""><button class=""btn btn-danger"">Hủy</button></a>
        </div>
    </div>
</div>
");
#nullable restore
#line 111 "D:\FPT_Uni\Sem5\codeC#_Trung\script_project\MobileShop\MobileShop\Views\Admin\AddProduct.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MobileShop.Models.Sanpham> Html { get; private set; }
    }
}
#pragma warning restore 1591
