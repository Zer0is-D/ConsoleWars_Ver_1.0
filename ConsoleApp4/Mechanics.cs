using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Mechanics
    {
        static Random random = new Random();
        static public int[] N = new int[3];

        public static void Herbalism(Hero player)
        {

            if ((player.Herbs.Sum()) < 10)
            {
                for (byte i = 0; i < player.Herbs.Length; i++)
                {
                    N[i] = (byte)random.Next(0, 5 - i);
                    if ((player.Herbs.Sum() + N[i]) > 10)
                        N[i] = 10 - player.Herbs.Sum();
                    player.Herbs[i] += N[i];
                }

                if (N[0] > 0)
                    Console.WriteLine($"\nВы нашли одуванчик X{N[0]}");
                if (N[1] > 0)
                    Console.WriteLine($"\nВы нашли подорожник X{N[1]}");
                if (N[2] > 0)
                    Console.WriteLine($"\nВы нашли женьшенень X{N[2]}");
            }
            else
                Console.WriteLine("\nВы не можете нести больше 10 трав");

            Location.Forest(ref player);
        }
        

        public static void Fishing(Hero player)
        {
            byte chance = (byte)random.Next(1, 10);
            byte fish = (byte)random.Next(1, 20);          
            if (player.Fishes.Sum() < 3)
            {
                if (fish < 11 && chance == 1)
                { player.Fishes[0]++; Console.WriteLine("\nВы поймали "); }
                else if (fish < 17)
                { player.Fishes[1]++; Console.WriteLine("\nВы поймали "); }
                else
                { player.Fishes[2]++; Console.WriteLine("\nВы поймали "); }
            }
            else
                Console.WriteLine("Вы не можете нести больше 3 рыб");
            Location.Valley(ref player);
        }

        public static void Trade(Hero player)
        {
            byte CostHerb = 5, CostFish = 20;
            ushort Sum = 0;

            for (byte i = 0; i < player.Herbs.Length; i++)
            {
                Sum += (ushort)(player.Herbs[i] * CostHerb + player.Fishes[i] * CostFish);
                player.money += player.Herbs[i] * CostHerb + player.Fishes[i] * CostFish;
                CostHerb += 5; CostFish += 20;
                player.Herbs[i] = player.Fishes[i] = 0;
            }

            switch (Sum % 10)
            {
                case 1:
                    Console.WriteLine($"Вы заработали {Sum} монету");
                    break;

                case 2:
                    Console.WriteLine($"Вы заработали {Sum} монеты");
                    break;

                case 3:
                    Console.WriteLine($"Вы заработали {Sum} монеты");
                    break;

                case 4:
                    Console.WriteLine($"Вы заработали {Sum} монеты");
                    break;

                default:
                    Console.WriteLine($"Вы заработали {Sum} монет");
                    break;
            }
            Location.Market(ref player);
        }
    }
}
