using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Hero
    {
        public int ExpToLvl = 10;
        public int money;

        

        public int[] Herbs = new int[3];
        public int[] Fishes = new int[3];

        

        private double EXP=0;
        public double exp
        {
            get { return EXP; }
            set
            {
                if (value > 0)
                { EXP = value; }
            }
        }


        private byte LVL=1;
        public byte lvl
        {
            get { return LVL; }
            set
            {
                if (value > 0)
                { LVL = value; }
            }
        }


        public double hp;

        double MaxHP;
        public double MAX_HP
        {
            get { return MaxHP; }
            set
            {
                if (value > 0)
                    MaxHP = value;
            }
        }
        

        private double MP;
        public double mp
        {
            get { return MP; }
            set
            {
                if (value > 0)
                { MP = value; }
            }
        }

        double MaxMP;
        public double MAX_MP
        {
            get { return MaxMP; }
            set
            {
                if (value > 0)
                    MaxMP = value;
            }
        }


        private double ATT;
        public double att
        {
            get { return ATT; }
            set
            {
                if (value > 0)
                { ATT = value; }
            }
        }

        private double AR;
        public double ar
        {
            get { return AR; }
            set
            {
                if (value > 0)
                { AR = value; }
            }
        }

        private double SP;
        public double sp
        {
            get { return SP; }
            set
            {
                if (value > 0)
                { SP = value; }
            }
        }

        public string cl { get; set; }

        public string Name { get; set; }

        public void Stat()
        {
            //Console.WriteLine($"\n{Name}\n\nЗдоровье: {hp}/{MAX_HP}\nМана: {mp}/{MAX_MP}\nОпыт: {exp}/{ExpToLvl}\nУровень: {lvl}");
            //Console.WriteLine($"\n{Name} {Class.ChangeCl(cl)} {lvl} уровня\nЗдоровье: {hp}/{MAX_HP}\nМана: {mp}/{MAX_MP}\nОпыт: {exp}/{ExpToLvl}");
            Console.WriteLine($"\nИмя: {Name} \nКласс: {cl} {lvl} уровня\nЗдоровье: {hp}/{MAX_HP}\nМана:     {mp}/{MAX_MP}\nОпыт:     {exp}/{ExpToLvl}");
        }

        public string weapon { get; set; }
    }
}
