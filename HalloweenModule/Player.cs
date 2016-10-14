using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenModule
{
    public class PlayerFactory
    {
        List<Player> players = new List<Player>();
        public Player createPlayer()
        {
            Player p = new Player();
            players.Add(p);
            return p;
        } 
        public void stopAll()
        {
            foreach (Player p in players)
            {
                p.stop();
            }
        }
    }
    public class Player
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        event EventHandler EndOfStream;
        public Player()
        {
            wplayer.EndOfStream += Wplayer_EndOfStream;

        }

        private void Wplayer_EndOfStream(int Result)
        {
            EndOfStream.Invoke(this, null);
        }

        public void play(string file)
        {
            wplayer.URL = file;
            wplayer.controls.play();
        }
        internal void stop()
        {
            wplayer.controls.stop();
        }
    }
}
