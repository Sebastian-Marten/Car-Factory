using CarFactoryApi.Interfaces;

namespace CarFactoryApi.Engines
{
    public class FourCyclinder : CarComponent, IEngine
    {
        public override string Name => "Four Cylinder";
        public override string Description => "Four Cylinder Engine";
        public string Manufacturer => "Honda";
        public int DisplacementCc => 2000;
        public int Horsepower => 120;

        public int Cylinders => 4;

        public string FuelType => "ULP";
    }
}