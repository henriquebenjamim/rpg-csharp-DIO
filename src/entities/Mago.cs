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
            this.PontosDeVida = 400;
            this.PontosDeMagia = 65;
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
            int forcaDoAtaque = this.Nivel + dado.Next(8, 10) + bonus;
            int ataqueCritico = forcaDoAtaque + 5;

            if(forcaDoAtaque > 8)
            {
                this.ValorUltimoAtaque = forcaDoAtaque;
                
                return this.Nome + " Realizou uma magia crítica e deu "+
                    ataqueCritico + " de dano mágico.";
                
            }
            
            else
            {
                this.ValorUltimoAtaque = forcaDoAtaque;

                return this.Nome + " Ataca com bônus com seu cajado e dá " + 
                forcaDoAtaque + " de dano.";
            }
            
        }
    }
}