#pragma checksum "c:\Users\dougl\Documents\USP\6 Semestre\PGP\PGP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "120cd06ddb238267ca6e6fa8e12f4bdea50cbc4f"
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
#line 1 "c:\Users\dougl\Documents\USP\6 Semestre\PGP\PGP\Views\_ViewImports.cshtml"
using PGP;

#line default
#line hidden
#line 2 "c:\Users\dougl\Documents\USP\6 Semestre\PGP\PGP\Views\_ViewImports.cshtml"
using PGP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"120cd06ddb238267ca6e6fa8e12f4bdea50cbc4f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"794a3b9539e23fed7086542110f23b9375efeb7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 544, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""text-center"">
         <h1>
            Bem Vindo(a)!
        </h1>
        <i class=""fas fa-user-friends fa-8x""></i>
        <br>
        <h4>
            Este é um formulário de avaliação de funcionários 360° para sua empresa!<br> 
            Acreditamos na importância do feedback como ferramenta de desenvolvimento na empresa e que,<br>
            mais do que auxiliar o profissional a melhorar, tem reflexo direto no sucesso de uma organização.
        </h4>
        <br>
        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 544, "\"", 580, 1);
#line 15 "c:\Users\dougl\Documents\USP\6 Semestre\PGP\PGP\Views\Home\Index.cshtml"
WriteAttributeValue("", 551, Url.Action("Termos", "Home"), 551, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(581, 62, true);
            WriteLiteral(" class=\"btn btn-primary\">COMEÇAR</a>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(660, 748, true);
                WriteLiteral(@"
    <script src="" ~/lib/modal-steps.min.js""></script>

    <script src=""https://code.jquery.com/jquery-1.12.4.min.js"" 
        integrity=""sha384-nvAa0+6Qg9clwYCGGPpDQLVpLNn0fRaROjHqs13t4Ggj3Ez50XnGQqc/r8MhnRDZ"" 
        crossorigin=""anonymous"">
    </script>   
    <script src=""bootstrap.min.js""></script>

    <script>
        $('#myModal').modalSteps();

        $('#myModal').modalSteps({
            btnCancelHtml: ""Cancel"",
            btnPreviousHtml: ""Previous"",
            btnNextHtml: ""Next"",
            btnLastStepHtml: ""Complete"",
            disableNextButton: false,
            completeCallback: function() {},
            callbacks: {},
            getTitleAndStep: function() {}
        });
    </script>
");
                EndContext();
            }
            );
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