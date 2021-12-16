using System;
using System.Diagnostics;

namespace rpg_csharp.src.entities
{

    public class Heroi
    {
        //metodo construtor com encapsulamento
        public Heroi(string Nome, string ClasseFantastica)
        {
            this.Nome = Nome;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel = 1;
            this.PontosDeVida = 500;
            this.PontosDeMagia = 50;
            this.NomeDoPet = "Dragão";
        }
        public Heroi(string nome, int nivel, int pontosDeVida, int pontosDeMagia, string classeFantastica, string nomeDoPet, int valorUltimoAtaque)
        {
            this.Nome = nome;
            this.Nivel = nivel;
            this.PontosDeVida = pontosDeVida;
            this.PontosDeMagia = pontosDeMagia;
            this.ClasseFantastica = classeFantastica;
            this.NomeDoPet = nomeDoPet;
            this.ValorUltimoAtaque = valorUltimoAtaque;

        }
        public string Nome { get; set; }

        public int Nivel { get; set; }

        public int PontosDeVida { get; set; }

        public int PontosDeMagia { get; set; }

        // lembrar de adicionar um enum para classes
        public string ClasseFantastica { get; set; }

        public string NomeDoPet { get; set; }

        public int ValorUltimoAtaque { get; set; }

        // exemplo de encapsulamento
        public override string ToString()
        {
            return "Meu nome é " + this.Nome + "\n"
                + "Nível: " + this.Nivel + "\n"
                + "Classe: " + this.ClasseFantastica + "\n"
                + "Pontos de vida: " + this.PontosDeVida + "\n"
                + "Pontos de Magia: " + this.PontosDeMagia + "\n"
                + "Pet: " + this.NomeDoPet + "\n"
            ;
        }

        // o virtual permite que outras classes possam sobrescrever ela
        public virtual string Atacar()
        {
            // futuramente adicionar um tipo de ataque magico
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel = dado.Next(18, 20);
            // se > 15 no dado, mensagem de critico.
            int ataqueCritico = forcaDoAtaque + 5;
            if (forcaDoAtaque > 18)
            {
                this.ValorUltimoAtaque = ataqueCritico;
                
                return this.Nome + " Atacou com um golpe crítico e realizou "
                    + ataqueCritico + " de dano.";
            }
            else
            {
                this.ValorUltimoAtaque = forcaDoAtaque;

                return this.Nome + " Ataca com a sua espada e da " +
                    forcaDoAtaque + " de dano.";
            }

        }

        public void ReceberDano(int DanoRecebido)
        {
            this.PontosDeVida = this.PontosDeVida - DanoRecebido;
        }

        // public void Batalhar(string alvo)
        // {   
        //     this.Nome = this.Nome;
        //     this.PontosDeVida = this.PontosDeVida;
        //     while(PontosDeVida > 0 && alvo > 0)
        //     {
        //         System.Console.WriteLine($"Jogador ataca e realiza {Atacar()} de dano.");
        //         System.Console.WriteLine();
        //         System.Console.WriteLine($"O inimigo ataca e realiza {alvo.Atacar()} de dano.");
        //     }
        // }
    }
}