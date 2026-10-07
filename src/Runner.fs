module Repro.Runner

type Job = int -> int

let newJob (job: Job) : int =
    job 0
