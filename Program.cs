using System;
using AperamTest.Controllers;
using AperamTest.Services;

namespace AperamTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TESTE TÉCNICO APERAM - PROGRAMA DE ESTÁGIO TI-INDUSTRIAL ===\n");

            var controller = new ProdutoController();
            var service = new ProdutoService();

            Console.WriteLine("1. Testando método Index:");
            Console.WriteLine(controller.Index());
            Console.WriteLine();

            Console.WriteLine("2. Testando método Inicializar:");
            Console.WriteLine(controller.Inicializar());
            Console.WriteLine();

            Console.WriteLine("3. Testando propriedade AcoesProduto:");
            controller.AcoesProduto.ForEach(acao => Console.WriteLine($"- {acao}"));
            Console.WriteLine();

            Console.WriteLine("4. Testando propriedade InformacoesProduto:");
            foreach (var info in controller.InformacoesProduto)
            {
                Console.WriteLine($"- {info.Key}: {info.Value}");
            }
            Console.WriteLine();

            Console.WriteLine("5. Testando ListarProdutosExemplo:");
            var produtos = service.ListarProdutosExemplo(1, 2);
            foreach (var produto in produtos)
            {
                Console.WriteLine($"- {produto.CodigoProduto}: {produto.DescricaoProduto}");
            }

            Console.WriteLine("\n=== QUESTÕES TEÓRICAS ===\n");

            Console.WriteLine("3.1) Análise do código:");
            int x = 10;
            int y = x;
            x = 5;
            Console.WriteLine($"Valor de y: {y}");
            Console.WriteLine("Resposta: O valor impresso será 10.");
            Console.WriteLine("Justificativa: Em C#, tipos primitivos como int são tipos de valor.");
            Console.WriteLine("Quando fazemos 'y = x', o valor de x (10) é copiado para y.");
            Console.WriteLine("Posteriormente, alterar x para 5 não afeta y, pois cada variável");
            Console.WriteLine("possui sua própria cópia do valor.\n");

            Console.WriteLine("3.2) Diferença entre public e private:");
            Console.WriteLine("- PUBLIC: Permite acesso de qualquer lugar do código. Usado para");
            Console.WriteLine("  APIs públicas, métodos e propriedades que devem ser acessíveis");
            Console.WriteLine("  externamente.");
            Console.WriteLine("- PRIVATE: Restringe acesso apenas à própria classe. Usado para");
            Console.WriteLine("  implementações internas, métodos auxiliares e encapsulamento");
            Console.WriteLine("  de dados sensíveis.\n");

            Console.WriteLine("3.3) Bloco try/catch:");
            Console.WriteLine("Serve para capturar e tratar exceções que podem ocorrer durante");
            Console.WriteLine("a execução do código, evitando que a aplicação trave.");
            Console.WriteLine("Boas práticas:");
            Console.WriteLine("- Capturar exceções específicas quando possível");
            Console.WriteLine("- Logar erros para diagnóstico");
            Console.WriteLine("- Não ignorar exceções silenciosamente");
            Console.WriteLine("- Usar finally para limpeza de recursos\n");

            Console.WriteLine("3.4) Modificador override:");
            Console.WriteLine("Override permite redefinir um método virtual da classe base.");
            Console.WriteLine("- VIRTUAL: Método na classe base que pode ser sobrescrito");
            Console.WriteLine("- OVERRIDE: Redefine um método virtual na classe derivada");
            Console.WriteLine("- NEW: Oculta um método da classe base (não é polimorfismo)");

            Console.ReadKey();
        }
    }
}