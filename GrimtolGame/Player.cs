using System.Collections.Generic;

namespace GrimtolGame
{
    public class Player
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public List<Item> Inventory { get; private set; }

        public Player(int health)
        {
            Health = health;
            Name = "Bob";
            Inventory = new List<Item>();
        }
    }
}