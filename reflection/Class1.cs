using System.Reflection;

namespace reflection;

public class Equipement
{
    public string Name { get; set; } = "PDU";
    public string IpAddress { get; set; } = "192.168.0.1";
}

public class Program
{
    public static void Main()
    {
        Equipement device = new();

        Type type = device.GetType();

        Console.WriteLine($"Inspect: {type.Name}");
        Console.WriteLine("------------------------------");

        PropertyInfo[] prop = type.GetProperties();

        foreach (var p in prop)
        {
            string name = p.Name;
            object value = p.GetValue(device);

            Console.WriteLine($"{name}: {value} (Type: {p.PropertyType.Name})");
        }
    }
}