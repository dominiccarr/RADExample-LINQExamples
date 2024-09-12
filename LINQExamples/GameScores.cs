using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    public class GameScore
    {
        public string ScoreID { get; set; } // Key Field
        public string GameID { get; set; }
        public string PlayerID { get; set; }
        public int score { get; set; }

        public override string ToString()
        {
            return String.Concat(new string[]
                            {" Game ID ", GameID," Player ID ",
                                PlayerID, " Score ",score.ToString() });
        }
    }
}
