using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //class Bat : Enemy
    class Bat : IMove, IFly
    {
        public void Move()
        {
            //...
        }
        public void Fly()
        {

        }
    }
}
