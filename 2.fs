// For more information see https://aka.ms/fsharp-console-apps
let rec printList V =
    match V with
    | [] -> ()
    | head :: tail ->
        printfn "%A" head
        printList tail

let listOfItems = ["KIlo"; "GraM"; "Mile"]
printList listOfItems