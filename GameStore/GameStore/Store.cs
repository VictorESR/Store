using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class Store
    {
        int maxGames = 4;
        List<Game> showcase = new List<Game>();

        public Store()
        {
            showcase.Add(new Game("Daddy simulator", 15f, "How to dad", "real-life"));
            showcase.Add(new Game("HalfLife 3", 10000f, "Best game never", "sci-fi"));
            showcase.Add(new Game("Hat in Time", 20f, "Super cute", "3D platformer"));
        }

        public void AddGame(Game game)
        {
            if (showcase.Count < maxGames)
                showcase.Add(game);
        }

        public void RemoveGame(Game game)
        {
            if (showcase.Contains(game))
                showcase.Remove(game);
        }

        public void Sell(Game game, User user)
        {
            if (user.wallet >= game.price)
            {
                user.wallet = user.wallet - game.price;
                user.libary.Add(game);
                RemoveGame(game);
            }
            else
            Console.WriteLine("Not enough money!");
        }
    }

    class User
    {
        public float wallet;
        public List<Game> libary = new List<Game>();

        public User(float walletFunds)
        {
            wallet = walletFunds;
        }
    }







        
        money
        Showcase
        Search
        
        public bool Sold;  
        removeGame
        if(Sold == true){delete this shit}
    

    class Game
    {
        public string genre;
        public string name;
        public string description;
        public float price;

        public Game(string name, float price, string description, string genre)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.genre = genre;
        }
    }
}
