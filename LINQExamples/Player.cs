using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

public class Player
{
    public string playerId; // Key Field
    public int XP { get; set; }

    public int randchange;
    public string GamerTag { get; set; }
    public string firstName { get; set; }
    public string secondName { get; set; }

    public override string ToString()
    {
        return String.Format(" XP {0} Gamer Tag {1} firstname {2}", XP,GamerTag,firstName );
    }
}