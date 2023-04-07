namespace TreeSitter.Bindings;

[NativeTypeName("unsigned int")]
public enum TSQuantifier : uint
{
    TSQuantifierZero = 0,
    TSQuantifierZeroOrOne,
    TSQuantifierZeroOrMore,
    TSQuantifierOne,
    TSQuantifierOneOrMore,
}
