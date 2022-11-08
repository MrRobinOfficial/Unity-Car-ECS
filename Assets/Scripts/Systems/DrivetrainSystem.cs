using Aspects;
using Unity.Burst;
using Unity.Entities;

namespace Systems
{
    [BurstCompile]
    public partial struct DrivetrainSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state) { }

        [BurstCompile]
        public void OnDestroy(ref SystemState state) { }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            float deltaTime = SystemAPI.Time.DeltaTime;

            var handle = new Drivetrain_Simulate_Job
            {
                deltaTime = deltaTime,
            }.ScheduleParallel(state.Dependency);

            handle.Complete();
        }
    }

    [BurstCompile]
    public partial struct Drivetrain_Simulate_Job : IJobEntity
    {
        public float deltaTime;

        [BurstCompile]
        public void Execute(DrivetrainAspect drivetrain)
        {
            drivetrain.Simulate(deltaTime);
        }
    }
}
