﻿namespace System
open System.Reflection

[<assembly: AssemblyVersionAttribute("0.6.0")>]
[<assembly: AssemblyFileVersionAttribute("0.6.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.6.0"
