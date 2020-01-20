using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace AIM.Core
{
    public class Transformation
    {
        public int transformationType { get; set; } // 0: Translation, 1: Rotation
        public Vector3d translationVector { get; set; }
        public Plane rotationPlane { get; set; }
        public double rotationAngle { get; set; } // In Radian

        /// <summary>
        /// Create a new transformation
        /// </summary>
        public Transformation()
        { }

        /// <summary>
        /// Create a new translation transformation
        /// </summary>
        /// <param name="translationVector">Translation Vector</param>
        public Transformation(Vector3d translationVector)
        {
            this.translationVector = translationVector;
            transformationType = 0;
        }


        /// <summary>
        /// Create a new rotation transformation
        /// </summary>
        /// <param name="rotationPlane">Rotation Plane</param>
        /// <param name="rotationAngle">Rotation Angle in Radian</param>
        public Transformation(Plane rotationPlane, double rotationAngle)
        {
            this.rotationPlane = rotationPlane;
            this.rotationAngle = rotationAngle;
            transformationType = 1;
        }

    }
}