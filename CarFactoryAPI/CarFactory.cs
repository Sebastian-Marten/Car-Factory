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
            return _engine.ToString() + " with " + _bodyType.ToString() + " has been built.";
        }
    }
}