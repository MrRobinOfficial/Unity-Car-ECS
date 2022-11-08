using Components;
using Unity.Entities;

namespace Aspects
{
	public readonly partial struct ECUAspect : IAspect
	{
        private readonly Entity entity;

        /* READ-ONLY */

        private readonly RefRO<DrivetrainComponent> drivetrain;
        private readonly RefRO<EngineComponent> engine;
        private readonly RefRO<ClutchComponent> clutch;
        private readonly RefRO<GearboxComponent> gearbox;
        private readonly RefRO<CenterDifferentialComponent> centerDifferential;
        private readonly RefRO<FrontDifferentialComponent> frontDifferential;
        private readonly RefRO<RearDifferentialComponent> rearDifferential;

        /* READ-WRITE */

        private readonly RefRW<ABSComponent> abs;
        private readonly RefRW<TCSComponent> tcs;
        private readonly RefRW<ESCComponent> esc;
        private readonly RefRW<HSAComponent> hsa;
        private readonly RefRW<SpeedLimiterComponent> speedLimiter;
        private readonly RefRW<CruiseControlComponent> cruiseControl;
    } 
}
