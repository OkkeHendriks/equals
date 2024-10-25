open LibA

let value1 = LibA.makeValueOfTypeWithPrivateConstructor 1
let value2 = LibA.makeValueOfTypeWithPrivateConstructor 2

[<EntryPoint>]
let main _ =
    printfn "Comparing two values from a defined in a referenced library with a private constructor."
    if value1 = value2 then
        printfn "Equal"
    else
        printfn "Not equal"
    0

