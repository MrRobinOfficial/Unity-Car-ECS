using Components;
using Unity.Entities;

namespace Aspects
{
    public readonly partial struct DrivetrainAspect : IAspect
    {
        private readonly Entity entity;
        private readonly RefRO<DrivetrainComponent> drivetrain;
        private readonly RefRW<EngineComponent> engine;
        private readonly RefRW<ClutchComponent> clutch;
        private readonly RefRW<GearboxComponent> gearbox;
        private readonly RefRW<DifferentialComponent> centerDifferential;

        public void Simulate(float DeltaTime)
        {
            var drivetrainType = drivetrain.ValueRO.type;

            switch (drivetrainType)
            {
                case DrivetrainType.FWD:
                    Simulate_FWD();
                    break;

                case DrivetrainType.RWD:
                    Simulate_RWD();
                    break;

                case DrivetrainType.AWD:
                    Simlate_AWD();
                    break;
            }
        }

        private void Simulate_FWD()
        {
            centerDifferential.ValueRW.frontOutputTorque = 0f;
        }

        private void Simulate_RWD()
        {
            centerDifferential.ValueRW.rearOutputTorque = 0f;
        }

        private void Simlate_AWD()
        {
            centerDifferential.ValueRW.frontOutputTorque = 0f;
            centerDifferential.ValueRW.rearOutputTorque = 0f;
        }
    }
}