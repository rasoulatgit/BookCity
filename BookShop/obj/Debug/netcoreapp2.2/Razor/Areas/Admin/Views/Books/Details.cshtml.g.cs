#pragma checksum "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ced18aec330cfa50452f3ed8ae134a3f504dad4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Books/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Books_Details))]
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
#line 1 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\_ViewImports.cshtml"
using BookShop;

#line default
#line hidden
#line 2 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\_ViewImports.cshtml"
using BookShop.ViewModel;

#line default
#line hidden
#line 3 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\_ViewImports.cshtml"
using BookShop.Models;

#line default
#line hidden
#line 4 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\_ViewImports.cshtml"
using BookShop.Utilities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ced18aec330cfa50452f3ed8ae134a3f504dad4", @"/Areas/Admin/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02d05085ea63c073aad36c48bfcebdcebac310f1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookShop.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imgs/no-image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = null;

#line default
#line hidden
            BeginContext(121, 161, true);
            WriteLiteral("\r\n<div class=\"modal\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header\">\r\n                اطلاعات کتاب ");
            EndContext();
            BeginContext(283, 11, false);
#line 12 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                        Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(294, 243, true);
            WriteLiteral("\r\n                <button data-dismiss=\"modal\" class=\"btn btn-danger\">\r\n                    <span>&times;</span>\r\n                </button>\r\n            </div>\r\n            <div class=\"modal-body row\">\r\n                <div class=\"col-md-4\">\r\n");
            EndContext();
