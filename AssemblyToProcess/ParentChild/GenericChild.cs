﻿[Equals]
public class GenericChild :
    GenericParent<int>
{
    public string InChild { get; set; }

    public static bool operator ==(GenericChild left, GenericChild right) => Operator.Weave();
    public static bool operator !=(GenericChild left, GenericChild right) => Operator.Weave();
}