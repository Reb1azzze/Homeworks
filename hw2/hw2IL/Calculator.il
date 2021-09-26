.class public auto ansi beforefieldinit hw1.Calculator
    extends [System.Private.CoreLib]System.Object
{
    // Methods
    .method public hidebysig static 
        float64 Calculate (
            float64 firstarg,
            string operation,
            float64 secondarg
        ) cil managed 
    {
        .maxstack 2
        .locals init (
            [0] float64 result,
            [1] float64,
            [2] float64
        )
       ldc.i4.1
       ldarg.1
       ldstr "+"
       call bool [System.Private.CoreLib]System.String::op_Equality(string, string)
       ldarg.1
       ldstr "-"
       call bool [System.Private.CoreLib]System.String::op_Equality(string, string)
       ldarg.1
       ldstr "*"
       call bool [System.Private.CoreLib]System.String::op_Equality(string, string)
       ldarg.1
       ldstr "/"
       call bool [System.Private.CoreLib]System.String::op_Equality(string, string)
       ldarg.0
       ldarg.2
       add
       stloc.1
       ldarg.0
       ldarg.2
       sub
       stloc.1
       ldarg.0
       ldarg.2
       mul
       stloc.1
       ldarg.2
       ldc.r8 0.0
       ldarg.0
       ldarg.2
       div
       ldc.r8 0.0
       stloc.1
       ldc.r8 0.0
       stloc.1
       ldc.i4.1
       ldloc.1
       stloc.0
       ldloc.0
       stloc.2
       ldloc.2
       ret
    }

    .method public hidebysig specialname rtspecialname 
        instance void .ctor () cil managed 
    {
        .maxstack 8
        ldarg.0
        call instance void [System.Private.CoreLib]System.Object::.ctor()
        ret
    } 
} 
