#pragma checksum "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0bc3d04f5ad7250d70d6e56555b77645c4168c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curriculo_Curriculo), @"mvc.1.0.view", @"/Views/Curriculo/Curriculo.cshtml")]
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
#line 1 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\_ViewImports.cshtml"
using N2_Curriculo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\_ViewImports.cshtml"
using N2_Curriculo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0bc3d04f5ad7250d70d6e56555b77645c4168c4", @"/Views/Curriculo/Curriculo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee761c2a725536a28f0d2343fca5630af5c2ec1", @"/Views/_ViewImports.cshtml")]
    public class Views_Curriculo_Curriculo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PessoaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Curriculo/curriculo.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
  
    ViewData["Title"] = "Currículo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0bc3d04f5ad7250d70d6e56555b77645c4168c44209", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0bc3d04f5ad7250d70d6e56555b77645c4168c45327", async() => {
                WriteLiteral("\r\n    <br />\r\n    <h1>Currículo - ");
#nullable restore
#line 10 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
               Write(Model.nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <div class=\"section\">\r\n        <h2>Informações Pessoais</h2>\r\n        <br />\r\n        <ul>\r\n            <li><strong>Nome:</strong> ");
#nullable restore
#line 15 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                  Write(Model.nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            <li><strong>CPF:</strong> ");
#nullable restore
#line 16 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                 Write(Model.cpf);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            <li><strong>Endereço:</strong> ");
#nullable restore
#line 17 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                      Write(Model.endereco);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            <li><strong>Telefone:</strong> ");
#nullable restore
#line 18 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                      Write(Model.telefone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            <li><strong>Email:</strong> ");
#nullable restore
#line 19 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                   Write(Model.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            <li><strong>Pretensão salarial:</strong> ");
#nullable restore
#line 20 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                                Write(Model.pretensao_salarial);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            <li><strong>Cargo pretendido:</strong> ");
#nullable restore
#line 21 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                              Write(Model.cargo_pretendido);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n");
#nullable restore
#line 24 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
      
        if (Model.formacao_academica != null || Model.formacao_academica.Count == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"section\">\r\n                <h2>Formação Acadêmica</h2>\r\n");
#nullable restore
#line 29 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                 foreach (FormacaoViewModel f in Model.formacao_academica)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <br />\r\n                    <p><strong>Instituição: ");
#nullable restore
#line 32 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                       Write(f.instituicao);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (Conclusão em ");
#nullable restore
#line 32 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                                                    Write(f.data_conclusao.ToString("MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(")</strong> </p>\r\n                    <ul>\r\n                        <li><strong>Curso:</strong> ");
#nullable restore
#line 34 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                               Write(f.curso);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li><strong>Situação:</strong> ");
#nullable restore
#line 35 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                                  Write(f.situacao);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    </ul>\r\n");
#nullable restore
#line 37 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n");
#nullable restore
#line 39 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 42 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
      
        if (Model.experiencia_profissional != null || Model.experiencia_profissional.Count == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"section\">\r\n                <h2>Experiência Profissional</h2>\r\n");
#nullable restore
#line 47 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                 foreach (ExperienciaViewModel e in Model.experiencia_profissional)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <br />\r\n                    <p><strong>Empresa: ");
#nullable restore
#line 50 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                   Write(e.empresa);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></p>\r\n                    <ul>\r\n                        <li><strong>Cargo:</strong> ");
#nullable restore
#line 52 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                               Write(e.cargo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        <li><strong>Período:</strong> ");
#nullable restore
#line 53 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                                 Write(e.data_inicio.ToString("MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" até ");
#nullable restore
#line 53 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                                                                        Write(e.data_fim.ToString("MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    </ul>\r\n");
#nullable restore
#line 55 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n");
#nullable restore
#line 57 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 60 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
      
        if (Model.idioma != null || Model.idioma.Count == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"section\">\r\n                <h2>Idiomas</h2>\r\n");
#nullable restore
#line 65 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                 foreach (IdiomaViewModel i in Model.idioma)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <br />\r\n                    <p><strong>Idioma: ");
#nullable restore
#line 68 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                  Write(i.idioma);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></p>\r\n                    <ul>\r\n                        <li><strong>Nível:</strong> ");
#nullable restore
#line 70 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                                               Write(i.nivel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                    </ul>\r\n");
#nullable restore
#line 72 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n");
#nullable restore
#line 74 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Curriculo.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br />\r\n    <br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PessoaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
