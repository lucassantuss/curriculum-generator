using System;
using System.Data;
using System.Data.SqlClient;
using N2_Curriculo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N2_Curriculo.DAO
{
    public class IdiomaDAO
    {
        private SqlParameter[] CriaParametros(IdiomaViewModel idioma)
        {
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("id", idioma.id);
            p[1] = new SqlParameter("id_dados_pessoais", idioma.id_dados_pessoais);
            p[2] = new SqlParameter("idioma", idioma.idioma);
            p[3] = new SqlParameter("nivel", idioma.nivel);

            return p;
        }

        public void Inserir(IdiomaViewModel idioma)
        {
            string sql =
            "insert into idiomas " +
            "values (@id_dados_pessoais, @idioma, " +
            "@nivel)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(idioma));
        }

        public void Alterar(IdiomaViewModel idioma)
        {
            string sql =
            "update idiomas set idioma = @idioma, nivel = @nivel " +
            "where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(idioma));
        }

        public void Excluir(int id)
        {
            string sql = "delete idiomas where id = " + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        public void ExcluirPessoa(int id)
        {
            string sql = "delete idiomas where id_dados_pessoais = " + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        public IdiomaViewModel Consulta(int id)
        {
            string sql = "select * from idiomas where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaIdioma(tabela.Rows[0]);
        }

        public IdiomaViewModel ConsultaPessoa(int id)
        {
            string sql = "select * from idiomas where id_dados_pessoais = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaIdioma(tabela.Rows[0]);
        }

        private IdiomaViewModel MontaIdioma(DataRow registro)
        {
            IdiomaViewModel i = new IdiomaViewModel();
            i.id = Convert.ToInt32(registro["id"]);
            i.id_dados_pessoais = Convert.ToInt32(registro["id_dados_pessoais"]);
            i.idioma = registro["idioma"].ToString();
            i.nivel = registro["nivel"].ToString();

            return i;
        }

        public List<IdiomaViewModel> Listagem(int id)
        {
            List<IdiomaViewModel> lista = new List<IdiomaViewModel>();
            string sql = "select * from idiomas where id_dados_pessoais = " + id + " order by id";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaIdioma(registro));

            return lista;
        }
    }
}