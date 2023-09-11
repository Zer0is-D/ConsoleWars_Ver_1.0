using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class
    {
        public static string ChangeCl ( string cl)
        {
            if ((cl=="мечник")|| (cl == "1") || (cl == "Мечник")) return "Мечник";
            if ((cl == "воин") || (cl == "2") || (cl == "Воин")) return "Воин";
            if ((cl == "маг") || (cl == "3") || (cl == "Маг")) return "Маг";
            if ((cl == "разбойник") || (cl == "4") || (cl == "Разбойник")) return "Разбойник";
            if ((cl == "лучник") || (cl == "5") || (cl == "Лучник")) return "Лучник";
            return "";
        }

        public static void ParamsOfHero(Hero player, string cl)
        {
            switch (cl)
            {
                case "Мечник":
                    Swordsman(player);
                    break;
                case "Воин":
                    Warrior(player);
                    break;
                case "Маг":
                    Mage(player);
                    break;
                case "Разбойник":
                    Rogue(player);
                    break;
                case "Лучник":
                    Archer(player);
                    break;
            }
        }

        private static void Archer(Hero player)
        {
            player.MAX_HP = player.hp = 40;
            player.MAX_MP = player.mp = 25;

            ChangeColors(new string[] { "Выберите оружие вашего персонажа:\n1) Корткий лук( ", "+5"," к скорости атаки)\n", }, 1,ConsoleColor.Green);
            ChangeColors(new string[] { "2) Длинный лук( ", "+1", " к атаке, ", "+1", " к скорсти атаки)\n"}, new int[] { 1, 3 }, ConsoleColor.Green);
            ChangeColors(new string[] { "3) Арбалет( ", "+3", " к атаке, ", "-1", " к скорости атаки и ", "+1", " к защите)" }, new int[] { 1, 3, 5 }, ConsoleColor.Green);

            do
            {
                player.weapon = Console.ReadLine();
            } while (player.weapon != "1" && player.weapon != "2" && player.weapon != "3");
            switch (player.weapon)
            {
                case "1":
                    player.att = 14;
                    player.sp = 7;
                    player.ar = 6;
                    player.weapon = "Корткий лук";
                    break;
                case "2":
                    player.att = 15;
                    player.sp = 6;
                    player.ar = 6;
                    player.weapon = "Длинный лук";
                    break;
                case "3":
                    player.att = 17;
                    player.sp = 4;
                    player.ar = 7;
                    player.weapon = "Арбалет";
                    break;
            }
        }

        private static void Rogue(Hero player)
        {
            player.MAX_HP = player.hp = 40;
            player.MAX_MP = player.mp = 25;
            Console.WriteLine("Выберите оружие вашего персонажа:\n1) Парные кинжалы(+3 к скорости атаки и +0,5 к защите)\n2) Короткий меч и щит(+1 к атаке, +1,5 к защите)\n3) Парные сабли(+3 к атаке, -2 к скорости атаки и +2 к защите)");
            do
            {
                player.weapon = Console.ReadLine();
            } while (player.weapon != "1" && player.weapon != "2" && player.weapon != "3");
            switch (player.weapon)
            {
                case "1":
                    player.att = 10;
                    player.sp = 9;
                    player.ar = 3.5;
                    player.weapon = "Кинжалы";
                    break;
                case "2":
                    player.att = 11;
                    player.sp = 6;
                    player.ar = 4;
                    player.weapon = "Короткий меч и щит";
                    break;
                case "3":
                    player.att = 13;
                    player.sp = 4;
                    player.ar = 5;
                    player.weapon = "Сабли";
                    break;
            }
        }

        private static void Mage(Hero player)
        {
            player.MAX_HP = player.hp = 30;
            player.MAX_MP = player.mp = 50;
            Console.WriteLine("Выберите оружие вашего персонажа:\n1) Волшебная палочка(-1 к атаке, +3 к скорости атаки и +0,5 к защите)\n2) Посох(+2 к атаке, +2 к защите)\n3) Книга заклинаний(+3 к атаке, -1 к скорости атаки и +1 к защите)");
            do
            {
                player.weapon = Console.ReadLine();
            } while (player.weapon != "1" && player.weapon != "2" && player.weapon != "3");
            switch (player.weapon)
            {
                case "1":
                    player.att = 5;
                    player.sp = 9;
                    player.ar = 2.5;
                    player.weapon = "Волшебная палочка";
                    break;
                case "2":
                    player.att = 8;
                    player.sp = 6;
                    player.ar = 4;
                    player.weapon = "Посох";
                    break;
                case "3":
                    player.att = 9;
                    player.sp = 5;
                    player.ar = 3;
                    player.weapon = "Книга заклинаний";
                    break;
            }
        }

        private static void Warrior(Hero player)
        {
            player.MAX_HP = player.hp = 50;
            player.MAX_MP = player.mp = 20;
            Console.WriteLine("Выберите оружие вашего персонажа:\n1) Меч и щит(+1 к атаке, +2 к защите)\n2) Топор и щит(+2 к атаке, +1 к защите)\n3) Цвайхандер(+5 к атаке, -2 к скорости атаки и +0,5 к защите)");
            do
            {
                player.weapon = Console.ReadLine();
            } while (player.weapon != "1" && player.weapon != "2" && player.weapon != "3");
            switch (player.weapon)
            {
                case "1":
                    player.att = 16;
                    player.sp = 5;
                    player.ar = 7;
                    player.weapon = "Меч и щит";
                    break;
                case "2":
                    player.att = 17;
                    player.sp = 5;
                    player.ar = 6;
                    player.weapon = "Топор и щит";
                    break;
                case "3":
                    player.att = 20;
                    player.sp = 3;
                    player.ar = 5.5;
                    player.weapon = "Цвайхандер";
                    break;
            }
        }

        private static void Swordsman(Hero player)
        {
            player.MAX_HP = player.hp = 45;
            player.MAX_MP = player.mp = 30;
            Console.WriteLine("Выберите оружие вашего персонажа:\n1) Рапира(+1 к атаке, +2 к скорости атаки и +0,5 к защите)\n2) Палаш(+2 к атаке, +1 к скорсти атаки и +1 к защите)\n3) Полуторный меч(+3 к атаке, -1 к скорости атаки и +1,5 к защите)");
            do
            {
                player.weapon = Console.ReadLine();
            } while (player.weapon != "1" && player.weapon != "2" && player.weapon != "3");
            switch (player.weapon)
            {
                case "1":
                    player.att = 12;
                    player.sp = 7;
                    player.ar = 4.5;
                    player.weapon = "Рапира";
                    break;
                case "2":
                    player.att = 13;
                    player.sp = 6;
                    player.ar = 5;
                    player.weapon = "Палаш";
                    break;
                case "3":
                    player.att = 14;
                    player.sp = 4;
                    player.ar = 5.5;
                    player.weapon = "Полуторный меч";
                    break;
            }
        }


        public static void ChangeColors(string[] texts, int[] chahgesPoint, ConsoleColor color)
        {
            int i = 0;
            for (int textNum = 0; textNum < texts.Length; textNum++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (i < chahgesPoint.Length)
                {
                    if (textNum == chahgesPoint[i])
                    {
                        Console.ForegroundColor = color;
                        i++;
                    }
                }
                Console.Write(texts[textNum]);
            }
        }
        public static void ChangeColors(string[] texts, int chahgesPoint, ConsoleColor color)
        {
            for (int textNum = 0; textNum < texts.Length; textNum++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (textNum == chahgesPoint)
                {
                    Console.ForegroundColor = color;
                }
                Console.Write(texts[textNum]);
            }
        }

        public static void ChangeColors2(string[] texts, string chahgesPoint, ConsoleColor color)
        {
            for (int textNum = 0; textNum < texts.Length; textNum++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (texts[textNum] == chahgesPoint)
                {
                    Console.ForegroundColor = color;
                }
                Console.Write(texts[textNum]);
            }
        }

    }
}
