module ProgramTests

let genCode n =
    $"""
let fn%i{n}() =
    task {{
        do! task {{ return () }}
        do! task {{ return () }}
        do! task {{ return () }}
        do! task {{ return () }}
        do! task {{ return () }}
        do! task {{ return () }}
        do! task {{ return () }}
        do! task {{ return () }}
        do! task {{ return () }}
        do! task {{ return () }}
    }}

"""

let [<EntryPoint>] main _ =
    use file = System.IO.File.CreateText "../../../../AccessViolation/Library.fs"
    """module Library
"""
    + (seq { 1 .. 3140 }
        |> Seq.map genCode
        |> String.concat "")
    |> file.WriteLine

    0