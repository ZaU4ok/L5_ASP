#pragma checksum "C:\Users\SuperPC\source\repos\LR5_ASP\LR5_ASP\Pages\CheckCookie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b905a636169c8e902ca68db10c657731b8e6c1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LR5_ASP.Pages.Pages_CheckCookie), @"mvc.1.0.razor-page", @"/Pages/CheckCookie.cshtml")]
namespace LR5_ASP.Pages
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
#line 1 "C:\Users\SuperPC\source\repos\LR5_ASP\LR5_ASP\Pages\_ViewImports.cshtml"
using LR5_ASP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b905a636169c8e902ca68db10c657731b8e6c1e", @"/Pages/CheckCookie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b95e0530fbf6527faa0ee4c7a78b5b8bd648ae82", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CheckCookie : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\SuperPC\source\repos\LR5_ASP\LR5_ASP\Pages\CheckCookie.cshtml"
  
    ViewData["Title"] = "Check Cookie";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Перевірка кукі:</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\SuperPC\source\repos\LR5_ASP\LR5_ASP\Pages\CheckCookie.cshtml"
 if (Model.CookieValue != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Значення кукі: ");
#nullable restore
#line 11 "C:\Users\SuperPC\source\repos\LR5_ASP\LR5_ASP\Pages\CheckCookie.cshtml"
                 Write(Model.CookieValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Users\SuperPC\source\repos\LR5_ASP\LR5_ASP\Pages\CheckCookie.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Кукі з вказаним ім\'ям не знайдено.</p>\r\n");
#nullable restore
#line 16 "C:\Users\SuperPC\source\repos\LR5_ASP\LR5_ASP\Pages\CheckCookie.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckCookieModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CheckCookieModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CheckCookieModel>)PageContext?.ViewData;
        public CheckCookieModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
