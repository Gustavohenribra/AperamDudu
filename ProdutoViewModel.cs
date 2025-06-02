using System;

namespace AperamTest.Models
{
    public class ProdutoViewModel
    {
        public string Titulo { get; set; }
        public DateTime DataCarregamento { get; set; }
        public bool PossuiPermissaoEdicao { get; set; }

        public ProdutoViewModel()
        {
            Titulo = "Cadastro de Produtos";
            DataCarregamento = DateTime.Now;
            PossuiPermissaoEdicao = true;
        }
    }
}