using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    public class GameObjects
    {
        public static Random r = new Random();



        public List<Player> players = new List<Player>
        {
            new Player { playerId = Guid.NewGuid().ToString(),
                                         firstName = "Dominic",
                                         secondName = "Carr",
                                          GamerTag = "Post Dark",
                                             XP = 1000},

            new Player { playerId = Guid.NewGuid().ToString(),
                                         firstName = "Fred",
                                         secondName = "Flinstone",
                                          GamerTag = "Twinny",
                                             XP = 100},

            new Player { playerId = Guid.NewGuid().ToString(),
                                         firstName = "Margaret",
                                         secondName = "Muldooney",
                                          GamerTag = "Minny",
                                             XP = 600},
            new Player { playerId = Guid.NewGuid().ToString(),
                                         firstName = "Bill",
                                         secondName = "Bloggs",
                                          GamerTag = "Mahindy",
                                             XP = 250},
    };
        public List<GameData> games = new List<GameData>
        {
            new GameData
            {
                GameID = Guid.NewGuid().ToString(),
                GameName = "Gear Up"
            },
            new GameData
            {
                GameID = Guid.NewGuid().ToString(),
                GameName = "Game on"
            }
        };

        public List<GameScore> scores = new List<GameScore>();
        

        public GameObjects()
        {
            // Create the Game scores here as the Games and players will be created
            Random _randomScore = new Random();

            foreach (var g in games)
            {
                var randomPlayer = players
                        .Select(p => new { p.playerId, gid = Guid.NewGuid() })
                        .OrderBy(o => o.gid).Take(3).ToList();

                foreach (var p in randomPlayer)
                {
                    scores.Add(new GameScore
                    {
                        ScoreID = Guid.NewGuid().ToString(),
                        GameID = g.GameID,
                        PlayerID = p.playerId,
                        score = _randomScore.Next(5, 600)
                    });
                }

            }

        }
    }






}
