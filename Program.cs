using System;
using rpg_csharp.src.entities;

namespace rpg_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x= 0;
            Heroi arus = new Heroi("Arus", "Guerreiro");
            Mago wedge = new Mago("Wedge", "Mago Negro");
            Inimigo kingMummy = new Inimigo("King Mummy", "Zumbi");
            
            //Console.WriteLine(arus.ToString());
            System.Console.WriteLine(arus.Atacar());
            //System.Console.WriteLine(wedge.Atacar());
            System.Console.WriteLine(kingMummy.Atacar());
            System.Console.WriteLine();
            System.Console.WriteLine(arus.ValorUltimoAtaque);
            System.Console.WriteLine(kingMummy.ValorUltimoAtaque);

            while(x == 0)
            {
                System.Console.WriteLine("Caso deseje terminar o jogo digite 1, 0 para continuar.");
                x = int.Parse(Console.ReadLine());
                if (x == 1) break;
                
                else
                {
                    if (arus.ValorUltimoAtaque == kingMummy.ValorUltimoAtaque)
                    {
                        System.Console.WriteLine($"Empate, ambos deram dano de {arus.ValorUltimoAtaque}." );
                    }
                    else if (arus.ValorUltimoAtaque > kingMummy.ValorUltimoAtaque)
                    {
                        kingMummy.ReceberDano(arus.ValorUltimoAtaque);
                        System.Console.WriteLine($"{arus.Nome} Venceu!");
                    }
                    else {
                        arus.ReceberDano(kingMummy.ValorUltimoAtaque);
                        System.Console.WriteLine($"{kingMummy.Nome} Venceu!");
                        }
                }
            }

        }
    }
}
