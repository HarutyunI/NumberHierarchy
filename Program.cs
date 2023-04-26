using NumberHierarchy;

var values = new ComparableValue[] { "111.9", "1123", "1121", "111.11", "1111", "1119", "11111", "10", "9", "112" };
PrintValues(values);
Console.WriteLine("Now we'll order these values");
var orderedValues = values.OrderBy(v => v).ToArray();
PrintValues(orderedValues);

void PrintValues(IEnumerable<ComparableValue> values)
{
    foreach (var value in values)
    {
        Console.WriteLine(value);
    }
}
