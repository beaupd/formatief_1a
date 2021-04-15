using System;
using System.Collections.Generic;
using System.Text;

namespace formatief_1a
{
    class Persoon
    {
        public string name;
        public double budget;
        public List<Game> games = new List<Game>();

        public Persoon(string nm, double bdgt)
        {
            this.name = nm;
            this.budget = bdgt;
        }
        
        public string getName()
        {
            return this.name;
        }
        public double getBudget()
        {
            return this.budget;
        }

        public void koop(Game game)
        {
            if (this.budget-game.nuPrijs() >= 0)
            {
                this.budget = this.budget - game.nuPrijs();
                games.Add(game);
                Console.WriteLine($"{this.name} koopt {game.getName()}: Gelukt \n Nieuw budget is {this.budget}\n");
            } else
            {
                Console.WriteLine($"{this.name} koopt {game.getName()}: Niet gelukt\n");
            }
        }
        public void verkoop(Game game, Persoon persoon)
        {
            if (persoon.getBudget() - game.nuPrijs() >= 0)
            {
                persoon.koop(game);
                this.budget += game.nuPrijs();
                this.games.Remove(game);
                Console.WriteLine($"{this.name} verkoopt aan {persoon.getName()}: Gelukt\n");
            } else
            {
                Console.WriteLine($"{this.name} verkoopt aan {persoon.getName()}: Niet gelukt\n");
            }
        }
        public void toString()
        {
            Console.WriteLine($"\n{this.name} heeft een budget van {this.budget} en bezit de volgende games:");
            foreach (var g in this.games)
            {
                g.toString();
            }
            Console.WriteLine("\n");
        }
    }
}
