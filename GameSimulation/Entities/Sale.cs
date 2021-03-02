using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public List<int> GameId { get; set; }
        public string GamerId { get; set; }
        public DateTime TransactionTime { get; set; }
        public int CampaignId { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
