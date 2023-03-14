using System;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {

        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Luis";
            sicrano.Idade = 21;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos. ");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Paulo";
            fulano.Idade = 22;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
