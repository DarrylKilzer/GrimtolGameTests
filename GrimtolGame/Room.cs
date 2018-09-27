using System.Collections.Generic;

namespace GrimtolGame
{
    public class Room
    {
        public string Description { get; private set; }
        public List<Item> Items { get; private set; }

        public Room(string description)
        {
            Description = description;
            Items = new List<Item>();
        }
    }
}