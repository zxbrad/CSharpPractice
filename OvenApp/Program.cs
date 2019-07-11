using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Oven oven = new Oven(40);
            Host host = new Host(oven);
            oven.run();
        }
    }
}
