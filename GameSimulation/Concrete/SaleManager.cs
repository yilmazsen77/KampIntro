using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Add(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Gamer name: " + gamer.Name + "  Product name: " + game.Name +
                "  Campaign name: " + campaign.Name + " added.");
        }

        public void Delete(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Gamer name: " + gamer.Name, "Product name: "
                + game.Name, "Campaign name: " + campaign.Name + "deleted.");
        }

        public void Update(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Gamer name: " + gamer.Name, "Product name: "
                + game.Name, "Campaign name: " + campaign.Name + "updated.");
        }
    }
}
