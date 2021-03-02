using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public string NationalityNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<int> PurchasedGames { get; set; }

    }
}
