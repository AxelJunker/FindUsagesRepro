module Repro.Program

type Job = int -> int

// Find Usages on each of these functions.

// Doesn't work
let withParamAbbrev (_: string) : Job = fun _ -> 1

// Works
let withParamExpanded (_: string) : int -> int = fun _ -> 1

// Works
let noParamAbbrev: Job = fun _ -> 1

[<EntryPoint>]
let main _ =
    withParamAbbrev "x" |> ignore
    withParamExpanded "x" |> ignore
    noParamAbbrev |> ignore

    0
