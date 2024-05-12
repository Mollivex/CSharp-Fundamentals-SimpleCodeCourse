using System;
using System.Collections.Generic;
using System.Linq;

/*
 * 
 *  Nested Loops
 * 
 * #SimpleCode_megaEXAMPLE #2 (NOT COMPLETE!)
 * 
 */

namespace MyProject_24
{
    class Program
    {
        public static object GameType { get; private set; }

        static void Main(string[] args)
        {
            var gamesInfo = GetGamesInfo();

            for (int i = 0; i < gamesInfo.Count; i++)
            {
                Console.WriteLine($"{gamesInfo[i].TypeOfGame}:");

                for (int j = 0; j < gamesInfo[i].Games.Count; j++)
                {
                    Console.WriteLine($"{gamesInfo[i].Games[j].Name}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static List<GameInfo> GetGamesInfo()
        {
            return new List<GameInfo>()
            {
                new GameInfo()
                {
                    TypeOfGame = GameType.RPG,
                    GetGamesInfo = new List<Game>()
                    {
                        new Game() { Name = "Fallout 4" },
                        new Game() { Name = "Gothic 2" },
                        new Game() { Name = "The Elder Scrolls 3: Morrowind" },
                    }
                },
                new GameInfo()
                {
                    TypeOfGame = GameType.Strategy,
                    Games = new List<Game>()
                    {
                        new Game() { Name = "Civilization VI" },
                        new Game() { Name = "Rome: Total War" },
                        new Game() { Name = "Starcraft II" },
                    }
                },
                new GameInfo()
                {
                    TypeOfGame = GameType.Shooter,
                    Games = new List<Game>()
                    {
                        new Game() { Name = "Doom" },
                        new Game() { Name = "Call of Duty 2" },
                        new Game() { Name = "Counter-Strike Source" },
                    }
                }
            };
        }
    }
}
