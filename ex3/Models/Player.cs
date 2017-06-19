using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ex3.Models
{
    public class Player
    {
        public string userName { get; set; }
        public int winCount { get; set; }
        public int loseCount { get; set; }

        public Player(string inputUserName)
        {
            this.userName = inputUserName;
            this.winCount = 0;
            this.loseCount = 0;
        }

        public void wonAGame()
        {
            this.winCount++;
        }
        public void loseAGame()
        {
            this.loseCount++;
        }
    }
}