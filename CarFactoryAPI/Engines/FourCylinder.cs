using CarFactoryApi.Interfaces;
namespace CarFactoryApi.Engines
{
    public class FourCylinder : CarComponent, IEngine
    {
        public override string Name => "FourCylinderEngine";
        public override string Description => "Four Cylinder Engine";
        public string Manufacturer => "Honda";
        public int Cylinders => 4;
        public int DisplacementCc => 2000;
        public int Horsepower => 120;
        public string FuelType => "ULP";
    }
}