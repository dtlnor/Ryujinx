namespace ARMeilleure.IntermediateRepresentation
{
    enum Instruction : ushort
    {
        Add,
        BitwiseAnd,
        BitwiseExclusiveOr,
        BitwiseNot,
        BitwiseOr,
        BranchIf,
        ByteSwap,
        Call,
        Compare,
        CompareAndSwap,
        CompareAndSwap16,
        CompareAndSwap8,
        ConditionalSelect,
        ConvertI64ToI32,
        ConvertToFP,
        ConvertToFPUI,
        Copy,
        CountLeadingZeros,
        Divide,
        DivideUI,
        Load,
        Load16,
        Load8,
        LoadArgument,
        Multiply,
        Multiply64HighSI,
        Multiply64HighUI,
        Negate,
        Return,
        RotateRight,
        ShiftLeft,
        ShiftRightSI,
        ShiftRightUI,
        SignExtend16,
        SignExtend32,
        SignExtend8,
        StackAlloc,
        Store,
        Store16,
        Store8,
        Subtract,
        Tailcall,
        VectorCreateScalar,
        VectorExtract,
        VectorExtract16,
        VectorExtract8,
        VectorInsert,
        VectorInsert16,
        VectorInsert8,
        VectorOne,
        VectorZero,
        VectorZeroUpper64,
        VectorZeroUpper96,
        ZeroExtend16,
        ZeroExtend32,
        ZeroExtend8,

        Clobber,
        Extended,
        Fill,
        LoadFromContext,
        Phi,
        Spill,
        SpillArg,
        StoreToContext
    }
}