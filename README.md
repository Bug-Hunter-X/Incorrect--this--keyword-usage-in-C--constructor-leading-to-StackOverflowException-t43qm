# Incorrect 'this' keyword usage in C# constructor leading to StackOverflowException
This repository demonstrates a common error in C# constructors where the 'this' keyword is misused, resulting in a StackOverflowException.  The incorrect usage involves attempting to assign 'this' to a new instance of the same class within the constructor.  This creates an infinite recursive call, eventually exceeding the stack limit.

The `bug.cs` file contains the erroneous code. The `bugSolution.cs` file provides the corrected implementation.

## How to Reproduce
1. Clone this repository.
2. Compile and run `bug.cs`.  Observe the StackOverflowException.
3. Compile and run `bugSolution.cs` to see the corrected behavior.