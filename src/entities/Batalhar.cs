namespace rpg_csharp.src.entities
{
    public class Batalhar
    {
        public Batalhar(string heroi, string inimigo, int vidaHeroi, int vidaInimigo, int ataqueHeroi, int ataqueInimigo)
        {
            this.Heroi = heroi;
            this.Inimigo = inimigo;
            this.VidaHeroi = vidaHeroi;
            this.VidaInimigo = vidaInimigo;
            this.AtaqueHeroi = ataqueHeroi;
            this.AtaqueInimigo = ataqueInimigo;
        }

        public string Heroi { get; set; }

        public string Inimigo { get; set; }

        public int VidaHeroi { get; set; }

        public int VidaInimigo { get; set; }

        public int AtaqueHeroi { get; set; }

        public int AtaqueInimigo { get; set; }

        public string Batalhando(string Heroi, string Inimigo, int vidaHeroi, int vidaInimigo, int ataqueHeroi, int ataqueInimigo)
        {
            string vencedor = "";
            while(vidaHeroi > 0 || vidaInimigo > 0)
            {
                vidaInimigo -= ataqueHeroi;
                System.Console.WriteLine($"{Heroi} atacou com {ataqueHeroi} de dano em {Inimigo}");
                System.Console.WriteLine($"{Heroi} finaliza o turno del@");
                System.Console.WriteLine($"{Inimigo} agora tem {vidaInimigo} de vida.");
                System.Console.WriteLine();
                if(vidaInimigo <= 0)
                {
                    System.Console.WriteLine($"{Inimigo} perdeu.");
                    vencedor = this.Heroi;
                    break;
                    
                } 
                vidaHeroi -= ataqueInimigo;
                System.Console.WriteLine($"{Inimigo} atacou com {ataqueInimigo} de dano em {Heroi}.");
                System.Console.WriteLine($"{Inimigo} finaliza o turno del@");
                System.Console.WriteLine($"{Heroi} agora tem {vidaHeroi} de vida.");
                System.Console.WriteLine();
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