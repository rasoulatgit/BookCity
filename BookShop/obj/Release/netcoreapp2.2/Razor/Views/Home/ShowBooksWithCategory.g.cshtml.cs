#pragma checksum "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cb76f89bb5e55380ff64c32735b197f45b58174"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowBooksWithCategory), @"mvc.1.0.view", @"/Views/Home/ShowBooksWithCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowBooksWithCategory.cshtml", typeof(AspNetCore.Views_Home_ShowBooksWithCategory))]
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
#line 1 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\_ViewImports.cshtml"
using BookShop;

#line default
#line hidden
#line 2 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\_ViewImports.cshtml"
using BookShop.Models;

#line default
#line hidden
#line 3 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\_ViewImports.cshtml"
using BookShop.ViewModel;

#line default
#line hidden
#line 4 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\_ViewImports.cshtml"
using BookShop.Utilities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cb76f89bb5e55380ff64c32735b197f45b58174", @"/Views/Home/ShowBooksWithCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"898ba1e63c3a5b1d1afd112333efa2a6007746af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowBooksWithCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookShop.ViewModel.BookIndexHomeViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imgs/book/books/6008610091._SS,400_.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid my-3 rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("bookCity"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
  
    ViewData["Title"] = "نمایش بر اساس دسته بندی";
    List<BooksTreeCategoryViewModel> Categories = ViewBag.Categories;
    Category category = ViewBag.Category;

#line default
#line hidden
            BeginContext(236, 22, true);
            WriteLiteral("\r\n<div class=\"mt-4\">\r\n");
            EndContext();
