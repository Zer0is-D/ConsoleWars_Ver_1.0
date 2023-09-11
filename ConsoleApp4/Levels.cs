using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Levels
    {
        public static double EXP(double PlayerExp, double ExpPlus)
        {
            return PlayerExp + ExpPlus;
        }

        public static void LvlUp(ref double exp, ref int ExpToLvl, ref double MaxHp, ref double MaxMp, ref double Att, ref double Ar, ref byte Lvl)
        {
            if (exp >= ExpToLvl)
            {
                exp -= ExpToLvl;
                ExpToLvl += 10;
                MaxHp += 5;
                MaxMp += 10;
                Att++;
                Ar++;
                Lvl++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nВы получили {0} уровень.\nЗдоровье - {1}.\nМана - {2}.\nНаносимый урон - {3}.\nЗащита - {4}\n\nТекущее количество опыта {6}\nДля следующего уровня нужно набрать {5} очков опыта\n\n", Lvl,MaxHp,MaxMp,Att,Ar,ExpToLvl,exp);
                Console.ForegroundColor = ConsoleColor.White;                
            }
        }
    }
}
