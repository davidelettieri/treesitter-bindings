namespace TreeSitter.Bindings;

[NativeTypeName("unsigned int")]
public enum TSQueryPredicateStepType : uint
{
    TSQueryPredicateStepTypeDone,
    TSQueryPredicateStepTypeCapture,
    TSQueryPredicateStepTypeString,
}
