.class public auto ansi beforefieldinit hw1.Parser
    extends [System.Private.CoreLib]System.Object
{
    .method public hidebysig static 
        int32 CheckArgumentsLength (
            string[] args
        ) cil managed 
    {
        .maxstack 2
        .locals init (
            [0] bool,
            [1] int32
        )

        nop
        ldarg.0
        ldlen
        conv.i4
        ldc.i4.3
        ceq
        stloc.0     
        ldloc.0
        brfalse.s IL_000f
        ldc.i4.0
        stloc.1
        br.s IL_001e
        ldstr "The program needs 3 arguments"
        call void [System.Console]System.Console::WriteLine(string)
        ldc.i4.3
        stloc.1
        br.s IL_001e
        ldloc.1
        ret
    }
    .method public hidebysig static 
        int32 CheckInput (
            string[] args,
            [out] float64& firstArg,
            [out] string& operation,
            [out] float64& secondArg
        ) cil managed 
    {      
        .maxstack 3
        .locals init (
            [0] bool isValidArg1,
            [1] bool isValidArg2,
            [2] class [System.Private.CoreLib]System.Collections.Generic.List`1<string> validOperations,
            [3] bool,
            [4] int32,
            [5] bool
        )
       ldarg.0
       ldc.i4.0
       ldelem.ref
       ldarg.1
       call bool [System.Private.CoreLib]System.Double::TryParse(string, float64&)
       stloc.0
       ldarg.2
       ldarg.0
       ldc.i4.1
       ldelem.ref
       stind.ref
       ldarg.0
       ldc.i4.2
       ldelem.ref
       ldarg.3
       call bool [System.Private.CoreLib]System.Double::TryParse(string, float64&)
       stloc.1
       newobj instance void class [System.Private.CoreLib]System.Collections.Generic.List`1<string>::.ctor()
       dup
       ldstr "/"
       callvirt instance void class [System.Private.CoreLib]System.Collections.Generic.List`1<string>::Add(!0)
       dup
       ldstr "*"
       callvirt instance void class [System.Private.CoreLib]System.Collections.Generic.List`1<string>::Add(!0)     
       dup
       ldstr "+"
       callvirt instance void class [System.Private.CoreLib]System.Collections.Generic.List`1<string>::Add(!0)
       dup
       ldstr "-"
       callvirt instance void class [System.Private.CoreLib]System.Collections.Generic.List`1<string>::Add(!0)
       stloc.2
       ldloc.0
       brfalse.s IL_0059
       ldloc.1
       ldc.i4.0
       ceq
       br.s IL_005a
       ldc.i4.1
       stloc.3
       ldloc.3
       brfalse.s IL_006f
       ldstr "Entered arguments are not correct"
       call void [System.Console]System.Console::WriteLine(string)
       ldc.i4.1
       stloc.s 4
       br.s IL_0096
       ldloc.2
       ldarg.2
       ldind.ref
       callvirt instance bool class [System.Private.CoreLib]System.Collections.Generic.List`1<string>::Contains(!0)
       ldc.i4.0
       ceq
       stloc.s 5
       ldloc.s 5
       brfalse.s IL_0091
       ldstr "Entered Operation is not supported"
       call void [System.Console]System.Console::WriteLine(string)
       ldc.i4.2
       stloc.s 4
       br.s IL_0096
       ldc.i4.0
       stloc.s 4
       br.s IL_0096
       ldloc.s 4
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