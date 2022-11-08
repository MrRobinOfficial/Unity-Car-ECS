using Components;
using Unity.Entities;

namespace Aspects
{
    public readonly partial struct AxleAspect : IAspect
    {
        private readonly RefRW<DifferentialComponent> differential;
    }
}
