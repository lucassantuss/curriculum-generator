#pragma checksum "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d940dece07bf17e9125def1e7a135ab47ac75ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curriculo_Form), @"mvc.1.0.view", @"/Views/Curriculo/Form.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d940dece07bf17e9125def1e7a135ab47ac75ef", @"/Views/Curriculo/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee761c2a725536a28f0d2343fca5630af5c2ec1", @"/Views/_ViewImports.cshtml")]
    public class Views_Curriculo_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PessoaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Salvar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
  
    ViewData["Title"] = "Currículo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d940dece07bf17e9125def1e7a135ab47ac75ef4437", async() => {
                WriteLiteral("\r\n    <h1>Currículo</h1>\r\n    <br />\r\n    <h2>Dados pessoais</h2>\r\n    <br />\r\n    <label for=\"nome\" class=\"control-label\">Nome</label>\r\n    <input type=\"text\" Name=\"nome\"");
                BeginWriteAttribute("value", " value=\"", 295, "\"", 314, 1);
#nullable restore
#line 12 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 303, Model.nome, 303, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    <br />\r\n    <label for=\"cpf\" class=\"control-label\">CPF</label>\r\n    <input type=\"text\" Name=\"cpf\"");
                BeginWriteAttribute("value", " value=\"", 442, "\"", 460, 1);
#nullable restore
#line 15 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 450, Model.cpf, 450, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    <br />\r\n    <label for=\"endereco\" class=\"control-label\">Endereço</label>\r\n    <input type=\"text\" Name=\"endereco\"");
                BeginWriteAttribute("value", " value=\"", 603, "\"", 626, 1);
#nullable restore
#line 18 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 611, Model.endereco, 611, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    <br />\r\n    <label for=\"telefone\" class=\"control-label\">Telefone</label>\r\n    <input type=\"text\" Name=\"telefone\"");
                BeginWriteAttribute("value", " value=\"", 769, "\"", 792, 1);
#nullable restore
#line 21 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 777, Model.telefone, 777, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    <br />\r\n    <label for=\"email\" class=\"control-label\">E-mail</label>\r\n    <input type=\"text\" Name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 927, "\"", 947, 1);
#nullable restore
#line 24 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 935, Model.email, 935, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    <br />\r\n    <label for=\"pretensao_salarial\" class=\"control-label\">Pretensão salarial</label>\r\n    <input type=\"number\" Name=\"pretensao_salarial\"");
                BeginWriteAttribute("value", " value=\"", 1122, "\"", 1155, 1);
#nullable restore
#line 27 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 1130, Model.pretensao_salarial, 1130, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n    <br />\r\n    <label for=\"CidadeId\" class=\"control-label\">Cargo pretendido</label>\r\n    <input type=\"text\" Name=\"cargo_pretendido\"");
                BeginWriteAttribute("value", " value=\"", 1314, "\"", 1345, 1);
#nullable restore
#line 30 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 1322, Model.cargo_pretendido, 1322, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" />
    <br />
    <br />

    <h2>Formação Acadêmica</h2>
    <br />
    <table class=""table table-responsive table-striped"">
        <tr>
            <th>Ações</th>
            <th>Instituição</th>
            <th>Curso</th>
            <th>Situação</th>
            <th>Data de Conclusão</th>
        </tr>
");
#nullable restore
#line 44 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
         if (Model.formacao_academica != null) foreach (FormacaoViewModel f in Model.formacao_academica)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1886, "\"", 1925, 2);
                WriteAttributeValue("", 1893, "/curriculo/EditFormacao?id=", 1893, 27, true);
#nullable restore
#line 48 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 1920, f.id, 1920, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info\">Editar</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1986, "\"", 2025, 3);
                WriteAttributeValue("", 1993, "javascript:apagarFormacao(", 1993, 26, true);
