using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace AIM.Core
{
    public class Element
    {
        public Guid id { get; }

        public Brep brepGeometry { get; set; }
        public Mesh meshGeometry { get; set; }

        /// <summary>
        /// Create a new Element
        /// </summary>
        public Element()
        {
            this.id = Guid.NewGuid();
        }

        /// <summary>
        /// Set element geometry (Brep)
        /// </summary>
        /// <param name="geometry">Part Geometry</param>
        public void SetGeometry(Brep geometry)
        {
            this.brepGeometry = geometry;
        }

        /// <summary>
        /// Set element geometry (Mesh)
        /// </summary>
        /// <param name="geometry">Part Geometry</param>
        public void SetGeometry(Mesh geometry)
        {
            this.meshGeometry = geometry;
        }
        
        /// <summary>
        /// Set element geometries (Brep AND Mesh)
        /// </summary>
        /// <param name="bGeometry">Part Geometry - Brep</param>
        /// <param name="mGeometry">Part Geometry - Mesh</param>
        public void SetGeometry(Brep bGeometry, Mesh mGeometry)
        {
            this.brepGeometry = bGeometry;
            this.meshGeometry = mGeometry;
        }

    }
}