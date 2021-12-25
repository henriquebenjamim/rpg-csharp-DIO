namespace rpg_csharp.src.entities
{
    public class Batalhar
    {
        public Batalhar(string heroi, string inimigo, int vidaHeroi, int vidaInimigo, int ataqueHeroi, int ataqueInimigo, int experiencia, int nivel)
        {
            this.Heroi = heroi;
            this.Inimigo = inimigo;
            this.VidaHeroi = vidaHeroi;
            this.VidaInimigo = vidaInimigo;
            this.AtaqueHeroi = ataqueHeroi;
            this.AtaqueInimigo = ataqueInimigo;
            this.Experiencia = experiencia;
            this.Nivel = nivel;
        }

        public string Heroi { get; set; }

        public string Inimigo { get; set; }

        public int VidaHeroi { get; set; }

        public int VidaInimigo { get; set; }

        public int AtaqueHeroi { get; set; }

        public int AtaqueInimigo { get; set; }

        public int Experiencia { get; set; }

        public int Nivel { get; set; }

        public string Batalhando(string Heroi, string Inimigo, int vidaHeroi, int vidaInimigo, int ataqueHeroi, int ataqueInimigo, int experiencia, int nivel)
        {
            string vencedor = "";
            int turnos = 0;
            while(vidaHeroi > 0 || vidaInimigo > 0)
            {
                vidaInimigo -= ataqueHeroi;
                System.Console.WriteLine($"{Heroi} atacou com {ataqueHeroi} de dano em {Inimigo}");
                System.Console.WriteLine($"{Inimigo} agora tem {vidaInimigo} de vida.");
                System.Console.WriteLine();
                System.Threading.Thread.Sleep(1500);
                turnos += 1;
                experiencia += 2;
                if (experiencia >= 10)
                    {
                        this.Nivel += 1;
                    }
                if(vidaInimigo <= 0)
                {
                    System.Console.WriteLine($"{Inimigo} perdeu.");
                    System.Console.WriteLine($"{Heroi} ganha de {(turnos)} experiencia bonus.");
                    // this.experiencia = experiencia;
                    experiencia += (turnos * 1);
                    if (experiencia >= 10)
                    {
                        this.Nivel += 1;
                    }
                    vencedor = this.Heroi;

                    break;
                    
                } 
                vidaHeroi -= ataqueInimigo;
                System.Console.WriteLine($"{Inimigo} atacou com {ataqueInimigo} de dano em {Heroi}.");
                System.Console.WriteLine($"{Heroi} agora tem {vidaHeroi} de vida.");
                System.Console.WriteLine();
                System.Threading.Thread.Sleep(1500);
                if(vidaHeroi <= 0)
                {
                    System.Console.WriteLine($"{Heroi}");
                    
                    vencedor = this.Inimigo;
                    break;
                }
            }

            return vencedor + " Venceu!";

            

        }
    }
}