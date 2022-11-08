using Aspects;
using Unity.Entities;
using UnityEngine;

namespace Authorings
{
    public class DrivetrainAuthoring : MonoBehaviour
    {

    }

    public class DrivetrainBaker : Baker<DrivetrainAuthoring>
    {
        public override void Bake(DrivetrainAuthoring authoring)
        {

        }
    }
}
