using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenModule
{
    class FakeRelais : Relais, Input
    {
        public event EventHandler inputChanged;

        Dictionary<int, bool> relays = new Dictionary<int, bool>();
        Dictionary<int, bool> inputs = new Dictionary<int, bool>();

        public bool Connected
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void activeRelay(int channel, bool active)
        {
            Console.WriteLine("Relais " + channel + " = " + active);
            relays[channel] = active;
        }

        public bool readChannel(int c)
        {
            if (!inputs.ContainsKey(c))
            {
                return false;
            }
            return inputs[c];
        }
        public void setChannel(int c, bool state)
        {
            inputs[c] = state;
            inputChanged.Invoke(this, null);
        }
    }
}
