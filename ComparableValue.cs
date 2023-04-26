namespace NumberHierarchy;

public struct ComparableValue : IComparable, IComparable<ComparableValue>
{
    private readonly string _value;
    private readonly string _originalValue;

    private ComparableValue(string val)
    {
        _originalValue = val;
        _value = val.Replace(".", string.Empty);
    }

    public static implicit operator ComparableValue(string val)
    {
        return new ComparableValue(val);
    }

    public int CompareTo(object obj)
    {
        if (!obj.GetType().IsAssignableTo(typeof(ComparableValue)))
        {
            throw new ArgumentException();
        }

        return CompareTo((ComparableValue)obj);
    }

    public int CompareTo(ComparableValue other)
    {
        for (int i = 0; i < Math.Min(_value.Length, other._value.Length); i++)
        {
            if (_value[i] == other._value[i])
            {
                continue;
            }

            if (Convert.ToInt16(_value[i]) > Convert.ToInt16(other._value[i]))
            {
                return 1;
            }

            return -1;
        }

        return _value.Length - other._value.Length;
    }

    public override string ToString()
    {
        return _originalValue;
    }
}
