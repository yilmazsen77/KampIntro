using GameSimulation.Adapters;
using GameSimulation.Concrete;
using GameSimulation.Entities;
using System;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(new Gamer
            {
                BirthDate = new DateTime(1989, 7, 31),
                Name = "a",
                LastName = "b",
                NationalityNumber = "1234"
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign
            {
                Id = 2,
                Name = "İndirim",
                Discount = 10
            });

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game
            {
                Id = 1,
                Name = "a",
                Price = 15
            });

            SaleManager salesManager = new SaleManager();
            salesManager.Add(new Gamer { Name = "a" }, new Game { Name = "b" }, new Campaign { Name = "İndirim" });
        }
    }
}
