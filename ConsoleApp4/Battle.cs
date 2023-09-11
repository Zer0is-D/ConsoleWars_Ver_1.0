using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp4
{
    class Battle
    {
        public static Random attack = new Random();

        //битва
        public static void Fight(ref Hero player, string EnemyName, bool EnemyMage, byte EnemySpells, byte EnemyQT, byte EnemyLVL, byte EnemySP, string CL, ref double PlayerMP, ref double PlayerExp, params double[] args
             /*double PlayerATT 0, double PlayerSP 1, double PlayerAR 2,
             double EnemyHP 3, double EnemyATT 4,double EnemyMageK 5,double ExpK 6*/)
        {
            byte BattleAct, AttQT;
            double enemyHP = args[3] * EnemyQT, Damage;
            int PlayerAttTime = 0, EnemyAttTime = 0;

            switch (EnemyQT)
            {
                case 1:
                    Console.WriteLine("\nНа вас напал {0}", EnemyName);
                    break;
                default:
                    Console.WriteLine("\nНа вас напали {0} {1}", EnemyQT, EnemyName);
                    break;
            }
            bool PlayerStep = false, EnemyStep = false, protect = false, FirstStep = true, Siebal = false;


            //первый ход за тем кто быстрее
            if (FirstStep)
            {
                FirstStep = false;
                if (player.sp >= EnemySP)
                {
                    PlayerStep = true; Console.WriteLine("Бой начинаеться с вашей атаки");
                }
                else
                {
                    EnemyStep = true; Console.WriteLine("Бой начинаеться с вражеской атаки");
                }
            }


            //дальнейшая битва
            
                while ((player.hp > 0) && (enemyHP > 0) && !Siebal)
                {
                    //ход игрока
                    while (PlayerStep && (player.hp > 0) && (enemyHP > 0)&&!Siebal)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        HpBar(player);
                        MpBar(player);
                        Console.ForegroundColor = ConsoleColor.Green;
                        protect = false;
                        Console.WriteLine("\nВаш ход\nВыберите действие:\n1) Атаковать\n2) Защищаться\n3) Сбежать");
                        do
                        {
                            BattleAct = Input.SimpleByteInput();
                        } while (BattleAct < 1 || BattleAct > 3);

                        switch (BattleAct)
                        {
                            case 1:
                                PlayerAttacking(EnemySP, args, ref enemyHP, out Damage, ref PlayerAttTime, ref EnemyAttTime, out PlayerStep, out EnemyStep);
                                break;
                            case 2:
                                PlayerDefense(out PlayerStep, out EnemyStep, out protect);
                                PlayerAttTime = 0; EnemyAttTime = 0;
                                break;
                            case 3:
                                Thread.Sleep(750);
                                Console.WriteLine("Вы сбегаете с поля боя");
                                Siebal = true;
                                break;
                        }
                    }

                    //ход противника
                    while (EnemyStep && (player.hp > 0) && (enemyHP > 0) && !Siebal)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nХод противника");
                        AttQT = (byte)attack.Next(1, EnemyQT);//кол-во атакующих врагов
                        Damage = (AttQT * args[4]) - attack.Next(0, 3);
                        switch (AttQT)
                        {
                            case 1:
                                Thread.Sleep(750);
                                Console.WriteLine("\nВас атаковал 1 противник");
                                break;
                            default:
                                Thread.Sleep(750);
                                Console.WriteLine("\nВас атаковало {0} противников", AttQT);
                                break;
                        }
                        Thread.Sleep(750);
                        EnemyAttacking(ref player, EnemySP, args, Damage, ref PlayerAttTime, ref EnemyAttTime, out PlayerStep, out EnemyStep, protect);
                    }
                }

                if (Siebal)
                    Console.WriteLine("ХАх ссыкло");
                //победа игрока
                if (enemyHP <= 0)
                {
                    
                    EnemyDefeat(EnemyName, EnemyQT, EnemyLVL, args);
                    PlayerExp += EnemyQT * EnemyLVL * args[6];
                    
                    Console.ReadKey();
                }

                //проигрыш игрока
                if (player.hp <= 0)
                {
                    
                    Thread.Sleep(750);
                    Console.WriteLine("Игрок терпит поражение");
                    Console.ReadKey();
                    Game.Main();
                }
            Console.ForegroundColor = ConsoleColor.White;
        }

        /*private static void SpecialAttack(string CL,Hero player)
        {
            Console.WriteLine("\nВыберите особое действие");
            switch (CL)
            {
                case "Мечник":
                    
                    break;

                case "Воин":
                    
                    break;

                case "Маг":

                    break;

                case "Разбойник":
                   
                    break;

                case "Лучник":
                    
                    break;
            }

            byte Spec = Input.SimpleByteInput();
            switch (CL)
            {
                case "Мечник":
                    switch (Spec)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                    }
                    break;
                case "Воин":
                    switch (Spec)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                    }
                    break;
                case "Маг":
                    switch (Spec)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                    }
                    break;
                case "Разбойник":
                    switch (Spec)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                    }
                    break;
                case "Лучник":
                    switch (Spec)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                    }
                    break;
            }
        }*/

        private static void PlayerDefense(out bool PlayerStep, out bool EnemyStep, out bool protect)
        {
            Thread.Sleep(750);
            Console.WriteLine("\nВы начинаете защащаться");
            protect = true;
            PlayerStep = false;
            EnemyStep = true;
        }

        private static void PlayerAttacking(byte EnemySP, double[] args, ref double enemyHP, out double Damage, ref int PlayerAttTime, ref int EnemyAttTime, out bool PlayerStep, out bool EnemyStep)
        {
            Thread.Sleep(750);
            Damage = args[0] + attack.Next(-2, 2);
            enemyHP -= Damage;
            Console.WriteLine("\nВы нанесли {0} урона", Damage);
            PlayerStep = AttTime(args[1], EnemySP, ref PlayerAttTime, ref EnemyAttTime);
            EnemyStep = !PlayerStep;
        }

        private static void EnemyAttacking(ref Hero player, byte EnemySP, double[] args, double Damage, ref int PlayerAttTime, ref int EnemyAttTime, out bool PlayerStep, out bool EnemyStep, bool protect)
        {
            if (!protect)
            {
                if ((Damage - args[2]) > 0)
                {
                    player.hp -= Damage - args[2];
                    Console.WriteLine("Вам нанесли {0} урона", Damage - args[2]);
                }
                else
                {
                    player.hp -= 0;
                    Console.WriteLine("Вам нанесли 0 урона");
                }
                PlayerStep = AttTime(args[1], EnemySP, ref PlayerAttTime, ref EnemyAttTime);
                EnemyStep = !PlayerStep;
            }
            else
            {
                if ((Damage - (2 * args[2])) > 0)
                {
                    player.hp -= Damage - (2 * args[2]);
                    Console.WriteLine("Вам нанесли {0} урона", Damage - 2 * args[2]);
                }
                else
                {
                    player.hp -= 0;
                    Console.WriteLine("Вам нанесли 0 урона");
                }
                PlayerStep = AttTime(args[1], EnemySP, ref PlayerAttTime, ref EnemyAttTime);
                EnemyStep = !PlayerStep;
            }
        }

        private static void EnemyDefeat(string EnemyName, byte EnemyQT, byte EnemyLVL, double[] args)
        {
            Thread.Sleep(750);
            switch (EnemyQT)
            {
                case 1:
                    Console.WriteLine("{0} терпит поражение. Игрок получает {1} ед. опыта", EnemyName, EnemyQT * EnemyLVL * args[6]);
                    break;
                default:
                    Console.WriteLine("{0} терпят поражение. Игрок получает {1} ед. опыта", EnemyName, EnemyQT * EnemyLVL * args[6]);
                    break;
            }
        }


        private static void HpBar(Hero player)
        {
            
            double part = player.MAX_HP / 10.0, c = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nHp: I");
            while (c <= player.MAX_HP)
            {
                if (c <= player.hp)
                    Game.ChangeColor("", "#", "", ConsoleColor.Green);
                else
                    Game.ChangeColor("", "#", "", ConsoleColor.Black);
                c += part;
            }
            
            Console.Write("I ");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        private static void MpBar(Hero player)
        {

            double part = player.MAX_MP / 10.0, c = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("MP: I");
            while (c <= player.MAX_HP)
            {
                if (c <= player.hp)
                    Game.ChangeColor("", "#", "", ConsoleColor.Blue);
                else
                    Game.ChangeColor("", "#", "", ConsoleColor.Black);
                c += part;
            }

            Console.Write("I\n ");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        //определяет чей ход
        public static bool AttTime(double PlayerSpeed, double EnemySpeed, ref int PlayerTimer, ref int EnemyTimer)
        {
            while (PlayerTimer < (100 / PlayerSpeed) && EnemyTimer < (100 / EnemySpeed))
            {
                PlayerTimer++; EnemyTimer++;
            }
            if (PlayerTimer >= (100 / PlayerSpeed)) { PlayerTimer = 0; return true; }
            else { EnemyTimer = 0; return false; }
        }
    }
}
