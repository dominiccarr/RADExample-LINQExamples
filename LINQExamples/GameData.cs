using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    public class GameData
    {
        public string GameID { get; set; } // Key Field
        public string GameName { get; set; }

        public override string ToString()
        {
            return String.Concat(" Game Name ", GameName);
        }
    }
}
