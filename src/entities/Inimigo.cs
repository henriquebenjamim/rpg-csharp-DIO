using System;

namespace rpg_csharp.src.entities
{
    public class Inimigo : Heroi
    {
        public Inimigo(string Nome, string ClasseFantastica) : base(Nome, ClasseFantastica)
        {
            this.Nome = Nome;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel = 1;
            this.PontosDeVida = 60;
            this.PontosDeMagia = 15;
            this.NomeDoPet = "Ameba";
        }

        public override string Atacar(){
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1, 15);
            
            this.ValorUltimoAtaque = forcaDoAtaque;
            
            return this.Nome + " Ataca e dá " + forcaDoAtaque + " de dano";
        }
    }
}