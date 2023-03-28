using Microsoft.AspNetCore.Mvc;
using System;
using N2_Curriculo.DAO;
using N2_Curriculo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N2_Curriculo.Controllers
{
    public class CurriculoController : Controller
    {
        #region Listagem - Currículos
        /// <summary>
        /// Action que retorna a Listagem de todos os currículos existentes na tela
        /// </summary>
        public IActionResult Index()
        {
            try
            {
                PessoaDAO pessoaDao = new PessoaDAO();
                var lista = pessoaDao.Listagem();

                return View(lista);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
        #endregion

        #region Métodos - Dados Pessoais
        /// <summary>
        /// Action responsável por direcionar para a tela de preenchimento dos Dados Pessoais (Novo Currículo)
        /// </summary>
        public IActionResult Create()
        {
            try
            {
                ViewBag.Operacao = "I";
                PessoaDAO dao = new PessoaDAO();
                PessoaViewModel pessoa = new PessoaViewModel();
                pessoa.id = dao.ProximoId();

                return View("Form", pessoa);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// Action responsável por exibir a tela de edição do currículo correspondente
        /// </summary>
        public IActionResult Edit(int id)
        {
            try
            {
                ViewBag.Operacao = "A";
                PessoaDAO p_dao = new PessoaDAO();
                ExperienciaDAO e_dao = new ExperienciaDAO();
                FormacaoDAO f_dao = new FormacaoDAO();
                IdiomaDAO i_dao = new IdiomaDAO();

                PessoaViewModel pessoa = p_dao.Consulta(id);

                if (pessoa != null)
                {
                    pessoa.experiencia_profissional = new List<ExperienciaViewModel>();
                    pessoa.formacao_academica = new List<FormacaoViewModel>();
                    pessoa.idioma = new List<IdiomaViewModel>();

                    var listaExperiencia = e_dao.Listagem(id);
                    var listaFormacao = f_dao.Listagem(id);
                    var listaIdioma = i_dao.Listagem(id);

                    if (listaExperiencia != null) foreach (var item in listaExperiencia)
                    {
                            pessoa.experiencia_profissional.Add(item);
                    }
                    if (listaFormacao != null) foreach (var item in listaFormacao)
                    {
                            pessoa.formacao_academica.Add(item);
                    }
                    if (listaIdioma != null) foreach (var item in listaIdioma)
                    {
                            pessoa.idioma.Add(item);
                    }
                }

                if (pessoa == null)
                    return RedirectToAction("index");
                else
                    return View("Form", pessoa);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// Action responsável por inserir/alterar os Dados Pessoais
        /// </summary>
        public IActionResult Salvar(PessoaViewModel pessoa,
                                    string Operacao)
        {
            try
            {
                PessoaDAO dao = new PessoaDAO();
                if (Operacao == "I")
                    dao.Inserir(pessoa);
                else
                    dao.Alterar(pessoa);

                return Redirect("/Curriculo/Edit?id=" + pessoa.id);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// Action responsável por deletar todos os dados do currículo e das tabelas associadas dessa pessoa em questão
        /// </summary>
        public IActionResult Delete(int id)
        {
            try
            {
                PessoaDAO p_dao = new PessoaDAO();
                ExperienciaDAO e_dao = new ExperienciaDAO();
                FormacaoDAO f_dao = new FormacaoDAO();
                IdiomaDAO i_dao = new IdiomaDAO();

                e_dao.ExcluirPessoa(id);
                f_dao.ExcluirPessoa(id);
                i_dao.ExcluirPessoa(id);
                p_dao.Excluir(id);

                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
        #endregion

        #region Métodos - Formação Academica
        /// <summary>
        /// Action responsável por exibir o Pop-Up (Modal) de nova formação academica
        /// </summary>
        public IActionResult CreateFormacao(int id)
        {
            try
            {
                ViewBag.Operacao = "I";
                FormacaoViewModel formacao = new FormacaoViewModel();
                formacao.id_dados_pessoais = id;

                if (formacao.data_conclusao == null || formacao.data_conclusao == Convert.ToDateTime("0001-01-01"))
                    formacao.data_conclusao = DateTime.Now;

                return PartialView("_FormacaoAcademica", formacao);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// Action responsável por exibir o Pop-Up (Modal) para a edição de uma formação academica existente
        /// </summary>
        public IActionResult EditFormacao(int id)
        {
            try
            {
                ViewBag.Operacao = "A";
                FormacaoDAO dao = new FormacaoDAO();
                FormacaoViewModel formacao = dao.Consulta(id);

                if (formacao.data_conclusao == null || formacao.data_conclusao == Convert.ToDateTime("0001-01-01"))
                    formacao.data_conclusao = DateTime.Now;

                if (formacao == null)
                    return RedirectToAction("Form");
                else
                    return PartialView("_FormacaoAcademica", formacao);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// Action responsável por inserir/alterar a formação academica associada ao curriculo em questão
        /// </summary>
        public IActionResult SalvarFormacao(FormacaoViewModel formacao,
                            string Operacao)
        {
            try
            {
                FormacaoDAO dao = new FormacaoDAO();
                if (Operacao == "I")
                    dao.Inserir(formacao);
                else
                    dao.Alterar(formacao);

                return Redirect("/Curriculo/Edit?id=" + formacao.id_dados_pessoais);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// Action responsável por deletar a formação academica selecionada
        /// </summary>
        public IActionResult DeleteFormacao(int id)
        {
            try
            {
                FormacaoDAO dao = new FormacaoDAO();
                FormacaoViewModel formacao = new FormacaoViewModel();
                formacao = dao.Consulta(id);

                dao.Excluir(id);

                return Redirect("/Curriculo/Edit?id=" + formacao.id_dados_pessoais);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
        #endregion

        #region Métodos - Experiencia Profissional
        /// <summary>
        /// Action responsável por exibir o Pop-Up (Modal) de nova experiencia profissional
        /// </summary>
        public IActionResult CreateExperiencia(int id)
        {
            try
            {
                ViewBag.Operacao = "I";
                ExperienciaViewModel experiencia = new ExperienciaViewModel();
                experiencia.id_dados_pessoais = id;

                if (experiencia.data_inicio == null || experiencia.data_inicio == Convert.ToDateTime("0001-01-01"))
                    experiencia.data_inicio = DateTime.Now;
                if (experiencia.data_fim == null || experiencia.data_fim == Convert.ToDateTime("0001-01-01"))
                    experiencia.data_fim = DateTime.Now;

                return PartialView("_ExperienciaProfissional", experiencia);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// Action responsável por exibir o Pop-Up (Modal) para a edição de uma experiencia profissional existente
        /// </summary>
        public IActionResult EditExperiencia(int id)
        {
            try
            {
                ViewBag.Operacao = "A";
                ExperienciaDAO dao = new ExperienciaDAO();
                ExperienciaViewModel experiencia = dao.Consulta(id);

                if (experiencia.data_inicio == null || experiencia.data_inicio == Convert.ToDateTime("0001-01-01"))
                    experiencia.data_inicio = DateTime.Now;
                if (experiencia.data_fim == null || experiencia.data_fim == Convert.ToDateTime("0001-01-01"))
                    experiencia.data_fim = DateTime.Now;

                if (experiencia == null)
                    return RedirectToAction("index");
                else
                    return PartialView("_ExperienciaProfissional", experiencia);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// Action responsável por inserir/alterar a experiencia profissional associada ao curriculo em questão
        /// </summary>
        public IActionResult SalvarExperiencia(ExperienciaViewModel experiencia,
                    string Operacao)
        {
            try
            {
                ExperienciaDAO dao = new ExperienciaDAO();
                if (Operacao == "I")
                    dao.Inserir(experiencia);
                else
                    dao.Alterar(experiencia);

                return Redirect("/Curriculo/Edit?id=" + experiencia.id_dados_pessoais);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// Action responsável por deletar a experiencia profissional selecionada
        /// </summary>
        public IActionResult DeleteExperiencia(int id)
        {
            try
            {
                ExperienciaDAO dao = new ExperienciaDAO();
                ExperienciaViewModel experiencia = new ExperienciaViewModel();
                experiencia = dao.Consulta(id);

                dao.Excluir(id);

                return Redirect("/Curriculo/Edit?id=" + experiencia.id_dados_pessoais);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
        #endregion

        #region Métodos - Idioma
        /// <summary>
        /// Action responsável por exibir o Pop-Up (Modal) de novo idioma
        /// </summary>
        public IActionResult CreateIdioma(int id)
        {
            try
            {
                ViewBag.Operacao = "I";
                IdiomaViewModel idioma = new IdiomaViewModel();
                idioma.id_dados_pessoais = id;

                return PartialView("_Idioma", idioma);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// Action responsável por exibir o Pop-Up (Modal) para a edição de um idioma existente
        /// </summary>
        public IActionResult EditIdioma(int id)
        {
            try
            {
                ViewBag.Operacao = "A";
                IdiomaDAO dao = new IdiomaDAO();
                IdiomaViewModel experiencia = dao.Consulta(id);

                if (experiencia == null)
                    return RedirectToAction("index");
                else
                    return PartialView("_Idioma", experiencia);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// Action responsável por inserir/alterar o idioma associado ao curriculo em questão
        /// </summary>
        public IActionResult SalvarIdioma(IdiomaViewModel idioma,
                    string Operacao)
        {
            try
            {
                IdiomaDAO dao = new IdiomaDAO();

                if (Operacao == "I")
                    dao.Inserir(idioma);
                else
                    dao.Alterar(idioma);

                return Redirect("/Curriculo/Edit?id=" + idioma.id_dados_pessoais);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        /// <summary>
        /// Action responsável por deletar o idioma selecionado
        /// </summary>
        public IActionResult DeleteIdioma(int id)
        {
            try
            {
                IdiomaDAO dao = new IdiomaDAO();
                IdiomaViewModel idioma = new IdiomaViewModel();
                idioma = dao.Consulta(id);

                dao.Excluir(id);

                return Redirect("/Curriculo/Edit?id=" + idioma.id_dados_pessoais);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
        #endregion
    }
}