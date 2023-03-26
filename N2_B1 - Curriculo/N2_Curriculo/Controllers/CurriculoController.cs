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

        #region Métodos Pessoa
        public IActionResult Create()
        {
            try
            {
                ViewBag.Operacao = "I";
                PessoaViewModel pessoa = new PessoaViewModel();

                return View("Form", pessoa);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

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
                pessoa.experiencia_profissional = new List<ExperienciaViewModel>();
                pessoa.formacao_academica = new List<FormacaoViewModel>();
                pessoa.idioma = new List<IdiomaViewModel>();

                var listaExperiencia = e_dao.Listagem(id);
                var listaFormacao = f_dao.Listagem(id);
                var listaIdioma = i_dao.Listagem(id);

                if (listaExperiencia != null) foreach (var item in listaExperiencia) {
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

                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                PessoaDAO dao = new PessoaDAO();
                dao.Excluir(id);

                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
        #endregion

        #region Métodos Formação
        public IActionResult CreateFormacao()
        {
            try
            {
                ViewBag.Operacao = "I";
                FormacaoViewModel formacao = new FormacaoViewModel();

                return PartialView("_FormacaoAcademica", formacao);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult EditFormacao(int id)
        {
            try
            {
                ViewBag.Operacao = "A";
                FormacaoDAO dao = new FormacaoDAO();
                FormacaoViewModel formacao = dao.Consulta(id);

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

                return RedirectToAction("Form");
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult DeleteFormacao(int id)
        {
            try
            {
                FormacaoDAO dao = new FormacaoDAO();
                dao.Excluir(id);

                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
        #endregion

        #region Métodos Experiencia
        public IActionResult CreateExperiencia()
        {
            try
            {
                ViewBag.Operacao = "I";
                ExperienciaViewModel experiencia = new ExperienciaViewModel();

                return PartialView("_ExperienciaProfissional", experiencia);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult EditExperiencia(int id)
        {
            try
            {
                ViewBag.Operacao = "A";
                ExperienciaDAO dao = new ExperienciaDAO();
                ExperienciaViewModel experiencia = dao.Consulta(id);

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

                return RedirectToAction("Form");
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult DeleteExperiencia(int id)
        {
            try
            {
                ExperienciaDAO dao = new ExperienciaDAO();
                dao.Excluir(id);

                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
        #endregion

        #region Métodos Idioma
        public IActionResult CreateIdioma()
        {
            try
            {
                ViewBag.Operacao = "I";
                IdiomaViewModel idioma = new IdiomaViewModel();

                return PartialView("_Idioma", idioma);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

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

                return RedirectToAction("Form");
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult DeleteIdioma(int id)
        {
            try
            {
                IdiomaDAO dao = new IdiomaDAO();
                dao.Excluir(id);

                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
        #endregion
    }
}