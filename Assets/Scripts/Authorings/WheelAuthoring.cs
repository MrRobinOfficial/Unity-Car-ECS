using Components;
using Unity.Entities;
using UnityEngine;

namespace Authorings
{
    /// <summary>
    /// 
    /// </summary>
    public class WheelAuthoring : MonoBehaviour
    {
        /* OVERALL CONFIG */

        /// <summary>
        /// In [kg]
        /// </summary>
        [SerializeField] private float m_Mass = 25f;

        /// <summary>
        /// In [m]
        /// </summary>
        [SerializeField] private float m_Width = 1.3f;

        /// <summary>
        /// In [m]
        /// </summary>
        [SerializeField] private float m_Radius = 0.35f;

        /// <summary>
        /// In [kg * m^2]
        /// </summary>
        [SerializeField] private float m_Inertia = 1.5f;

        /// <summary>
        /// In [kg]
        /// </summary>
        public float Mass => m_Mass;

        /// <summary>
        /// In [m]
        /// </summary>
        public float Width => m_Width;

        /// <summary>
        /// In [m]
        /// </summary>
        public float Radius => m_Radius;

        /// <summary>
        /// In [kg * m^2]
        /// </summary>
        public float Inertia => m_Inertia;

        /* SUSPENSION CONFIG */

        /// <summary>
        /// In [cm]
        /// </summary>
        [Header("Suspension")]
        [SerializeField, Range(6f, 30f)] private float m_RideHeight = 10f;

        /// <summary>
        /// Spring stiffness rate in [N/mm]
        /// </summary>
        [SerializeField, Range(0, 150)] private float m_SpringStiffness = 45f;

        /// <summary>
        /// 
        /// </summary>
        [SerializeField] private AnimationCurve m_SpringCurve = new(DefaultSpringCurve.keys);

        /// <summary>
        /// Damping rate when the suspension is compressing in [N/ms^-1]
        /// </summary>
        [SerializeField] private uint m_DamperBumpStiffness = 3500;

        /// <summary>
        /// 
        /// </summary>
        [SerializeField] private AnimationCurve m_DamperBumpCurve = new(DefaultDamperBumpCurve.keys);

        /// <summary>
        /// Damping rate when the suspension is extending in [N/ms^-1]
        /// </summary>
        [SerializeField] private uint m_DamperReboundStiffness = 4000;

        /// <summary>
        /// 
        /// </summary>
        [SerializeField] private AnimationCurve m_DamperReboundCurve = new(DefaultDamperReboundCurve.keys);

        /// <summary>
        /// In [cm]
        /// </summary>
        public float RideHeight => m_RideHeight;

        /* SPRING CONFIG */

        /// <summary>
        /// Spring stiffness rate in [N/mm]
        /// </summary>
        public float SpringStiffness => m_SpringStiffness;

        /* DAMPER CONFIG */

        /// <summary>
        /// Damping rate when the suspension is compressing in [N/ms^-1]
        /// </summary>
        public uint DamperBumpStiffness => m_DamperBumpStiffness;

        /// <summary>
        /// Damping rate when the suspension is extending in [N/ms^-1]
        /// </summary>
        public uint DamperReboundStiffness => m_DamperReboundStiffness;

        private static readonly AnimationCurve DefaultSpringCurve = 
            AnimationCurve.EaseInOut(timeStart: 0f, valueStart: 0f, timeEnd: 1f, valueEnd: 1f);

        private static readonly AnimationCurve DefaultDamperBumpCurve = 
            AnimationCurve.EaseInOut(timeStart: 0f, valueStart: 0f, timeEnd: 1f, valueEnd: 1f);

        private static readonly AnimationCurve DefaultDamperReboundCurve = 
            AnimationCurve.EaseInOut(timeStart: 0f, valueStart: 0f, timeEnd: 1f, valueEnd: 1f);
    }

    public class WheelBaker : Baker<WheelAuthoring>
    {
        public override void Bake(WheelAuthoring authoring)
        {
            AddComponent(new WheelComponent
            {
                mass = authoring.Mass,
                width = authoring.Width,
                radius = authoring.Radius,
                inertia = authoring.Inertia,
            });

            AddComponent(new SuspensionComponent
            {
                rideHeight = authoring.RideHeight,
                springStiffness= authoring.SpringStiffness,
                damperBumpStiffness = authoring.DamperBumpStiffness,
                damperReboundStiffness = authoring.DamperReboundStiffness,
            });
        }
    } 
}
