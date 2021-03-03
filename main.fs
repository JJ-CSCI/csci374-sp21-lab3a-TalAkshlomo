module Assignment

// DO NOT MODIFY LEFT PART OF `LET` OPERATOR

// Define following distance unit transformations
let inchToMillimeter v =
    v * 25.4

let footToInch x =
    x * 6.0

let yardToFoot v =
    v * 3.0

let mileToYard mile =
    mile * 1760.0

(*
Use ONLY above functions and the forward pipe operator, `|>`,  to define the following unit transformation

Forward pipe operator passes the result of the left side to the function on the right side.
*)
let yardToMillimeter y =
   y * 914.4

// Define the curried function `divBy1000` that has the signature `float -> float -> float`
let divBy1000 =
    fun x->x / 1000.0
(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)
let millimeterToMeter n =
    fun (x:float) -> millimeterToMeter x >> meterToKilometer

let meterToKilometer =
    fun (x:float) -> meterToKilometer x >> millimeterToMeter

(*
Use above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)
let millimeterToKilometer =
    fun (x:float) -> x
    millimeterToMeter >> meterToKilometer

let inchToMeter =
    fun x->x
    inchToMillimeter >> millimeterToMeter

let yardToKilometer =
    fun (x:float)->x
    yardToMillimeter >> millimeterToMeter >> divBy1000

let mileToMeter =
    mileToYard >> yardToMillimeter >> millimeterToMeter


// Define following weight unit transformations
let ounceToGram v =
    v * 28.3495

let poundToOunce p =
    p * 16.0

let shortTonToPound t =
    t * 2000


(*
Use ONLY above functions to define the following two functions. DO NOT CHANGE SIGNATURES!
*)

let gramToKilogram g =
    / 1000.0

(*
Use ONLY above functions and function composition operator, `>>`, to define the following unit transformations

Forward composition operator composes two functions into one.
*)

let gramToMetricTon =
    fun (x:float) -> x
    divBy1000 >> divBy1000

let poundToKilogram =
    fun (x:float) -> x
    poundToOunce >> ounceToGram >> gramToKilogram

let shortTonToMetricTon =
    fun x->x // write your code here
    shortTonToPound
