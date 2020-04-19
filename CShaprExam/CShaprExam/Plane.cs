using System;
using System.Collections.Generic;
using System.Text;

namespace TarasenkoCShaprExam
{
    class Plane
    {
        protected int CurSpeed; // Текущая скорость
        protected int CurHeight; // Текущая высота
        protected int PenaltyPoints; // Штрафные очки(общие)
        protected bool IsMaxSpeed; // Проверка не набрана ли макс скорость
        protected bool IsBegin; // проверка, начался ли полет
        protected List<Dispatcher> DispList; // для диспетчеров

        protected delegate void DelChange(int _speed, int _height);
        protected event DelChange EventChange;

        public Plane()
        {
            CurHeight = 0;
            CurHeight = 0;
            PenaltyPoints = 0;
            IsMaxSpeed = false;
            IsBegin = false;
            DispList = new List<Dispatcher>();
        }

        //public void AddDispatcher(string _name) Функция создания диспетчера, от которой я решил отказаться чтобы обеспечить сменяемость диспетчеров во время полета
        //{
        //    Dispatcher TestDisp = new Dispatcher(_name);
        //    EventChange += TestDisp.RecomHeight;
        //    DispList.Add(TestDisp);
        //    Console.WriteLine($"{_name} is added as new Dispatcher");
        //}

        public void PlaneFly()
        {
            Console.WriteLine($"Enter the name of the 1st Dispatcher: ");
            Dispatcher FirstD = new Dispatcher(Console.ReadLine());
            DispList.Add(FirstD);
            Console.WriteLine($"Enter the name of the 2nd Dispatcher: ");
            Dispatcher SecondD = new Dispatcher(Console.ReadLine());
            DispList.Add(SecondD);
            Console.WriteLine($"\nSo now all squad is ready and we can begin Simulation!\nLoading...");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            ConsoleKeyInfo UserKey;
            bool FirstDFlag = false;
            bool SecondDFlag = false;

            while (true)
            {
                UserKey = Console.ReadKey();

                if (!IsMaxSpeed && !FirstDFlag)
                {
                    EventChange += FirstD.RecomHeight; // подписали первого диспетчера на событие если летим вверх
                    FirstDFlag = true;
                }
                else if(IsMaxSpeed && !SecondDFlag)
                {
                    EventChange -= FirstD.RecomHeight; // летим вниз - отписали первого
                    EventChange += SecondD.RecomHeight; // подписали второго
                    SecondDFlag = true;
                }
                    
                if ((UserKey.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    if (UserKey.Key == ConsoleKey.RightArrow)
                        CurSpeed += 150;
                    else if (UserKey.Key == ConsoleKey.LeftArrow)
                        CurSpeed -= 150;
                    else if (UserKey.Key == ConsoleKey.UpArrow)
                        CurHeight += 500;
                    else if (UserKey.Key == ConsoleKey.DownArrow)
                        CurHeight -= 500;
                }
                else
                {
                    if (UserKey.Key == ConsoleKey.RightArrow)
                        CurSpeed += 50;
                    else if (UserKey.Key == ConsoleKey.LeftArrow)
                        CurSpeed -= 50;
                    else if (UserKey.Key == ConsoleKey.UpArrow)
                        CurHeight += 250;
                    else if (UserKey.Key == ConsoleKey.DownArrow)
                        CurHeight -= 250;
                }

                if(DispList.Count == 2 && CurSpeed >= 50) // Диспетчеры берут управление и полет начался
                {
                    if (!IsBegin)
                        Console.WriteLine($"The Simulation has begin!");
                    IsBegin = true;

                    EventChange(CurSpeed, CurHeight);

                    if(CurSpeed == 1000)
                    {
                        IsMaxSpeed = true;
                        Console.WriteLine($"Okay! You have reached maximum height! Now try to land the Plane!");
                    }
                    else if(IsMaxSpeed && CurSpeed <=50)
                    {
                        Console.WriteLine("\nThe Simulation is over! Good job!");
                        Console.WriteLine("\nDispatchers is counting the Penalty Points...");
                        System.Threading.Thread.Sleep(3000);

                        foreach(Dispatcher item in DispList)
                        {
                            PenaltyPoints += item.Penalty;
                            Console.WriteLine($"{item.Name}: {item.Penalty}");
                        }

                        Console.WriteLine($"Your Penalty Points score is: {PenaltyPoints}");
                        break; // выход из основного цикла
                    }
                }
                Console.WriteLine($"\nCurrent Speed : {CurSpeed} km/h Current Height : {CurHeight} m." );
            }
        }
    }
}
