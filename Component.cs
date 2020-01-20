using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIM.Core
{
    public class Component
    {
        public Guid id { get; }
        public List<Element> elements { get; set; }
        public List<Transformation> transformations = new List<Transformation>();

        /// <summary>
        /// Create a new component
        /// </summary>
        public Component()
        {
            this.id = Guid.NewGuid();
            this.elements = new List<Element>();
        }

        /// <summary>
        /// Create a component with one single Part
        /// </summary>
        /// <param name="part"></param>
        public Component(Part part)
        {
            this.id = Guid.NewGuid();
            this.elements = new List<Element>();
            this.Add(part);
        }

        /// <summary>
        /// Create a component with one single Fastener
        /// </summary>
        /// <param name="part"></param>
        public Component(Fastener fast)
        {
            this.id = Guid.NewGuid();
            this.elements = new List<Element>();
            this.Add(fast);
        }

        /// <summary>
        /// Create a new component
        /// </summary>
        public Component(List<Element> elements)
        {
            this.id = Guid.NewGuid();
            this.elements = elements;
        }


        /// <summary>
        /// Set the component transformations
        /// </summary>
        /// <param name="partTransformations"></param>
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

        /// <summary>
        /// Add an element to the component
        /// </summary>
        /// <param name="ele"></param>
        public void Add(Element ele)
        {
            elements.Add(ele);
        }

    }
}
