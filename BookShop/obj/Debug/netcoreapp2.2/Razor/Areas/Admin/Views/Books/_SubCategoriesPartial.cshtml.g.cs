#pragma checksum "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1a0ea3e601106da49ccba600121977d2f2821db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books__SubCategoriesPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/_SubCategoriesPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Books/_SubCategoriesPartial.cshtml", typeof(AspNetCore.Areas_Admin_Views_Books__SubCategoriesPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1a0ea3e601106da49ccba600121977d2f2821db", @"/Areas/Admin/Views/Books/_SubCategoriesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02d05085ea63c073aad36c48bfcebdcebac310f1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Books__SubCategoriesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookShop.ViewModel.BooksTreeCategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
   int[] CategoryID = ViewData["CatID"] as int[];

#line default
#line hidden
            BeginContext(119, 6, true);
            WriteLiteral("<ul>\r\n");
            EndContext();
#line 4 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
     foreach (var cat in Model)
    {

#line default
#line hidden
            BeginContext(165, 10, true);
            WriteLiteral("    <li>\r\n");
            EndContext();
#line 7 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
         if (CategoryID!= null)
        {
            

#line default
#line hidden
#line 9 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
             if (CategoryID.Contains(cat.id))
            {

#line default
#line hidden
            BeginContext(281, 64, true);
            WriteLiteral("                <input type=\"checkbox\" name=\"CategoryID\" checked");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 345, "\"", 360, 1);
#line 11 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
WriteAttributeValue("", 353, cat.id, 353, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(361, 4, true);
            WriteLiteral(" /> ");
            EndContext();
            BeginContext(366, 9, false);
#line 11 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
                                                                               Write(cat.title);

#line default
#line hidden
            EndContext();
#line 11 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
                                                                                              
            }
            else
            {

#line default
#line hidden
            BeginContext(425, 56, true);
            WriteLiteral("                <input type=\"checkbox\" name=\"CategoryID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 481, "\"", 496, 1);
#line 15 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
WriteAttributeValue("", 489, cat.id, 489, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(497, 4, true);
            WriteLiteral(" /> ");
            EndContext();
            BeginContext(502, 9, false);
#line 15 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
                                                                       Write(cat.title);

#line default
#line hidden
            EndContext();
#line 15 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
                                                                                      
            }

#line default
#line hidden
#line 16 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
             
        }
        else
        {

#line default
#line hidden
            BeginContext(564, 52, true);
            WriteLiteral("            <input type=\"checkbox\" name=\"CategoryID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 616, "\"", 631, 1);
#line 20 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
WriteAttributeValue("", 624, cat.id, 624, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(632, 4, true);
            WriteLiteral(" /> ");
            EndContext();
            BeginContext(637, 9, false);
#line 20 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
                                                                   Write(cat.title);

#line default
#line hidden
            EndContext();
#line 20 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
                                                                                  
        }

#line default
#line hidden
            BeginContext(659, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(669, 58, false);
#line 22 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
    Write(await Html.PartialAsync("_SubCategoriesPartial", cat.subs));

#line default
#line hidden
            EndContext();
            BeginContext(728, 15, true);
            WriteLiteral("\r\n\r\n    </li>\r\n");
            EndContext();
#line 25 "C:\Users\Rasoul\source\repos\BookShop - 10 AdminPannel With Menu and controllers Full - Copy (4) - Copy\BookShop\Areas\Admin\Views\Books\_SubCategoriesPartial.cshtml"
    }

#line default
#line hidden
            BeginContext(750, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookShop.ViewModel.BooksTreeCategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
