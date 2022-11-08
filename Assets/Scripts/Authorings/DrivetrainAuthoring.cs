using Components;
using Extensions;
using Unity.Entities;
using UnityEngine;

namespace Authorings
{
    /// <summary>
    /// 
    /// </summary>
    public class DrivetrainAuthoring : MonoBehaviour
    {
        /* DRIVETRAIN CONFIG */

        /// <summary>
        /// 
        /// </summary>
        [Header("Drivetrain")]
        [SerializeField] private DriveType m_DriveType = DriveType.FWD;

        /// <summary>
        /// 
        /// </summary>
        [SerializeField] private TransmissionType m_TransmissionType = TransmissionType.Manual;

        public DriveType DriveType => m_DriveType;
        public TransmissionType TransmissionType => m_TransmissionType;

        /* ENGINE CONFIG */

        /// <summary>
        /// 
        /// </summary>
        [Header("Engine")]
        [SerializeField] private EngineType m_EngineType = EngineType.InternalCombustion;

        /// <summary>
        /// 
        /// </summary>
        [SerializeField] private float m_EngineIdleRPM = 1100f;

        /// <summary>
        /// 
        /// </summary>
        [SerializeField] private float m_EngineMaxRPM = 7800f;

        public EngineType EngineType => m_EngineType;
        public float EngineIdleRPM => m_EngineIdleRPM;
        public float EngineMaxRPM => m_EngineMaxRPM;

        /* CLUTCH CONFIG */

        /// <summary>
        /// 
        /// </summary>
        [Header("Clutch")]
        [SerializeField] private ClutchType m_ClutchType = ClutchType.FrictionDisc;

        public ClutchType ClutchType => m_ClutchType;

        /* GEARBOX CONFIG */

        /// <summary>
        /// In [sec]
        /// </summary>
        [Header("Gearbox")]
        [SerializeField] private float m_ShiftTime = 0.3f;

        /// <summary>
        /// 
        /// </summary>
        [SerializeField] private uint m_ShiftUpRPM = 4500;

        /// <summary>
        /// 
        /// </summary>
        [SerializeField] private uint m_ShiftDownRPM = 2500;

        /// <summary>
        /// In [sec]
        /// </summary>
        public float ShiftTime => m_ShiftTime;

        /// <summary>
        /// 
        /// </summary>
        public uint ShiftUpRPM => m_ShiftUpRPM;

        /// <summary>
        /// 
        /// </summary>
        public uint ShiftDownRPM => m_ShiftDownRPM;

        /* DIFFERENTIAL CONFIG */

        /// <summary>
        /// 
        /// </summary>
        [Header("Differential")]
        [SerializeField] private float m_FrontFinalDriveRatio = 3.5f;

        /// <summary>
        /// 
        /// </summary>
        [SerializeField] private float m_RearFinalDriveRatio = 3.5f;

        /// <summary>
        /// 
        /// </summary>
        public float FrontFinalDriveRatio => m_FrontFinalDriveRatio;

        /// <summary>
        /// 
        /// </summary>
        public float RearFinalDriveRatio => m_RearFinalDriveRatio;

        /* WHEELS CONFIG */

        /// <summary>
        /// Front left wheel
        /// </summary>
        [Header("Wheels")]
        [SerializeField] private WheelAuthoring m_FL_Wheel = null;

        /// <summary>
        /// Front right wheel
        /// </summary>
        [SerializeField] private WheelAuthoring m_FR_Wheel = null;

        /// <summary>
        /// Rear left wheel
        /// </summary>
        [SerializeField] private WheelAuthoring m_RL_Wheel = null;

        /// <summary>
        /// Rear right wheel
        /// </summary>
        [SerializeField] private WheelAuthoring m_RR_Wheel = null;

        /// <summary>
        /// Front left wheel
        /// </summary>
        public WheelAuthoring FL_Wheel => m_FL_Wheel;

        /// <summary>
        /// Front right wheel
        /// </summary>
        public WheelAuthoring FR_Wheel => m_FR_Wheel;

        /// <summary>
        /// Rear left wheel
        /// </summary>
        public WheelAuthoring RL_Wheel => m_RL_Wheel;

        /// <summary>
        /// Rear right wheel
        /// </summary>
        public WheelAuthoring RR_Wheel => m_RR_Wheel;
    }

    /// <summary>
    /// 
    /// </summary>
    public class DrivetrainBaker : Baker<DrivetrainAuthoring>
    {
        public override void Bake(DrivetrainAuthoring authoring)
        {
            AddComponent(new DrivetrainComponent
            {
                driveType = authoring.DriveType,
                transmissionType = authoring.TransmissionType,
            });

            AddComponent(new EngineComponent
            {
                type = authoring.EngineType,
                idleRPM = authoring.EngineIdleRPM,
                maxRPM = authoring.EngineMaxRPM,
            });

            AddComponent(new ClutchComponent
            {
                type = authoring.ClutchType
            });

            AddComponent(new GearboxComponent
            {
                shiftTime = authoring.ShiftTime,
                shiftUpRPM = authoring.ShiftUpRPM,
                shiftDownRPM = authoring.ShiftDownRPM,
            });

            AddComponent<CenterDifferentialComponent>();

            AddComponent(new FrontDifferentialComponent
            {
                leftWheel = Entity.Null,
                rightWheel = Entity.Null,
                finalDriveRatio = authoring.FrontFinalDriveRatio
            });

            AddComponent(new RearDifferentialComponent
            {
                leftWheel = Entity.Null,
                rightWheel = Entity.Null,
                finalDriveRatio = authoring.RearFinalDriveRatio
            });
        }
    }
}
