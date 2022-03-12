Z3 problem descriptions:

1. Starting from the number 1, we go through a process of steps. At every step, we are allowed to do only one of two things: 
 - either multiply the number by 2, or: 
 - first subtract 1 and then divide by 3 (these two operations together are considered as one step)
But the latter option is only allowed when the division results in an odd integer, (i.e. an integer that is not a multiple of 2).
Use Z3 to find the shortest path to reach 19, starting from 1.

2. An alphametic puzzle (also sometimes known as a cryptarithm) is a type of puzzle where words are put together into an arithmetic formula such that digits can be substituted for the letters to make the formula true.

3. Logic Equations
This is a mathematical puzzle that requires logic. You have to figure out the variables' values by solving the logic equations using the grid below. 

4. The eight queens puzzle is the problem of placing eight chess queens on an 8×8 chessboard so that no two queens threaten each other; thus, a solution requires that no two queens share the same row, column, or diagonal.
 
5. We want to test 7 medicines in 7 test rounds, in such a way that:
Every medicine is tested in (exactly) three test rounds
Every test round tests (exactly) three different medicines
No pair of medicines is tested more than once in the same test round
Let Z3 find out whether the tests can be arranged in this way or not. And if it can be done, find a clear way 	 to present the resulting arrangement.

6. You have a grid of squares, all of which contain a skyscraper of various sizes. Around the grid are clues telling you how many skyscrapers you can see from that position. 
https://brainbashers.com/skyscrapers.asp  

7. We have 3 jugs of water, capacity: 8, 5, 3 liters resp.
	Initially 8 liters of water in the first jug, other two empty
	Wanted end-situation: 4 liters in the first jug, 4 liters in the second jug, 3rd jug empty
	The jugs are irregularly shaped and unmarked; no water can be spilled; each step pouring water from one 	jug to another stops when either the source jug is empty or the destination jug is full, whichever happens 	first. 

8. A set of dice is intransitive (or nontransitive) if it contains three dice, A, B, and C, with the property that A rolls higher than B more than half the time, and B rolls higher than C more than half the time, but it is not true that A rolls higher than C more than half the time.
https://en.wikipedia.org/wiki/Intransitive_dice 

9. In the picture below you see 3 triangles that cover each point of a 5x5 grid, in such a way that all vertices of all triangles are themselves points of that grid (not just points with integer coefficients). 
Use Z3 to find another set of triangles subject to the same conditions.

10. In the following Math’s challenge, you travel from 'START' to 'FINISH' in no specific order or direction from one adjacent circle to another, keeping the accumulating sum total always equal to another 'Prime' number. Values in adjacent circles can be used more than once but 'ping-ponging' between circles (i.e. returning immediately to the circle that you have just left) is not allowed. The following challenge is to finish with a sum total of 79 (a prime number). 
https://gordonburgin.com 

11. Cannibals and Missionaries. Three missionaries and three cannibals want to get to the other side of a river. There is a small boat, which can fit only two. To prevent a tragedy, there can never be more cannibals than missionaries together. 

12. We play a game with marbles. 
Initially, we have 4 marbles.
We play 5 steps.
In every step either the number of marbles is doubled, is incremented by 7, or is decreased by 5. 
Use z3 to see whether it is possible to end up with 5 marbles after doing exactly 5 such steps.
If it is possible: give the action for that step (doubling, incrementing, decreasing) and the number of marbles at that moment.
If it is not possible: give a short description why.

13. Spend exactly 400 euro and buy exactly 100 animals. 
Dogs cost 60 euro, cats cost 4 euro, and mice cost 1 euro each. 
You have to buy at least one of each. 
How many of each should you buy?
BONUS: Is there another solution? If yes, what is it? If not, explain. 
(tip: use z3-clauses to find out, and remember week 1 (slide 12, question c): how you get the second roots of a quadratic equation)

14. In this Zebra puzzle we have 3 Houses (1, 2, and 3). They are each colored differently (either pink, red or yellow). In each house lives a different animal (either a fish, a mouse or a zebra). And they each have a different drink (either tea, coffee or beer).
Use z3 to find out for each house: the color, the animal and the drink.
Present the results in a clear table.
- The fish lives in the pink house.
- The person drinking tea lives directly to the left of the pink house
- The third house is not red.
- The zebra lives directly to the left of the fish

15. The Tower of Hanoi is a mathematical game or puzzle consisting of three rods and a number of disks of various diameters, which can slide onto any rod. The puzzle begins with the disks stacked on one rod in order of decreasing size, the smallest at the top, thus approximating a conical shape. The objective of the puzzle is to move the entire stack to the last rod, obeying the following rules:
-	Only one disk may be moved at a time.
-	Each move consists of taking the upper disk from one of the stacks and placing it on top of another stack or on an empty rod.
-	No disk may be placed on top of a disk that is smaller than it. 
https://en.wikipedia.org/wiki/Tower_of_Hanoi  

