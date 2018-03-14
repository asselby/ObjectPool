using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
  public  class Taxi
    {
       static public bool isBusy;
        public Taxi()
        {
            isBusy = false;
        }
    }
}
