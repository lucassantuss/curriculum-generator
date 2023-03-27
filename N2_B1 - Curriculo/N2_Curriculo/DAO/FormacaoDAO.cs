using System;
using System.Data;
using System.Data.SqlClient;
using N2_Curriculo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N2_Curriculo.DAO
{
    public class FormacaoDAO
    {
        private SqlParameter[] CriaParametros(FormacaoViewModel formacao)
        {
            SqlParameter[] p = new SqlParameter[6];
            p[0] = new SqlParameter("id", formacao.id);
            p[1] = new SqlParameter("id_dados_pessoais", formacao.id_dados_pessoais);
            p[2] = new SqlParameter("instituicao", formacao.instituicao);
            p[3] = new SqlParameter("curso", formacao.curso);
            p[4] = new SqlParameter("situacao", formacao.situacao);
            p[5] = new SqlParameter("data_conclusao", formacao.data_conclusao);

            return p;
        }

        public void Inserir(FormacaoViewModel formacao)
        {
            string sql =
            "insert into formacao_academica " +
            "values (@id_dados_pessoais, @instituicao, @curso, " +
            "@situacao, @data_conclusao)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(formacao));
        }

        public void Alterar(FormacaoViewModel formacao)
        {
            string sql =
            "update formacao_academica set instituicao = @instituicao, curso = @curso, " +
            "situacao = @situacao, data_conclusao = @data_conclusao " +
            "where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(formacao));
        }

        public void Excluir(int id)
        {
            string sql = "delete formacao_academica where id = " + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        public void ExcluirPessoa(int id)
        {
            string sql = "delete formacao_academica where id_dados_pessoais = " + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        public FormacaoViewModel Consulta(int id)
        {
            string sql = "select * from formacao_academica where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaFormacao(tabela.Rows[0]);
        }

        public FormacaoViewModel ConsultaPessoa(int id)
        {
            string sql = "select * from formacao_academica where id_dados_pessoais = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaFormacao(tabela.Rows[0]);
        }

        private FormacaoViewModel MontaFormacao(DataRow registro)
        {
            FormacaoViewModel f = new FormacaoViewModel();
            f.id = Convert.ToInt32(registro["id"]);
            f.id_dados_pessoais = Convert.ToInt32(registro["id_dados_pessoais"]);
            f.instituicao = registro["instituicao"].ToString();
            f.curso = registro["curso"].ToString();
            f.situacao = registro["situacao"].ToString();
            f.data_conclusao = Convert.ToDateTime(registro["data_conclusao"]);

            return f;
        }

        public List<FormacaoViewModel> Listagem(int id)
        {
            List<FormacaoViewModel> lista = new List<FormacaoViewModel>();
            string sql = "select * from formacao_academica where id_dados_pessoais = " + id + " order by id";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaFormacao(registro));

            return lista;
        }
    }
}