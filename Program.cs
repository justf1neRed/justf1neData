using System;
using System.Collections.Generic;
using System.Linq;

namespace Pikachy
{
    class Program
    {
        class Tamagochi
        {
            int StrikePointsEat = 0; 
            int StrikePointsWalk = 0; 
            int StrikePointsSleep = 0;
            int StrikePointsPlay = 0;

            public void GetFeed(object sender, GameMechanics e)
            {
                Console.Clear();
                Console.WriteLine("Хозяин, я хочу есть!\n 1 - Кормить, 2 - Игнорировать, 3 - Выход из приложения");
                int UserChoise = int.Parse(Console.ReadLine());

                if(UserChoise == 1)
                {
                    Console.WriteLine(e.Feed);
                }
                else if(UserChoise == 2)
                {
                    Console.WriteLine("Питомец недоволен");
                    StrikePointsEat++;

                    if(StrikePointsEat >= 3)
                    {
                        Console.WriteLine("Зря вы не покормили питомца!");
                        GetIll();
                    }
                    else
                    {
                        Console.WriteLine($"Уровень недовольства(еда): {StrikePointsEat}");
                    }
                }
                else if(UserChoise == 3)
                {
                    Environment.Exit(0);
                }
                System.Threading.Thread.Sleep(3000);
            }

            public void GetWalk(object sender, GameMechanics e)
            {
                Console.Clear();
                Console.WriteLine("Хозяин, я хочу на прогулку!\n 1 - Отпустить гулять, 2 - Игнорировать, 3 - Выход из приложения");
                int UserChoise = int.Parse(Console.ReadLine());

                if (UserChoise == 1)
                {
                    Console.WriteLine(e.Walk);
                }
                else if (UserChoise == 2)
                {
                    Console.WriteLine("Питомец недоволен");
                    StrikePointsWalk++;

                    if (StrikePointsWalk >= 3)
                    {
                        Console.WriteLine("Зря вы не погуляли с питомцем!");
                        GetIll();
                    }
                    else
                    {
                        Console.WriteLine($"Уровень недовольства(прогулки): {StrikePointsWalk}");
                    }
                }
                else if(UserChoise == 3)
                {
                    Environment.Exit(0);
                }
                System.Threading.Thread.Sleep(3000);
            }

            public void GetSleep(object sender, GameMechanics e)
            {
                Console.Clear();
                Console.WriteLine("Хозяин, я хочу спать!\n 1 - Уложить спать, 2 - Игнорировать, 3 - Выход из приложения");
                int UserChoise = int.Parse(Console.ReadLine());

                if (UserChoise == 1)
                {
                    Console.WriteLine(e.Sleep);
                }
                else if(UserChoise == 2)
                {
                    Console.WriteLine("Питомец недоволен");
                    StrikePointsSleep++;

                    if (StrikePointsSleep >= 3)
                    {
                        Console.WriteLine("Зря вы не дали питомцу поспать!");
                        GetIll();
                    }
                    else
                    {
                        Console.WriteLine($"Уровень недовольства(сон): {StrikePointsSleep}");
                    }
                }
                else if (UserChoise == 3)
                {
                    Environment.Exit(0);
                }

                System.Threading.Thread.Sleep(3000);
            }

            public void GetPlay(object sender, GameMechanics e)
            {
                Console.Clear();
                Console.WriteLine("Хозяин, поиграй со мной!\n 1 - Поиграть, 2 - Игнорировать, 3 - Выход из приложения");
                int UserChoise = int.Parse(Console.ReadLine());

                if (UserChoise == 1)
                {
                    Console.WriteLine(e.Play);
                }
                else if(UserChoise == 2)
                {
                    Console.WriteLine("Питомец недоволен");
                    StrikePointsPlay++;

                    if (StrikePointsPlay >= 3)
                    {
                        Console.WriteLine("Зря вы не поиграли с питомцем!");
                        GetIll();
                    }
                    else
                    {
                        Console.WriteLine($"Уровень недовольства(игры): {StrikePointsPlay}");
                    }
                }
                else if (UserChoise == 3)
                {
                    Environment.Exit(0);
                }
                System.Threading.Thread.Sleep(3000);
            }

            public void GetIll()
            {
                Console.Clear();
                Console.WriteLine("Питомец заболел!\n 1 - Будем лечить!\n 2 - Нет, он притворяется!");
                int UserChoise = int.Parse(Console.ReadLine());
                if(UserChoise == 1)
                {
                    Console.WriteLine("Питомец полностью здоров!\nВсе штрафы за плохой уход за питомцем обнулены");
                    StrikePointsEat = 0; 
                    StrikePointsWalk = 0; 
                    StrikePointsSleep = 0;
                    StrikePointsPlay = 0;
                }
                else
                {
                    Console.WriteLine("Дела плохи!");
                    HeDead();
                }
                System.Threading.Thread.Sleep(3000);

            }

            public void HeDead()
            {
                Console.WriteLine("He's Dead");
                Environment.Exit(0); 
            }
            
        }

        class GameMechanics : EventArgs
        {
            public string Feed { get; set; }
            public string Walk { get; set; }

            public string Sleep { get; set; }

            public string Play { get; set; }
        }

        class Gamer
        {
            public EventHandler<GameMechanics> NewGame;
            public void Game(GameMechanics e)
            {
                if (NewGame != null) { NewGame(this, e); }
            }
        }



        static void Main(string[] args)
        {
            Gamer Oleg = new Gamer();
            Tamagochi Cat = new Tamagochi();

            Oleg.NewGame += Cat.GetFeed;
            Oleg.NewGame += Cat.GetWalk;
            Oleg.NewGame += Cat.GetSleep;
            Oleg.NewGame += Cat.GetPlay;

            GameMechanics test = new GameMechanics { Feed = "Питомец накормлен" };
            GameMechanics test1 = new GameMechanics { Walk = "Питомец сходил на прогулку" };
            GameMechanics test2 = new GameMechanics { Sleep = "Питомец поспал" };
            GameMechanics test3 = new GameMechanics { Play = "С питомцем поиграли" };

            int GetAction;
            int TempForCheck=0;
            Random x = new Random();

            do
            {
                do
                {
                    GetAction = x.Next(1, 4); 
                } while (GetAction == TempForCheck);
                TempForCheck = GetAction;

                if(GetAction == 1) { Cat.GetFeed(Oleg,test); }
                else if(GetAction == 2) { Cat.GetWalk(Oleg, test1); }
                else if (GetAction == 3) { Cat.GetSleep(Oleg, test2); }
                else if (GetAction == 4) { Cat.GetPlay(Oleg, test3); }
                

            } while (true);

            
            
            
        }
    }
}
