using System;

namespace rpg_csharp.src.entities
{
    public class EfeitosJogo
    {
        public string Carregando()
        {
            bool i  = true;
            while(i)
            {
                Console.Clear();
                System.Console.WriteLine("Carregando.");
                System.Threading.Thread.Sleep(900);
                Console.Clear();
                System.Console.WriteLine("Carregando..");
                System.Threading.Thread.Sleep(900);
                Console.Clear();
                System.Console.WriteLine("Carregando...");
                System.Threading.Thread.Sleep(900);
                Console.Clear();
                System.Console.WriteLine("Carregando..");
                System.Threading.Thread.Sleep(900);
                Console.Clear();
                System.Console.WriteLine("Carregando.");
                System.Threading.Thread.Sleep(900);
                Console.Clear();
                System.Console.WriteLine("Carregando..");
                System.Threading.Thread.Sleep(900);
                Console.Clear();
                System.Console.WriteLine("Carregando...");
                System.Threading.Thread.Sleep(900);
                i = false;
            
            }
            return "Carregado!";
        }

        public string BoasVindas()
        {
            System.Console.WriteLine("Seja bem vindo ao rpg c# da DIO, o criador deste jogo é o Henrique Benjamim.");
            System.Console.WriteLine();
            System.Threading.Thread.Sleep(6000);
            System.Console.WriteLine("Os ensinamentos foram dados na metoria de Orientação a Objeto com o Felipe Aguiar, da DIO!");
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("Desde então venho refinando os conhecimentos com o projeto!");
            System.Threading.Thread.Sleep(7000);
            System.Console.WriteLine("Você encontrará facilmente o linkedin dele e o github com o '/henriquebenjamim...' nos dominios respectivos.");
            System.Console.WriteLine();
            System.Threading.Thread.Sleep(7000);
            System.Console.WriteLine("Este é um projeto que terá como parte do resultado da sua vaga como estagiário! Isso não é demais?!");
            System.Console.WriteLine();
            System.Threading.Thread.Sleep(7000);
            Console.Clear();
            return "Iniciando o seu jogo...";
        }
    }
}