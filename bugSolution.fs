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

//The correct way to swap lists in F# is to create new lists
let swapList list1 list2 =
    list2, list1

let mutable list2 = [6;7;8;9;10]

let myList2, list2_2 = swapList myList list2
printf "%A %A" myList2 list2_2// This will print [6;7;8;9;10] [1;2;3;4;5] as expected

//Another approach using List.append and List.take/List.skip
let swapList2 list1 list2 = 
    let len1 = List.length list1
    let len2 = List.length list2
    List.append (List.take len2 list2) (List.skip len2 list1), List.append (List.take len1 list1) (List.skip len1 list2)

let myList3, list2_3 = swapList2 myList list2
printf "%A %A" myList3 list2_3