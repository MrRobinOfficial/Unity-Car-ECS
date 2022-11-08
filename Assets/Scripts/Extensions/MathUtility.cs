using Unity.Mathematics;
using Time = UnityEngine.Time;

namespace Extensions
{
    public class InterpolatedFloat
    {
        public float Value
        {
            get => _value;
            set => _value = value;
        }

        public float GetInterpolated() => math.lerp(0f, 0f, GetFrameRatio());

        public void Reset(float value) { }

        public static float GetFrameRatio() => math.unlerp(Time.fixedTime, Time.fixedTime + Time.fixedDeltaTime, Time.time);

        private float _value;
        private float _prevValue;
    }

    public static class MathUtility
	{
        public static float Sign(float value) => value < 0f ? -1f : (value > 0f ? 1f : 0f);

        public static bool NearlyEqual(float a, float b, float tolerance) => math.abs(a - b) < tolerance;

        public static float SafeDivision(float a, float b) => (b == 0f) ? 0f : a / b;

        public static float MapRangeUnclamped(float val, float inA, float inB, float outA, float outB) => math.lerp(outA, outB, math.unlerp(inA, inB, val));

        public static float MapRangeClamped(float val, float inA, float inB, float outA, float outB)
        {
            var t = (val - inA) / (inB - inA);

            if (t > 1f)
                return outB;
            if (t < 0f)
                return outA;

            return outA + (outB - outA) * t;
        }

        /// <summary>
        /// Convert speed (kph) into speed (mph)
        /// </summary>
        /// <param name="kph">Kilometres per hour</param>
        /// <returns>Speed [mph]</returns>
        public static float ConvertKphToMph(float kph)
        {
            const float V = 1.609f;
            return kph / V;
        }
    }
}