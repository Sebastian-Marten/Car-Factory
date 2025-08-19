using CarFactoryApi.Interfaces;
namespace CarFactoryApi.BodyTypes
{
    public class Coupe : CarComponent, IBodyType
    {
        public override string Name => "Coupe";
        public override string Description => "Coupe";
        public int NumberOfDoors => 2;
        public bool IsConvertible => false;
    }
}