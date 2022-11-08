using Unity.Entities;

namespace Components
{
	/// <summary>
	/// 
	/// </summary>
	public struct GearboxComponent : IComponentData
	{
		/// <summary>
		/// In [%]
		/// </summary>
		public float efficiency;

		/// <summary>
		/// 
		/// </summary>
		public int gearIndex;

        /// <summary>
        /// In [sec]
        /// </summary>
        public float shiftTime;

		/// <summary>
		/// 
		/// </summary>
		public uint shiftUpRPM;

		/// <summary>
		/// 
		/// </summary>
		public uint shiftDownRPM;
	}
}