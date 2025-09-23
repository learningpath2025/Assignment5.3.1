# Assignment5.3.1

- You have a long flowerbed in which some of the plots are planted, and some are not. 
- However, flowers cannot be planted in adjacent plots.
- Given an integer array flowerbed containing 0's and 1's. 
- Where 0 means empty and 1 means not empty, and an integer n, 
- return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

- Example 1:
	- Input: flowerbed = [1,0,0,0,1], n = 1
	- Output: true
- Example 2:
	- Input: flowerbed = [1,0,0,0,1], n = 2
	- Output: false

- Hints:
	- Create a foreach loop to go over each plot.
	- Check if the current plot is empty.
	- Check left neighbor (or if it's the first plot).
	- Check right neighbor (or if it's the last plot).
	- If both neighbors are empty (or out of bounds), plant the flower and decrement the count of flowers to plant.
	- If we have planted enough flowers, return true.
	- If the loop finishes and we still need to plant more flowers, return false.