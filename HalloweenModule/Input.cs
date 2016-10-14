using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenModule
{
    interface Input
    {
        event EventHandler inputChanged;
        bool Connected { get; set; }

        bool readChannel(int c);
    }
}
