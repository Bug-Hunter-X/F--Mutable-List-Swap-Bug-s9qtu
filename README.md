# F# Mutable List Swap Bug

This repository demonstrates a common error when working with mutable variables and lists in F#.  The bug arises from the misconception that F# lists behave like mutable arrays in other languages.  F# lists are immutable; therefore, attempting to swap them using mutable references results in unexpected behavior.

## Bug Description
The code attempts to swap two mutable lists.  However, due to the immutability of F# lists, the swap operation doesn't work as intended.  The expected outcome is that the two lists are swapped, but instead, both lists end up referencing the same list after the swap operation.