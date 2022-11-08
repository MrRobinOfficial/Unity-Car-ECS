using Components;
using Extensions;
using Unity.Entities;
using UnityEngine;

namespace Authorings
{
    /// <summary>
    /// 
    /// </summary>
	public class SurfaceAuthoring : MonoBehaviour
	{
        public Friction kineticFriction;
        public Friction staticFriction;
    }

    /// <summary>
    /// 
    /// </summary>
    public class SurfaceBaker : Baker<SurfaceAuthoring>
    {
        public override void Bake(SurfaceAuthoring authoring)
        {
            AddComponent(new SurfaceComponent
            {
                staticFriction = authoring.staticFriction,
                kineticFriction = authoring.kineticFriction
            });
        }
    }
}