using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Location
    {
       
        static byte Action_ID;
        static byte ID_Description;
        static byte ID_Event;
        static Random Event = new Random();
        static Random random = new Random();
        static bool Cave_Found = false;

        public static void Forest(ref Hero player)
        {
            ID_Description = (byte)Event.Next(1, 4);
            switch (ID_Description)
            {
                case 1:
                    Console.WriteLine("\n\nВ этом лесу скрывается куча пропавших вещей как и их прошлые хозяева");
                    break;

                case 2:
                    Console.WriteLine("\n\nНикогда не знаешь кого встретишь в лесах: стаю сверепых волков или \nчудишь по-страшнее");
                    break;

                case 3:
                    Console.WriteLine("\n\nБродя по лесу, даже в одиночку, вас всегда будет сопровождать чей-то взгляд со спины");
                    break;
            }
            Events.Event1(player,20,8);
            Events.EventMahich(ref player, 4, "Крыса", false, 0, (byte)random.Next(3, 7), 1, 3, 15, 5, 0, 2);
            do
            {
                Console.WriteLine("\nВаши действия\n1) Вернуться в город\n2) Собрать трав\n3) Осмотреться в лесу");            
                Action_ID = Input.ByteInput(player);
            } while (Action_ID < 1 || Action_ID > 3);

            switch (Action_ID)
            {
                case 1:
                    City(ref player);
                    break;

                case 2:
                    Mechanics.Herbalism(player);
                    break;

                case 3:
                    Forest(ref player);
                    break;
            }
        }

        public static void City(ref Hero player)
        {
            ID_Description = (byte)Event.Next(1, 4);
            switch (ID_Description)
            {
                case 1:
                    Console.WriteLine("\n\nМесто где ключом бьет жизнь. Странники из близлижащих стран, знатные \nбогатые рода и вечно работающие крестьяне");
                    break;

                case 2:
                    Console.WriteLine("\n\nВ этой части города обычно все тихо и спокойно");
                    break;

                case 3:
                    Console.WriteLine("\n\nВсе тут по своему прекрасно, кроме наверное густой и тошнотворной вони \nв некоторых частях города");
                    break;
            }
            Events.Event1(player, 10, 8);
            Events.EventMahich(ref player, 10, "Крыса", false, 0, (byte)random.Next(3, 7), 1, 3, 15, 4, 0, 2);

            do
            {
                Console.WriteLine("\nВаши действия\n1) Пойти в ратушу\n2) Проведать рынок\n3) Заглянуть в таверну\n4) Выйти на поляну\n5) Пойти в лес");
                Action_ID = Input.ByteInput(player);
            } while (Action_ID < 1 || Action_ID > 5);

            switch (Action_ID)
            {
                case 1:
                    Town_hall(ref player);
                    break;

                case 2:
                    Market(ref player);
                    break;

                case 3:
                    Tavern(ref player);
                    break;

                case 4:
                    Field(ref player);
                    break;

                case 5:
                    Forest(ref player);
                    break;
            }
        }

        public static void Market(ref Hero player)
        {
            ID_Description = (byte)Event.Next(1, 4);
            switch (ID_Description)
            {
                case 1:
                    Console.WriteLine("\n\nШум торгов и крики зазывал первое что вы услышите блуждая по рынку.");
                    break;

                case 2:
                    Console.WriteLine("\n\n...Довольные улыбки покупателей и еще более довольные лица торговцев...");
                    break;

                case 3:
                    Console.WriteLine("\n\nНет лучше места в городе где можно продать \nсобранное добро, так и преобрести новое снаряжения.");
                    break;
            }

            Events.Event1(player, 5, 8);
            Events.EventMahich(ref player, 20, "Крыса", false, 0, (byte)random.Next(3, 7), 1, 3, 15, 4, 0, 2);

            do
            {
                Console.WriteLine("\nВаши действия\n1) Поговорить с торговцем\n2) Продать вещи\n3)Заглянуть в таверну\n4) Вернуться в центр города");            
                Action_ID = Input.ByteInput(player);
            } while (Action_ID < 1 || Action_ID > 4);

            switch (Action_ID)
            {
                case 1:
                    Dialogs.Treader(ref player);
                    break;

                case 2:
                    Mechanics.Trade(player);
                    break;
                case 3:
                    Tavern(ref player);
                    break;

                case 4:
                    City(ref player);
                    break;
            }
        }
        
        public static void Town_hall(ref Hero player)
        {
            ID_Description = (byte)Event.Next(1, 4);
            switch (ID_Description)
            {
                case 1:
                    Console.WriteLine("\n\nБолшие и просторные комнаты украшенные раритетными картинами и дорогой\n качественной мебелью");
                    break;

                case 2:
                    Console.WriteLine("\n\nВажные чины обсуждают проблемы города и способы их устранения");
                    break;

                case 3:
                    Console.WriteLine("\n\nСамое красвивое и чистое здания в этом городе");
                    break;
            }

            do
            {
                Console.WriteLine("\nВаши действия\n1) Поговорить с мэром\n2) Вернуться в центр города");            
                Action_ID = Input.ByteInput(player);
            } while (Action_ID < 1 || Action_ID > 2);

            switch (Action_ID)
            {
                case 1:
                    Dialogs.Mayor(ref player);
                    break;

                case 2:
                    City(ref player);
                    break;
            }
        }

        public static void Tavern(ref Hero player)
        {
            ID_Description = (byte)Event.Next(1, 4);
            switch (ID_Description)
            {
                case 1:
                    Console.WriteLine("\n\nЗдесь отмечают победы успешные торговцы, а заблудшие души ищут смысл на дне кружек");
                    break;

                case 2:
                    Console.WriteLine("\n\nХаризматичный бородатый трактирщик который за монету нопоит вас \nхолодной медовухой и затравит сто раз услышаную шутку от который пробивает \nна улыбку");
                    break;

                case 3:
                    Console.WriteLine("\n\nУютная и теплая атмосфера создается в этом месте, и даже надоедливый \nбард поющий что-то про чеканую монету не может испортить ее");
                    break;
            }


            do
            {
                Console.WriteLine("\nВаши действия\n1) Поговорить с трактирщиком\n2) ...\n3) Вернуться в центр города");            
                Action_ID = Input.ByteInput(player);
            } while (Action_ID < 1 || Action_ID > 3);

            switch (Action_ID)
            {
                case 1:
                    Dialogs.Host(ref player);
                    break;

                case 2:
                    //();
                    break;

                case 3:
                    City(ref player);
                    break;
            }
        }

        public static void Field(ref Hero player)
        {
            ID_Description = (byte)Event.Next(1, 4);
            switch (ID_Description)
            {
                case 1:
                    Console.WriteLine("\n\n");
                    break;

                case 2:
                    Console.WriteLine("\n\nПоляна поляной");
                    break;

                case 3:
                    Console.WriteLine("\n\nПоляна поляной");
                    break;
            }

            Events.Event1(player, 10, 8);
            Events.EventMahich(ref player, 5, "Крыса", false, 0, (byte)random.Next(3, 7), 1, 3, 15, 4, 0, 2);
            if (Quests.MayorQuest == 1)
            {
                do
                {
                    Console.WriteLine("\nВаши действия\n1) Отправиться в Долину\n2) Осмотреться\n3) Взойти на холм с виверной\n4) Вернуться в город");
                    Action_ID = Input.ByteInput(player);
                } while (Action_ID < 1 || Action_ID > 4);
                switch (Action_ID)
                {
                    case 1:
                        Valley(ref player);
                        break;

                    case 2:
                        Field(ref player);
                        break;

                    case 3:
                        Hill(ref player);
                        break;

                    case 4:
                        City(ref player);
                        break;
                }
            }
            else
            {
                do
                {
                    Console.WriteLine("\nВаши действия\n1) Отправиться в Долину\n2) Осмотреться\n3) Вернуться в город");
                    Action_ID = Input.ByteInput(player);
                } while (Action_ID < 1 || Action_ID > 3);
                switch (Action_ID)
                {
                    case 1:
                        Valley(ref player);
                        break;

                    case 2:
                        Field(ref player);
                        break;

                    case 3:
                        City(ref player);
                        break;
                }
            }
            switch (Action_ID)
            {
                case 1:
                    Valley(ref player);
                    break;

                case 2:
                    Field(ref player);
                    break;

                case 3:
                    Hill(ref player);
                    break;

                case 4:
                    City(ref player);
                    break;
            }
        }

        public static void Valley(ref Hero player)
        {
            ID_Description = (byte)Event.Next(1, 4);
            switch (ID_Description)
            {
                case 1:
                    Console.WriteLine("\n\nРайское место для различных травников и рыбаков");
                    break;

                case 2:
                    Console.WriteLine("\n\nЭти земли славяться своей плодородной почвой и крупными морскими обитателями");
                    break;

                case 3:
                    Console.WriteLine("\n\n\"Подозрительно плодородно\" - вот что говорят городские ученные");
                    break;
            }

            Events.EventMahich(ref player, 4, "Крыса", false, 0, (byte)random.Next(3, 7), 1, 3, 15, 4, 0, 2);
            Events.EventMahich(ref player, 20, "Скелет", false, 0, (byte)random.Next(2, 5), 1, 6, 30, 10, 0, 10);

            do
            {
                if (Cave_Found)
                    Console.WriteLine("\nВаши действия\n1) Искать пещеру \n2) Осмотреться\n3) Вернуться в город");
                else
                    Console.WriteLine("\nВаши действия\n1) Искать пещеру \n2) Осмотреться\n3) Вернуться в город");
            
                Action_ID = Input.ByteInput(player);
            } while (Action_ID < 1 || Action_ID > 3);

            switch (Action_ID)
            {
                case 1:
                    if (Cave_Found)
                        Cave(ref player);
                    else                    
                        CaveSearch(ref player);                    
                    break;

                case 2:
                    do
                    {
                        Console.WriteLine("\nДействия:\n1) Собрать траву \n2) Рыбачить\n3)Продолжить путь\n4) Вернуться в город");                    
                        Action_ID = Input.ByteInput(player);
                    } while (Action_ID < 1 || Action_ID > 4);

                    switch (Action_ID)
                    {
                        case 1:
                            Mechanics.Herbalism(player);
                            break;

                        case 2:
                            Mechanics.Fishing(player);
                            break;

                        case 3:
                            Valley(ref player);
                            break;

                        case 4:
                            City(ref player);
                            break;
                    }
                    break;

                case 3:
                    City(ref player);
                    break;
            }
        }

        private static void CaveSearch(ref Hero player)
        {
            byte chance = (byte)random.Next(1, 10);
            if (chance == 1)
            {
                Console.WriteLine("\n//Сообщение про пещеру");
                Cave_Found = true;
                Cave(ref player);
            }
            else
            {
                Events.EventMahich(ref player, 4, "Крыса", false, 0, (byte)random.Next(3, 7), 1, 3, 15, 5, 0, 2);
                do
                {
                    Console.WriteLine("\nНе удалосьнайти все такое, повторить - 1, нет - 2");                
                    Action_ID = Input.ByteInput(player);
                } while (Action_ID < 1 || Action_ID > 2);

                switch (Action_ID)
                {
                    case 1:
                        CaveSearch(ref player);
                        break;

                    case 2:
                        Valley(ref player);
                        break;
                }
            }
        }

        public static void Cave(ref Hero player)
        {
            ID_Description = (byte)Event.Next(1, 4);
            switch (ID_Description)
            {
                case 1:
                    Console.WriteLine("\n\nОписание пещеры");
                    break;

                case 2:
                    Console.WriteLine("\n\nОписание пещеры");
                    break;

                case 3:
                    Console.WriteLine("\n\nОписание пещеры");
                    break;
            }

            Events.EventMahich(ref player, 2, "Скелет", false, 0, (byte)random.Next(2, 5), 1, 6, 30, 10, 0, 10);

            CallFight(ref player, "пАжилой Крыс", false, 0, 1, 1, 3, 100, 10, 0, 0);
            Game.Final();
        }

        public static void Hill(ref Hero player)
        {
            if(Quests.MayorQuest==1)
                Console.WriteLine("\nНа холме вы видите ту виверну что просил убить мэр. Сейчас она спит.");
            else
                Console.WriteLine("\nНа холме вы видите виверну. Сейчас она спит.");
            Console.WriteLine("\nВаши действия\n1) Атаковать\n2) Спуститься с холма");

            do
            {
                Action_ID = Input.ByteInput(player);
            } while (Action_ID < 1 || Action_ID > 2);
            switch (Action_ID)
            {
                case 1:
                    CallFight(ref player, "Виверна", false, 0, 1, 1, 5, 75, 10, 0, 50);
                    Field(ref player);
                    break;

                case 2:
                    Field(ref player);
                    break;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static void CallFight(ref Hero player, string EnemyName, bool EnemyMage, byte EnemySpells, byte EnemyQT, byte EnemyLVL, byte EnemySP, byte EnemyHP, byte EnemyAtt, byte EnemyMana, double GetingExp)
        {
            double max_hp = player.MAX_HP, max_mp = player.mp, att = player.att, ar = player.ar, exp = player.exp, HP = player.hp, MP = player.mp;
            byte lvl = player.lvl;
            int LvlUp = player.ExpToLvl;

            Battle.Fight(ref player, EnemyName, EnemyMage, EnemySpells, EnemyQT, EnemyLVL, EnemySP, player.cl, ref MP, ref exp, player.att, player.sp, player.ar, EnemyHP, EnemyAtt, EnemyMana, GetingExp);
            player.hp = HP; player.mp = MP; player.exp = exp;

            while (player.exp >= player.ExpToLvl)
            {
                Levels.LvlUp(ref exp, ref LvlUp, ref max_hp, ref max_mp, ref att, ref ar, ref lvl);
                player.MAX_HP = player.hp = max_hp; player.mp = player.MAX_MP = max_mp;
                player.exp = exp; player.ExpToLvl = LvlUp; player.lvl = lvl;
                player.att = att; player.ar = ar;
            }
        }

    }
}
