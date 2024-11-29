using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace N2_Curriculo.DAO
{
    internal static class HelperDAO
    {
        /// <summary>
        /// Executa a query SQL no banco de dados, usando os parametros e a instrução passada
        /// </summary>
        public static void ExecutaSQL(
                    string sql,
                    SqlParameter[] parametros)
        {
            using (var conexao = ConexaoBD.GetConexao())
            {
                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Executa a query SQL no banco de dados, e retorna os dados filtrados numa DataTable
        /// </summary>
        public static DataTable ExecutaSelect(string sql,
                                              SqlParameter[] parametros)
        {
            using (var cx = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, cx))
                {
                    DataTable tabela = new DataTable();
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);
                    adapter.Fill(tabela);
                    return tabela;
                }
            }
        }
    }
}