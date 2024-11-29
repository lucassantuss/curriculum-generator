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
        /// <summary>
        /// Método que recebe os dados de IdiomaViewModel e retorna um SqlParameter desses campos
        /// </summary>
        private SqlParameter[] CriaParametros(IdiomaViewModel idioma)
        {
            SqlParameter[] p = new SqlParameter[4];
            p[0] = new SqlParameter("id", idioma.id);
            p[1] = new SqlParameter("id_dados_pessoais", idioma.id_dados_pessoais);
            p[2] = new SqlParameter("idioma", idioma.idioma);
            p[3] = new SqlParameter("nivel", idioma.nivel);

            return p;
        }

        /// <summary>
        /// Query utilizada para inserir um novo idioma
        /// </summary>
        public void Inserir(IdiomaViewModel idioma)
        {
            string sql =
            "insert into idiomas " +
            "values (@id_dados_pessoais, @idioma, " +
            "@nivel)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(idioma));
        }

        /// <summary>
        /// Query utilizada para alterar um idioma existente
        /// </summary>
        public void Alterar(IdiomaViewModel idioma)
        {
            string sql =
            "update idiomas set idioma = @idioma, nivel = @nivel " +
            "where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(idioma));
        }

        /// <summary>
        /// Query utilizada para excluir um idioma existente baseado no Id do Idioma
        /// </summary>
        public void Excluir(int id)
        {
            string sql = "delete idiomas where id = " + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        /// <summary>
        /// Query utilizada para excluir todos os idiomas relacionados ao Id de uma determinada pessoa
        /// </summary>
        public void ExcluirPessoa(int id)
        {
            string sql = "delete idiomas where id_dados_pessoais = " + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        /// <summary>
        /// Query utilizada para consultar os dados de um idioma existente
        /// </summary>
        public IdiomaViewModel Consulta(int id)
        {
            string sql = "select * from idiomas where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaIdioma(tabela.Rows[0]);
        }

        /// <summary>
        /// Query utilizada para consultar todos os idiomas relacionados ao Id de uma determinada pessoa
        /// </summary>
        public IdiomaViewModel ConsultaPessoa(int id)
        {
            string sql = "select * from idiomas where id_dados_pessoais = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaIdioma(tabela.Rows[0]);
        }

        /// <summary>
        /// Método responsável por converter os dados de DataRow em IdiomaViewModel
        /// </summary>
        private IdiomaViewModel MontaIdioma(DataRow registro)
        {
            IdiomaViewModel i = new IdiomaViewModel();
            i.id = Convert.ToInt32(registro["id"]);
            i.id_dados_pessoais = Convert.ToInt32(registro["id_dados_pessoais"]);
            i.idioma = registro["idioma"].ToString();
            i.nivel = registro["nivel"].ToString();

            return i;
        }

        /// <summary>
        /// Query utilizada para listar todos os idiomas relacionados ao Id de uma determinada pessoa em um List<IdiomaViewModel>
        /// </summary>
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