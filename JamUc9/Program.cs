using GameLevels;
using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLevels
{
    class Program
    {
        static void Main(string[] args)
        {
            var link = new Game("Sword Nicolas  Online");
            //Player player = new Player(Game.Instance.HalfWidth, Game.Instance.HalfHeight, "shroom.png");

            //var levelOne = new Scene();
            //levelOne.Add(player);
            link.Start(new Game.GameLevels.LevelOne());
        }
    }
}
