using Unity.Entities;

namespace Components
{
	public struct EngineComponent : IComponentData
	{
		public float IdleRPM;
		public float MaxRPM;
		public float AngularVelocity;
		public float OutputTorque;
	} 
}