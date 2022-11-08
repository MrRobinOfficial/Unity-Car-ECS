using Components;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Physics.Extensions;

namespace Systems
{
    /// <summary>
    /// Updating all the wheel entities
    /// </summary>
    [BurstCompile]
    public partial struct WheelSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state) { }

        [BurstCompile]
        public void OnDestroy(ref SystemState state) { }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            float deltaTime = SystemAPI.Time.DeltaTime;

            var handle = new Wheel_Physics_Job
            {
                deltaTime = deltaTime,
            }.ScheduleParallel(state.Dependency);

            handle.Complete();
        }
    }

    [BurstCompile]
    public partial struct Wheel_Physics_Job : IJobEntity
    {
        public float deltaTime;

        [BurstCompile]
        public void Execute(WheelComponent wheel,
                            PhysicsVelocity velocity,
                            PhysicsMass mass)
        {
            var impulse = math.forward() * 0f * deltaTime;
            velocity.ApplyLinearImpulse(mass, impulse);
        }
    }
}