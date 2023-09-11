using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp4
{
    class Game
    {
        static Random rand = new Random();


        public static void Main()
        {
            if (!Directory.Exists("C:\\Games\\TextRPG"))
                Directory.CreateDirectory("C:\\Games\\TextRPG");
            
            Hero player = new Hero();           
            Quests.MAinQuest = 1;
            Console.ForegroundColor = ConsoleColor.White;

            byte Menu;
            Console.WriteLine("1 - Новая игра\n2 - Загрузка");
            do
            {
                Menu = Input.SimpleByteInput();
            } while (Menu < 1 || Menu > 2);

            switch (Menu)
            {
                case 1:
                    NewGame(player);
                    break;

                case 2:
                    Load(player);
                    Location.City(ref player);
                    break;
            }
            //Основная часть игры            
            Location.Forest(ref player);            
            Console.ReadKey();
        }

        private static void NewGame(Hero player)
        {
            player.cl = "";
            while (player.cl == "")
            {
                Console.WriteLine("\nВыберите класс вашего персонажа: Мечник, Воин, Маг, Разбойник, Лучник");
                player.cl = Console.ReadLine();
                player.cl = Class.ChangeCl(player.cl);
            }
            Class.ParamsOfHero(player, player.cl);
            ChangeColor("\nНазовитесь ", player.cl, ".\n", ConsoleColor.Blue);
            player.Name = Console.ReadLine();
        }

        public static void Final()
        {            
            for(ushort a=0;a<1000;a++)
            {
                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 16);
                Console.Write("Congratulations! ");
                Thread.Sleep(50);
            }
            Console.ReadKey();
            Environment.Exit(0);
        }

        public static void Save(Hero player)
        {
            File.Delete($"C:\\Games\\TextRPG\\Save.txt");
            File.Delete($"C:\\Games\\TextRPG\\SaveInventory.txt");

            File.AppendAllLines($"C:\\Games\\TextRPG\\Save.txt",
                new string[]
                {
                    player.Name, player.cl,
                    player.hp.ToString(), player.MAX_HP.ToString(),
                    player.mp.ToString(), player.MAX_MP.ToString(),
                    player.ar.ToString(), player.att.ToString(), player.sp.ToString(),
                    player.exp.ToString(), player.ExpToLvl.ToString(), player.lvl.ToString(),
                    Quests.InnkeepQuest.ToString(), Quests.MayorQuest.ToString(), Quests.TavernQuest.ToString(),
                });

            for(byte i = 0; i < player.Herbs.Length; i++)
            {
                File.AppendAllLines($"C:\\Games\\TextRPG\\SaveInventory.txt",
                new string[]
                {
                    player.Herbs[i].ToString(),player.Fishes[i].ToString()
                });
            }

            Console.WriteLine("\nПрогресс сохранен");
        }

        public static void Load(Hero player)
        {           
            string[] vs = File.ReadAllLines($"C:\\Games\\TextRPG\\Save.txt");
            player.Name = vs[0];
            player.cl =  vs[1];
            player.hp = Convert.ToDouble(vs[2]);
            player.MAX_HP = Convert.ToDouble(vs[3]);
            player.mp = Convert.ToDouble(vs[4]);
            player.MAX_MP = Convert.ToDouble(vs[5]);
            player.ar = Convert.ToDouble(vs[6]);
            player.att = Convert.ToDouble(vs[7]);
            player.sp = Convert.ToDouble(vs[8]);
            player.exp = Convert.ToDouble(vs[9]);
            player.ExpToLvl = Convert.ToInt32(vs[10]);
            player.lvl = Convert.ToByte(vs[11]);
            Quests.InnkeepQuest = Convert.ToSByte(vs[12]);
            Quests.MayorQuest = Convert.ToSByte(vs[13]);
            Quests.TavernQuest = Convert.ToSByte(vs[14]);
            string[] Inventory = File.ReadAllLines($"C:\\Games\\TextRPG\\SaveInventory.txt");
            byte one = 0;
            for (byte i = 0; i < player.Herbs.Length; i++)
            {
                player.Herbs[i] = Convert.ToInt32(Inventory[one]);
                player.Fishes[i] = Convert.ToInt32(Inventory[one + 1]);
                one += 2;
            }
        }

        public static void ChangeColor(string before,string str, string after, ConsoleColor id)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(before);
            Console.ForegroundColor = id;
            Console.Write(str);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(after);
        }
        /*      Цвета
               
                Console.Write("\nВыберите класс вашего персонажа: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Мечник");
                Console.ResetColor();
                Console.Write(", ");

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Воин");
                Console.ResetColor();
                Console.Write(", ");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Маг");
                Console.ResetColor();
                Console.Write(", ");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Разбойник");
                Console.ResetColor();
                Console.Write(", ");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Лучник");
         */
    }
}