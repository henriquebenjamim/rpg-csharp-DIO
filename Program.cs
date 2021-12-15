using System;
using rpg_csharp.src.entities;

namespace rpg_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Heroi rexxar = new Heroi("XxCoolxX", "Guerreiro");
            
            Inimigo gremlin = new Inimigo("LapoLaCa", "Sereia");
            
            
            System.Console.WriteLine($"Olá, {rexxar.Nome}");
            System.Console.WriteLine("Deseja se aventurar no bosque de jardim?");
            System.Console.WriteLine("utilize 0 para parar e qualquer outro número para iniciar.");
            int resposta = int.Parse(Console.ReadLine());
            if (resposta != 0)
            {
                System.Console.WriteLine("Vamos começar sua jornada.");
                System.Console.WriteLine("");

                System.Console.WriteLine("A um longo período de tempo houveram vários guerreiros nesta terra," +
                    "porém um rei que utilizou de magia negra se apossou de todas as terras e manteve" +
                    "as riquezas para si e nenhuma ao povo, os guerreiros e magos dá época então foram acabar" +
                    "com o mal. Porém mal sabiam eles que a magia era o menor dos problemas, existia um monstro " +
                    "ressucitado a mais de 1 milhão de anos chamado Paçoca que era mais poderoso que tudo e foi" +
                    "liberto novamente. No combate, todos os guerreiros do bem foram derrotados porém utilizaram" +
                    "de uma magia para selar o inimigo e mantê-lo longe de todos. Hoje temos uma vida mais digna" +
                    "pela batalha anterior e somos muito gratos a todos os guerreiros.");

                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine("Percebo que você tem uma classe, não é?!");
                System.Console.WriteLine($"Pelas vestimentas, arrisco dizer que você é {rexxar.ClasseFantastica}. Acertei?");
                System.Console.WriteLine("Eu sabia! hahahaha!");

                System.Console.WriteLine();
                System.Console.WriteLine("Estou sentindo um pouco de calafrios.");
                System.Console.WriteLine("Você está sentindo?");
                int responderResposta = int.Parse(Console.ReadLine());
                if (responderResposta != 0)
                {
                    System.Console.WriteLine("Acho melhor irmos embora daqui...");
                    System.Console.WriteLine("Oh, não! Surgiu um inimigo. Devemos lutar contra ele.");
                    System.Console.WriteLine("Mas peraí, eu não sei lutar, essa bronca quem terá que resolver é você...");
                    while(rexxar.PontosDeVida > 0 && gremlin.PontosDeVida > 0)
                    {
                        System.Console.WriteLine("++++++++++++++");
                        rexxar.Atacar();
                        gremlin.Atacar();
                        System.Console.WriteLine($"{rexxar.Nome} realizou {rexxar.ValorUltimoAtaque} de dano em {gremlin.Nome}");
                        gremlin.ReceberDano(rexxar.ValorUltimoAtaque);
                        System.Console.WriteLine($"{gremlin.Nome} agora tem {gremlin.PontosDeVida} de vida.");
                        System.Console.WriteLine($"{rexxar.Nome} finaliza o turno dele.");
                        System.Console.WriteLine();
                        System.Threading.Thread.Sleep(2000);

                        if (gremlin.PontosDeVida <= 0)
                        {
                            System.Console.WriteLine($"{gremlin.Nome} recebey {rexxar.ValorUltimoAtaque} de dano e ficou com {gremlin.PontosDeVida}");
                            System.Console.WriteLine($"{gremlin.Nome} perdeu a batalha...");
                        }
                        


                        System.Console.WriteLine($"{gremlin.Nome} realizou {gremlin.ValorUltimoAtaque} de dano em {rexxar.Nome}");
                        rexxar.ReceberDano(gremlin.ValorUltimoAtaque);
                        System.Console.WriteLine($"{rexxar.Nome} agora tem {rexxar.PontosDeVida} de vida.");
                        System.Console.WriteLine($"{gremlin.Nome} finaliza o turno dele.");
                        System.Threading.Thread.Sleep(2000);
                        System.Console.WriteLine();
                        
                        
                        if(rexxar.PontosDeVida <= 0)
                        {
                            System.Console.WriteLine($"{rexxar.Nome} recebeu {gremlin.ValorUltimoAtaque} de dano. e ficou com {rexxar.PontosDeVida}");
                            System.Console.WriteLine($"{rexxar.Nome} perdeu a batalha...");
                        }
                        
                        System.Console.WriteLine("Finalizando o turno geral...");
                        System.Threading.Thread.Sleep(4000);
                        System.Console.WriteLine("==============================");
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        System.Console.WriteLine();
                        System.Console.WriteLine();

                    
                    }

                }

                else
                {
                    System.Console.WriteLine("Game over! Desistentes não ganham nada.");
                    
                }

            }
                
            else 
            {
                System.Console.WriteLine("Fim do jogo.");
            }

            
            
            
            
            
            
            
            // //Console.WriteLine(arus.ToString());
            // System.Console.WriteLine(arus.Atacar());
            // //System.Console.WriteLine(wedge.Atacar());
            // System.Console.WriteLine(kingMummy.Atacar());
            // System.Console.WriteLine();
            // System.Console.WriteLine(arus.ValorUltimoAtaque);
            // System.Console.WriteLine(kingMummy.ValorUltimoAtaque);

            

            // while(x == 0)
            // {
            //     System.Console.WriteLine("Caso deseje terminar o jogo digite 1, 0 para continuar.");
            //     x = int.Parse(Console.ReadLine());
            //     if (x == 1) break;
                
            //     else
            //     {
            //         if (arus.ValorUltimoAtaque == kingMummy.ValorUltimoAtaque)
            //         {
            //             System.Console.WriteLine($"Empate, ambos deram dano de {arus.ValorUltimoAtaque}." );
            //         }
            //         else if (arus.ValorUltimoAtaque > kingMummy.ValorUltimoAtaque)
            //         {
            //             kingMummy.ReceberDano(arus.ValorUltimoAtaque);
            //             System.Console.WriteLine($"{arus.Nome} Venceu!");
            //         }
            //         else {
            //             arus.ReceberDano(kingMummy.ValorUltimoAtaque);
            //             System.Console.WriteLine($"{kingMummy.Nome} Venceu!");
            //             }
            //     }
            // }

        }
    }
}
