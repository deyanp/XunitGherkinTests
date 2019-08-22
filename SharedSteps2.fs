module SharedSteps2

open SharedSteps
open Xunit.Gherkin.Quick

[<AutoOpenAttribute>]
type AddTwoNumbersRoot with
    [<And(@"I chose (\d+) as second number")>]
    member __.``I chose second number`` (secondNumber:int) = 
        printfn "in I chose second number %i" secondNumber    


