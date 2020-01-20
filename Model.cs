using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace AIM.Core
{
    public class Model
    {

        // Assembly Sequence
        public List<Component> sequence { get; }
        
        // Any Issue in the model
        public List<Issue> issues { get; }

        // Obstacles
        public List<Mesh> obstacles = new List<Mesh>();
        
        /// <summary>
        /// Create a new empty Assembly Model
        /// </summary>
        public Model()
        {
            sequence = new List<Component>();
            issues = new List<Issue>();
        }

        /// <summary>
        /// Create a new Assembly Model
        /// </summary>
        /// <param name="components"></param>
        public Model(List<Component> components)
        {
            sequence = components;
            issues = new List<Issue>();
        }

        /// <summary>
        /// Add a new component to the model
        /// </summary>
        /// <param name="component"></param>
        public void Add(Component component)
        {
            this.sequence.Add(component);
        }

        /// <summary>
        /// Add a new part to the model
        /// </summary>
        /// <param name="part"></param>
        public void Add(Part part)
        {
            this.sequence.Add(new Component(part));
        }

        /// <summary>
        /// Add a new issue to the model
        /// </summary>
        /// <param name="issue"></param>
        public void Add(Issue issue)
        {
            this.issues.Add(issue);
        }

        /// <summary>
        /// Add a new obstacle to the Model (Only Mesh)
        /// </summary>
        /// <param name="obstacle"></param>
        public void Add(Mesh obstacle)
        {
            this.obstacles.Add(obstacle);
        }
    }
}