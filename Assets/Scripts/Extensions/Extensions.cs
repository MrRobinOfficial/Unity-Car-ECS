namespace Extensions
{
    public enum DriveType : byte
    {
        FWD,
        RWD,
        AWD
    }

    public enum DrivingMode : byte
    {
        Normal,
        ECO,
        Sport,
        Profile1,
        Profile2,
        Profile3,
    }

    public enum EngineType : byte
    {
        InternalCombustion,
        Electric,
        IndirectDiesel,
        DirectDiesel,
    }

    public enum TransmissionType : byte
    {
        Manual,
        Automatic,
        AutomaticSequential,
        CVT,
    }

    public enum ClutchType : byte
    {
        TorqueConverter,
        FrictionDisc,
    }

    public enum DifferentialType : byte
    {
        Open,
        Locked,
        ClutchPack,
        Viscous,
        TorqueBias,
    }

    public enum SurfaceType : byte
    {
        Custom,
        DryAsphalt,
        WetAsphalt,
        DryConcrete,
        WetConcrete,
        DryMudd,
        WetMudd,
        Grass,
        Sand,
        Gravel,
        Snow,
        Ice,
    }

    [System.Serializable]
    public struct Friction
    {
        public float lowerBound;
        public float upperBound;
    }

    public static partial class Extensions
    {

    } 
}
