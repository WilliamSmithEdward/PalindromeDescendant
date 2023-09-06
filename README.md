# PalindromeDescendant
The PalindromeDescendant method checks if a number or its "descendants" are palindromic. A palindromic number is one that reads the same forwards and backwards, like 121 or 1221. 

* If the number has more than two digits, the method creates its "descendant". This is done by adding pairs of digits next to each other. For example, 233 becomes 56 because 2+3 is 5 and 3+3 is 6.
* If the number has only two digits, the method checks if both digits are the same.
* The method keeps making new descendants and checks each one. If it finds a palindromic descendant, it stops and returns true. If not, it returns false.

## Logic:
* Convert the number to its string representation.
* Check if the string representation of the number is a palindrome, using the following criteria:
* Split the number string into two halves.
* Compare the first half to the reverse of the second half.
* If both are equal, then the number is a palindrome.
* If the number string has more than 2 characters, create its descendant by summing pairs of adjacent digits.
* If the number string has 2 characters, check if both characters are the same.

## Returns:
* bool: Returns true if the number or any of its descendants are palindromic; otherwise, returns false.

## Notes:
* Console outputs are present within the method for debugging purposes. They provide insights into the various stages of the palindrome check.
* The method will return true as soon as it identifies a palindrome, without needing to check further descendants.

## Examples

```csharp
PalindromeDescendant(11211230) ➞ false
// 11211230 ➞ 2333 ➞ 56

palindromeDescendant(13001120) ➞ true
// 13001120 ➞ 4022 ➞ 44

PalindromeDescendant(23336014) ➞ true
// 23336014 ➞ 5665

PalindromeDescendant(11) ➞ true
// Number itself is a palindrome.
```