#line 9 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
     if (ViewBag.ConfirmEmailAlert != null)
    {

#line default
#line hidden
            BeginContext(310, 36, true);
            WriteLiteral("        <p class=\"alert alert-info\">");
            EndContext();
            BeginContext(347, 25, false);
#line 11 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                               Write(ViewBag.ConfirmEmailAlert);

#line default
#line hidden
            EndContext();
            BeginContext(372, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 12 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
    }

#line default
#line hidden
            BeginContext(385, 461, true);
            WriteLiteral(@"</div>


<div class=""row"" style=""margin-top: 62px"">

    <div id=""content"" class=""col-12"">

        <div class=""row mt-5"">
            <div id=""placeholder""></div>
            <div class=""col-md-3 d-none d-lg-inline"" id=""sidebar"">
                <div class=""card"">
                    <div class=""card-header bg-primary text-white"">
                        دسته بندی کتابها
                    </div>
                    <div class=""card-body"">
");
            EndContext();
#line 28 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                         foreach (var item in Categories)
                        {
                            if (item != null)
                            {

#line default
#line hidden
            BeginContext(1010, 96, true);
            WriteLiteral("                                <div class=\"list-group\">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1106, "\"", 1155, 2);
            WriteAttributeValue("", 1113, "/Home/ShowBooksWithCategory?catID=", 1113, 34, true);
#line 33 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
WriteAttributeValue("", 1147, item.id, 1147, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1156, "\"", 1253, 3);
            WriteAttributeValue("", 1164, "list-group-item", 1164, 15, true);
            WriteAttributeValue(" ", 1179, "list-group-item-action", 1180, 23, true);
#line 33 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
WriteAttributeValue("  ", 1202, item.id == category.CategoryID ? "active" : "", 1204, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1254, 43, true);
            WriteLiteral(">\r\n                                        ");
            EndContext();
            BeginContext(1298, 10, false);
#line 34 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                   Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(1308, 95, true);
            WriteLiteral("\r\n                                        <span class=\"float-left badge badge-info badge-pill\">");
            EndContext();
            BeginContext(1404, 23, false);
#line 35 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                                                                        Write(item.CategoryBooksCount);

#line default
#line hidden
            EndContext();
            BeginContext(1427, 93, true);
            WriteLiteral("</span>\r\n                                    </a>\r\n\r\n                                </div>\r\n");
            EndContext();
#line 39 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(1578, 195, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-9 col-12\">\r\n\r\n                <h5 id=\"TopLastBookPublished\"> کتاب های موجود در دسته‌بندی <b>");
            EndContext();
            BeginContext(1774, 21, false);
#line 46 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                                                         Write(category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(1795, 53, true);
            WriteLiteral("</b>  </h5>\r\n                <div class=\"row my-5\">\r\n");
            EndContext();
#line 48 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                     if (Model.Any())
                    {
                        

#line default
#line hidden
#line 50 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1991, 82, true);
            WriteLiteral("                            <div class=\"col-8 col-md-4 col-xl-3 m-2 p-0 post\">\r\n\r\n");
            EndContext();
#line 54 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                 if (item != null)
                                {
                                    if (item.ImageByte != null)
                                    {

#line default
#line hidden
            BeginContext(2264, 44, true);
            WriteLiteral("                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2308, "\"", 2349, 2);
            WriteAttributeValue("", 2314, "/admin/books/ShowImage/", 2314, 23, true);
#line 58 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
WriteAttributeValue("", 2337, item.BookID, 2337, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2350, 36, true);
            WriteLiteral(" class=\"img-fluid my-3 rounded-pill\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 2386, "\"", 2403, 1);
#line 58 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
WriteAttributeValue("", 2392, item.Title, 2392, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2404, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 59 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2527, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2567, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8cb76f89bb5e55380ff64c32735b197f45b5817413630", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2671, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 63 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2712, 40, true);
            WriteLiteral("                                    <h4>");
            EndContext();
            BeginContext(2753, 10, false);
#line 64 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2763, 104, true);
            WriteLiteral("</h4>\r\n                                    <hr />\r\n                                    <span> نویسنده : ");
            EndContext();
            BeginContext(2868, 15, false);
#line 66 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                                Write(item.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(2883, 101, true);
            WriteLiteral("</span>\r\n                                    <hr />\r\n                                    <h5> قیمت : ");
            EndContext();
            BeginContext(2985, 34, false);
#line 68 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                           Write(item.Price.ToString("#,### تومان"));

#line default
#line hidden
            EndContext();
            BeginContext(3019, 106, true);
            WriteLiteral("</h5>\r\n                                    <p>\r\n                                        مختصری از کتاب :\r\n");
            EndContext();
#line 71 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                         if (item.Summury != null)
                                        {
                                            

#line default
#line hidden
            BeginContext(3281, 12, false);
#line 73 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                       Write(item.Summury);

#line default
#line hidden
            EndContext();
#line 73 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                                         
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(3427, 96, true);
            WriteLiteral("                                            <span>خلاصه‌ای برای این کتاب ثبت نشده است. </span>\r\n");
            EndContext();
#line 78 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3566, 210, true);
            WriteLiteral("                                        <span>\r\n                                            <button class=\"btn btn-info btn-block mt-5 mb-1 rounded  text-white\" data-toggle=\"ajax-modal\" data-url=\"/Home/Details/");
            EndContext();
            BeginContext(3777, 11, false);
#line 80 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                                                                                                                                             Write(item.BookID);

#line default
#line hidden
            EndContext();
            BeginContext(3788, 236, true);
            WriteLiteral("\">جزئیات بیشتر</button>\r\n                                            <a href=\"#\" class=\"btn btn-success btn-block  rounded text-white\">خرید</a>\r\n                                        </span>\r\n                                    </p>\r\n");
            EndContext();
#line 84 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                                }

#line default
#line hidden
            BeginContext(4059, 36, true);
            WriteLiteral("                            </div>\r\n");
            EndContext();
#line 86 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                        }

#line default
#line hidden
#line 86 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                         

                    }
                    else
                    {

#line default
#line hidden
            BeginContext(4196, 175, true);
            WriteLiteral("                        <p class=\"bg-warning mx-auto\">\r\n                            کتابی در این دسته بندی ثبت نشده است. <a href=\"/\">بازگشت</a>\r\n                        </p>\r\n");
            EndContext();
#line 94 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\ShowBooksWithCategory.cshtml"
                    }

#line default
#line hidden
            BeginContext(4394, 82, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookShop.ViewModel.BookIndexHomeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
