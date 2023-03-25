using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace N2_Curriculo.DAO
{
    public class PessoaDAO
    {
        private SqlParameter[] CriaParametros(JogoViewModel jogo)
        {
            SqlParameter[] p = new SqlParameter[5];
            p[0] = new SqlParameter("id", jogo.id);
            p[1] = new SqlParameter("descricao", jogo.descricao);
            p[2] = new SqlParameter("valor_locacao", jogo.valor_locacao);
            p[3] = new SqlParameter("data_aquisicao", jogo.data_aquisicao);
            p[4] = new SqlParameter(nameof(jogo.categoriaID), jogo.categoriaID);
            return p;
        }

        public void Inserir(JogoViewModel jogo)
        {
            string sql =
            "insert into jogos(id, descricao, valor_locacao, " +
            "data_aquisicao, categoriaID)" +
            "values (@id , @descricao, @valor_locacao, " +
            "@data_aquisicao, @categoriaID )";
            HelperDAO.ExecutaSQL(sql, CriaParametros(jogo));
        }

        public void Alterar(JogoViewModel jogo)
        {
            string sql =
            "update jogos set descricao = @descricao, valor_locacao = @valor_locacao, " +
            "data_aquisicao=@data_aquisicao, categoriaID = @categoriaID " +
            "where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(jogo));
        }

        public void Excluir(int id)
        {
            string sql = "delete jogos where id = " + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        public JogoViewModel Consulta(int id)
        {
            string sql = "select * from jogos where id =" + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaJogo(tabela.Rows[0]);
        }

        private JogoViewModel MontaJogo(DataRow registro)
        {
            JogoViewModel j = new JogoViewModel();
            j.id = Convert.ToInt32(registro["id"]);
            j.categoriaID = Convert.ToInt32(registro["categoriaID"]);
            j.valor_locacao = Convert.ToDouble(registro["valor_locacao"]);
            j.descricao = registro["descricao"].ToString();
            j.data_aquisicao = Convert.ToDateTime(registro["data_aquisicao"]);
            return j;
        }

        public List<JogoViewModel> Listagem()
        {
            List<JogoViewModel> lista = new List<JogoViewModel>();
            string sql = "select * from jogos order by descricao";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaJogo(registro));
            return lista;
        }
    }
}