using Extensions;
using Unity.Entities;

namespace Components
{
	/// <summary>
	/// 
	/// </summary>
	public struct ClutchComponent : IComponentData
	{
		/// <summary>
		/// 
		/// </summary>
		public ClutchType type;

        /// <summary>
        /// In [N/m]
        /// </summary>
		public float torqueCapacity;

		/// <summary>
		/// 
		/// </summary>
		public float damping;

		/// <summary>
		/// In [rad/s]
		/// </summary>
		public float angularVelocity;

        /// <summary>
        /// In [N/m]
        /// </summary>
        public float outputTorque;
    }
}