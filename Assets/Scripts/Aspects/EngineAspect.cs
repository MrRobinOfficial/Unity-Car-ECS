using Components;
using Unity.Entities;

namespace Aspects
{
	public readonly partial struct EngineAspect : IAspect
	{
        /* READ-ONLY */

        private readonly RefRO<EngineComponent> engine;

        /* READ-WRITE */

        private readonly RefRW<RevlimiterComponent> revlimiter;
        private readonly RefRW<LaunchControlComponent> launchControl;
        private readonly RefRW<TurbochargerComponent> turbocharger;
    }
}