let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20 as expected

//Now let's try with a list
let mutable myList = [1;2;3;4;5]

let swapList list1 list2 =
    let temp = list1
    list1 <- list2
    list2 <- temp

let mutable list2 = [6;7;8;9;10]

swapList myList list2
printf "%A %A" myList list2 //This will print [6;7;8;9;10] [6;7;8;9;10] but we want [6;7;8;9;10] [1;2;3;4;5]

//The problem is that lists in F# are immutable. We need to create new lists with the swapped values.

let swapList list1 list2 =
    list2, list1

let myList2, list2_2 = swapList myList list2
printf "%A %A" myList2 list2_2// This will print [6;7;8;9;10] [1;2;3;4;5] as expected