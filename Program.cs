using System;
using rpg_csharp.src.entities;

namespace rpg_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Olá, seja bem vindo ao rpg csharp...");
            System.Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();
            System.Threading.Thread.Sleep(1500);
            System.Console.WriteLine($"Que nome bonito, {nome}!");
            System.Console.WriteLine("Qual a sua classe?");
            string classe = Console.ReadLine();
            System.Threading.Thread.Sleep(1500);

            EfeitosJogo carregandoTela = new EfeitosJogo();

            System.Console.WriteLine(carregandoTela.Carregando());
            System.Console.WriteLine(carregandoTela.BoasVindas());

            Heroi rexxar = new Heroi(nome, classe);
            Inimigo gremlin = new Inimigo("rei múmia", "monstro");
            Batalhar minhaBatalha =  new Batalhar(rexxar.Nome, gremlin.Nome, rexxar.PontosDeVida, gremlin.PontosDeVida, rexxar.NextNumber(), gremlin.NextNumber(), rexxar.BarraExperiencia, rexxar.Nivel);
            
            System.Console.WriteLine("Deseja se aventurar no bosque de jardim?");
            System.Console.WriteLine("utilize 0 para parar e 1 para iniciar.");
            int resposta = int.Parse(Console.ReadLine());
            if (resposta != 0)
            {
                System.Console.WriteLine(rexxar.Historia());
                System.Console.WriteLine();
                System.Console.WriteLine("Estou sentindo um pouco de calafrios.");
                System.Console.WriteLine("Você está sentindo?");
                int responderResposta = int.Parse(Console.ReadLine());
                if (responderResposta != 0)
                {
                    System.Console.WriteLine("Acho melhor irmos embora daqui...");
                    System.Threading.Thread.Sleep(0500);
                    System.Console.WriteLine("Oh, não! Surgiu um inimigo. Devemos lutar contra ele.");
                    System.Threading.Thread.Sleep(1500);
                    System.Console.WriteLine("Mas peraí, eu não sei lutar, essa bronca quem terá que resolver é você...");
                    System.Threading.Thread.Sleep(0500);
                    System.Console.WriteLine();
                    System.Console.WriteLine(minhaBatalha.Batalhando(rexxar.Nome, gremlin.Nome, rexxar.PontosDeVida, gremlin.PontosDeVida, rexxar.RealizarDano(), gremlin.RealizarDano(), rexxar.BarraExperiencia, rexxar.Nivel));
                }

                else
                {
                    System.Console.WriteLine("Game over! Desistentes não ganham nada.");
                }

            }
                
            else 
            {
                System.Console.WriteLine("Fim do jogo.");
            }
        }
    }
}
