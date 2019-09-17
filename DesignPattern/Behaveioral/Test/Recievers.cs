using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaveioral.Test
{
    internal class Reciever1
    {
        
        public Reciever1()
        {
            Hanndler.GetInstance().Event1 += (b,i) =>
            {
                if (!Hanndler.GetInstance().Checked)
                {
                    Hanndler.GetInstance().counter++;
                    Console.WriteLine($"{Hanndler.GetInstance().counter}from:{this}  {i}");
                    Hanndler.GetInstance().Checked = true;

                }

            };
        }
    }
    internal class Reciever2
    {
        public Reciever2()
        {
            Hanndler.GetInstance().Event1 += (b,i) =>
            {
                if (!Hanndler.GetInstance().Checked)
                {
                    Hanndler.GetInstance().counter++;
                    Console.WriteLine($"{Hanndler.GetInstance().counter}from:{this}  {i}");
                }
                    
            };
        }
    }
    internal class Reciever3
    {
        public Reciever3()
        {
            Hanndler.GetInstance().Event1 += (b,i) =>
            {
                if (!Hanndler.GetInstance().Checked)
                {
                    Hanndler.GetInstance().counter++;
                    Console.WriteLine($"{Hanndler.GetInstance().counter}from:{this}  {i}");
                }
                    
            };
        }
    }
}
