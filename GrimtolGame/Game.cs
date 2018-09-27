using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrimtolGame
{
    public class Game
    {
        public List<Room> Rooms { get; set; }
        public Player CurrentPlayer { get; set; }

        public Game(int playerHealth = 100)
        {
            Rooms = new List<Room>();
            BuildRooms();
            CurrentPlayer = new Player(playerHealth);
        }

        void BuildRooms()
        {
            var room0 = new Room("The first room");
            var room1 = new Room("The second room");
            var room2 = new Room("The third room");
            var room3 = new Room("The fourth room");

            Rooms.Add(room0);
            Rooms.Add(room1);
            Rooms.Add(room2);
            Rooms.Add(room3);

            var item0 = new Item();

            room1.Items.Add(item0);
        }
    }
}
