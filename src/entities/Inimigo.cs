using System;

namespace rpg_csharp.src.entities
{
    public class Inimigo : Heroi
    {
        public Inimigo(string nome, string classeFantastica) : base(nome, classeFantastica)
        {
            Nivel = 1;
            PontosDeVida = 90;
            PontosDeMagia = 15;
        }
        public override string Atacar(){
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1, 15);
            int ataqueCritico = forcaDoAtaque + 5;

            if(forcaDoAtaque > 13)
            {
                this.ValorUltimoAtaque = ataqueCritico;

                return this.Nome + "Ataca com crítico e realiza " + ValorUltimoAtaque + " de dano.";
            }
            else 
            {
                this.ValorUltimoAtaque = forcaDoAtaque;
            
                return this.Nome + " Ataca e dá " + ValorUltimoAtaque + " de dano.";
            }
        }

        public override int RealizarDano()
        {
            Random dado = new Random();
            //int forcaDoAtaque = this.Nivel + dado.Next(1, 20);
            int forcaDoAtaque = NextNumber(); 
            int ataqueCritico = forcaDoAtaque + 5;
            if (forcaDoAtaque > 18)
            {
                this.ValorUltimoAtaque = ataqueCritico;
                System.Console.WriteLine($"Critou, deu {ataqueCritico}");
                
                return ataqueCritico;
            }
            else
            {
                this.ValorUltimoAtaque = forcaDoAtaque;
                System.Console.WriteLine($"Saiu {forcaDoAtaque} de dano");
                return forcaDoAtaque;
            }
        }
    }
}