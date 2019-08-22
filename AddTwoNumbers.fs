module FeatureTests

open Xunit
open Xunit.Gherkin.Quick
open SharedSteps
open SharedSteps2

[<FeatureFile("./AddTwoNumbers.feature")>]
type AddTwoNumbers() =
    inherit AddTwoNumbersRoot()

    let a : int = 1

    // [<Given(@"I chose (\d+) as first number")>]
    // member __.``Given I chose x as first number`` (firstNumber:int) = 
    //     printfn "in Given I chose x as first number %i" firstNumber

    [<And(@"I chose (\d+) as second number")>]
    member __.``I chose second number`` (secondNumber:int) = 
        printfn "in I chose second number %i" secondNumber    

    [<When(@"I press add")>]
    member __.``I press add`` () = 
        printfn "in I press add"

    [<Then(@"the result should be (\d+) on the screen")>]
    member __.``The result should be z on the screen`` (expectedResult:int) = 
        printfn "in The result should be z on the screen %i" expectedResult
        Assert.True(true)
