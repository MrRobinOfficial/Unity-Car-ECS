using Unity.Mathematics;

namespace Extensions
{
    public static partial class Extensions
    {
        /// <summary>
        /// Creates a curve based on points and engine speed
        /// </summary>
        /// <param name="type">Engine type</param>
        /// <param name="angularSpeed">Engine speed in [rad/s]</param>
        /// <param name="p1">Point 1</param>
        /// <param name="p2">Point 2</param>
        /// <param name="p3">Point 3</param>
        /// <returns></returns>
        public static float GetTorqueCurve(EngineType type,
                                           float angularSpeed,
                                           float p1,
                                           float p2,
                                           float p3)
        {
            // Engine Torque Formula
            // Te = Pe / We = P1 + P2*We + P3*We^2
            // Te = Torque Engine
            // Pe = Power Engine
            // We = Angular Velocity Engine
            // P1..P3 = Constants

            // Indirect injection Diesel:
            const float IJD_P1 = 0.6f;
            const float IJD_P2 = 1.4f;

            // Direct injection Diesel:
            const float DJD_P1 = 0.87f;
            const float DJD_P2 = 1.13f;

            switch (type)
            {
                case EngineType.IndirectDiesel:
                    p1 *= IJD_P1;
                    p2 *= IJD_P2;
                    break;

                case EngineType.DirectDiesel:
                    p1 *= DJD_P1;
                    p2 *= DJD_P2;
                    break;
            }

            return p1 + p2 * angularSpeed + p3 * math.pow(angularSpeed, 2f);
        }
    }

}