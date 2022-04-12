# Binary Search
## Description
- Steps for implement Binary Search:
1.Compare x with the middle element.
2.If x matches with the middle element, we return the mid index.
3.Else If x is greater than the mid element, then x can only lie in the right half subarray after the mid element. So we recur for the right half.
## What I have learned?
- Is BigO(log n)
- The array have to be sorted in order to work.
- Start from the half of the array asking if the number is bigger or smaller than the number in the middle of the array.
- Can be implemente two ways Recursive and Iterative way.
