using Components;
using Extensions;
using Unity.Entities;

namespace Aspects
{
    public readonly partial struct DrivetrainAspect : IAspect
    {
        private readonly Entity entity;

        /* READ-ONLY */

        private readonly RefRO<DrivetrainComponent> drivetrain;

        /* READ-WRITE */

        private readonly RefRW<EngineComponent> engine;
        private readonly RefRW<ClutchComponent> clutch;
        private readonly RefRW<GearboxComponent> gearbox;
        private readonly RefRW<CenterDifferentialComponent> centerDifferential;
        private readonly RefRW<FrontDifferentialComponent> frontDifferential;
        private readonly RefRW<RearDifferentialComponent> rearDifferential;

        public void Simulate(float DeltaTime)
        {
            var driveType = drivetrain.ValueRO.driveType;

            switch (driveType)
            {
                case DriveType.FWD:
                    Simulate_FWD();
                    break;

                case DriveType.RWD:
                    Simulate_RWD();
                    break;

                case DriveType.AWD:
                    Simlate_AWD();
                    break;
            }

            frontDifferential.ValueRW.outputTorque = frontDifferential.ValueRO.finalDriveRatio * centerDifferential.ValueRO.frontOutputTorque;

            rearDifferential.ValueRW.outputTorque = rearDifferential.ValueRO.finalDriveRatio * centerDifferential.ValueRO.rearOutputTorque;
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