using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_124
{
    class Employee : Person, IQuittable
    {
        public void SayName()
        {
            base.SayName();
        }

        public void Quit ()
        {
            throw new NotImplementedException();
        }


    }
}
