# Towers of Hanoi

This challenge involves writing an algorithm to solve the Towers of Hanoi
problem and present each move needed for its solutions. Towers of Hanoi
is a classic problem in which the player is required to move a number of
disks from the first of three towers to the last tower. Each disk is of
a different size, and disks can only be moved one at a time to either
an empty tower or one that current has a larger disk on top. The ideal
solution for this problem for any number, n, disks is 2ⁿ - 1.

## Challenge

- The Towers of Hanoi is a mathematical puzzle where you have 3 towers and N disks of different sizes.
- The puzzle starts with the disks sorted (i.e. smaller disks sits on top of larger disks) on the left-most tower, and the objective of the puzzle is to move the disks to the right-most tower with the following restrictions: 
  - Only one disk can be moved at a given time.
  - A disk is moved from the top of a tower to the top of another tower.
  - A disk can’t be placed on top of a smaller disk.

### Examples
    Input    Moves
    2        Disk 1 moved from A to B
             Disk 2 moved from A to C
             Disk 1 moved from B to C

    3        Disk 1 moved from A to C
             Disk 2 moved from A to B
             Disk 1 moved from C to B
             Disk 3 moved from A to C
             Disk 1 moved from B to A
             Disk 2 moved from B to C
             Disk 1 moved from A to C

## Solution

![Whiteboard Solution Photo](/assets/TowersOfHanoi.jpg)
