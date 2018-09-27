using GrimtolGame;
using System;
using System.Linq;
using Xunit;

namespace GrimtolGameTests
{
    public class GrimtolUnitTests: IDisposable
    {
        Game game;

        public GrimtolUnitTests()
        {
            game = new Game();
        }

        [Fact]
        public void IsGame()
        {
            Assert.True(game.GetType() == typeof(Game));
        }

        [Fact]
        public void Player_Health_100_At_Start()
        {
            Assert.True(game.CurrentPlayer.Health == 100);
        }

        [Fact]
        public void Game_Has_4_Rooms()
        {
            Assert.True(game.Rooms.Count == 4);
        }

        [Fact]
        public void Room_1_Has_1_Item()
        {
            Assert.True(game.Rooms[1].Items.Count == 1);
        }

        [Fact]
        public void Room_1_Has_Key()
        {
            Assert.True(game.Rooms[1].Items[0].Name == "key");
        }

        [Theory]
        [InlineData(100, 100)]
        [InlineData(1000, 1000)]
        public void Player_Health_Passed_In(int startHealth, int expectedHealth)
        {
            Game g = new Game(startHealth);
            Assert.True(g.CurrentPlayer.Health == expectedHealth);
        }

        

        public void Dispose()
        {
            game = null;
        }
    }
}
