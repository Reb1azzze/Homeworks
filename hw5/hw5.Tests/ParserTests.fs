module ParserTests

open hw5
open Xunit
open Parser

[<Theory>]
[<InlineData("19", "+", "20", 19, "+", 20)>]
[<InlineData("30", "-", "6", 30, "-", 6)>]
[<InlineData("34", "*", "21", 34, "*", 21)>]
[<InlineData("22", "/", "2", 22, "/", 2)>]
let ``Correct with int values`` (inArg1, inOp, inArg2, expArg1, expOp, expArg2) =
    let arg1, op, arg2 = TryParseArguments [|inArg1; inOp; inArg2|]
    Assert.Equal(Success expArg1, arg1)
    Assert.Equal(Success expOp, op)
    Assert.Equal(Success expArg2, arg2)

[<Theory>]
[<InlineData("52.1", "+", "4.51", 52.1, "+", 4.51)>]
[<InlineData("14.266", "-", "8.22", 14.266, "-", 8.22)>]
[<InlineData("-20.3", "*", "1.4", -20.3, "*", 1.4)>]
[<InlineData("0.5", "/", "12.4", 0.5, "/", 12.4)>]
let ``Correct with rational values`` (inArg1, inOp, inArg2, expArg1, expOp, expArg2) =
    let arg1, op, arg2 = TryParseArguments [|inArg1; inOp; inArg2|]
    Assert.Equal(Success expArg1, arg1)
    Assert.Equal(Success expOp, op)
    Assert.Equal(Success expArg2, arg2)

[<Theory>]
[<InlineData("2.15", "lolo", "34.5")>]
[<InlineData("169.1", "", "35.1123")>]
let ``Fail with wrong operation`` (inArg1, inOp, inArg2) =
    let arg1, op, arg2 = TryParseArguments [|inArg1; inOp; inArg2|]
    Assert.Equal(Failure "Not allowed operation.", op)
    
[<Theory>]
[<InlineData("omg", "+", "3.1")>]
[<InlineData("", "*", "3.1")>]
let ``TryParserArguments gives failure with incorrect arg1`` (inArg1, inOp, inArg2) =
    let arg1, op, arg2 = TryParseArguments [|inArg1; inOp; inArg2|]
    Assert.Equal(Failure "Not allowed argument.", arg1)

[<Theory>]
[<InlineData("12", "+", "wtf")>]
[<InlineData("10", "/", "wtwefweg")>]
let ``TryParserArguments gives failure with incorrect arg2`` (inArg1, inOp, inArg2) =
    let arg1, op, arg2 = TryParseArguments [|inArg1; inOp; inArg2|]
    Assert.Equal(Failure "Not allowed argument.", arg2)

[<Theory>]
[<InlineData("ewrgwerg", "-", "afag")>]
[<InlineData("234f5324f5", "*", "wtf")>]
let ``TryParserArguments gives failure with incorrect args`` (inArg1, inOp, inArg2) =
    let arg1, op, arg2 = TryParseArguments [|inArg1; inOp; inArg2|]
    Assert.Equal(Failure "Not allowed argument.", arg1) 
    Assert.Equal(Failure "Not allowed argument.", arg2) 