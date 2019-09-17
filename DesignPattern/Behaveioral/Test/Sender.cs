using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Behaveioral.Test
{
    internal class Sender
    {
        public static void Send()
        {
            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                var num = rand.Next(0, 100);
                   Hanndler.GetInstance().Checked=false;
                   Hanndler.GetInstance().Event1(Hanndler.GetInstance().Checked, num);
                   

            }
        }
    }
}
