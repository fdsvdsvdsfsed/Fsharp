// For more information see https://aka.ms/fsharp-console-apps
// List of names
let names: string list = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]

// Filter names that contain the letter 'I' (case-insensitive)
let filteredNames: string list = 
    names 
    |> List.filter (fun name -> name.Contains("I", System.StringComparison.OrdinalIgnoreCase))

// Concatenate all the filtered names using List.fold
let concatenatedNames: string = 
    filteredNames 
    |> List.fold (fun acc name -> acc + name) ""

// Print the concatenated result
printfn "Concatenated names containing 'I': %s" concatenatedNames
