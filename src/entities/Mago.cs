using System;

namespace rpg_csharp.src.entities
{
    public class Mago : Heroi
    {
        public Mago(string Nome, string ClasseFantastica) : base(Nome, ClasseFantastica)
        {
            this.Nome = Nome;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel = 1;
            this.PontosDeVida = 45;
            this.PontosDeMagia = 50;
            this.NomeDoPet = "Dragão";
        }

        public override string Atacar(){
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1, 10);
            int ataqueCritico = forcaDoAtaque + 5;

            if (forcaDoAtaque > 8)
            {
                this.ValorUltimoAtaque = ataqueCritico;

                return this.Nome + "Realizou um ataque critico físico com o cajado e deu " +
                    ataqueCritico + " de dano.";
            }
            else
            {   
                this.ValorUltimoAtaque = forcaDoAtaque;

                return this.Nome + " Ataca com o seu cajado e dá " + forcaDoAtaque + " de dano." ;
            }
                
            
            

        }

        public string Atacar(int bonus){
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel + dado.Next(1, 10) + bonus;
            int ataqueCritico = forcaDoAtaque + 5;

            if(forcaDoAtaque > 8)
            {
                this.ValorUltimoAtaque = forcaDoAtaque;
                this.PontosDeMagia -= 8;
                
                return this.Nome + " Realizou uma magia crítica, gastou 10 de mana e deu "+
                    ataqueCritico + " de dano mágico.";
                
            }
            
            else
            {
                this.ValorUltimoAtaque = forcaDoAtaque;
                this.PontosDeMagia -= 10;

                return this.Nome + " Ataca com bônus com seu cajado e dá " + 
                forcaDoAtaque + " de dano.";
            }
            
        }
    }
}