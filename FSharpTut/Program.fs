open System

let loop_stuff() =

    for i = 1 to 10 do
        printfn "%i" i

    for i = 10 downto 1 do
        printfn "%i" i

    for i in [1..10] do
        printfn "%i" i

    [1..10] |> List.iter (printfn "Num : %i")

    let sum = List.reduce (+) [1..10]
    printfn "Sum : %i" sum

    let magic_num  = "7"
    let mutable guess = ""
    while not (magic_num.Equals(guess)) do
        printfn "Guess the number:"
        guess <- Console.ReadLine()
    printfn "You guessed the number"

loop_stuff()

let string_stuff() =

    let str1 = "This is a random string"

    let str2 = @"I ignore backslashes"

    let str3 = """ "I ignore double qoutes and backslashes """

    let str4 = str1 + " " + str2

    printfn "Lenght : %i" (String.length str4)
    printfn "%c" str1.[1]
    printfn "1st Word : %s" (str1.[0..3])

    let upper_str = String.collect (fun c -> sprintf"%c, " c) "commas"
    printfn "Commas : %s" upper_str

    printfn "Any upper : %b" (String.exists (fun c -> Char.IsUpper(c)) str1)
    
    printfn "Number : %b" (String.forall (fun c -> Char.IsDigit(c)) "1234")

    let string1 = String.init 10 (fun i -> i.ToString())
    printfn "Numbers : %s" string1

    String.iter(fun c -> printfn "%c" c) "Print me"


string_stuff()

Console.ReadKey() |> ignore
