module CalculatorTests
open hw5
open Parser
open Xunit
open Calculator

[<Theory>]
[<InlineData(16, "+", 15, 31)>]
[<InlineData(1, "-", 6, -5)>]
[<InlineData(5, "*", 3, 15)>]
[<InlineData(5, "+", 7, 12)>]
let ``Correct with int values`` (arg1, op, arg2, expected) =
    let result = Calculate arg1 op arg2
    Assert.Equal(Success expected, result)

[<Theory>]
[<InlineData(20.1, "+", 12.5, 32.6)>]
[<InlineData(2.5, "-", 1.6, 0.9)>]
[<InlineData(0.9, "*", 2, 1.8)>]
[<InlineData(8.23543, "/", 8.23543, 1)>]
let ``Correct with rational values`` (arg1, op, arg2, expected) =
    let result = Calculate arg1 op arg2
    Assert.Equal(Success expected, result)
    
[<Theory>]
[<InlineData(100, "/", 0)>]
let ``fail on division by zero`` (arg1, op, arg2) =
    let result = Calculate arg1 op arg2
    Assert.Equal(Failure "Divide by zero is not allowed.", result)