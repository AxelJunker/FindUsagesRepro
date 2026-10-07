module Repro.Program

[<EntryPoint>]
let main _ =
    Runner.newJob (RunnerJob.withParamAbbrev "x") |> ignore
    Runner.newJob (RunnerJob.withParamExpanded "x") |> ignore
    Runner.newJob RunnerJob.noParamAbbrev |> ignore

    0
