using Unity.Entities;

namespace Components
{
	/// <summary>
	/// 
	/// </summary>
	public struct SuspensionComponent : IComponentData
	{
        /* OVERALL CONFIG */

        /// <summary>
        /// In [cm]
        /// </summary>
        public float rideHeight;

        /* SPRING CONFIG */

        /// <summary>
        /// Spring stiffness rate in [N/mm]
        /// </summary>
        public float springStiffness;

        /* DAMPER CONFIG */

        /// <summary>
        /// Damping rate when the suspension is compressing in [N/ms^-1]
        /// </summary>
        public uint damperBumpStiffness;

        /// <summary>
        /// Damping rate when the suspension is extending in [N/ms^-1]
        /// </summary>
        public uint damperReboundStiffness;
    }
}
