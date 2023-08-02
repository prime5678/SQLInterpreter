using System.Collections.Generic;
using System.Dynamic;

public class DynamicResult : DynamicObject
{
    private Dictionary<string, object?> _data = new Dictionary<string, object?>();

    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {
        string name = binder.Name;
        return _data.TryGetValue(name, out result);
    }

    public override bool TrySetMember(SetMemberBinder binder, object? value)
    {
        _data[binder.Name] = value;
        return true;
    }
}