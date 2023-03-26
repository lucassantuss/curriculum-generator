using System;
using System.Data;
using System.Data.SqlClient;
using N2_Curriculo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N2_Curriculo.DAO
{
    public class ExperienciaDAO
    {
        private SqlParameter[] CriaParametros(ExperienciaViewModel experiencia)
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("id", experiencia.id);
            p[1] = new SqlParameter("id_dados_pessoais", experiencia.id_dados_pessoais);
            p[2] = new SqlParameter("empresa", experiencia.empresa);
            p[3] = new SqlParameter("cargo", experiencia.cargo);
            p[4] = new SqlParameter("data_inicio", experiencia.data_inicio);
            p[5] = new SqlParameter("data_fim", experiencia.data_fim);

            return p;
        }

        public void Inserir(ExperienciaViewModel experiencia)
        {
            string sql =
            "insert into experiencia_profissional " +
            "values (@id_dados_pessoais, @empresa, @cargo, " +
            "@data_inicio, @data_fim)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(experiencia));
        }

        public void Alterar(ExperienciaViewModel experiencia)
        {
            string sql =
            "update experiencia_profissional set empresa = @empresa, cargo = @cargo, " +
            "data_inicio = @data_inicio, data_fim = @data_fim " +
            "where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(experiencia));
        }

        public void Excluir(int id)
        {
            string sql = "delete experiencia_profissional where id = " + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        public ExperienciaViewModel Consulta(int id)
        {
            string sql = "select * from experiencia_profissional where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaExperiencia(tabela.Rows[0]);
        }

        public ExperienciaViewModel ConsultaPessoa(int id)
        {
            string sql = "select * from experiencia_profissional where id_dados_pessoais = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaExperiencia(tabela.Rows[0]);
        }

        private ExperienciaViewModel MontaExperiencia(DataRow registro)
        {
            ExperienciaViewModel e = new ExperienciaViewModel();
            e.id = Convert.ToInt32(registro["id"]);
            e.id_dados_pessoais = Convert.ToInt32(registro["id_dados_pessoais"]);
            e.empresa = registro["empresa"].ToString();
            e.cargo = registro["cargo"].ToString();
            e.data_inicio = Convert.ToDateTime(registro["data_inicio"]);
            //e.data_fim = Convert.ToDateTime(registro["data_fim"]);

            return e;
        }

        public List<ExperienciaViewModel> Listagem(int id)
        {
            List<ExperienciaViewModel> lista = new List<ExperienciaViewModel>();
            string sql = "select * from experiencia_profissional where id_dados_pessoais = " + id + " order by id";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaExperiencia(registro));

            return lista;
        }
    }
}