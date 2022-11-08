using Unity.Entities;

namespace Components
{
    /// <summary>
    /// 
    /// </summary>
    public struct FuelComponent : IComponentData
    {
        /// <summary>
        /// 
        /// </summary>
        public float capacity;

        /// <summary>
        /// 
        /// </summary>
        public float volume;

        /// <summary>
        /// 
        /// </summary>
        public float rate;
    } 
}
