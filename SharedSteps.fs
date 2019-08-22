module SharedSteps

open Xunit.Gherkin.Quick

// [<FeatureFile("./AddTwoNumbers.feature")>]
[<AutoOpenAttribute>]
type AddTwoNumbersRoot() =
    inherit Feature()

    [<Given(@"I chose (\d+) as first number")>]
    member __.``Given I chose x as first number`` (firstNumber:int) = 
        printfn "in Given I chose x as first number %i" firstNumber


// [<AutoOpenAttribute>]
// type AddTwoNumbersRoot with
//     [<And(@"I chose (\d+) as second number")>]
//     member __.``I chose second number`` (secondNumber:int) = 
//         printfn "in I chose second number %i" secondNumber    