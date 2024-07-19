// For more information see https://aka.ms/fsharp-console-apps
// Create a sequence of the first 700 positive integers
let numbers = seq { 1 .. 700 }

// Convert the sequence to a list
let numberList = numbers |> Seq.toList

// Filter out elements that are multiples of both 7 and 5
let filteredNumbers = 
    numberList 
    |> List.filter (fun x -> x % 7 = 0 && x % 5 = 0)

// Sum all the filtered numbers using List.fold
let sumOfFilteredNumbers = 
    filteredNumbers 
    |> List.fold (fun acc x -> acc + x) 0

// Print the result
printfn "The sum of numbers that are multiples of both 7 and 5 is %d" sumOfFilteredNumbers
