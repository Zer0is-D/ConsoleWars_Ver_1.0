using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Input
    {
        static string[] KeyWords = new string[] { "save", "сохранить", "stat", "стат", "exit", "выход", "load", "загрузить" };
        

        public static char CharInput()
        {
            char x; string str;
            do
            {
                str = Console.ReadLine();
            } while (!char.TryParse(str, out x));
            return x;
        }
        
        
        //int
        public static int IntInput()
        {
            int x;
            string str;
            do
            {
                str = Console.ReadLine();
            } while (!int.TryParse(str, out x));
            return x;
        }

        public static uint UIntInput()
        {
            uint x;
            string str;
            do
            {
                str = Console.ReadLine();
            } while (!uint.TryParse(str, out x));
            return x;
        }


        //short
        public static short ShortInput()
        {
            short x;
            string str;
            do
            {
                str = Console.ReadLine();
            } while (!short.TryParse(str, out x));
            return x;
        }

        public static ushort UShortInput()
        {
            ushort x;
            string str;
            do
            {
                str = Console.ReadLine();
            } while (!ushort.TryParse(str, out x));
            return x;
        }


        //byte
        public static byte ByteInput(Hero player)
        {
            byte x;
            string str;
            do
            {
                str = Console.ReadLine();
            } while (!byte.TryParse(str, out x)&&!CheckKey(str));

            if (CheckKey(str))
            {
                Act(str,player);
                return 0;
            }
            return x;
        }

        public static byte SimpleByteInput()
        {
            byte x;
            string str;
            do
            {
                str = Console.ReadLine();
            } while (!byte.TryParse(str, out x) );           
            return x;
        }

        public static sbyte SByteInput()
        {
            sbyte x;
            string str;
            do
            {
                str = Console.ReadLine();
            } while (!sbyte.TryParse(str, out x));
            return x;
        }


        //дробные
        public static float FloatInput()
        {
            float x;
            string str;
            do
            {
                str = Console.ReadLine();
            } while (!float.TryParse(str, out x));
            return x;
        }

        public static double DoubleInput()
        {
            double x;
            string str;
            do
            {
                str = Console.ReadLine();
            } while (!double.TryParse(str, out x));
            return x;
        }


        public static ulong ULongInput()
        {
            ulong x;
            string str;
            do
            {
                str = Console.ReadLine();
            } while (!ulong.TryParse(str, out x));
            return x;
        }


        public static bool CheckKey(string str)
        {
            bool ans=false;
            for(byte i = 0; i < KeyWords.Length&&!ans; i++)
            {
                ans = KeyWords[i] == str;
            }
            return ans;
        }


        public static void Act(string str,Hero player)
        {
            if (str == KeyWords[0] || str == KeyWords[1])
                Game.Save(player);

            if (str == KeyWords[2] || str == KeyWords[3])
                player.Stat();

            if (str == KeyWords[4] || str == KeyWords[5])
                Environment.Exit(0);

            if (str == KeyWords[6] || str == KeyWords[7])
                Game.Load(player);
        }
    }
}
