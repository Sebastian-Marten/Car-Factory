public abstract class CarComponent
{
    public abstract string Name { get; }
    public virtual string Description { get; } = "Generic car component";

    public override string ToString()
    {
        string result = $"{Name}: {Description}";

        var interfaceProperties = GetType()
            .GetInterfaces()
            .SelectMany(i => i.GetProperties());

        foreach (var prop in interfaceProperties)
        {
            var value = prop.GetValue(this);
            result += $", {prop.Name}={value}";
        }

        return result;
    }
}