using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenModule
{
    public class Action
    {
        public string file { get; }
        public bool arD { get; }
        public bool arG { get; }
        public bool avD { get; }
        public bool avG { get; }
        public bool avC { get; }

        public Action(string file, bool arD, bool arG, bool avD, bool avG, bool avC)
        {
            this.file = file;
            this.arD = arD;
            this.arG = arG;
            this.avD = avD;
            this.avG = avG;
            this.avC = avC;
        }

        public void exec(PlayerFactory playerFactory)
        {
            Console.WriteLine("Exec " + file);
            if (avD)
            {
                Player player = playerFactory.createPlayer();
                player.play(file + "/avD.wav");
            }
            if (avG)
            {
                Player player = playerFactory.createPlayer();
                player.play(file + "/avG.wav");
            }
            if (avC)
            {
                Player player = playerFactory.createPlayer();
                player.play(file + "/avC.wav");
            }
            if (arD)
            {
                Player player = playerFactory.createPlayer();
                player.play(file + "/arD.wav");
            }
            if (arG)
            {
                Player player = playerFactory.createPlayer();
                player.play(file + "/arG.wav");
            }
        }
    }

    public class Sequence
    {
        public int time { get; }
        public List<Action> actions { get; }
        public Sequence(int time, List<Action> actions)
        {
            this.time = time;
            this.actions = actions;
        }
    }
}
