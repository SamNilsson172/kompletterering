using System;

namespace komplttereing
{
    class Program
    {
        public static Enemy Slime() { return new Enemy("Slime", 100, 10, "Blooorg!"); }
        public static Enemy Troll() { return new Enemy("Troll", 100, 10, "Waaaa!"); }
        public static Enemy Spirit() { return new Enemy("Spirit", 100, 10, "Wooshhh!"); }

        static void Main(string[] args)
        {
            Npc David = new Npc("David", "Red", 39, "What a good day!");
            Npc Linda = new Npc("Linda", "Blond", 84, "According to all known laws of aviation, there is no way a bee should be able to fly. Its wings are too small to get its fat little body off the ground. The bee, of course, flies anyway because bees don't care what humans think is impossible.");
            Npc Jason = new Npc("Jason", "Black", 20, "My monsters are stronger than yours.");

            string[] hairColors = { "Blonde", "Brown", "Black" };
            Player p = new Player(TheGoodStuff.String(1, 16, false, "What is your name?"), hairColors[TheGoodStuff.Selection(hairColors, "What is your hair color?", 3)], TheGoodStuff.Integer("How old are you?"));
            p.Description();
            TheGoodStuff.ClickToContinue();

            string[] startingMonstersName = { "Slime", "Troll", "Spirit" };
            TheGoodStuff.StoreReturnMethods<Enemy>[] startingMonstersMeth = { Slime, Troll, Spirit };
            p.Catch(TheGoodStuff.Selection(startingMonstersName, "What monster would you like to start with?", 3, startingMonstersMeth));

            string[] options = { "Talk to people", "Fight monsters" };
            while (p.pets.array[0].Alive())
            {
                switch (TheGoodStuff.Selection(options, "What would you like to do?", 1))
                {
                    case 0:
                        switch (TheGoodStuff.generator.Next(0, 3))
                        {
                            case 0:
                                David.Description();
                                break;
                            case 1:
                                Linda.Description();
                                break;
                            case 2:
                                Jason.Description();
                                break;
                        }
                        TheGoodStuff.ClickToContinue();
                        break;

                    case 1:
                        Fight();
                        break;
                }
            }

            void Fight()
            {
                Pet player = p.pets.array[0];
                Enemy opponent = null;
                switch (TheGoodStuff.generator.Next(0, 2))
                {
                    case 0:
                        opponent = Slime();
                        break;

                    case 1:
                        opponent = Troll();
                        break;

                    case 2:
                        opponent = Spirit();
                        break;
                }

                bool caught = false;
                string[] options = { "Attack", "Catch" };
                while (opponent.Alive())
                {
                    player.Stats();
                    opponent.Stats();

                    switch (TheGoodStuff.Selection(options, "What would you like to do?", 2))
                    {
                        case 0:
                            player.Attack(opponent);
                            opponent.Attack(player);

                            if (player.hp <= 0)
                            {
                                p.pets.Remove(p.pets.array[0]);
                                if (p.pets.array.Length == 0)
                                {
                                    Console.WriteLine("You died!");
                                    TheGoodStuff.ClickToContinue();
                                    Environment.Exit(0);
                                }
                                player = p.pets.array[0];
                            }
                            if (opponent.hp <= 0)
                            {
                                Console.WriteLine("You won!");
                                player.IncreaseFriendship();
                                player.Heal();
                                TheGoodStuff.ClickToContinue();
                            }
                            break;

                        case 1:
                            opponent.Heal();
                            p.Catch(opponent);
                            caught = true;
                            TheGoodStuff.ClickToContinue();
                            break;
                    }
                    if (caught)
                        break;
                }
            }
        }
    }
}
