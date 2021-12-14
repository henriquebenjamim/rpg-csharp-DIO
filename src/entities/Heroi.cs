using System;
using System.Diagnostics;

namespace rpg_csharp.src.entities
{
    
    public class Heroi
    {
        //metodo construtor com encapsulamento
        public Heroi(string Nome, string ClasseFantastica){
            this.Nome = Nome;
            this.ClasseFantastica = ClasseFantastica;
            this.Nivel = 1;
            this.PontosDeVida = 50;
            this.PontosDeMagia = 50;
            this.NomeDoPet = "Dragão";
        }
        public string Nome { get; set; }

        public int Nivel { get; set; }

        public int PontosDeVida {get; set; }

        public int PontosDeMagia {get; set; }

        // lembrar de adicionar um enum para classes
        public string ClasseFantastica {get; set; }

        public string NomeDoPet { get; set; }

        public int ValorUltimoAtaque { get; set; }

        // exemplo de encapsulamento
        public override string ToString(){
            return "Meu nome é " + this.Nome + "\n"
                + "Nível: " + this.Nivel + "\n"
                + "Classe: " + this.ClasseFantastica + "\n"
                + "Pontos de vida: " + this.PontosDeVida + "\n"
                + "Pontos de Magia: " + this.PontosDeMagia + "\n"
                + "Pet: " + this.NomeDoPet + "\n"
            ;
        }

        // o virtual permite que outras classes possam sobrescrever ela
        public virtual string Atacar(){
            // futuramente adicionar um tipo de ataque magico
            Random dado = new Random();
            int forcaDoAtaque = this.Nivel = dado.Next(1,20);
            // se > 15 no dado, mensagem de critico.

            this.ValorUltimoAtaque = forcaDoAtaque;
            return this.Nome + " Ataca com a sua espada e da " +
                    forcaDoAtaque + " de dano" ;
        }

        public void ReceberDano(int DanoRecebido){
            this.PontosDeVida = this.PontosDeVida - DanoRecebido;
        }

    }
}