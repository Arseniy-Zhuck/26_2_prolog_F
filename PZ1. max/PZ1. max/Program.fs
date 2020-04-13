// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.



[<EntryPoint>]
let main argv =
    let p1_1 x y =
        if x>y then x
        else y 
    
    let b = System.Convert.ToInt32(System.Console.ReadLine())
    let c = System.Convert.ToInt32(System.Console.ReadLine()) 
    let A = p1_1 b,c
    
    printfn "%A" A
    let z = System.Console.ReadKey()
     
    printfn "%A" argv
    0 // return an integer exit code
