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
            this.PontosDeVida = 120;
            this.PontosDeMagia = 50;
            this.NomeDoPet = "Dragão";
        }
        public Heroi(string nome, int nivel, int pontosDeVida, int pontosDeMagia, string classeFantastica, string nomeDoPet, int valorUltimoAtaque, int barraExperiencia)
        {
            this.Nome = nome;
            this.Nivel = nivel;
            this.PontosDeVida = pontosDeVida;
            this.PontosDeMagia = pontosDeMagia;
            this.ClasseFantastica = classeFantastica;
            this.NomeDoPet = nomeDoPet;
            this.ValorUltimoAtaque = valorUltimoAtaque;
            this.BarraExperiencia = barraExperiencia;

        }
        public string Nome { get; set; }

        public int Nivel { get; set; }

        public int PontosDeVida { get; set; }

        public int PontosDeMagia { get; set; }

        // lembrar de adicionar um enum para classes
        public string ClasseFantastica { get; set; }

        public string NomeDoPet { get; set; }

        public int ValorUltimoAtaque { get; set; }

        public int BarraExperiencia { get; set; }

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

        public string Historia()
        {
            return "Então iremos começar sua jornada... \n A mais de mil anos houveram guerreiros e magos que protegiam o mundo do mal, \n" +
                " porém um rei que utilizou de magia negra se apossou de todas as terras e manteve \n " +
                " as riquezas para si e nenhuma ao povo, os guerreiros e magos dá época então foram acabar \n" +
                " com o mal. Porém mal sabiam eles que a magia era o menor dos problemas, existia um monstro \n" +
                " ressucitado a mais de 1 milhão de anos chamado Paçoca que era mais poderoso que tudo e foi \n" +
                " liberto novamente. No combate, todos os guerreiros do bem foram derrotados porém utilizaram \n" +
                " de uma magia para selar o inimigo e mantê-lo longe de todos. Hoje temos uma vida mais digna \n" +
                " pela batalha anterior e somos muito gratos a todos os guerreiros. \n" +
                "\n ";
                                
        }

        // o virtual permite que outras classes possam sobrescrever ela
        public virtual string Atacar()
        {
            // futuramente adicionar um tipo de ataque magico
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel = dado.Next(1, 20);
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


        public int RealizarDano()
        {
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel = dado.Next(1, 20);
            int ataqueCritico = forcaDoAtaque + 5;
            if (forcaDoAtaque > 18)
            {
                this.ValorUltimoAtaque = ataqueCritico;
                
                return forcaDoAtaque;
            }
            else
            {
                this.ValorUltimoAtaque = forcaDoAtaque;
                return forcaDoAtaque;
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