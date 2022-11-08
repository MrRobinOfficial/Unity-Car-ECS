using Unity.Entities;
using Unity.Physics;

namespace Components
{
	public struct WheelComponent : IComponentData
	{
		/// <summary>
		/// In [kg]
		/// </summary>
		public float mass;

		/// <summary>
		/// In [kg * m^2]
		/// </summary>
		public float inertia;

		/// <summary>
		/// In [rad/s]
		/// </summary>
		public float angularVelocity;

		/// <summary>
		/// In [rad/s^2]
		/// </summary>
		public float angularAcceleration;

        /// <summary>
        /// In [N]
        /// </summary>
        public float longitudinalForce;

        /// <summary>
        /// In [N]
        /// </summary>
        public float lateralForce;

		/// <summary>
		/// In [N]
		/// </summary>
		public float normalForce;

		/// <summary>
		/// In [m]
		/// </summary>
		public float width;

        /// <summary>
        /// In [m]
        /// </summary>
        public float radius;

		/// <summary>
		/// 
		/// </summary>
        public float surfaceFrictionCoefficient;

		/// <summary>
		/// 
		/// </summary>
        public float wheelFrictionCoefficient;

        public bool isGrounded;
		public bool isLocked;

		public RaycastHit hit;
	} 
}
