#pragma checksum "C:\Users\HP\source\repos\Exament3_diars_Jefri\Exament1_diars\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04b94488948ecd354a27ed4592f8f34a78e493c6"
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
#line 1 "C:\Users\HP\source\repos\Exament3_diars_Jefri\Exament1_diars\Views\_ViewImports.cshtml"
using Exament1_diars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\Exament3_diars_Jefri\Exament1_diars\Views\_ViewImports.cshtml"
using Exament1_diars.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04b94488948ecd354a27ed4592f8f34a78e493c6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47004fbb397ee4ac36508d379bdb4493811184b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<section class=""content"">
    <a href=""/home/create"" class=""btn btn-primary"" style=""margin-left:80%"">Crear Rutina</a>
    <br />
    <br />
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th>Rutina</th>
                <th>Opciones</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 16 "C:\Users\HP\source\repos\Exament3_diars_Jefri\Exament1_diars\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\HP\source\repos\Exament3_diars_Jefri\Exament1_diars\Views\Home\Index.cshtml"
                   Write(item.Nombre_Rutina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 501, "\"", 537, 2);
            WriteAttributeValue("", 508, "/Home/Ejercicios/?id=", 508, 21, true);
#nullable restore
#line 20 "C:\Users\HP\source\repos\Exament3_diars_Jefri\Exament1_diars\Views\Home\Index.cshtml"
WriteAttributeValue("", 529, item.Id, 529, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Ejercicios</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 22 "C:\Users\HP\source\repos\Exament3_diars_Jefri\Exament1_diars\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</section>\r\n");
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