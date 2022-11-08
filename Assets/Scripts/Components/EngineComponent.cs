using Extensions;
using Unity.Entities;

namespace Components
{
	public struct EngineComponent : IComponentData
	{
		/// <summary>
		/// 
		/// </summary>
		public EngineType type;

		/// <summary>
		/// In [%]
		/// </summary>
		public float efficiency;

        /// <summary>
        /// In [kg * m^2]
        /// </summary>
        public float inertia;

        /// <summary>
        /// In [N/m]
        /// </summary>
        public float frictionTorque;

        /// <summary>
        /// Compression factor. Higher equals more compression of braking.
        /// </summary>
        public float frictionCoefficient;

        /// <summary>
        /// 
        /// </summary>
        public float idleRPM;

		/// <summary>
		/// 
		/// </summary>
		public float maxRPM;

        /// <summary>
        /// Maximum power in [kW]
        /// </summary>
        public float maxPower;

        /// <summary>
        /// RPM at maximum power
        /// </summary>
        public float powerRPM;

        /// <summary>
        /// 
        /// </summary>
        public bool enableStalling;

        /// <summary>
        /// Stalls after reaching lower than this RPM
        /// </summary>
        public float stallRPM;

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