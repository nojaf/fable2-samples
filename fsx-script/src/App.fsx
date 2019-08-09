#load "../.paket/load/netstandard2.0/main.group.fsx"

open System

let defines = "FOO;BAR"
defines.Split([|' ';',';';'|], StringSplitOptions.RemoveEmptyEntries)
|> printfn "%A"