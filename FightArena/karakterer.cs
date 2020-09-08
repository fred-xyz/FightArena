using System;
using System.Collections.Generic;
using System.Text;

namespace FightArena
{
    class karakterer
    {
        private string name;
        private int hp;
        private int attack_rating_min;
        private int attack_rating_max;
        private int defence_rating_min;
        private int defence_rating_max;
        private int win;
        private int lost;

        public string Name_pop
        {
            get { return name; }
            set { name = value; }
        }
        public int Hp_pop
        {
            get { return hp; }
            set { hp = value; }
        }
        public int Attack_rating_min_pop
        {
            get { return attack_rating_min; }
            set { attack_rating_min = value; }
        }
        public int Attack_rating_max_pop
        {
            get { return attack_rating_max; }
            set { attack_rating_max = value; }
        }
        public int Defence_rating_min_pop
        {
            get { return defence_rating_min; }
            set { defence_rating_min = value; }
        }
        public int Defence_rating_max_pop
        {
            get { return defence_rating_max; }
            set { defence_rating_max = value; }
        }
        public int Win_pop
        {
            get { return win; }
            set { win = value; }
        }
        public int Lost_pop
        {
            get { return lost; }
            set { lost = value; }
        }
    }

    /*public karakterer(string name, int hp, int attack_rating_min, int attack_rating_max, int defence_rating, int win, int lost)
    {
        name = "";
        hp = 1;
        attack_rating_min = 1;
        attack_rating_max = 2;
        defence_rating = 1;
        win = 0;
        lost = 0;
    }*/

}
