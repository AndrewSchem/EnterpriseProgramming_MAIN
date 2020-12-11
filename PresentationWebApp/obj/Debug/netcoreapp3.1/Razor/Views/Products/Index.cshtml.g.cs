#pragma checksum "C:\Users\andre\Source\Repos\EnterpriseProgramming_MAIN\PresentationWebApp\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c1cacb70e785ac89fab465d4bb8549d00fdebf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "C:\Users\andre\Source\Repos\EnterpriseProgramming_MAIN\PresentationWebApp\Views\_ViewImports.cshtml"
using PresentationWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\Source\Repos\EnterpriseProgramming_MAIN\PresentationWebApp\Views\_ViewImports.cshtml"
using PresentationWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c1cacb70e785ac89fab465d4bb8549d00fdebf9", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d37c9bc11724120768bc51102823a04d56debf5", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppingCart.Application.ViewModels.ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\andre\Source\Repos\EnterpriseProgramming_MAIN\PresentationWebApp\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Products Catalogue</h1>\n\n\n<div class=\"container\">\n    <div class=\"row\">\n\n");
#nullable restore
#line 14 "C:\Users\andre\Source\Repos\EnterpriseProgramming_MAIN\PresentationWebApp\Views\Products\Index.cshtml"
         foreach(var p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4\">\n                <div class=\"card\" style=\"width: 18rem;\">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 347, "\"", 364, 1);
#nullable restore
#line 18 "C:\Users\andre\Source\Repos\EnterpriseProgramming_MAIN\PresentationWebApp\Views\Products\Index.cshtml"
WriteAttributeValue("", 353, p.ImageUrl, 353, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top image\" alt=\"...\">\n                    <div class=\"card-body\">\n                        <h5 class=\"card-title\">");
#nullable restore
#line 20 "C:\Users\andre\Source\Repos\EnterpriseProgramming_MAIN\PresentationWebApp\Views\Products\Index.cshtml"
                                          Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <p class=\"card-text\">$");
#nullable restore
#line 21 "C:\Users\andre\Source\Repos\EnterpriseProgramming_MAIN\PresentationWebApp\Views\Products\Index.cshtml"
                                         Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 593, "\"", 626, 2);
            WriteAttributeValue("", 600, "/Products/Details?id=", 600, 21, true);
#nullable restore
#line 22 "C:\Users\andre\Source\Repos\EnterpriseProgramming_MAIN\PresentationWebApp\Views\Products\Index.cshtml"
WriteAttributeValue("", 621, p.Id, 621, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">View Specification</a>\n\n");
#nullable restore
#line 24 "C:\Users\andre\Source\Repos\EnterpriseProgramming_MAIN\PresentationWebApp\Views\Products\Index.cshtml"
                         if (User.IsInRole("Admin"))
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 768, "\"", 800, 2);
            WriteAttributeValue("", 775, "/Products/Delete?id=", 775, 20, true);
#nullable restore
#line 26 "C:\Users\andre\Source\Repos\EnterpriseProgramming_MAIN\PresentationWebApp\Views\Products\Index.cshtml"
WriteAttributeValue("", 795, p.Id, 795, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\n");
#nullable restore
#line 27 "C:\Users\andre\Source\Repos\EnterpriseProgramming_MAIN\PresentationWebApp\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 31 "C:\Users\andre\Source\Repos\EnterpriseProgramming_MAIN\PresentationWebApp\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShoppingCart.Application.ViewModels.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
