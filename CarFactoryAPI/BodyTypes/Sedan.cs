using CarFactoryApi.Interfaces;
namespace CarFactoryApi.BodyTypes
{
    public class Sedan : CarComponent, IBodyType
    {
        public override string Name => "Sedan";
        public override string Description => "Sedan";
        public int NumberOfDoors => 4;
        public bool IsConvertible => false;
    }
}