#pragma checksum "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b53e16fdf26c793b7729b6ad463fd87c1c2ca08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sanpham_Detail), @"mvc.1.0.view", @"/Views/Sanpham/Detail.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b53e16fdf26c793b7729b6ad463fd87c1c2ca08", @"/Views/Sanpham/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sanpham_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MobileShop.Models.Sanpham>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml"
  
    ViewBag.Title = "Product Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b53e16fdf26c793b7729b6ad463fd87c1c2ca083501", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n    <style>\r\n        .checked {\r\n            color: orange;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b53e16fdf26c793b7729b6ad463fd87c1c2ca084688", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""card"">
            <div class=""card-body"">
                <h2 class=""mt-6"" style=""text-align:center; font-weight:bold; margin-top: 70px"">Chi tiết sản phẩm</h2>
                <h3 class=""card-title"" style=""font-weight:bold"">Điện thoại ");
#nullable restore
#line 21 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml"
                                                                      Write(Model.Tensp);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-5 col-md-5 col-sm-6\">\r\n                        <div class=\"white-box text-center\"><img style=\"width:100%\"");
                BeginWriteAttribute("src", " src=\"", 853, "\"", 886, 1);
#nullable restore
#line 24 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml"
WriteAttributeValue("", 859, Url.Content(@Model.Anhbia), 859, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-responsive\"></div>\r\n                    </div>\r\n                    <div class=\"col-lg-7 col-md-7 col-sm-6\">\r\n                        <h3 class=\"box-title mt-5\">");
#nullable restore
#line 27 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml"
                                              Write(Model.Tensp);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                        <span class=""fa fa-star checked""></span>
                        <span class=""fa fa-star checked""></span>
                        <span class=""fa fa-star checked""></span>
                        <span class=""fa fa-star checked""></span>
                        <span class=""fa fa-star""></span>
                        <br />
                        <p>");
#nullable restore
#line 34 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml"
                      Write(Model.Mota);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <h2 style=\"color:red\" class=\"mt-5\">\r\n                            $");
#nullable restore
#line 36 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml"
                        Write(Model.Giatien);

#line default
#line hidden
#nullable disable
                WriteLiteral("<small class=\"text-success\"> (15% off)</small>\r\n                        </h2>\r\n                        <h4 style=\"color:orange\">\r\n");
#nullable restore
#line 39 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml"
                             if (@Model.Sanphammoi == true)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p>Hàng mới về</p>\r\n");
#nullable restore
#line 42 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p>Hàng cũ</p>\r\n");
#nullable restore
#line 46 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </h4>\r\n                        <button class=\" fa fa-shopping-cart btn btn-primary btn-rounded\">  Mua ngay</button>\r\n                        <h3 class=\"box-title mt-5\">Số lượng chỉ còn ");
#nullable restore
#line 49 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml"
                                                               Write(Model.Soluong);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" toàn quốc!</h3>

                        <table class=""table table-striped"">
                            <tbody>
                                <tr>
                                    <th scope=""row"">Thẻ sim: </th>
                                    <td>");
#nullable restore
#line 55 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml"
                                   Write(Model.Thesim);

#line default
#line hidden
#nullable disable
                WriteLiteral(" eSIM, hỗ trợ 5G</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <th scope=\"row\">Bộ nhớ trong: </th>\r\n                                    <td>");
#nullable restore
#line 59 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml"
                                   Write(Model.Bonhotrong);

#line default
#line hidden
#nullable disable
                WriteLiteral(" GB</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <th scope=\"row\">Ram: </th>\r\n                                    <td>");
#nullable restore
#line 63 "C:\Users\admin\Desktop\MobileShop-PRN211\MobileShop\Views\Sanpham\Detail.cshtml"
                                   Write(Model.Ram);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" GB</td>
                                </tr>
                            </tbody>
                        </table>

                        <ul class=""list-unstyled"">
                            <li><i class=""fa fa-check text-success""></i> Trả góp 0%</li>
                            <li><i class=""fa fa-check text-success""></i> Freeship toàn quốc</li>
                            <li><i class=""fa fa-check text-success""></i> Hỗ trợ đổi trả trong 6 tháng</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
