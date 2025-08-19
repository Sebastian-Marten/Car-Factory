public abstract class CarComponent
{
    public virtual string Name { get; } = "GenericComponent";
    public virtual string Description { get; } = "Generic car component";

    public override string ToString()
    {
        string result = $"{Description}{Environment.NewLine}";

        var interfaceProperties = GetType()
            .GetInterfaces()
            .SelectMany(i => i.GetProperties());

        foreach (var prop in interfaceProperties)
        {
            var value = prop.GetValue(this);
            result += $"{prop.Name} {value}{Environment.NewLine}";
        }
        result += Environment.NewLine; // Add an extra newline at the end for better readability
        return result;
    }
}