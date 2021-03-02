using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    public class GamerManager : IGamerService
    {

        IPersonValidation _personValidation;

        public GamerManager(IPersonValidation personValidation)
        {
            _personValidation = personValidation;
        }

        public void Add(Gamer gamer)
        {
            if (_personValidation.IsPerson(gamer))
            {
                Console.WriteLine("Gamer added.");
            }
            else
            {
                Console.WriteLine("Validation problem.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted.");

        }


        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated.");

        }
    }
}
