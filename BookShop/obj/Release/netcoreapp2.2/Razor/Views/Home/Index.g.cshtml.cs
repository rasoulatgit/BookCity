#pragma checksum "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d2ba1a1bd4aa68855e459c851040008e40a98c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2ba1a1bd4aa68855e459c851040008e40a98c4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"898ba1e63c3a5b1d1afd112333efa2a6007746af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookShop.ViewModel.BookIndexHomeViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imgs/book/png/book png1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowBooksWithCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item list-group-item-action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imgs/book/books/6008610091._SS,400_.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid my-3 rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("bookCity"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "صفحه اصلی";
    List<BooksTreeCategoryViewModel> Categories = ViewBag.Categories;


#line default
#line hidden
            BeginContext(181, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Search", async() => {
                BeginContext(199, 140, true);
                WriteLiteral("\r\n\r\n    <div id=\"topHead\" class=\"row align-items-center rounded text-center text-white py-5 \">\r\n        <div class=\"col-md-6\">\r\n            ");
                EndContext();
                BeginContext(339, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4d2ba1a1bd4aa68855e459c851040008e40a98c48255", async() => {
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
                BeginContext(406, 148, true);
                WriteLiteral("\r\n            <h1>\r\n                شهر کتاب\r\n            </h1>\r\n        </div>\r\n        <div class=\"col-md-6 text-center float-left\">\r\n            ");
                EndContext();
                BeginContext(554, 531, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d2ba1a1bd4aa68855e459c851040008e40a98c49830", async() => {
                    BeginContext(594, 484, true);
                    WriteLiteral(@"
                <label class=""h3"">کتاب مورد نظر خود را جستجو کنید</label><br />
                <div class=""input-group mb-3 col-md-9 mx-md-auto"">
                    <input type=""text"" class=""form-control "" name=""bookTitle"" placeholder=""عنوان کتاب  ..."">
                    <div class=""input-group-prepend"">
                        <button typeof=""submit"" class=""btn btn-info"" id=""button-addon1"">جستجو</button>
                    </div>
                </div>
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1085, 32, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
#line 31 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
 if (ViewBag.ConfirmEmailAlert!=null)
{

#line default
#line hidden
            BeginContext(1162, 71, true);
            WriteLiteral("<div class=\"alert mt-5 clearfix alert-primary alert-dismissible\">\r\n    ");
            EndContext();
            BeginContext(1234, 25, false);
#line 34 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
Write(ViewBag.ConfirmEmailAlert);

#line default
#line hidden
            EndContext();
            BeginContext(1259, 108, true);
            WriteLiteral("\r\n    <button class=\"btn btn-danger float-left\" data-dismiss=\"alert\"><span>&times;</span></button>\r\n</div>\r\n");
            EndContext();
#line 37 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1370, 449, true);
            WriteLiteral(@"<div class=""row"" style=""margin-top: 62px"">

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
#line 50 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                         foreach (var item in Categories)
                        {
                            if (item != null)
                            {

#line default
#line hidden
            BeginContext(1983, 94, true);
            WriteLiteral("                                <div class=\"list-group\">\r\n                                    ");
            EndContext();
            BeginContext(2077, 333, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d2ba1a1bd4aa68855e459c851040008e40a98c414521", async() => {
                BeginContext(2189, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(2232, 10, false);
#line 56 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                                   Write(item.title);

#line default
#line hidden
                EndContext();
                BeginContext(2242, 95, true);
                WriteLiteral("\r\n                                        <span class=\"float-left badge badge-info badge-pill\">");
                EndContext();
                BeginContext(2338, 23, false);
#line 57 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                                                                                        Write(item.CategoryBooksCount);

#line default
#line hidden
                EndContext();
                BeginContext(2361, 45, true);
                WriteLiteral("</span>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-catID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                                                                               WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["catID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-catID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["catID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2410, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 60 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(2510, 234, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-9 col-12\">\r\n\r\n                <h4 id=\"TopLastBookPublished\">آخرین کتابهای منتشر شده </h4>\r\n                <div class=\"row my-5\">\r\n");
            EndContext();
#line 69 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(2817, 78, true);
            WriteLiteral("                        <div class=\"col-8 col-md-4 col-xl-3 m-2 p-0 post\">\r\n\r\n");
            EndContext();
#line 73 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                             if (item != null)
                            {
                                if (item.ImageByte != null)
                                {

#line default
#line hidden
            BeginContext(3070, 40, true);
            WriteLiteral("                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3110, "\"", 3151, 2);
            WriteAttributeValue("", 3116, "/admin/books/ShowImage/", 3116, 23, true);
#line 77 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 3139, item.BookID, 3139, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3152, 36, true);
            WriteLiteral(" class=\"img-fluid my-3 rounded-pill\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 3188, "\"", 3205, 1);
#line 77 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 3194, item.Title, 3194, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3206, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 78 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3317, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(3353, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d2ba1a1bd4aa68855e459c851040008e40a98c421109", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3457, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 82 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3494, 36, true);
            WriteLiteral("                                <h4>");
            EndContext();
            BeginContext(3531, 10, false);
#line 83 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3541, 96, true);
            WriteLiteral("</h4>\r\n                                <hr />\r\n                                <span> نویسنده : ");
            EndContext();
            BeginContext(3638, 15, false);
#line 85 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                                            Write(item.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(3653, 93, true);
            WriteLiteral("</span>\r\n                                <hr />\r\n                                <h5> قیمت : ");
            EndContext();
            BeginContext(3747, 43, false);
#line 87 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                                       Write(string.Format("{0:#,## تومان}", item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3790, 98, true);
            WriteLiteral("</h5>\r\n                                <p>\r\n                                    مختصری از کتاب :\r\n");
            EndContext();
#line 90 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                                     if (item.Summury != null)
                                    {
                                        

#line default
#line hidden
            BeginContext(4032, 12, false);
#line 92 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                                   Write(item.Summury);

#line default
#line hidden
            EndContext();
#line 92 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                                                     
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(4166, 92, true);
            WriteLiteral("                                        <span>خلاصه‌ای برای این کتاب ثبت نشده است. </span>\r\n");
            EndContext();
#line 97 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4297, 202, true);
            WriteLiteral("                                    <span>\r\n                                        <button class=\"btn btn-info btn-block mt-5 mb-1 rounded  text-white\" data-toggle=\"ajax-modal\" data-url=\"/Home/Details/");
            EndContext();
            BeginContext(4500, 11, false);
#line 99 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                                                                                                                                                         Write(item.BookID);

#line default
#line hidden
            EndContext();
            BeginContext(4511, 224, true);
            WriteLiteral("\">جزئیات بیشتر</button>\r\n                                        <a href=\"#\" class=\"btn btn-success btn-block  rounded text-white\">خرید</a>\r\n                                    </span>\r\n                                </p>\r\n");
            EndContext();
#line 103 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4766, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 106 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (3)\BookShop\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4823, 84, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
