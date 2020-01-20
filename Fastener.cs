using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace AIM.Core
{
    /// <summary>
    /// Structure defining the Fastners elements
    /// </summary>
    public class Fastener : Element
    {

        //public int type { get; set; }
        public Plane position { get; set; }
        public double umz { get; set; }

        public Fastener()
        { }


        /// <summary>
        /// Create a new fastener
        /// </summary>
        /// <param name="position">Position and Orientation in space</param>
        public Fastener(Plane position)
        {
            //this.type = type;
            this.position = position;
        }
    }
}