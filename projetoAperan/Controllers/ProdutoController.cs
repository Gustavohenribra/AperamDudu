using System;
using System.Collections.Generic;
using AperamTest.Services;
using AperamTest.Models;
using AperamTest.Utils;
using Newtonsoft.Json;

namespace AperamTest.Controllers
{
    public class ProdutoController : BaseController
    {
        private readonly ProdutoService _produtoService;

        public ProdutoController()
        {
            _produtoService = new ProdutoService();
        }

        public string Index()
        {
            return "Página inicial do módulo Produto carregada com sucesso.";
        }

        public string Inicializar()
        {
            try
            {
                var viewModel = new ProdutoViewModel();

                var response = new
                {
                    Sucesso = true,
                    Permissoes = new[] { "Ler", "Escrever", "Excluir", "Atualizar" },
                    Usuario = UsuarioLogado.Chave,
                    ViewModel = viewModel
                };

                return JsonConvert.SerializeObject(response);
            }
            catch (Exception ex)
            {
                var errorResponse = new
                {
                    Sucesso = false,
                    Mensagem = "Erro ao inicializar o módulo",
                    Erro = ex.Message
                };

                return JsonConvert.SerializeObject(errorResponse);
            }
        }

        public override List<string> AcoesProduto
        {
            get
            {
                return new List<string>
                {
                    "Pesquisar",
                    "Salvar",
                    "Editar",
                    "Excluir",
                    "Visualizar"
                };
            }
        }

        public override Dictionary<string, string> InformacoesProduto
        {
            get
            {
                return new Dictionary<string, string>
                {
                    { "NomeTela", "CADASTRO_PRODUTO" },
                    { "CodigoModulo", "PRD001" }
                };
            }
        }
    }
}