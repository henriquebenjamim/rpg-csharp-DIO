using System;
using System.Diagnostics;

namespace rpg_csharp.src.entities
{
    public class Batalhar
    {   
        public string Heroi { get; set; }
        public string Inimigo { get; set; }
        public int VidaHeroi { get; set; }
        public int VidaInimigo { get; set; }
        public int AtaqueHeroi { get; set; }
        public int AtaqueInimigo { get; set; }
        public int Experiencia { get; set; }
        public int Nivel { get; set; }

        public Batalhar(string heroi, string inimigo, int vidaHeroi, int vidaInimigo, int ataqueHeroi, int ataqueInimigo, int experiencia, int nivel)
        {
            Heroi = heroi;
            Inimigo = inimigo;
            VidaHeroi = vidaHeroi;
            VidaInimigo = vidaInimigo;
            AtaqueHeroi = ataqueHeroi;
            AtaqueInimigo = ataqueInimigo;
            Experiencia = experiencia;
            Nivel = nivel;
        }
        
        public string Batalhando(string heroi, string inimigo, int vidaHeroi, int vidaInimigo, int ataqueHeroi, int ataqueInimigo, int experiencia, int nivel)
        {
            string vencedor = "";
            int turnos = 0;
            while(vidaHeroi > 0 || vidaInimigo > 0)
            {
                
                System.Console.WriteLine(ataqueHeroi);
                System.Console.WriteLine();
                System.Console.WriteLine($"{heroi} atacou com {ataqueHeroi} de dano em {Inimigo}");
                vidaInimigo -= ataqueHeroi;
                System.Console.WriteLine($"{inimigo} agora tem {vidaInimigo} de vida.");
                System.Console.WriteLine("--");
                System.Threading.Thread.Sleep(1500);
                turnos += 1;
                experiencia += 2;
                if (experiencia >= 10)
                    {
                        this.Nivel += 1;
                    }
                if(vidaInimigo <= 0)
                {
                    System.Console.WriteLine($"{inimigo} perdeu.");
                    System.Console.WriteLine($"{heroi} ganha de {(turnos)} experiencia bonus.");
                    // this.experiencia = experiencia;
                    experiencia += (turnos * 1);
                    if (experiencia >= 10)
                    {
                        this.Nivel += 1;
                    }
                    vencedor = this.Heroi;

                    break;
                    
                }
                
                System.Console.WriteLine($"{inimigo} atacou com {ataqueInimigo} de dano em {Heroi}.");
                vidaHeroi -= ataqueInimigo;
                System.Console.WriteLine($"{heroi} agora tem {vidaHeroi} de vida.");
                System.Console.WriteLine(AtaqueInimigo);
                System.Console.WriteLine();
                System.Threading.Thread.Sleep(1500);
                if(vidaHeroi <= 0)
                {
                    System.Console.WriteLine($"{heroi}");
                    
                    vencedor = this.Inimigo;
                    break;
                }
                Random dadoHeroi = new Random();
                ataqueHeroi = dadoHeroi.Next(1, 20);
                Random dadoInimigo = new Random();
                ataqueInimigo = dadoInimigo.Next(1, 20);
            }

            return vencedor + " Venceu!";

            

        }
    }
}