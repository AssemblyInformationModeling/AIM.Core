using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Is this useful at the moment ?

namespace AIM.Core
{
    public class Joint
    {
        public int type { get; set; }
        public List<Element> parts { get; set; }

        public Joint(List<Element> parts)
        {

        }

    }
}
