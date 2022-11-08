using Unity.Entities;

namespace Components
{
	public struct DifferentialComponent : IComponentData
	{
		/* In [N/m] */
		public float frontOutputTorque;

        /* In [N/m] */
        public float rearOutputTorque;
    }
}