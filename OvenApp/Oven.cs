using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OvenApp
{
    public delegate void OverHeatEventHandler(object sender, EventArgs e);
    class Oven
    {
        public event OverHeatEventHandler OverHeat;
        private int temp;
        private int top = 100;
        private bool isOn;
        public Oven(int top)
        {
            this.temp = 37;
            this.top = top;
            this.isOn = false;
        }
        public void run()
        {
            isOn = true;
            while (isOn)
            {
                this.temp += 1;
                Console.WriteLine($"Temperature is {this.temp}");
                if(this.temp >= top && this.OverHeat != null)
                {
                    Console.WriteLine("Oven is over heat!");
                    this.OverHeat(this, new EventArgs());
                    
                }
                Thread.Sleep(1000);
            }
        }
        public void stop()
        {
            isOn = false;
            temp = 37;
            Console.WriteLine($"oven temperature is {this.temp}");
        }
    }
}
