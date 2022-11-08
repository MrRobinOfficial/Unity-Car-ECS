using Components;
using Unity.Entities;

namespace Aspects
{
	public readonly partial struct DifferentialAspect : IAspect
	{
        /* READ-ONLY */

        private readonly RefRO<CenterDifferentialComponent> centerDifferential;

        /* READ-WRITE */

        private readonly RefRW<FrontDifferentialComponent> frontDifferential;
        private readonly RefRW<RearDifferentialComponent> rearDifferential;
    }
}