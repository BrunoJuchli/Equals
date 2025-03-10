﻿[Equals]
public class WithGenericParameter<T> :
    GenericClass<T>
    where T : GenericClassBaseClass
{
    public int X { get; set; }

    public static bool operator ==(WithGenericParameter<T> left, WithGenericParameter<T> right) => Operator.Weave();
    public static bool operator !=(WithGenericParameter<T> left, WithGenericParameter<T> right) => Operator.Weave();
}