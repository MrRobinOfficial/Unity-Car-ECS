using Extensions;
using Unity.Entities;

namespace Components
{
    /// <summary>
    /// 
    /// </summary>
    public struct DrivetrainComponent : IComponentData
    {
        /// <summary>
        /// 
        /// </summary>
        public DriveType driveType;

        /// <summary>
        /// 
        /// </summary>
        public TransmissionType transmissionType;

        /// <summary>
        /// 
        /// </summary>
        public bool isIgnited;

        /// <summary>
        /// 
        /// </summary>
        public bool isEngineRunning;
    } 
}
