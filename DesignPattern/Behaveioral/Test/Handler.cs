using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaveioral.Test
{
    public delegate void Event(bool isDone,int num);
    public  class  Hanndler
    {
        private static bool chk;
        private static Hanndler handler;
        Hanndler()
        {
            chk = true;
        }

        public static Hanndler GetInstance()
        {
            if (!chk)
            {
                handler=new Hanndler();
            }

            return handler;
        }
       public   Event Event3;
       public  Event Event2;
       public  Event Event1;
       public bool Checked;
       public  int counter = 0;

  
    }
}
