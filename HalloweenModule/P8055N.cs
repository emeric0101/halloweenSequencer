using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloweenModule
{

    class P8055N : Input
    {
        private bool connected = false;

        public event EventHandler inputChanged;
        Timer timer = new Timer
        {
            Enabled = true,
            Interval = 500
        };
        bool[] inputs = new bool[8];

        public bool Connected
        {
            get
            {
                return connected;
            }

            set
            {
                connected = value;
            }
        }

        [DllImport("k8055d.dll")]
        private static extern int OpenDevice(int CardAddress);

        [DllImport("k8055d.dll")]
        private static extern void CloseDevice();

        [DllImport("k8055d.dll")]
        private static extern int ReadAnalogChannel(int Channel);

        [DllImport("k8055d.dll")]
        private static extern void ReadAllAnalog(ref int Data1, ref int Data2);

        [DllImport("k8055d.dll")]
        private static extern void OutputAnalogChannel(int Channel, int Data);

        [DllImport("k8055d.dll")]
        private static extern void OutputAllAnalog(int Data1, int Data2);

        [DllImport("k8055d.dll")]
        private static extern void ClearAnalogChannel(int Channel);

        [DllImport("k8055d.dll")]
        private static extern void SetAllAnalog();

        [DllImport("k8055d.dll")]
        private static extern void ClearAllAnalog();

        [DllImport("k8055d.dll")]
        private static extern void SetAnalogChannel(int Channel);

        [DllImport("k8055d.dll")]
        private static extern void WriteAllDigital(int Data);

        [DllImport("k8055d.dll")]
        private static extern void ClearDigitalChannel(int Channel);

        [DllImport("k8055d.dll")]
        private static extern void ClearAllDigital();

        [DllImport("k8055d.dll")]
        private static extern void SetDigitalChannel(int Channel);

        [DllImport("k8055d.dll")]
        private static extern void SetAllDigital();

        [DllImport("k8055d.dll")]
        private static extern bool ReadDigitalChannel(int Channel);

        [DllImport("k8055d.dll")]
        private static extern int ReadAllDigital();

        [DllImport("k8055d.dll")]
        private static extern int ReadCounter(int CounterNr);

        [DllImport("k8055d.dll")]
        private static extern void ResetCounter(int CounterNr);

        [DllImport("k8055d.dll")]
        private static extern void SetCounterDebounceTime(int CounterNr, int DebounceTime);

        [DllImport("k8055d.dll")]
        private static extern int Version();

        [DllImport("k8055d.dll")]
        private static extern int SearchDevices();

        [DllImport("k8055d.dll")]
        private static extern int SetCurrentDevice(int lngCardAddress);

        public bool readChannel(int c)
        {
            if (Connected)
                return ReadDigitalChannel(c);

            return false;
        }

        public P8055N()
        {
            if (OpenDevice(0) == -1)
            {
                Console.WriteLine("Card not found");
                return;
            }
            else
            {
                Console.WriteLine("Card ready");
                timer.Tick += Timer_Tick;
                Connected = true;
            }
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            bool changed = false;
            for (int i=0;i<inputs.Count();i++)
            {
                bool result = readChannel(i); ;
                if (result != inputs[i])
                {
                    changed = true;
                }
                inputs[i] = result;
            }
            if (changed)
            {
                inputChanged.Invoke(this, null);
            }
        }
    }
}
