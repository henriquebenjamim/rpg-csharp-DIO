using System;
using System.Diagnostics;

namespace rpg_csharp.src.entities
{
    public abstract class Heroi
    {
        public string Nome {get; set;}
        public int Nivel { get; set; }
        public int PontosDeVida { get; set; }
        public int PontosDeMagia { get; set; }
        public string ClasseFantastica { get; set; }
        public int ValorUltimoAtaque { get; set; }
        public int BarraExperiencia { get; set; }

        public Heroi()
        {
        }

        public Heroi(string nome, string classeFantastica)
        {
            Nome = nome;
            ClasseFantastica = classeFantastica;
            Nivel = 1;
            PontosDeVida = 80;
            PontosDeMagia = 50;
            
        }
        public Heroi(string nome, int nivel, int pontosDeVida, int pontosDeMagia, string classeFantastica, int valorUltimoAtaque, int barraExperiencia)
        {
            Nome = nome;
            Nivel = nivel;
            PontosDeVida = pontosDeVida;
            PontosDeMagia = pontosDeMagia;
            ClasseFantastica = classeFantastica;
            ValorUltimoAtaque = valorUltimoAtaque;
            BarraExperiencia = barraExperiencia;
        }

        public override string ToString()
        {
            return "Meu nome é " + Nome + "\n"
                + "Nível: " + Nivel + "\n"
                + "Classe: " + ClasseFantastica + "\n"
                + "Pontos de vida: " + PontosDeVida + "\n"
                + "Pontos de Magia: " + PontosDeMagia + "\n";
        }

        public string Historia()
        {
            return "Aconteceu uma treta muito grande no passado e você precisa resolver essa bronca agora...";                           
        }

        private static readonly Random Rng = new Random();

        public int NextNumber()
        {
            return Rng.Next(1, 20);
        }
        public virtual string Atacar()
        {
            // futuramente adicionar um tipo de ataque magico
            Random dado = new Random();
            //int forcaDoAtaque = this.Nivel = dado.Next(1, 20);
            // se > 15 no dado, mensagem de critico.
            int forcaDoAtaque = NextNumber();
            int ataqueCritico = forcaDoAtaque + 5;
            if (forcaDoAtaque > 18)
            {
                
                return this.Nome + " Atacou com um golpe crítico e realizou "
                    + ataqueCritico + " de dano.";
            }
            else
            {
                return this.Nome + " Ataca com a sua espada e da " +
                    forcaDoAtaque + " de dano.";
            }
        }
        public abstract int RealizarDano();

        public void ReceberDano(int DanoRecebido)
        {
            this.PontosDeVida = this.PontosDeVida - DanoRecebido;
        }

    }

}