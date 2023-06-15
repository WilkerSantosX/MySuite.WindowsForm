using AcessoBancoDados.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        //Cria a conexão
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.StringConexao);
        }

        //Parâmetros que vão para o banco  
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        //Persistência - Inserir, Alterar, Excluir
        public object Executar(CommandType commandType, string nomeStoredProcedureOuTextoSQL)
        {
            try
            {
                //Criar a conexão
                SqlConnection sqlConnection = CriarConexao();

                //Abrir a conexão
                sqlConnection.Open();

                //Criar o comando que vai até o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                //Colocando as coisas dentro do comando (dentro da caixa que vai trafegar na conexão)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSQL;
                sqlCommand.CommandTimeout = 6000; //Em segundos 10 min

                //Adicionando os pârametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Executar o comando, ou seja, mandar o comando para o banco
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //Consultar registros do banco de dados
        public DataTable Obter(CommandType commandType, string nomeStoredProcedureOuTextoSQL)
        {
            try
            {
                //Criar a conexão
                SqlConnection sqlConnection = CriarConexao();

                //Abrir a conexão
                sqlConnection.Open();

                //Criar o comando que vai até o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                //Colocando as coisas dentro do comando (dentro da caixa que vai trafegar na conexão)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSQL;
                sqlCommand.CommandTimeout = 6000; //Em segundos 10 min

                //Adicionando os pârametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Criar um adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //DataTable = tabela de dados vazias onde vou colocar os dados que vem do banco
                DataTable dataTable = new DataTable();

                //Mandar o comando ir até o banco buscar os dados e preencher o dataTable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
