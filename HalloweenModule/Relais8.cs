using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenModule
{

    class Relais8 : Relais
    {
        SerialPort ComPort;
        public Relais8(string port) {
            ComPort = new SerialPort(port);
            ComPort.Open();
            // Reset
            for (int i =1;i< 9;i++)
            {
                activeRelay(i, false);
            }
        }

        public void activeRelay(int channel, bool active)
        {
            string cmd = "RLY" + channel.ToString();
            if (active)
            {
                cmd = cmd +"1";
            }
            else
            {
                cmd = cmd + "0";
            }
            Console.WriteLine(cmd);
            ComPort.WriteLine(cmd);
            System.Threading.Thread.Sleep(10);
        }
    }
}
