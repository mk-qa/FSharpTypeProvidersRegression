namespace RegexTypeProvider

open System.Globalization
open FSharp.Text.RegexProvider
open FSharp.Text.RegexExtensions

module TestRegex =

    type PhoneRegex = Regex< @"(?<AreaCode>^\d{3})-(?<PhoneNumber>\d{3}-\d{4}$)" >
    let value1 = PhoneRegex().TypedMatch("425-123-2345").AreaCode.Value
    match PhoneRegex().TryTypedMatch("425-123-2345") with
    | Some m -> printfn "Phone number is %s" m.PhoneNumber.Value
    | None -> printfn "Phone number unavailable"
    
    type TempRegex = Regex< @"^(?<Temperature>[\d\.]+)\s*°C$", noMethodPrefix = true >
    let value2 = TempRegex().Match("21.3°C").Temperature.TryValue

    type DateRegex = Regex< @"^Date:\s*(?<Date>\d{4}-\d{2}-\d{2})$", noMethodPrefix = true >
    let value3 = DateRegex().Match("Date: 2019-06-18").Date.AsDateTime(DateTimeStyles.AssumeUniversal|||DateTimeStyles.AdjustToUniversal)
