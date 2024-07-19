// For more information see https://aka.ms/fsharp-console-apps
// Function to trim spaces from each element in the list
let trimTheGivenSpace (givenList: string list) =
    givenList |> List.map (fun x -> x.Trim())

// List of strings with leading and trailing spaces
let names = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]

// Trim spaces from each element
let trimmedNames = trimTheGivenSpace names

// Print each trimmed name
trimmedNames |> List.iter (printfn "%s")
