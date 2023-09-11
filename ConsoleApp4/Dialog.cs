using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Dialogs
    {
        /*
        Мэр 
        Торговец
        Трактирщик
        Рандомный гей
        */

        static byte Action_ID;

        public static void Mayor(ref Hero player)
        {
            Console.WriteLine("\n\nВаши действия\n1) Взять квест\n2) Узнать о ...\n3) Завершить разговор");
            do
            {
                Action_ID = Input.ByteInput(player);
            } while (Action_ID < 1 || Action_ID > 3);
            switch (Action_ID)
            {
                case 1:
                    Console.WriteLine("\nСЛЫШЬ УБЕЙ ВЕНУ!!");
                    Quests.MayorQuest = 1;
                    Mayor(ref player);
                    break;

                case 2:
                    // Узнать о ...
                    /*Console.WriteLine("Узнать о ...: \n1) СУКА ТЫ КТО??? \n2) СУКА Я ГДЕ??? ...\n3) Я ВЫШЕЛ БЛЕАТЬ");
                    //Action_ID = Input.ByteInput();
                    switch (Action_ID)
                    {
                        case 1:
                            Console.WriteLine("");
                            break;

                        case 2:
                            Console.WriteLine("");
                            break;

                        case 3:
                            Mayor();
                            break;
                    }*/
                    break;

                case 3:
                    Location.Town_hall(ref player);
                    break;
            }
        }

        public static void Treader(ref Hero player)
        {
            Console.WriteLine("\n\nВаши действия\n1) Взять квест\n2) Узнать о ...\n3) Завершить разговор");
            do
            {
                Action_ID = Input.ByteInput(player);
            } while (Action_ID < 1 || Action_ID > 3);
            switch (Action_ID)
            {
                case 1:
                    //Квест
                    break;

                case 2:
                    // Узнать о ...
                    /*Console.WriteLine("Узнать о ...: \n1) СУКА ТЫ КТО??? \n2) СУКА Я ГДЕ??? ...\n3) Я ВЫШЕЛ БЛЕАТЬ");
                    //Action_ID = Input.ByteInput();
                    switch (Action_ID)
                    {
                        case 1:
                            Console.WriteLine("");
                            break;

                        case 2:
                            Console.WriteLine("");
                            break;

                        case 3:
                            Mayor();
                            break;
                    }*/
                    break;

                case 3:
                    Location.Market(ref player);
                    break;
            }
        }

        public static void Host(ref Hero player)
        {
            Console.WriteLine("\n\nВаши действия\n1) Взять квест\n2) Узнать о ...\n3) Завершить разговор");
            do
            {
                Action_ID = Input.ByteInput(player);
            } while (Action_ID < 1 || Action_ID > 3);
            switch (Action_ID)
            {
                case 1:
                    //Квест
                    break;

                case 2:
                    // Узнать о ...
                    /*Console.WriteLine("Узнать о ...: \n1) СУКА ТЫ КТО??? \n2) СУКА Я ГДЕ??? ...\n3) Я ВЫШЕЛ БЛЕАТЬ");
                    //Action_ID = Input.ByteInput();
                    switch (Action_ID)
                    {
                        case 1:
                            Console.WriteLine("");
                            break;

                        case 2:
                            Console.WriteLine("");
                            break;

                        case 3:
                            Mayor();
                            break;
                    }*/
                    break;

                case 3:
                    Location.Tavern(ref player);
                    break;
            }
        }

        public static void Random_gay(ref Hero player)
        {
            Console.WriteLine("\nВаши действия\n1) Взять квест\n2) Узнать о ...\n3) Завершить разговор");
            do
            {
                Action_ID = Input.ByteInput(player);
            } while (Action_ID < 1 || Action_ID > 3);
            switch (Action_ID)
            {
                case 1:
                    //Квест
                    break;

                case 2:
                    // Узнать о ...
                    /*Console.WriteLine("Узнать о ...: \n1) СУКА ТЫ КТО??? \n2) СУКА Я ГДЕ??? ...\n3) Я ВЫШЕЛ БЛЕАТЬ");
                    //Action_ID = Input.ByteInput();
                    switch (Action_ID)
                    {
                        case 1:
                            Console.WriteLine("");
                            break;

                        case 2:
                            Console.WriteLine("");
                            break;

                        case 3:
                            Mayor();
                            break;
                    }*/
                    break;

                case 3:
                    Location.Town_hall(ref player);
                    break;
            }
        }
    }
}
