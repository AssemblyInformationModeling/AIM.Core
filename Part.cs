using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIM.Core
{
    public class Part : Element
    {

        public List<Transformation> transformations { get; set; }
        public bool isOffsite { get; set; }

        /// <summary>
        /// Set the part transformations
        /// </summary>
        /// <param name="partTransformations">List of transformations</param>
        public void SetTransformations(List<Transformation> partTransformations)
        {
            this.transformations = partTransformations;
        }

        /// <summary>
        /// Add one Transformations to the list
        /// </summary>
        /// <param name="trans">Transformation to add</param>
        public void AddTransformation(Transformation trans)
        {
            transformations.Add(trans);
        }
    }
}
