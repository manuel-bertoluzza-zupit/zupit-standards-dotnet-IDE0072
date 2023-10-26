namespace zupit_standards_dotnet_IDE0072;

// An enum with 20 items
public enum MyEnum
{
    Item1,
    Item2,
    Item3,
    Item4,
    Item5,
    Item6,
    Item7,
    Item8,
    Item9,
    Item10,
    Item11,
    Item12,
    Item13,
    Item14,
    Item15,
    Item16,
    Item17,
    Item18,
    Item19,
    Item20
};

public class MyProgram
{
    public static int GetValue(MyEnum randomItem)
    {
        // A switch expression with a few cases different than the default case
        var value = randomItem switch
        {
            MyEnum.Item1 or MyEnum.Item2 or MyEnum.Item3 => 1,
            MyEnum.Item4 => 2,
            _ => 0
        };
        return value;
    }

    static void Main()
    {
    }
}