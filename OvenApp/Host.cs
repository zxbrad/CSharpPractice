using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvenApp
{
    class Host
    {
        private Oven oven;
        void HostHandleOverHeat(object sender, EventArgs e)
        {
            Console.WriteLine("turn off oven");
            oven.stop();
        }
        public Host(Oven oven)
        {
            this.oven = oven;
            this.oven.OverHeat += new OverHeatEventHandler(HostHandleOverHeat);
        }
    }
}
