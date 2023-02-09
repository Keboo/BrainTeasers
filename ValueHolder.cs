namespace BrainTeasers;

//Spot the bug: The following code throws an exception
//What exception is thrown and why?
public class ValueHolder
{
    private Dictionary<string, object> Values { get; } = new();
    
    public ValueHolder()
    {
        Values["1"] = "default";
        Values["2"] = -1;
        Values["3"] = DateTime.MinValue;
    }

    public string GetString() => (string)Values["1"];
    public decimal GetNumber() => (decimal)Values["2"];
    public DateTime GetDateTime() => (DateTime)Values["3"];
}
