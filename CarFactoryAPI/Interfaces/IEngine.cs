namespace CarFactoryApi.Interfaces
{
    public interface IEngine
    {
        string Name { get; }
        string Manufacturer { get; }
        int Cylinders { get; }
        int DisplacementCc { get; }
        string FuelType { get; }
        int Horsepower { get; }
        string ToString();
    }
}