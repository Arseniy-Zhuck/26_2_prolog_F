// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
let rec read_list n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = read_list (n-1)
    Head::Tail

let read_data = 
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    read_list n

let rec prog list=
    match list with
    |[] -> []
    |h::t ->    let tail=prog t
                if h%2=0 then h::tail
                         else tail  

let rec write_list list=
    match list with
    |[] ->   let z=System.Console.ReadKey()

             0
    |h::t -> System.Console.WriteLine(h.ToString())
             write_list t   


[<EntryPoint>]
let main argv = 
    write_list (prog read_data) // return an integer exit code
