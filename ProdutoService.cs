using System.Collections.Generic;
using AperamTest.Models;

namespace AperamTest.Services
{
    public class ProdutoService
    {
        public List<ProdutoGrid> ListarProdutosExemplo(int grupo, int subgrupo)
        {
            var produtos = new List<ProdutoGrid>
            {
                new ProdutoGrid
                {
                    CodigoProduto = "PRD001",
                    DescricaoProduto = "Aço Carbono Laminado a Quente"
                },
                new ProdutoGrid
                {
                    CodigoProduto = "PRD002",
                    DescricaoProduto = "Aço Inoxidável Austenítico"
                },
                new ProdutoGrid
                {
                    CodigoProduto = "PRD003",
                    DescricaoProduto = "Liga de Alumínio 6061-T6"
                },
                new ProdutoGrid
                {
                    CodigoProduto = "PRD004",
                    DescricaoProduto = "Chapa de Cobre Eletrolítico"
                },
                new ProdutoGrid
                {
                    CodigoProduto = "PRD005",
                    DescricaoProduto = "Perfil Estrutural de Aço"
                },
                new ProdutoGrid
                {
                    CodigoProduto = "PRD006",
                    DescricaoProduto = "Barra Redonda de Titânio"
                },
                new ProdutoGrid
                {
                    CodigoProduto = "PRD007",
                    DescricaoProduto = "Tubo de Aço Galvanizado"
                }
            };

            return produtos.FindAll(p =>
                p.CodigoProduto.Contains(grupo.ToString()) ||
                p.DescricaoProduto.Contains(subgrupo.ToString()));
        }
    }
}