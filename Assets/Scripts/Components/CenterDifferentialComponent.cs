using Unity.Entities;

namespace Components
{
    /// <summary>
    /// 
    /// </summary>
	public struct CenterDifferentialComponent : IComponentData
	{
        /// <summary>
        /// In [N/m]
        /// </summary>
        public float frontOutputTorque;

        /// <summary>
        /// In [N/m]
        /// </summary>
        public float rearOutputTorque;
    }
}