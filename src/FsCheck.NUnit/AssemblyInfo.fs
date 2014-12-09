﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FsCheck.Nunit")>]
[<assembly: AssemblyProductAttribute("FsCheck.Nunit")>]
[<assembly: AssemblyDescriptionAttribute("Integrates FsCheck with NUnit")>]
[<assembly: AssemblyVersionAttribute("1.0.4")>]
[<assembly: AssemblyFileVersionAttribute("1.0.4")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.4"