#nullable restore
#line 49 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 2019, f.id, 2019, 5, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2024, ")", 2024, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Apagar</a>\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 51 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
                   Write(f.instituicao);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
                   Write(f.curso);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
                   Write(f.situacao);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
                   Write(f.data_conclusao.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 56 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </table>
    <a href=""javascript:modalFormacao()"" class=""btn btn-primary"">Adicionar</a>
    <br />
    <br />
    <br />

    <h2>Experiências profissionais</h2>
    <br />
    <table class=""table table-responsive table-striped"">
        <tr>
            <th>Ações</th>
            <th>Empresa</th>
            <th>Cargo</th>
            <th>Data de Início</th>
            <th>Data Final</th>
        </tr>
");
#nullable restore
#line 73 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
         if (Model.experiencia_profissional != null) foreach (ExperienciaViewModel e in Model.experiencia_profissional)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2962, "\"", 3004, 2);
                WriteAttributeValue("", 2969, "/curriculo/EditExperiencia?id=", 2969, 30, true);
#nullable restore
#line 77 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 2999, e.id, 2999, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info\">Editar</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3065, "\"", 3107, 3);
                WriteAttributeValue("", 3072, "javascript:apagarExperiencia(", 3072, 29, true);
#nullable restore
#line 78 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 3101, e.id, 3101, 5, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3106, ")", 3106, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Apagar</a>\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 80 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
                   Write(e.empresa);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 81 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
                   Write(e.cargo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 82 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
                   Write(e.data_inicio.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 83 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
                   Write(e.data_fim.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 85 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </table>
    <a href=""javascript:modalExperiencia()"" class=""btn btn-primary"">Adicionar</a>
    <br />
    <br />
    <br />

    <h2>Idiomas</h2>
    <br />
    <table class=""table table-responsive table-striped"">
        <tr>
            <th>Ações</th>
            <th>Idioma</th>
            <th>Nível</th>
        </tr>
");
#nullable restore
#line 100 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
         if (Model.idioma != null) foreach (IdiomaViewModel i in Model.idioma)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3932, "\"", 3969, 2);
                WriteAttributeValue("", 3939, "/curriculo/EditIdioma?id=", 3939, 25, true);
#nullable restore
#line 104 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 3964, i.id, 3964, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info\">Editar</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4030, "\"", 4067, 3);
                WriteAttributeValue("", 4037, "javascript:apagarIdioma(", 4037, 24, true);
#nullable restore
#line 105 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
WriteAttributeValue("", 4061, i.id, 4061, 5, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4066, ")", 4066, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Apagar</a>\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 107 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
                   Write(i.idioma);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 108 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
                   Write(i.nivel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 110 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\Form.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </table>
    <a href=""javascript:modalIdioma()"" class=""btn btn-primary"">Adicionar</a>
    <br />
    <br />
    <br />

    <input type=""submit"" value=""Salvar dados"" class=""btn btn-success"" />
    <br />
    <br />

    <div class=""modal"" id=""modal_validacao"" role=""dialog"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"" id=""modal-body"">

                </div>
            </div><!-- /.modal-content -->
        </div><!-- /.modal-dialog -->
    </div><!-- /.modal -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    function apagarExperiencia(id) {
        if (confirm('Confirma a exclusão da experiência profissional selecionada?'))
            location.href = 'aluno/DeleteExperiencia?id=' + id;
    }

    function apagarFormacao(id) {
        if (confirm('Confirma a exclusão da formação acadêmica selecionada?'))
            location.href = 'aluno/DeleteFormacao?id=' + id;
    }

    function apagarIdioma(id) {
        if (confirm('Confirma a exclusão do idioma selecionado?'))
            location.href = 'aluno/DeleteIdioma?id=' + id;
    }

    function modalExperiencia() {

        $.ajax({
            url: ""/Curriculo/CreateExperiencia"",
            dataType: 'html',
            beforeSend: function () {

            },
            success: function (data) {

                $('#modal-body').html(data);
                $('#modal_validacao').modal('show');
            }
        });
    }

    function modalFormacao() {

        $.ajax({
            url: ""/Curriculo/Cre");
            WriteLiteral(@"ateFormacao"",
            dataType: 'html',
            beforeSend: function () {

            },
            success: function (data) {

                $('#modal-body').html(data);
                $('#modal_validacao').modal('show');
            }
        });
    }

    function modalIdioma() {

        $.ajax({
            url: ""/Curriculo/CreateIdioma"",
            dataType: 'html',
            beforeSend: function () {

            },
            success: function (data) {

                $('#modal-body').html(data);
                $('#modal_validacao').modal('show');
            }
        });
    }
</script>");
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