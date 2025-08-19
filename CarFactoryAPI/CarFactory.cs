using CarFactoryApi.BodyTypes;
using CarFactoryApi.Engines;
using CarFactoryApi.Interfaces;
namespace CarFactoryApi
{
    public class CarFactory(IEngine engine, IBodyType bodyType)
    {
        private readonly IEngine _engine = engine;
        private readonly IBodyType _bodyType = bodyType;

        public string BuildCar()
        {
            return $"Car Factory has built a new car:{Environment.NewLine}{Environment.NewLine}Body{Environment.NewLine}{_bodyType}{Environment.NewLine}{_engine}";
        }
    }
}