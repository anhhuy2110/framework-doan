#pragma checksum "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "817639e2166db358e45656c94987eb364720559e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThongKe_Index3), @"mvc.1.0.view", @"/Views/ThongKe/Index3.cshtml")]
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
#line 1 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\_ViewImports.cshtml"
using PJC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\_ViewImports.cshtml"
using PJC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"817639e2166db358e45656c94987eb364720559e", @"/Views/ThongKe/Index3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Views/_ViewImports.cshtml")]
    public class Views_ThongKe_Index3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PJC.Models.PhieuMuon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container-fluid"">
        <h1 class=""mt-4"">Thống Kê</h1>
        <ol class=""breadcrumb mb-4"">
            <li class=""breadcrumb-item""><a href=""/Home"">Trang chủ</a></li>
            <li class=""breadcrumb-item active"">Thống kê</li>
        </ol>
        <div class=""row mtbox"">
            <div class=""col-md-2 col-sm-2 col-md-offset-1 box0"">
                <div class=""box1"">
                    <a href=""/ThongKe/Index1"">
                        <img src=""https://img.icons8.com/carbon-copy/64/000000/book.png"" />
                    </a>
                    <h3></h3>
                </div>
                <p>Có ");
#nullable restore
#line 21 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                 Write(ViewBag.SoLuongSach);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" sách trong thư viện!</p>
            </div>

            <div class=""col-md-2 col-sm-2 box0"">
                <div class=""box1"">
                    <a href=""/ThongKe/Index2"">
                        <img src=""https://img.icons8.com/dusk/64/000000/reading.png"" />
                    </a>
                    <h3></h3>
                </div>
                <p>Có ");
#nullable restore
#line 31 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                 Write(ViewBag.SoLuongDocGia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" độc giả!</p>
            </div>
            <div class=""col-md-2 col-sm-2 box0"">
                <div class=""box1"">
                    <a href=""/ThongKe/Index3"">
                        <img src=""https://img.icons8.com/dusk/64/000000/borrow-book.png"" />
                    </a>
                    <h3</h3>
                </div>
                <p>Có ");
#nullable restore
#line 40 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                 Write(ViewBag.SoLuongPhieuMuon);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" phiếu mượn!</p>
            </div>
            <div class=""col-md-2 col-sm-2 box0"">
                <div class=""box1"">
                    <a href=""/ThongKe/Index4"">
                        <img src=""https://img.icons8.com/dusk/64/000000/return-book.png"" />
                    </a>

                    <h3</h3>
                </div>
                <p>Có ");
#nullable restore
#line 50 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                 Write(ViewBag.SoLuongPhieuTra);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" phiếu trả!</p>
            </div>
            <div class=""col-md-2 col-sm-2 box0"">
                <div class=""box1"">
                    <a href=""/ThongKe/Index5"">
                        <img src=""https://img.icons8.com/wired/64/000000/return-book.png"" />
                    </a>
                    <h3</h3>
                </div>
                <p>Có ");
#nullable restore
#line 59 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                 Write(ViewBag.SoLuongPhieuChuaTra);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" phiếu chưa trả!</p>
            </div>
            <div class=""col-md-2 col-sm-2 box0"">
                <div class=""box1"">
                    <a href=""/ThongKe/Index6"">
                        <img src=""https://img.icons8.com/wired/64/000000/return-book.png"" />
                    </a>
                    <h3</h3>
                </div>
                <p>Doanh thu tiền phạt($):");
#nullable restore
#line 68 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                                     Write(ViewBag.DoanhThu);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>

        <div class=""card mb-4"">
            <div class=""card-header""><i class=""fas fa-table mr-1""></i>Phiếu mượn</div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 80 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                               Write(Html.DisplayNameFor(model => model.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 83 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                               Write(Html.DisplayNameFor(model => model.MaDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 86 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                               Write(Html.DisplayNameFor(model => model.NgayMuon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 89 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                               Write(Html.DisplayNameFor(model => model.NgayHenTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 92 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                               Write(Html.DisplayNameFor(model => model.SoLuongMuon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 95 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                               Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 101 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 105 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 108 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.MaDG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 111 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.NgayMuon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 114 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.NgayHenTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 117 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.SoLuongMuon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 120 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                   \r\n                                </tr>\r\n");
#nullable restore
#line 124 "D:\Bao Cao Do An\Framework đồ án\PJC\Views\ThongKe\Index3.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PJC.Models.PhieuMuon>> Html { get; private set; }
    }
}
#pragma warning restore 1591