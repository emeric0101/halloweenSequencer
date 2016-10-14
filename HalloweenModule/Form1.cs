using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloweenModule
{

    public partial class Form1 : Form
    {
        volatile Input inputCard;
        volatile Relais relais8 = new FakeRelais();
        FakeRelais fakeRelais = new FakeRelais();
        bool lumiere = true;
        Random rn = new Random();
        bool active = false;
        List<Effect> effects = new List<Effect>();
        Dictionary<string, List<Sequence>> sequence = new Dictionary<string, List<Sequence>>();
        Sequence current = null;
        PlayerFactory playerFactory = new PlayerFactory();

        System.Timers.Timer timer = new System.Timers.Timer()
        {
            Enabled = false,
            Interval = 10
        };
        private Dictionary<string, ListBox.ObjectCollection> sequencerItems = new Dictionary<string, ListBox.ObjectCollection>();

        public Form1()
        {
            InitializeComponent();
            inputCard = new P8055N();
            // debug
            if (!inputCard.Connected)
            {
                inputCard = fakeRelais;
            }


            checkBoxRelais1.Click += CheckBoxRelais1_Click;
            checkBox2.Click += CheckBox2_Click;
            inputCard.inputChanged += InputCard_inputChanged;

            effects.Add(new Effect("Rire démoniaque", "rire", playerFactory));
            effects.Add(new Effect("Attaque monstre + cri", "attaquemonstre", playerFactory));
            effects.Add(new Effect("Loup", "loup", playerFactory));
            effects.Add(new Effect("Rire Sorcière", "riresorciere", playerFactory));
            effects.Add(new Effect("Hurle fille", "hurlefille", playerFactory));
            effects.Add(new Effect("Musique 1", "musique1", playerFactory));
            effects.Add(new Effect("It's a small world", "musique2", playerFactory));
            foreach (Effect e in effects)
            {
                flowLayoutPanel1.Controls.Add(e.Panel);
            }
            timer.Elapsed += Timer_Elapsed;
        }

        public T NextOfList<T>(IList<T> list, T item)
        {
            return list[(list.IndexOf(item) + 1) == list.Count ? 0 : (list.IndexOf(item) + 1)];
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            foreach (var seq in this.sequence)
            {
                if (current == null)
                {
                    current = seq.Value.First();
                }
                timer.Interval = current.time * 1000;
                foreach (Action a in current.actions)
                {
                    a.exec(playerFactory);
                }

                current = NextOfList(seq.Value, current);
            }

        }

        private void InputCard_inputChanged(object sender, EventArgs e)
        {
            bool relaisToilette = inputCard.readChannel(1);
        }

        private void CheckBox2_Click(object sender, EventArgs e)
        {
            fakeRelais.setChannel(2, checkBox2.Checked);
        }

        private void CheckBoxRelais1_Click(object sender, EventArgs e)
        {
            fakeRelais.setChannel(1, checkBoxRelais1.Checked);
        }

    


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = SerialPort.GetPortNames();
            int index = 0;
            string ComPortName = null;
            do
            {
                index += 1;
                if (ArrayComPortsNames.Count() < index+1) { break; }
                portComList.Items.Add(ArrayComPortsNames[index]);
            }

            while (!((ArrayComPortsNames[index] == ComPortName)
                          || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            //want to get first out
            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }

            portComList.Text = ArrayComPortsNames[0];

            
        }


        private void portComList_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (relais8 == null) {
                relais8 = new Relais8((string)portComList.SelectedItem);
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            active = !active;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            lumiere = true;
            relais8.activeRelay(5, lumiere);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lumiere = false;
            relais8.activeRelay(5, lumiere);

        }





        private void buttonSequence_Click(object sender, EventArgs e)
        {
            int time = (int)sequenceTimerInput.Value;
            Console.WriteLine(currentKey);
            switch (currentKey)
            {
                case "AvGCb":
                    AvGLb.Items.Add("Durée + " + time + " s");
                    break;
                case "ArGCb":
                    ArGLb.Items.Add("Durée + " + time + " s");
                    break;
                case "AvDCb":
                    AvDLb.Items.Add("Durée + " + time + " s");
                    break;
                case "ArDCb":
                    ArDLb.Items.Add("Durée + " + time + " s");
                    break;
                case "AvCCb":
                    AvCLb.Items.Add("Durée + " + time + " s");
                    break;
            }
            

            List<Action> effects = new List<Action>();
            foreach (Effect ef in this.effects)
            {
                if (!ef.hasActions()) { continue; }
                effects.Add(ef.toAction());
            }
            sequence[currentKey].Add(new Sequence(time, effects));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                timer.Enabled = false;
            }
            else
            {
                timer.Start();
                timer.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (currentKey)
            {
                case "AvGCb":
                    AvGLb.Items.RemoveAt(AvGLb.Items.Count - 1);
                    break;
                case "ArGCb":
                    AvGLb.Items.RemoveAt(AvGLb.Items.Count - 1);
                    break;
                case "AvDCb":
                    AvGLb.Items.RemoveAt(AvGLb.Items.Count - 1);
                    break;
                case "ArDCb":
                    AvGLb.Items.RemoveAt(AvGLb.Items.Count - 1);
                    break;
                case "AvCCb":
                    AvGLb.Items.RemoveAt(AvGLb.Items.Count - 1);
                    break;
            }
            sequence[currentKey].Remove(sequence[currentKey].Last());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            playerFactory.stopAll();
        }

        string currentKey = "AvDCb";

        private void ArGCb_CheckedChanged(object sender, EventArgs e)
        {
            string key = ((RadioButton)sender).Name;
            currentKey = key;
            if (!sequencerItems.Keys.Contains(key))
            {
                sequencerItems[key] = new ListBox.ObjectCollection(AvGLb);
                sequence[key] = new List<Sequence>();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
