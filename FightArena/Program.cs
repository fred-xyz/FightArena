using System;

namespace FightArena
{
    class Program
    {
        static void Main(string[] args)
        {
            karakterer kongfuharray = new karakterer();
            kongfuharray.Name_pop = "Kong Fu Harray";
            kongfuharray.Hp_pop = 120;
            kongfuharray.Attack_rating_min_pop = 2;
            kongfuharray.Attack_rating_max_pop = 3;
            //flat defence
            kongfuharray.Defence_rating_min_pop = 5;
            kongfuharray.Defence_rating_max_pop = 5;
            kongfuharray.Win_pop = 0;
            kongfuharray.Lost_pop = 0;

            karakterer superhundendino = new karakterer();
            superhundendino.Name_pop = "Super Hunden Dino";
            superhundendino.Hp_pop = 70;
            superhundendino.Attack_rating_min_pop = 6;
            superhundendino.Attack_rating_max_pop = 9;
            superhundendino.Defence_rating_min_pop = 2;
            superhundendino.Defence_rating_max_pop = 9;
            superhundendino.Win_pop = 0;
            superhundendino.Lost_pop = 0;

            karakterer hurtigkarl = new karakterer();
            hurtigkarl.Name_pop = "Hurtig Karl";
            hurtigkarl.Hp_pop = 90;
            //dont use the random to cause damage he have two attack
            hurtigkarl.Attack_rating_min_pop = 5;
            hurtigkarl.Attack_rating_max_pop = 2;
            //flat defence
            hurtigkarl.Defence_rating_min_pop = 3;
            hurtigkarl.Defence_rating_max_pop = 3;
            hurtigkarl.Win_pop = 0;
            hurtigkarl.Lost_pop = 0;

            karakterer giftgunner = new karakterer();
            giftgunner.Name_pop = "Gift Gunner";
            giftgunner.Hp_pop = 90;
            giftgunner.Attack_rating_min_pop = 1;
            giftgunner.Attack_rating_max_pop = 14;
            //flat defence
            giftgunner.Defence_rating_min_pop = 5;
            giftgunner.Defence_rating_max_pop = 5;
            giftgunner.Win_pop = 0;
            giftgunner.Lost_pop = 0;

            karakterer minimusenmikkel = new karakterer();
            minimusenmikkel.Name_pop = "Minimusen Mikkel";
            minimusenmikkel.Hp_pop = 40;
            //flatt damges
            minimusenmikkel.Attack_rating_min_pop = 9;
            minimusenmikkel.Attack_rating_max_pop = 9;
            //flat defence
            minimusenmikkel.Defence_rating_min_pop = 9;
            minimusenmikkel.Defence_rating_max_pop = 9;
            minimusenmikkel.Win_pop = 0;
            minimusenmikkel.Lost_pop = 0;

            karakterer kattentiger = new karakterer();
            //remenber he gits 3 hp hen he attacks
            kattentiger.Name_pop = "Katten Tiger";
            kattentiger.Hp_pop = 35;
            kattentiger.Attack_rating_min_pop = 3;
            kattentiger.Attack_rating_max_pop = 8;
            //flat defence
            kattentiger.Defence_rating_min_pop = 4;
            kattentiger.Defence_rating_max_pop = 4;
            kattentiger.Win_pop = 0;
            kattentiger.Lost_pop = 0;

            karakterer Gummigeden = new karakterer();
            Gummigeden.Name_pop = "Gummi Geden";
            Gummigeden.Hp_pop = 70;
            //flatt damges
            Gummigeden.Attack_rating_min_pop = 6;
            Gummigeden.Attack_rating_max_pop = 6;
            //flat defence
            Gummigeden.Defence_rating_min_pop = 8;
            Gummigeden.Defence_rating_max_pop = 8;
            Gummigeden.Win_pop = 0;
            Gummigeden.Lost_pop = 0;

            karakterer elgenegon = new karakterer();
            elgenegon.Name_pop = "Elgen Egon";
            elgenegon.Hp_pop = 90;
            elgenegon.Attack_rating_min_pop = 5;
            elgenegon.Attack_rating_max_pop = 12;
            //flat defence
            elgenegon.Defence_rating_min_pop = 4;
            elgenegon.Defence_rating_max_pop = 4;
            elgenegon.Win_pop = 0;
            elgenegon.Lost_pop = 0;

            Console.WriteLine("welcome to the fight arena");
            Console.WriteLine("the fight list looks like this for to night");
            Console.WriteLine("1st :Kong Fu Harray VS Super Hunden Dino");
            Console.WriteLine("2nd: Hurtig Karl VS Gift Gunner");
            Console.WriteLine("3th: Minimusen Mikkel VS Katten Tiger");
            Console.WriteLine("4th: Gummi Geden VS Elgen Egon");
            Console.WriteLine();

            // 1st fight
            Random random = new Random();
            //i dont get it. it chack the wile loop condisson but is dos no follo it
            while (kongfuharray.Hp_pop > 0 || superhundendino.Hp_pop > 0)
            {
                Console.WriteLine(kongfuharray.Name_pop + "attack");
                int damage_1 = random.Next(kongfuharray.Attack_rating_min_pop, kongfuharray.Attack_rating_max_pop);
                int defence_1 = random.Next(superhundendino.Defence_rating_min_pop, superhundendino.Defence_rating_max_pop);
                int totel_attack_damage_1 = damage_1 - defence_1;
                if (totel_attack_damage_1 < 0)
                {
                    totel_attack_damage_1 = 0;
                }
                Console.WriteLine("he dells " + totel_attack_damage_1 + " to " + superhundendino.Name_pop);
                superhundendino.Hp_pop = superhundendino.Hp_pop - totel_attack_damage_1;
                Console.WriteLine(superhundendino.Name_pop + " hp: " + superhundendino.Hp_pop);
                Console.ReadLine();

                Console.WriteLine(superhundendino.Name_pop + " attack");
                int damage_2 = random.Next(superhundendino.Attack_rating_min_pop, superhundendino.Attack_rating_max_pop);
                int defence_2 = random.Next(kongfuharray.Defence_rating_min_pop, kongfuharray.Defence_rating_max_pop);
                int totel_attack_damage_2 = damage_2 - defence_2;
                if (totel_attack_damage_2 < 0)
                {
                    totel_attack_damage_2 = 0;
                }
                Console.WriteLine("he dells " + totel_attack_damage_2 + " to " + kongfuharray.Name_pop);
                kongfuharray.Hp_pop = kongfuharray.Hp_pop - totel_attack_damage_2;
                Console.WriteLine(kongfuharray.Name_pop + " hp: " + kongfuharray.Hp_pop);
                Console.ReadLine();
            }

            if(kongfuharray.Hp_pop > 0)
            {
                Console.WriteLine(kongfuharray.Name_pop + "is the winner.");
                kongfuharray.Win_pop = +1;
                superhundendino.Lost_pop = +1;
             }
             else
             {
                Console.WriteLine(superhundendino.Name_pop + "is the winner.");
                superhundendino.Win_pop = +1;
                kongfuharray.Lost_pop = +1;

             }
        }
    }
}
