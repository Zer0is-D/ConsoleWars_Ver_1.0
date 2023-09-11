using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Events
    {
        public static byte action_id;
        static byte ID_Event;
        static Random random = new Random();

        public static byte Event1(Hero player, byte chance, byte MaxMoney)
        {
            ID_Event = (byte)random.Next(1, chance);

            if (ID_Event == 1)
            {
                byte Coin = (byte)random.Next(3, MaxMoney);
                Thread.Sleep(750);
                Console.WriteLine("\n\"Кошель на дороге\" \n\nВы нашли кошель с {0} монетами", Coin);
                Console.WriteLine("1 - взять кошель\n2 - пройти мимо");
                do
                {
                    action_id = Input.ByteInput(player);
                } while (action_id < 1 || action_id > 2);
                switch (action_id)
                {
                    case 1:
                        Game.ChangeColor("\nВы берете кошель себе, деньги всяко пригодяться.\n\n", '+' + Coin.ToString(), "\n", ConsoleColor.Yellow);
                        return Coin;

                    case 2:
                        Console.WriteLine("\nВы проходите мимо кошеля с монетами, вы же не ниший чтобы подбирать деньги с земли.");
                        return 0;
                }
            }

            return 0;
        }

        public static void EventMahich(ref Hero player, byte chance, string EnemyName, bool EnemyMage, byte EnemySpells, byte EnemyQT, byte EnemyLVL, byte EnemySP, byte EnemyHP, byte EnemyAtt, byte EnemyMana, double GetingExp)
        {
            ID_Event = (byte)random.Next(1, chance);
            if (ID_Event == 1)
            {
                Location.CallFight(ref player, EnemyName, EnemyMage, EnemySpells, EnemyQT, EnemyLVL, EnemySP, EnemyHP, EnemyAtt, EnemyMana, GetingExp);
            }
        }

        public static int Event3(Hero player)
        {


            return 0;
        }

        public static int Event4(Hero player)
        {
            return 0;
        }

        public static int Event5(Hero player)
        {
            return 0;
        }
    }
}
