using AcessoBancoDados;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpdeskService
{
    public class HelpdeskNegocio
    {
        #region Conexão

        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        #endregion

        #region Validação Geral

        /// <summary>
        /// Esse método verifica o login
        /// </summary>
        /// <returns>Usuario</returns>
        public Usuario VerificaLogin(Usuario usuario)
        {
            acessoDadosSqlServer.LimparParametros();

            Usuario UserConectado = new Usuario();

            string user = "'" + usuario.Login + "'";
            string pass = "'" + usuario.Senha + "'";

            DataTable dataTableUsuario = acessoDadosSqlServer.Obter(
                CommandType.Text, "SELECT CodUsuario, Nome, Email, Usuario, Senha, CodPerfil, CodSetor, QtdAcesso, DhAcesso FROM Usuario WHERE Usuario = " + user + "AND Senha = " + pass + "AND Ativo = 1");

            //Percorrer o Datable e transformar em coleção de Cliente
            foreach (DataRow rows in dataTableUsuario.Rows)
            {
                UserConectado.CodUsuario = Convert.ToInt32(rows["CodUsuario"]);
                UserConectado.Nome = Convert.ToString(rows["Nome"]);
                UserConectado.Email = Convert.ToString(rows["Email"]);
                UserConectado.Login = Convert.ToString(rows["Usuario"]);
                UserConectado.Senha = Convert.ToString(rows["Senha"]);
                UserConectado.CodPerfil = Convert.ToInt32(rows["CodPerfil"]);
                UserConectado.CodSetor = Convert.ToInt32(rows["CodSetor"]);
                if (rows["QtdAcesso"] != DBNull.Value)
                    UserConectado.QtdAcesso = Convert.ToInt32(rows["QtdAcesso"]);
                if (rows["DhAcesso"] != DBNull.Value)
                    UserConectado.DhAcesso = Convert.ToDateTime(rows["DhAcesso"]);
            }

            DateTime? dataNovoAcesso = null;

            if (UserConectado.CodUsuario > 0)
            {
                acessoDadosSqlServer.LimparParametros();

                int contador = UserConectado.QtdAcesso + 1;
                dataNovoAcesso = DateTime.Now;

                acessoDadosSqlServer.AdicionarParametros("@CodUsuario", UserConectado.CodUsuario);
                acessoDadosSqlServer.AdicionarParametros("@QtdAcesso", contador);
                acessoDadosSqlServer.AdicionarParametros("@DhAcesso", dataNovoAcesso);

                acessoDadosSqlServer.Executar(
                CommandType.Text,
                "UPDATE Usuario SET QtdAcesso = @QtdAcesso, DhAcesso = @DhAcesso WHERE CodUsuario = @CodUsuario");

            }

            UserConectado.QtdAcesso += 1;
            UserConectado.DhAcesso = dataNovoAcesso;

            return UserConectado;
        }

        public UFCollection ObterUF()
        {
            acessoDadosSqlServer.LimparParametros();

            UFCollection listaUF = new UFCollection();

            DataTable dataTableUF = acessoDadosSqlServer.Obter(
                CommandType.Text, "SELECT CodUF, NomeUF, Sigla FROM UF");

            //Percorrer o Datable e transformar em coleção de Cliente
            foreach (DataRow rows in dataTableUF.Rows)
            {
                UF uf = new UF();

                uf.CodUF = Convert.ToInt32(rows["CodUF"]);
                uf.NomeUF = Convert.ToString(rows["NomeUF"]);
                uf.Sigla = Convert.ToString(rows["Sigla"]);

                listaUF.Add(uf);
            }

            return listaUF;
        }

        public CidadeUFCollection CidadesObterTodosPorUF(string uf)
        {
            acessoDadosSqlServer.LimparParametros();

            CidadeUFCollection listaCidade = new CidadeUFCollection();

            DataTable dataTableCidade = acessoDadosSqlServer.Obter(
                CommandType.Text, "SELECT CI.CodCidade, CI.NomeCidade, UF.NomeUF FROM Cidade CI (NOLOCK) INNER JOIN UF (NOLOCK) ON CI.CodUF = UF.CodUF WHERE UF.Sigla = '" + uf + "' ORDER BY 2");

            //Percorrer o Datable e transformar em coleção de Cliente
            foreach (DataRow rows in dataTableCidade.Rows)
            {
                CidadeUF cidade = new CidadeUF();
                cidade.CodCidade = Convert.ToInt32(rows["CodCidade"]);
                cidade.NomeCidade = Convert.ToString(rows["NomeCidade"]);
                cidade.NomeUF = Convert.ToString(rows["NomeUF"]);

                listaCidade.Add(cidade);
            }

            return listaCidade;
        }

        public CidadeUF CidadeObterPorID(int codCidade)
        {
            acessoDadosSqlServer.LimparParametros();

            CidadeUF cidade = new CidadeUF();

            acessoDadosSqlServer.AdicionarParametros("@CodCidade", codCidade);

            DataTable dataTableCidade = acessoDadosSqlServer.Obter(
               CommandType.Text, "SELECT CID.CodCidade, CID.NomeCidade, UF.NomeUF, UF.Sigla FROM Cidade CID INNER JOIN UF ON UF.CodUF = CID.CodUF WHERE CodCidade = @CodCidade");

            foreach (DataRow rows in dataTableCidade.Rows)
            {
                cidade.CodCidade = Convert.ToInt32(rows["CodCidade"]);
                cidade.NomeCidade = Convert.ToString(rows["NomeCidade"]);
                cidade.NomeUF = Convert.ToString(rows["NomeUF"]);
                cidade.Sigla = Convert.ToString(rows["Sigla"]);
            }

            return cidade;
        }

        public int CidadeObterPorNomeEstado(string cidade, string uf)
        {
            acessoDadosSqlServer.LimparParametros();

            CidadeUF cidadeUF = new CidadeUF();

            DataTable dataTableCidade = acessoDadosSqlServer.Obter(
               CommandType.Text, "SELECT CID.CodCidade, CID.NomeCidade, UF.NomeUF, UF.Sigla FROM Cidade CID INNER JOIN UF ON UF.CodUF = CID.CodUF WHERE CID.NomeCidade = '" + cidade + "'" + " AND UF.Sigla ='" + uf + "'");

            foreach (DataRow rows in dataTableCidade.Rows)
            {
                cidadeUF.CodCidade = Convert.ToInt32(rows["CodCidade"]);
                cidadeUF.NomeCidade = Convert.ToString(rows["NomeCidade"]);
                cidadeUF.NomeUF = Convert.ToString(rows["NomeUF"]);
                cidadeUF.Sigla = Convert.ToString(rows["Sigla"]);
            }

            return cidadeUF.CodCidade;
        }

        public ProdutoCollection ProdutoObterTodos()
        {
            acessoDadosSqlServer.LimparParametros();

            ProdutoCollection produtoCollection = new ProdutoCollection();

            DataTable dataTableCategoria = acessoDadosSqlServer.Obter(
               CommandType.Text, "SELECT CodProduto, NomeProduto, Ativo FROM Produto WHERE Ativo = 1");

            foreach (DataRow rows in dataTableCategoria.Rows)
            {
                Produto produto = new Produto();

                produto.CodProduto = Convert.ToInt32(rows["CodProduto"]);
                produto.NomeProduto = Convert.ToString(rows["NomeProduto"]);
                produto.Ativo = Convert.ToBoolean(rows["Ativo"]);

                produtoCollection.Add(produto);
            }

            return produtoCollection;
        }

        public ProdutoCollection ProdutoObterInativos()
        {
            acessoDadosSqlServer.LimparParametros();

            ProdutoCollection produtoCollection = new ProdutoCollection();

            DataTable dataTableCategoria = acessoDadosSqlServer.Obter(
               CommandType.Text, "SELECT CodProduto, NomeProduto, Ativo FROM Produto WHERE Ativo = 0");

            foreach (DataRow rows in dataTableCategoria.Rows)
            {
                Produto produto = new Produto();

                produto.CodProduto = Convert.ToInt32(rows["CodProduto"]);
                produto.NomeProduto = Convert.ToString(rows["NomeProduto"]);
                produto.Ativo = Convert.ToBoolean(rows["Ativo"]);

                produtoCollection.Add(produto);
            }

            return produtoCollection;
        }

        public Produto ProdutoObterPorNome(string nomeCategoria)
        {
            acessoDadosSqlServer.LimparParametros();

            Produto produto = new Produto();

            acessoDadosSqlServer.AdicionarParametros("@NomeCategoria", nomeCategoria);

            DataTable dataTableCategoria = acessoDadosSqlServer.Obter(
               CommandType.Text, "SELECT CodProduto, NomeProduto, Ativo FROM Produto WHERE NomeProduto='" + nomeCategoria + "'");

            foreach (DataRow rows in dataTableCategoria.Rows)
            {
                produto.CodProduto = Convert.ToInt32(rows["CodProduto"]);
                produto.NomeProduto = Convert.ToString(rows["NomeProduto"]);
                produto.Ativo = Convert.ToBoolean(rows["Ativo"]);
            }

            return produto;
        }

        #endregion

        #region Ordem Servico

        /// <summary>
        /// Esse método Lista todas as Ordens de Serviço para o Suporte Nivel 1
        /// </summary>
        /// <returns>OrdemServicoCollection</returns>       
        public DataTable OrdemServicoObterTodos()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                OrdemServicoCollection ordemServicoCollection = new OrdemServicoCollection();

                DataTable dataTableOrdemServico = acessoDadosSqlServer.Obter(
                    CommandType.Text,
                    "SELECT OS.CodOrdemServico,CAT.CodCategoria, CAT.NomeCategoria,CLI.CodCliente, CLI.CPF_CNPJ, OS.Assunto,OS.Descricao,STA.CodStatus, STA.NomeStatus,OS.DhCriacao,OS.CriacaoCodUsuario, US.Nome,OS.DhFinalizada,OS.FinalizadaCodUsuario,OS.DhPrevisaoTermino,OS.DhCancelada,OS.CanceladaCodUsuario,OS.MotivoCancelamento,OS.ObservacaoOperador FROM OrdemServico OS INNER JOIN Categoria CAT ON CAT.CodCategoria = OS.CodCategoria INNER JOIN Cliente CLI ON CLI.CodCliente = OS.CodCliente INNER JOIN Status STA ON STA.CodStatus = OS.CodStatus INNER JOIN Usuario US ON US.CodUsuario = OS.CriacaoCodUsuario WHERE OS.CodStatus = 1");

                return dataTableOrdemServico;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel realizar a operação. Detalhes: " + ex.Message);
            }
        }

        /// <summary>
        /// Esse método Lista todas as Ordens de Serviço para o Suporte Nivel 2
        /// </summary>
        /// <returns>DataTable Ordem Servico</returns>
        public DataTable OrdemServicoObterAbertos()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                OrdemServicoCollection ordemServicoCollection = new OrdemServicoCollection();

                DataTable dataTableOrdemServico = acessoDadosSqlServer.Obter(
                    CommandType.Text,
                    "SELECT OS.CodOrdemServico,CAT.CodCategoria, CAT.NomeCategoria,CLI.CodCliente, CLI.CPF_CNPJ, OS.Assunto,OS.Descricao,STA.CodStatus, STA.NomeStatus,OS.DhCriacao,OS.CriacaoCodUsuario, US.Nome,OS.DhFinalizada,OS.FinalizadaCodUsuario,OS.DhPrevisaoTermino,OS.DhCancelada,OS.CanceladaCodUsuario,OS.MotivoCancelamento,OS.ObservacaoOperador FROM OrdemServico OS INNER JOIN Categoria CAT ON CAT.CodCategoria = OS.CodCategoria INNER JOIN Cliente CLI ON CLI.CodCliente = OS.CodCliente INNER JOIN Status STA ON STA.CodStatus = OS.CodStatus INNER JOIN Usuario US ON US.CodUsuario = OS.CriacaoCodUsuario WHERE OS.CodStatus = 1");

                return dataTableOrdemServico;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel realizar a operação. Detalhes: " + ex.Message);
            }
        }

        /// <summary>
        /// Esse método Lista uma Ordem de Serviço pelo ID para um DataTable
        /// </summary>
        /// <returns>OrdemServico</returns> 
        public DataTable OrdemServicoTableObterPorID(int CodOrdemServico)
        {
            acessoDadosSqlServer.LimparParametros();

            OrdemServico ordemServico = new OrdemServico();

            acessoDadosSqlServer.AdicionarParametros("@CodOrdemServico", CodOrdemServico);

            DataTable dataTableOrdemServico = acessoDadosSqlServer.Obter(
                CommandType.Text, "SELECT OS.CodOrdemServico,CAT.CodCategoria, CAT.NomeCategoria,CLI.CodCliente, CLI.CPF_CNPJ, OS.Assunto,OS.Descricao,STA.CodStatus, STA.NomeStatus,OS.DhCriacao,OS.CriacaoCodUsuario, US.Nome,OS.DhFinalizada,OS.FinalizadaCodUsuario,OS.DhPrevisaoTermino,OS.DhCancelada,OS.CanceladaCodUsuario,OS.MotivoCancelamento,OS.ObservacaoOperador FROM OrdemServico OS INNER JOIN Categoria CAT ON CAT.CodCategoria = OS.CodCategoria INNER JOIN Cliente CLI ON CLI.CodCliente = OS.CodCliente INNER JOIN Status STA ON STA.CodStatus = OS.CodStatus INNER JOIN Usuario US ON US.CodUsuario = OS.CriacaoCodUsuario WHERE CodOrdemServico = @CodOrdemServico");

            //Percorrer o Datable e transformar em coleção de Cliente
            //foreach (DataRow rows in dataTableOrdemServico.Rows)
            //{
            //    ordemServico.CodOrdemServico = Convert.ToInt32(rows["CodOrdemServico"]);
            //    ordemServico.CodCategoria = Convert.ToInt32(rows["CodCategoria"]);
            //    ordemServico.Categoria = Convert.ToString(rows["NomeCategoria"]);
            //    ordemServico.CodCliente = Convert.ToInt32(rows["CodCliente"]);
            //    ordemServico.ClienteCpf = Convert.ToString(rows["CPF_CNPJ"]);
            //    ordemServico.Assunto = Convert.ToString(rows["Assunto"]);
            //    ordemServico.Descricao = Convert.ToString(rows["Descricao"]);
            //    ordemServico.CodStatus = Convert.ToInt32(rows["CodStatus"]);
            //    ordemServico.Status = Convert.ToString(rows["NomeStatus"]);
            //    ordemServico.DhCriacao = Convert.ToDateTime(rows["DhCriacao"]);
            //    ordemServico.CriacaoCodUsuario = Convert.ToInt32(rows["CriacaoCodUsuario"]);
            //    ordemServico.UsuarioSolicitante = Convert.ToString(rows["Nome"]);

            //    if (rows["DhFinalizada"] != DBNull.Value)
            //        ordemServico.DhFinalizada = Convert.ToDateTime(rows["DhFinalizada"]);

            //    if (rows["FinalizadaCodUsuario"] != DBNull.Value)
            //        ordemServico.FinalizadaCodUsuario = Convert.ToInt32(rows["FinalizadaCodUsuario"]);

            //    if (rows["DhPrevisaoTermino"] != DBNull.Value)
            //        ordemServico.DhPrevisaoTermino = Convert.ToDateTime(rows["DhPrevisaoTermino"]);

            //    if (rows["DhCancelada"] != DBNull.Value)
            //        ordemServico.DhCancelada = Convert.ToDateTime(rows["DhCancelada"]);

            //    if (rows["CanceladaCodUsuario"] != DBNull.Value)
            //        ordemServico.CanceladaCodUsuario = Convert.ToInt32(rows["CanceladaCodUsuario"]);

            //    ordemServico.MotivoCancelamento = Convert.ToString(rows["MotivoCancelamento"]);
            //    ordemServico.ObservacaoTecnica = Convert.ToString(rows["ObservacaoTecnica"]);

            //}

            return dataTableOrdemServico;
        }

        /// <summary>
        /// Esse método Lista uma Ordem de Serviço pelo ID para um objeto
        /// </summary>
        /// <returns>OrdemServico</returns> 
        public OrdemServico OrdemServicoObterPorID(int CodOrdemServico)
        {
            acessoDadosSqlServer.LimparParametros();

            OrdemServico ordemServico = new OrdemServico();

            acessoDadosSqlServer.AdicionarParametros("@CodOrdemServico", CodOrdemServico);

            DataTable dataTableOrdemServico = acessoDadosSqlServer.Obter(
                CommandType.Text, "SELECT OS.CodOrdemServico,CAT.CodProduto, CAT.NomeProduto,CLI.CodCliente, CLI.CPF_CNPJ, CLI.Nome, CLI.Telefone, CLI.Email, CLI.Endereco, CLI.Numero, CLI.Bairro, CLI.CodCidade, OS.Assunto,OS.Descricao,STA.CodStatus, STA.NomeStatus,OS.DhCriacao,OS.CriacaoCodUsuario, US.Nome,OS.DhFinalizada,OS.FinalizadaCodUsuario,OS.DhPrevisaoTermino,OS.DhCancelada,OS.CanceladaCodUsuario,OS.MotivoCancelamento,OS.ObservacaoOperador, CID.NomeCidade, UF.Sigla FROM OrdemServico OS INNER JOIN Produto CAT ON CAT.CodProduto = OS.CodProduto INNER JOIN Cliente CLI ON CLI.CodCliente = OS.CodCliente INNER JOIN Status STA ON STA.CodStatus = OS.CodStatus INNER JOIN Usuario US ON US.CodUsuario = OS.CriacaoCodUsuario INNER JOIN Cidade CID ON CID.CodCidade = CLI.CodCidade INNER JOIN UF UF ON UF.CodUF = CID.CodUF WHERE CodOrdemServico = @CodOrdemServico");

            //Percorrer o Datable e transformar em coleção de Cliente
            foreach (DataRow rows in dataTableOrdemServico.Rows)
            {
                ordemServico.CodOrdemServico = Convert.ToInt32(rows["CodOrdemServico"]);
                ordemServico.produto.CodProduto = Convert.ToInt32(rows["CodProduto"]);
                ordemServico.produto.NomeProduto = Convert.ToString(rows["NomeProduto"]);
                ordemServico.cliente.CodCliente = Convert.ToInt32(rows["CodCliente"]);
                ordemServico.cliente.Nome = Convert.ToString(rows["Nome"]);
                ordemServico.cliente.CPF = Convert.ToString(rows["CPF_CNPJ"]);
                ordemServico.cliente.Telefone = Convert.ToString(rows["Telefone"]);
                ordemServico.cliente.Email = Convert.ToString(rows["Email"]);
                ordemServico.cliente.Endereco = Convert.ToString(rows["Endereco"]);
                ordemServico.cliente.Numero = Convert.ToString(rows["Numero"]);
                ordemServico.cliente.Bairro = Convert.ToString(rows["Bairro"]);
                ordemServico.cliente.CodCidade = Convert.ToInt32(rows["CodCidade"]);
                ordemServico.cliente.Cidade = Convert.ToString(rows["NomeCidade"]);
                ordemServico.cliente.UF = Convert.ToString(rows["Sigla"]);
                ordemServico.Assunto = Convert.ToString(rows["Assunto"]);
                ordemServico.Descricao = Convert.ToString(rows["Descricao"]);
                ordemServico.CodStatus = Convert.ToInt32(rows["CodStatus"]);
                ordemServico.Status = Convert.ToString(rows["NomeStatus"]);
                ordemServico.DhCriacao = Convert.ToDateTime(rows["DhCriacao"]);
                ordemServico.CriacaoCodUsuario = Convert.ToInt32(rows["CriacaoCodUsuario"]);
                ordemServico.UsuarioSolicitante = Convert.ToString(rows["Nome"]);

                if (rows["DhFinalizada"] != DBNull.Value)
                    ordemServico.DhFinalizada = Convert.ToDateTime(rows["DhFinalizada"]);

                if (rows["FinalizadaCodUsuario"] != DBNull.Value)
                    ordemServico.FinalizadaCodUsuario = Convert.ToInt32(rows["FinalizadaCodUsuario"]);

                if (rows["DhPrevisaoTermino"] != DBNull.Value)
                    ordemServico.DhPrevisaoTermino = Convert.ToDateTime(rows["DhPrevisaoTermino"]);

                if (rows["DhCancelada"] != DBNull.Value)
                    ordemServico.DhCancelada = Convert.ToDateTime(rows["DhCancelada"]);

                if (rows["CanceladaCodUsuario"] != DBNull.Value)
                    ordemServico.CanceladaCodUsuario = Convert.ToInt32(rows["CanceladaCodUsuario"]);

                ordemServico.MotivoCancelamento = Convert.ToString(rows["MotivoCancelamento"]);
                ordemServico.ObservacaoOperador = Convert.ToString(rows["ObservacaoOperador"]);

            }

            return ordemServico;
        }

        /// <summary>
        /// Esse método Edita uma Ordem de Serviço
        /// </summary>
        /// <returns>String de Sucesso</returns> 
        public string OrdemServicoEditar(OrdemServico ordemServico)
        {
            acessoDadosSqlServer.LimparParametros();

            acessoDadosSqlServer.AdicionarParametros("@CodOrdemServico", ordemServico.CodOrdemServico);
            acessoDadosSqlServer.AdicionarParametros("@CodProduto", ordemServico.produto.CodProduto);
            acessoDadosSqlServer.AdicionarParametros("@CodCliente", ordemServico.cliente.CodCliente);
            acessoDadosSqlServer.AdicionarParametros("@Assunto", ordemServico.Assunto);
            acessoDadosSqlServer.AdicionarParametros("@Descricao", ordemServico.Descricao);
            acessoDadosSqlServer.AdicionarParametros("@CodStatus", ordemServico.CodStatus);

            if (ordemServico.DhFinalizada != null)
            {
                acessoDadosSqlServer.AdicionarParametros("@DhFinalizada", ordemServico.DhFinalizada);
                acessoDadosSqlServer.AdicionarParametros("@FinalizadaCodUsuario", ordemServico.FinalizadaCodUsuario);
            }

            acessoDadosSqlServer.AdicionarParametros("@DhPrevisaoTermino", ordemServico.DhPrevisaoTermino);
            acessoDadosSqlServer.AdicionarParametros("@ObservacaoOperador", ordemServico.ObservacaoOperador);

            if (ordemServico.DhFinalizada == null)
            {
                acessoDadosSqlServer.Executar(
                CommandType.Text,
                "UPDATE OrdemServico SET CodProduto = @CodProduto, CodCliente = @CodCliente, Assunto = @Assunto, Descricao = @Descricao, CodStatus = @CodStatus, DhPrevisaoTermino = @DhPrevisaoTermino, ObservacaoOperador = @ObservacaoOperador WHERE CodOrdemServico = @CodOrdemServico");
            }
            else
            {
                acessoDadosSqlServer.Executar(
                CommandType.Text,
                "UPDATE OrdemServico SET CodCategoria = @CodCategoria, CodCliente = @CodCliente, Assunto = @Assunto, Descricao = @Descricao, CodStatus = @CodStatus, DhFinalizada = @DhFinalizada, FinalizadaCodUsuario = @FinalizadaCodUsuario, DhPrevisaoTermino = @DhPrevisaoTermino, ObservacaoOperador = @ObservacaoOperador WHERE CodOrdemServico = @CodOrdemServico");
            }

            return "Ordem de Serviço atualizado com sucesso!";
        }

        /// <summary>
        /// Esse método Cancela uma Ordem de Serviço
        /// </summary>
        /// <returns>String de Sucesso</returns> 
        public string OrdemServicoCancelar(OrdemServico ordemServico)
        {
            acessoDadosSqlServer.LimparParametros();

            acessoDadosSqlServer.AdicionarParametros("@CodOrdemServico", ordemServico.CodOrdemServico);
            acessoDadosSqlServer.AdicionarParametros("@DhCancelada", ordemServico.DhCancelada);
            acessoDadosSqlServer.AdicionarParametros("@CanceladaCodUsuario", ordemServico.CanceladaCodUsuario);
            acessoDadosSqlServer.AdicionarParametros("@MotivoCancelamento", ordemServico.MotivoCancelamento);

            //PASSAR O CODUSUARIO

            acessoDadosSqlServer.Executar(
                CommandType.Text,
                "UPDATE OrdemServico SET CodStatus = 3, DhCancelada = @DhCancelada, MotivoCancelamento = @MotivoCancelamento, CanceladaCodUsuario = @CanceladaCodUsuario WHERE CodOrdemServico = @CodOrdemServico");

            return "Ordem de Serviço Cancelada com Sucesso";
        }

        /// <summary>
        /// Esse método Insere uma Ordem de Serviço
        /// </summary>
        /// <returns>String de Sucesso</returns>
        public string OrdemServicoInserir(OrdemServico ordemServico)
        {
            acessoDadosSqlServer.LimparParametros();

            acessoDadosSqlServer.AdicionarParametros("@CodProduto", ordemServico.produto.CodProduto);
            acessoDadosSqlServer.AdicionarParametros("@CodCliente", ordemServico.cliente.CodCliente);
            acessoDadosSqlServer.AdicionarParametros("@Assunto", ordemServico.Assunto);
            acessoDadosSqlServer.AdicionarParametros("@Descricao", ordemServico.Descricao);
            acessoDadosSqlServer.AdicionarParametros("@CodStatus", ordemServico.CodStatus);
            acessoDadosSqlServer.AdicionarParametros("@DhCriacao", ordemServico.DhCriacao);
            acessoDadosSqlServer.AdicionarParametros("@CriacaoCodUsuario", ordemServico.CriacaoCodUsuario);
            acessoDadosSqlServer.AdicionarParametros("@DhPrevisaoTermino", ordemServico.DhPrevisaoTermino);
            acessoDadosSqlServer.AdicionarParametros("@ObservacaoTecnica", ordemServico.ObservacaoTecnica);

            string codOrdemServico = acessoDadosSqlServer.Executar(
                CommandType.Text,
                "INSERT INTO OrdemServico (CodProduto, CodCliente, Assunto, Descricao, CodStatus, DhCriacao, CriacaoCodUsuario, DhPrevisaoTermino, ObservacaoTecnica) VALUES (@CodProduto, @CodCliente, @Assunto, @Descricao, @CodStatus, @DhCriacao, @CriacaoCodUsuario, @DhPrevisaoTermino, @ObservacaoTecnica) SELECT SCOPE_IDENTITY()").ToString();

            return codOrdemServico;
        }

        /// <summary>
        /// Esse método Finaliza uma Ordem de Serviço
        /// </summary>
        /// <returns>String de Sucesso</returns>
        public string OrdemServicoFinalizar(OrdemServico ordemServico)
        {
            acessoDadosSqlServer.LimparParametros();

            acessoDadosSqlServer.AdicionarParametros("@CodOrdemServico", ordemServico.CodOrdemServico);
            acessoDadosSqlServer.AdicionarParametros("@HouveTrocaProduto", ordemServico.HouveTrocaProduto);
            acessoDadosSqlServer.AdicionarParametros("@ObservacaoTecnica", ordemServico.ObservacaoTecnica);
            acessoDadosSqlServer.AdicionarParametros("@CodStatus", ordemServico.CodStatus);
            acessoDadosSqlServer.AdicionarParametros("@DhFinalizada", ordemServico.DhFinalizada);
            acessoDadosSqlServer.AdicionarParametros("@FinalizadaCodUsuario", ordemServico.FinalizadaCodUsuario);

            acessoDadosSqlServer.Executar(
                CommandType.Text,
                "UPDATE OrdemServico SET HouveTrocaProduto = @HouveTrocaProduto, ObservacaoTecnica = @ObservacaoTecnica , CodStatus = @CodStatus , DhFinalizada = @DhFinalizada, FinalizadaCodUsuario = @FinalizadaCodUsuario WHERE CodOrdemServico = @CodOrdemServico");

            return "Ordem de Serviço finalizada com sucesso!";
        }

        #endregion

        #region Cliente

        /// <summary>
        /// Esse método Insere um cliente na base
        /// </summary>
        /// <returns>String de Sucesso</returns>
        public string ClienteInserir(Cliente cliente)
        {
            acessoDadosSqlServer.LimparParametros();

            acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
            acessoDadosSqlServer.AdicionarParametros("@CPF", cliente.CPF);
            acessoDadosSqlServer.AdicionarParametros("@Telefone", cliente.Telefone);
            acessoDadosSqlServer.AdicionarParametros("@Email", cliente.Email);
            acessoDadosSqlServer.AdicionarParametros("@Endereco", cliente.Endereco);
            acessoDadosSqlServer.AdicionarParametros("@Numero", cliente.Numero);
            acessoDadosSqlServer.AdicionarParametros("@Bairro", cliente.Bairro);
            acessoDadosSqlServer.AdicionarParametros("@CodCidade", cliente.CodCidade);

            acessoDadosSqlServer.Executar(
               CommandType.Text,
               "INSERT INTO Cliente (Nome,CPF_CNPJ,Telefone,Email,Endereco,Numero,Bairro,CodCidade) VALUES (@Nome,@CPF,@Telefone,@Email,@Endereco,@Numero,@Bairro,@CodCidade)");

            return "Cliente cadastrado com sucesso!";
        }

        /// <summary>
        /// Esse método lista todos os clientes em um DataTable
        /// </summary>
        /// <returns>ClienteCollection</returns>   
        public DataTable ClienteDataTableObterTodos()
        {
            acessoDadosSqlServer.LimparParametros();

            DataTable dataTableCliente = acessoDadosSqlServer.Obter(
                    CommandType.Text,
                    "SELECT Nome, CPF_CNPJ CPF, Telefone, Email, Endereco, Numero, Bairro, CID.NomeCidade Cidade, UF.Sigla UF FROM Cliente CLI (NOLOCK) JOIN Cidade CID ON CLI.CodCidade = CID.CodCidade JOIN UF UF ON UF.CodUF = CID.CodUF");

            return dataTableCliente;
        }

        /// <summary>
        /// Esse método Lista um cliente por ID
        /// </summary>
        /// <returns>Cliente</returns> 
        public Cliente ClienteObterPorID(int CodCliente)
        {
            acessoDadosSqlServer.LimparParametros();

            Cliente cliente = new Cliente();

            acessoDadosSqlServer.AdicionarParametros("@CodCliente", CodCliente);

            DataTable dataTableCliente = acessoDadosSqlServer.Obter(
                    CommandType.Text,
                    "SELECT CodCliente, Nome, CPF_CNPJ, Telefone, Email, Endereco, Numero, Bairro, CID.NomeCidade, UF.NomeUF FROM Cliente CLI JOIN Cidade CID ON CID.CodCidade = CLI.CodCidade JOIN UF UF ON UF.CodUF = CID.CodUF WHERE CodCliente = @CodCliente");

            //Percorrer o Datable e transformar em coleção de Cliente
            foreach (DataRow rows in dataTableCliente.Rows)
            {
                cliente.Nome = Convert.ToString(rows["Nome"]);
                cliente.CPF = Convert.ToString(rows["CPF"]);
                cliente.Telefone = Convert.ToString(rows["Telefone"]);
                cliente.Email = Convert.ToString(rows["Email"]);
                cliente.Endereco = Convert.ToString(rows["Endereco"]);
                cliente.Numero = Convert.ToString(rows["Numero"]);
                cliente.Bairro = Convert.ToString(rows["Bairro"]);
                cliente.CodCidade = Convert.ToInt32(rows["CodCidade"]);
                cliente.Cidade = Convert.ToString(rows["NomeCidade"]);
                cliente.UF = Convert.ToString(rows["NomeUF"]);
            }

            return cliente;
        }

        public Cliente ClienteObterPorCPF(string cpf)
        {
            acessoDadosSqlServer.LimparParametros();

            Cliente cliente = new Cliente();

            DataTable dataTableCliente = acessoDadosSqlServer.Obter(
               CommandType.Text, "SELECT CodCliente, Nome, CPF_CNPJ, Telefone, Email, Endereco, Numero, Bairro, CID.CodCidade, CID.NomeCidade, UF.Sigla FROM Cliente CLI JOIN Cidade CID ON CID.CodCidade = CLI.CodCidade JOIN UF UF ON UF.CodUF = CID.CodUF WHERE CPF_CNPJ = '" + cpf + "'");

            foreach (DataRow rows in dataTableCliente.Rows)
            {
                cliente.CodCliente = Convert.ToInt32(rows["CodCliente"]);
                cliente.Nome = Convert.ToString(rows["Nome"]);
                cliente.CPF = Convert.ToString(rows["CPF_CNPJ"]);
                cliente.Telefone = Convert.ToString(rows["Telefone"]);
                cliente.Email = Convert.ToString(rows["Email"]);
                cliente.Endereco = Convert.ToString(rows["Endereco"]);
                cliente.Numero = Convert.ToString(rows["Numero"]);
                cliente.Bairro = Convert.ToString(rows["Bairro"]);
                cliente.CodCidade = Convert.ToInt32(rows["CodCidade"]);
                cliente.Cidade = Convert.ToString(rows["NomeCidade"]);
                cliente.UF = Convert.ToString(rows["Sigla"]);
            }

            return cliente;

        }

        /// <summary>
        /// Esse método Edita um Cliente
        /// </summary>
        /// <returns>String de Sucesso</returns> 
        public string ClienteEditar(OrdemServico ordemServico)
        {
            acessoDadosSqlServer.LimparParametros();

            acessoDadosSqlServer.AdicionarParametros("@CodCliente", ordemServico.cliente.CodCliente);
            acessoDadosSqlServer.AdicionarParametros("@Telefone", ordemServico.cliente.Telefone);
            acessoDadosSqlServer.AdicionarParametros("@Email", ordemServico.cliente.Email);
            acessoDadosSqlServer.AdicionarParametros("@Endereco", ordemServico.cliente.Endereco);
            acessoDadosSqlServer.AdicionarParametros("@Numero", ordemServico.cliente.Numero);
            acessoDadosSqlServer.AdicionarParametros("@Bairro", ordemServico.cliente.Bairro);
            acessoDadosSqlServer.AdicionarParametros("@CodCidade", ordemServico.cliente.CodCidade);

            acessoDadosSqlServer.Executar(
               CommandType.Text,
               "UPDATE Cliente SET Telefone = @Telefone, Email = @Email, Endereco = @Endereco, Numero = @Numero, Bairro = @Bairro, CodCidade = @CodCidade WHERE CodCliente = @CodCliente");

            return "";
        }


        #endregion

        #region Gestao

        /// <summary>
        /// Esse método Insere um Usuario na base
        /// </summary>
        /// <returns>String de Sucesso</returns>
        public string UsuarioInserir(Usuario usuario)
        {
            acessoDadosSqlServer.LimparParametros();

            acessoDadosSqlServer.AdicionarParametros("@Nome", usuario.Nome);
            acessoDadosSqlServer.AdicionarParametros("@Email", usuario.Email);
            acessoDadosSqlServer.AdicionarParametros("@Usuario", usuario.Login);
            acessoDadosSqlServer.AdicionarParametros("@Senha", usuario.Senha);
            acessoDadosSqlServer.AdicionarParametros("@CodPerfil", usuario.CodPerfil);
            acessoDadosSqlServer.AdicionarParametros("@CodSetor", usuario.CodSetor);
            acessoDadosSqlServer.AdicionarParametros("@Ativo", usuario.Ativo);

            acessoDadosSqlServer.Executar(
               CommandType.Text,
               "INSERT INTO Usuario (Nome,Email,Usuario,Senha,CodPerfil,CodSetor,Ativo) VALUES (@Nome,@Email,@Usuario,@Senha,@CodPerfil,@CodSetor,@Ativo)");

            return "Usuário inserido com sucesso!";
        }

        /// <summary>
        /// Esse método inativa um Usuario na base
        /// </summary>
        /// <returns>String de Sucesso</returns>
        public string UsuarioCancelar(Usuario usuario)
        {
            acessoDadosSqlServer.LimparParametros();

            acessoDadosSqlServer.AdicionarParametros("@CodUsuario", usuario.CodUsuario);
            acessoDadosSqlServer.AdicionarParametros("@Ativo", usuario.Ativo);

            acessoDadosSqlServer.Executar(
               CommandType.Text,
               "UPDATE Usuario SET Ativo = @Ativo WHERE CodUsuario = @CodUsuario");

            return "Usuário inativado com sucesso!";
        }

        /// <summary>
        /// Esse método retorna todos usuarios ativos
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable UsuarioObterTodos()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                DataTable dataTableUsuario = acessoDadosSqlServer.Obter(
                    CommandType.Text,
                    "SELECT US.CodUsuario, US.Nome, US.Email, US.Usuario Login, US.Senha, PE.TipoPerfil, SE.Departamento FROM Usuario US INNER JOIN Perfil PE ON PE.CodPerfil = US.CodPerfil INNER JOIN Setor SE ON SE.CodSetor = US.CodSetor WHERE US.Ativo = 1");

                return dataTableUsuario;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel realizar a operação. Detalhes: " + ex.Message);
            }
        }

        /// <summary>
        /// Esse método retorna todos usuarios ativos
        /// </summary>
        /// <returns>Collection</returns>
        public UsuarioCollection UsuarioObterLista()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                UsuarioCollection usuarioCollection = new UsuarioCollection();

                DataTable dataTableUsuario = acessoDadosSqlServer.Obter(
                    CommandType.Text,
                    "SELECT US.CodUsuario, US.Nome, US.Email, US.Usuario Login, US.Senha, PE.TipoPerfil, SE.Departamento FROM Usuario US INNER JOIN Perfil PE ON PE.CodPerfil = US.CodPerfil INNER JOIN Setor SE ON SE.CodSetor = US.CodSetor WHERE US.Ativo = 1");

                //Percorrer o Datable e transformar em coleção de Cliente
                foreach (DataRow rows in dataTableUsuario.Rows)
                {
                    Usuario usuario = new Usuario();

                    usuario.CodUsuario = Convert.ToInt32(rows["CodUsuario"]);
                    usuario.Nome = Convert.ToString(rows["Nome"]);
                    usuario.Email = Convert.ToString(rows["Email"]);
                    usuario.Login = Convert.ToString(rows["Login"]);

                    usuarioCollection.Add(usuario);
                }

                return usuarioCollection;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel realizar a operação. Detalhes: " + ex.Message);
            }
        }

        /// <summary>
        /// Esse método insere um produto na base
        /// </summary>
        /// <returns>String de Sucesso</returns>
        public string ProdutoInserir(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@NomeProduto", produto.NomeProduto);
                acessoDadosSqlServer.AdicionarParametros("@Ativo", produto.Ativo);

                acessoDadosSqlServer.Executar(
                   CommandType.Text,
                   "INSERT INTO Produto (NomeProduto,Ativo) VALUES (@NomeProduto,@Ativo)");

                return "Produto inserido com sucesso!";
            }
            catch (Exception ex)
            {
                string erro;
                return erro = ex.Message;
            }
        }

        /// <summary>
        /// Esse método inativa um produto na base
        /// </summary>
        /// <returns>String de Sucesso</returns>
        public string ProdutoInativar(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Ativo", produto.Ativo);
                acessoDadosSqlServer.AdicionarParametros("@CodProduto", produto.CodProduto);

                acessoDadosSqlServer.Executar(
                   CommandType.Text,
                   "UPDATE Produto SET Ativo = @Ativo WHERE CodProduto = @CodProduto");

                return "Produto inativado com sucesso!";
            }
            catch (Exception ex)
            {
                string erro;
                return erro = ex.Message;
            }
        }

        public Usuario UsuarioObterPorLogin(string login)
        {
            acessoDadosSqlServer.LimparParametros();

            Usuario user = new Usuario();

            DataTable dataTableUsuario = acessoDadosSqlServer.Obter(
               CommandType.Text, "SELECT CodUsuario, Nome, Usuario, Senha FROM Usuario WHERE Usuario='" + login + "' AND Ativo = 1");

            foreach (DataRow rows in dataTableUsuario.Rows)
            {
                user.CodUsuario = Convert.ToInt32(rows["CodUsuario"]);
                user.Nome = Convert.ToString(rows["Nome"]);
                user.Login = Convert.ToString(rows["Usuario"]);
                user.Senha = Convert.ToString(rows["Senha"]);
            }

            return user;
        }

        public PerfilCollection UsuarioTipoPerfilbterTodos()
        {
            acessoDadosSqlServer.LimparParametros();

            PerfilCollection perfilCollection = new PerfilCollection();

            DataTable dataTableCategoria = acessoDadosSqlServer.Obter(
               CommandType.Text, "SELECT CodPerfil, TipoPerfil FROM Perfil");

            foreach (DataRow rows in dataTableCategoria.Rows)
            {
                Perfil perfil = new Perfil();

                perfil.CodPerfil = Convert.ToInt32(rows["CodPerfil"]);
                perfil.TipoPerfil = Convert.ToString(rows["TipoPerfil"]);

                perfilCollection.Add(perfil);
            }

            return perfilCollection;
        }

        public SetorCollection SetorbterTodos()
        {
            acessoDadosSqlServer.LimparParametros();

            SetorCollection setorCollection = new SetorCollection();

            DataTable dataTableSetor = acessoDadosSqlServer.Obter(
               CommandType.Text, "SELECT CodSetor, Departamento FROM Setor");

            foreach (DataRow rows in dataTableSetor.Rows)
            {
                Setor setor = new Setor();

                setor.CodSetor = Convert.ToInt32(rows["CodSetor"]);
                setor.Departamento = Convert.ToString(rows["Departamento"]);

                setorCollection.Add(setor);
            }

            return setorCollection;
        }

        #endregion

        #region Relatorio

        public StatusCollection StatusObterTodos()
        {
            acessoDadosSqlServer.LimparParametros();

            StatusCollection statusCollection = new StatusCollection();

            DataTable dataTableStatus = acessoDadosSqlServer.Obter(
               CommandType.Text, "SELECT CodStatus, NomeStatus FROM Status");

            foreach (DataRow rows in dataTableStatus.Rows)
            {
                Status status = new Status();

                status.CodStatus = Convert.ToInt32(rows["CodStatus"]);
                status.NomeStatus = Convert.ToString(rows["NomeStatus"]);

                statusCollection.Add(status);
            }

            return statusCollection;
        }


        public DataTable OrdemServicoRelatorio(int codCliente, int codStatus, int codUsuario)
        {
            acessoDadosSqlServer.LimparParametros();

            DataTable dataTableCliente = null;

            //Se a pesquisa for somente por CPF independente de outro filtro
            if (codCliente > 0 && codStatus == 0 && codUsuario == 0)
            {
                acessoDadosSqlServer.AdicionarParametros("@codCliente", codCliente);

                dataTableCliente = acessoDadosSqlServer.Obter(
                    CommandType.Text,
                    "SELECT CodOrdemServico, P.NomeProduto, CLI.CPF_CNPJ, CLI.Nome, OS.Assunto, OS.Descricao, STA.NomeStatus, OS.DhCriacao, US.Usuario, OS.ObservacaoOperador, OS.DhFinalizada, US2.Usuario, OS.ObservacaoTecnica, OS.DhPrevisaoTermino, OS.DhCancelada, OS.MotivoCancelamento FROM OrdemServico OS JOIN Produto P ON P.CodProduto = OS.CodProduto JOIN Cliente CLI ON CLI.CodCliente = OS.CodCliente JOIN Status STA ON STA.CodStatus = OS.CodStatus JOIN Usuario US ON US.CodUsuario = OS.CriacaoCodUsuario JOIN Usuario US2 ON US2.CodUsuario = OS.FinalizadaCodUsuario WHERE OS.CodCliente = @codCliente");

            }
            //Se for usado o filtro de Status
            else if (codStatus > 0)
            {
                acessoDadosSqlServer.AdicionarParametros("@codStatus", codStatus);

               dataTableCliente = acessoDadosSqlServer.Obter(
                   CommandType.Text,
                   "SELECT CodOrdemServico, P.NomeProduto, CLI.CPF_CNPJ, CLI.Nome, OS.Assunto, OS.Descricao, STA.NomeStatus, OS.DhCriacao, US.Usuario, OS.ObservacaoOperador, OS.DhFinalizada, US2.Usuario, OS.ObservacaoTecnica, OS.DhPrevisaoTermino, OS.DhCancelada, OS.MotivoCancelamento FROM OrdemServico OS JOIN Produto P ON P.CodProduto = OS.CodProduto JOIN Cliente CLI ON CLI.CodCliente = OS.CodCliente JOIN Status STA ON STA.CodStatus = OS.CodStatus JOIN Usuario US ON US.CodUsuario = OS.CriacaoCodUsuario JOIN Usuario US2 ON US2.CodUsuario = OS.FinalizadaCodUsuario WHERE OS.CodStatus = @codStatus");

            }
            //Se for usado o filtro de Usuario
            else if (codUsuario > 0)
            {
                acessoDadosSqlServer.AdicionarParametros("@codUsuario", codUsuario);

                dataTableCliente = acessoDadosSqlServer.Obter(
                   CommandType.Text,
                   "SELECT CodOrdemServico, P.NomeProduto, CLI.CPF_CNPJ, CLI.Nome, OS.Assunto, OS.Descricao, STA.NomeStatus, OS.DhCriacao, US.Usuario, OS.ObservacaoOperador, OS.DhFinalizada, US2.Usuario, OS.ObservacaoTecnica, OS.DhPrevisaoTermino, OS.DhCancelada, OS.MotivoCancelamento FROM OrdemServico OS JOIN Produto P ON P.CodProduto = OS.CodProduto JOIN Cliente CLI ON CLI.CodCliente = OS.CodCliente JOIN Status STA ON STA.CodStatus = OS.CodStatus JOIN Usuario US ON US.CodUsuario = OS.CriacaoCodUsuario JOIN Usuario US2 ON US2.CodUsuario = OS.FinalizadaCodUsuario WHERE OS.CriacaoCodUsuario = @codUsuario");

            }
            else if (codCliente == 0 && codStatus == 0 && codUsuario == 0)
            {
                dataTableCliente = acessoDadosSqlServer.Obter(
                    CommandType.Text,
                    "SELECT CodOrdemServico, P.NomeProduto, CLI.CPF_CNPJ, CLI.Nome, OS.Assunto, OS.Descricao, STA.NomeStatus, OS.DhCriacao, US.Usuario, OS.ObservacaoOperador, OS.DhFinalizada, US2.Usuario, OS.ObservacaoTecnica, OS.DhPrevisaoTermino, OS.DhCancelada, OS.MotivoCancelamento FROM OrdemServico OS JOIN Produto P ON P.CodProduto = OS.CodProduto JOIN Cliente CLI ON CLI.CodCliente = OS.CodCliente JOIN Status STA ON STA.CodStatus = OS.CodStatus JOIN Usuario US ON US.CodUsuario = OS.CriacaoCodUsuario JOIN Usuario US2 ON US2.CodUsuario = OS.FinalizadaCodUsuario");

            }

            return dataTableCliente;
        }

        #endregion
    }
}
