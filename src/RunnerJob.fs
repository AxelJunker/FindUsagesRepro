module Repro.RunnerJob

open Repro

// Find Usages on each of these.

// Doesn't work
let withParamAbbrev (_: string) : Runner.Job = fun _ -> 1

// Works
let withParamExpanded (_: string) : int -> int = fun _ -> 1

// Works
let noParamAbbrev: Runner.Job = fun _ -> 1
