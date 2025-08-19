using CarFactoryApi.Interfaces;

namespace CarFactoryApi.Engines
{
    public class SixCylinder : CarComponent, IEngine
    {
        public override string Name => "Six Cylinder";
        public override string Description => "Six Cylinder Engine";
        public string Manufacturer => "Honda";
        public int Cylinders => 6;
        public int DisplacementCc => 3200;
        public string FuelType => "ULP 95";
        public int Horsepower => 193;
    }
}