#line 19 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                     if (Model.Image != null)
                    {

#line default
#line hidden
            BeginContext(607, 28, true);
            WriteLiteral("                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 635, "\"", 677, 2);
            WriteAttributeValue("", 641, "/admin/books/showimage/", 641, 23, true);
#line 21 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
WriteAttributeValue("", 664, Model.BookID, 664, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 678, "\"", 696, 1);
#line 21 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
WriteAttributeValue("", 684, Model.Title, 684, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(697, 23, true);
            WriteLiteral(" class=\"img-fluid\" />\r\n");
            EndContext();
#line 22 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(792, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(816, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ced18aec330cfa50452f3ed8ae134a3f504dad47491", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 25 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
AddHtmlAttributeValue("", 852, Model.Title, 852, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(886, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(911, 100, true);
            WriteLiteral("                </div>\r\n                <div class=\"col-md-4\">\r\n                    <p>عنوان کتاب : ");
            EndContext();
            BeginContext(1012, 11, false);
#line 29 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1023, 37, true);
            WriteLiteral("</p>\r\n                    <p>شابک  : ");
            EndContext();
            BeginContext(1061, 10, false);
#line 30 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                          Write(Model.ISBN);

#line default
#line hidden
            EndContext();
            BeginContext(1071, 36, true);
            WriteLiteral("</p>\r\n                    <p>ناشر : ");
            EndContext();
            BeginContext(1108, 29, false);
#line 31 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                         Write(Model.Publisher.PublisherName);

#line default
#line hidden
            EndContext();
            BeginContext(1137, 39, true);
            WriteLiteral("</p>\r\n                    <p>موجودی  : ");
            EndContext();
            BeginContext(1177, 11, false);
#line 32 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                            Write(Model.Stock);

#line default
#line hidden
            EndContext();
            BeginContext(1188, 36, true);
            WriteLiteral("</p>\r\n                    <p>وزن  : ");
            EndContext();
            BeginContext(1225, 12, false);
#line 33 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                         Write(Model.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(1237, 37, true);
            WriteLiteral("</p>\r\n                    <p>قیمت  : ");
            EndContext();
            BeginContext(1275, 34, false);
#line 34 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                          Write(Model.Price.ToString("#,## تومان"));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 43, true);
            WriteLiteral("</p>\r\n                    <p>سال انتشار  : ");
            EndContext();
            BeginContext(1353, 17, false);
#line 35 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                Write(Model.PublishYear);

#line default
#line hidden
            EndContext();
            BeginContext(1370, 43, true);
            WriteLiteral("</p>\r\n                    <p>تعداد صفحه  : ");
            EndContext();
            BeginContext(1414, 15, false);
#line 36 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                Write(Model.NumOfPage);

#line default
#line hidden
            EndContext();
            BeginContext(1429, 70, true);
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n");
            EndContext();
#line 39 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                     if (Model.IsPublish)
                    {

#line default
#line hidden
            BeginContext(1565, 142, true);
            WriteLiteral("                        <p>وضعیت : <span class=\"badge badge-success\"> منتشر شده</span></p>\r\n                        <p>تاریخ انتشار در سایت : ");
            EndContext();
            BeginContext(1708, 71, false);
#line 42 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                             Write(Convert.ToShamsi(Model.PublishDate.Value, "dddd d MMMM yyyy ساعت h:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1779, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 43 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1857, 149, true);
            WriteLiteral("                        <p>وضعیت : <span class=\"badge badge-info\"> منتشر نشده</span></p>\r\n                        <p>تاریخ انتشار در سایت : -- </p>\r\n");
            EndContext();
#line 48 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(2029, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 49 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                     if (Model.File != null)
                    {

#line default
#line hidden
            BeginContext(2098, 75, true);
            WriteLiteral("                        <p>\r\n                            قسمتی از کتاب : <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2173, "\"", 2215, 2);
            WriteAttributeValue("", 2180, "/admin/books/download/", 2180, 22, true);
#line 52 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
WriteAttributeValue("", 2202, Model.BookID, 2202, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2216, 171, true);
            WriteLiteral(" class=\"badge badge-success\">\r\n                                <i class=\"fa fa-download pl-2\"></i> دانلود\r\n                            </a>\r\n                        </p>\r\n");
            EndContext();
#line 56 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2459, 107, true);
            WriteLiteral("                        <p>قسمتی از کتاب : <span class=\"badge bg-warning\"> فایلی بارگذاری نشده</span></p>\r\n");
            EndContext();
#line 60 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(2589, 30, true);
            WriteLiteral("                    <p>زبان : ");
            EndContext();
            BeginContext(2620, 27, false);
#line 61 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                         Write(Model.Language.LanguageName);

#line default
#line hidden
            EndContext();
            BeginContext(2647, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 62 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                     if (ViewBag.Author != null)
                    {
                        string authors = "";
                        foreach (var i in ViewBag.Author)
                        {
                            if (authors == "")
                            {
                                authors = i;
                            }
                            else
                            {
                                authors += " - " + i;
                            }
                        }

#line default
#line hidden
            BeginContext(3192, 69, true);
            WriteLiteral("                        <p>\r\n                            نویسندکان : ");
            EndContext();
            BeginContext(3262, 7, false);
#line 77 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                   Write(authors);

#line default
#line hidden
            EndContext();
            BeginContext(3269, 32, true);
            WriteLiteral("\r\n                        </p>\r\n");
            EndContext();
#line 79 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3373, 46, true);
            WriteLiteral("                        <p>نویسنده : -- </p>\r\n");
            EndContext();
#line 83 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(3442, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 84 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                     if (ViewBag.Category != null)
                    {
                        string categories = "";
                        foreach (var i in ViewBag.Category)
                        {
                            if (categories == "")
                            {
                                categories = i;
                            }
                            else
                            {
                                categories += " - " + i;
                            }
                        }

#line default
#line hidden
            BeginContext(3997, 71, true);
            WriteLiteral("                        <p>\r\n                            دسته‌بندیها : ");
            EndContext();
            BeginContext(4069, 10, false);
#line 99 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                     Write(categories);

#line default
#line hidden
            EndContext();
            BeginContext(4079, 32, true);
            WriteLiteral("\r\n                        </p>\r\n");
            EndContext();
#line 101 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(4183, 48, true);
            WriteLiteral("                        <p>دسته‌بندی : -- </p>\r\n");
            EndContext();
#line 105 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(4254, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 106 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                     if (ViewBag.Translator != null)
                    {
                        string translators = "";
                        foreach (var i in ViewBag.Translator)
                        {
                            if (translators == "")
                            {
                                translators = i;
                            }
                            else
                            {
                                translators += " - " + i;
                            }
                        }

#line default
#line hidden
            BeginContext(4817, 67, true);
            WriteLiteral("                        <p>\r\n                            مترجمان : ");
            EndContext();
            BeginContext(4885, 11, false);
#line 121 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                                 Write(translators);

#line default
#line hidden
            EndContext();
            BeginContext(4896, 32, true);
            WriteLiteral("\r\n                        </p>\r\n");
            EndContext();
#line 123 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(5000, 44, true);
            WriteLiteral("                        <p>مترجم : -- </p>\r\n");
            EndContext();
#line 127 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(5067, 228, true);
            WriteLiteral("                </div>\r\n                <div class=\"col-md-12\">\r\n                    <hr />\r\n                    <br />\r\n                    <p class=\"mx-5\">\r\n                        خلاصه کتاب : <br />\r\n                        ");
            EndContext();
            BeginContext(5296, 13, false);
#line 134 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\Details.cshtml"
                   Write(Model.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(5309, 260, true);
            WriteLiteral(@"
                    </p>
                </div>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-danger float-left"" data-dismiss=""modal"">بستن</button>
            </div>
        </div>
    </div>
</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ConvertDate Convert { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookShop.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
