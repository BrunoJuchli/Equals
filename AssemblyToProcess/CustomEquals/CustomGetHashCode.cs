﻿[Equals]
public class CustomGetHashCode
{
    public int X { get; set; }

    [CustomGetHashCode]
    int CustomGetHashCodeMethod()
    {
        return 42;
    }

    public static bool operator ==(CustomGetHashCode left, CustomGetHashCode right) => Operator.Weave();
    public static bool operator !=(CustomGetHashCode left, CustomGetHashCode right) => Operator.Weave();
}