# 01_CodeChallenge_Chunker
Solution for a C# coding verification test I did 

## Unit Tests to be added


## Task

Receive a string and a value of chunks to be splitted

If the value of chunk is less then 1, an ArgumetException should be raised
If the provided string is empty, a empty array of strings should be returned
If number of chunks is greater than the string size, the number of chunks must be the string size
The difference of characters should be divided at the beginning of the array

Methods signature:

public static IEnumerable<string> ChunkIter(string s, int chunks)
public static string[] Chunk(string s, int chunks)

Output example:

s = "abcdefgh"
chunks = 5

output: ["ab", "cd", "ef", "g", "h"]

_____________________________

s = "abcdefgh"
chunks = 10

output: ["a", "b", "c", "d", "e", "f", "g", "h"]

_____________________________

s = ""
chunks = 3

output: []



