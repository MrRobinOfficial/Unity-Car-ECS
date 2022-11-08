using Extensions;
using Unity.Entities;

namespace Components
{
    public struct SurfaceComponent : IComponentData
    {
        public Friction kineticFriction;
        public Friction staticFriction;
    }
}