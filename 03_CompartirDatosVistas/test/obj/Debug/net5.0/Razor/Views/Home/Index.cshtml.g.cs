#pragma checksum "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a261354a550d15c6ddf9653fb789f3879c1a6a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/_ViewImports.cshtml"
using test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/_ViewImports.cshtml"
using test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a261354a550d15c6ddf9653fb789f3879c1a6a0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04aae2d41d7a1f2a1b7badf4f453e10febdd2915", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<span>");
#nullable restore
#line 10 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml"
 Write(ViewBag.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n<hr>\r\n<span>");
#nullable restore
#line 12 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml"
 Write(ViewData["Apellido"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n<hr>\r\n<span>");
#nullable restore
#line 14 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml"
 Write(TempData["Usuario"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n<hr>\r\n<ul>\r\n");
#nullable restore
#line 17 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml"
     foreach (var Fruta in (List<string>)ViewData["Frutas"])
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 19 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml"
       Write(Fruta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 20 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<ul>\r\n");
#nullable restore
#line 24 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml"
     foreach (var Fruta in @ViewBag.Frutas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 26 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml"
       Write(Fruta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 27 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<ul>\r\n");
#nullable restore
#line 31 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml"
     foreach (var Fruta in (List<string>)TempData["Frutas"])
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 33 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml"
       Write(Fruta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 34 "/home/devsw/DevProjects/Core/MVC/03_CompartirDatosVistas/test/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
