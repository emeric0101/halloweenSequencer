using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloweenModule
{
    public class Effect
    {
        static int locationX = 100;
        static int locationY = 100;
        public Panel Panel { get; }
        CheckBox avD = new CheckBox();
        CheckBox avG = new CheckBox();
        CheckBox arD = new CheckBox();
        CheckBox arG = new CheckBox();
        CheckBox avC = new CheckBox();
        string file;

        public bool hasActions()
        {
            return arD.Checked || arG.Checked || avD.Checked || avG.Checked || avC.Checked;
        }
        public Action toAction()
        {
            return new Action(file, arD.Checked, arG.Checked, avD.Checked, avG.Checked, avC.Checked);
        }
        public Effect(string name, string file, PlayerFactory playerFactory)
        {
            this.file = file;
            Panel = new Panel();
            locationX += 25;
            locationY += 25;
            Panel.Size = new Size(200, 200);

            avD.Text = "Av D";
            avD.Location = new Point(10, 30);

            avG.Text = "Av G";
            avG.Location = new Point(10, 60);

            arD.Text = "Ar D";
            arD.Location = new Point(10, 90);

            arG.Text = "Ar G";
            arG.Location = new Point(10, 120);

            avC.Text = "Av C";
            avC.Location = new Point(10, 150);

            Button btn = new Button();
            btn = new Button();
            btn.Text = name;

            btn.Click += new EventHandler(delegate (object o, EventArgs a)
            {
                toAction().exec(playerFactory);
            });

            Panel.Controls.Add(btn);
            Panel.Controls.Add(avD);
            Panel.Controls.Add(avG);
            Panel.Controls.Add(avC);
            Panel.Controls.Add(arD);
            Panel.Controls.Add(arG);
        }
    }
}
