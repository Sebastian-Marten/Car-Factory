using System.Reflection;
namespace CarFactoryApi.Helpers
{
    public abstract class CarComponent
    {
        public virtual string Description { get; } = "Generic car component";

        public override string ToString()
        {
            // Build the representation of the car component
            // Include the description and all properties from implemented interfaces
            string result = $"{Description}";

            IEnumerable<PropertyInfo> interfaceProperties = GetType()
                .GetInterfaces()
                .SelectMany(i => i.GetProperties());

            foreach (PropertyInfo prop in interfaceProperties)
            {
                var value = prop.GetValue(this);
                result += $"{Environment.NewLine}{prop.Name} = {value}";
            }

            return result;
        }
    }
}