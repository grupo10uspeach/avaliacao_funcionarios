#pragma checksum "c:\Users\dougl\Documents\USP\6 Semestre\PGP\PGP\Views\Home\Desempenho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab82607a374dfac003fc4b475536b96a76d6b081"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Desempenho), @"mvc.1.0.view", @"/Views/Home/Desempenho.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Desempenho.cshtml", typeof(AspNetCore.Views_Home_Desempenho))]
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
#line 1 "c:\Users\dougl\Documents\USP\6 Semestre\PGP\PGP\Views\_ViewImports.cshtml"
using PGP;

#line default
#line hidden
#line 2 "c:\Users\dougl\Documents\USP\6 Semestre\PGP\PGP\Views\_ViewImports.cshtml"
using PGP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab82607a374dfac003fc4b475536b96a76d6b081", @"/Views/Home/Desempenho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"794a3b9539e23fed7086542110f23b9375efeb7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Desempenho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 447, true);
            WriteLiteral(@"<style>
body{text-align: center; padding-top: 50px}

.estrelas input[type=radio] {
  display: none;
}
.estrelas label i.fa{
  font-size: 2.5em
}
.estrelas label i.fa:before {
  content:'\f005';
  color: #FC0;
}
.estrelas input[type=radio]:checked ~ label i.fa:before {
  color: #CCC;
}
</style>

<div class=""container"">
    <div class=""text-center"">
        <h1>
            Avaliação do Funcionário <p style=""color: orange;"">");
            EndContext();
            BeginContext(448, 16, false);
#line 22 "c:\Users\dougl\Documents\USP\6 Semestre\PGP\PGP\Views\Home\Desempenho.cshtml"
                                                          Write(ViewData["Nome"]);

#line default
#line hidden
            EndContext();
            BeginContext(464, 1187, true);
            WriteLiteral(@"</p>
        </h1>
        <i class=""far fa-thumbs-up fa-8x""></i>
        <br>
        <h4>
           Desempenho em relação ao cumprimento das obrigações do profissional<br>
           O que você  acha do trabalho deste profissional?
        </h4>

        <link rel=""stylesheet"" href=""//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"">
        <div class=""estrelas"">
            <input type=""radio"" id=""cm_star-empty"" name=""fb"" value="""" checked/>
            <label for=""cm_star-1""><i class=""fa""></i></label>
            <input type=""radio"" id=""cm_star-1"" name=""fb"" value=""1""/>
            <label for=""cm_star-2""><i class=""fa""></i></label>
            <input type=""radio"" id=""cm_star-2"" name=""fb"" value=""2""/>
            <label for=""cm_star-3""><i class=""fa""></i></label>
            <input type=""radio"" id=""cm_star-3"" name=""fb"" value=""3""/>
            <label for=""cm_star-4""><i class=""fa""></i></label>
            <input type=""radio"" id=""cm_star-4"" name=""fb"" value=""4""/>
          ");
            WriteLiteral("  <label for=\"cm_star-5\"><i class=\"fa\"></i></label>\r\n            <input type=\"radio\" id=\"cm_star-5\" name=\"fb\" value=\"5\"/>\r\n        </div>\r\n        <br>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1651, "\"", 1688, 1);
#line 46 "c:\Users\dougl\Documents\USP\6 Semestre\PGP\PGP\Views\Home\Desempenho.cshtml"
WriteAttributeValue("", 1658, Url.Action("Selecao", "Home"), 1658, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1689, 47, true);
            WriteLiteral(" class=\"btn btn-primary\">VOLTAR</a>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1736, "\"", 1777, 1);
#line 47 "c:\Users\dougl\Documents\USP\6 Semestre\PGP\PGP\Views\Home\Desempenho.cshtml"
WriteAttributeValue("", 1743, Url.Action("Habilidades", "Home"), 1743, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1778, 58, true);
            WriteLiteral(" class=\"btn btn-primary\">CONTINUAR</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
