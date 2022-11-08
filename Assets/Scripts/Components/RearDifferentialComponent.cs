using Unity.Entities;

namespace Components
{
    /// <summary>
    /// 
    /// </summary>
    public struct RearDifferentialComponent : IComponentData
    {
        /// <summary>
        /// Left wheel
        /// </summary>
        public Entity leftWheel;

        /// <summary>
        /// Right wheel
        /// </summary>
        public Entity rightWheel;

        /// <summary>
        /// 
        /// </summary>
        public float finalDriveRatio;

        /// <summary>
        /// In [N/m]
        /// </summary>
        public float outputTorque;
    }
}
