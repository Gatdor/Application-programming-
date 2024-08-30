# C# Coding Examples

This repository contains a series of C# code examples and explanations covering fundamental and advanced programming concepts. Each section includes code and a brief overview of the concepts demonstrated.

## 1. Calculator Application

**Description:** A simple console calculator and additional functionalities.

- **Calculator Program:** Performs addition, subtraction, multiplication, and division based on user input.
- **Average Calculation Method:** Computes the average of an integer array, handling empty arrays by returning 0.
- **Employee Class:** Demonstrates constructors, including a default and overloaded constructor with optional parameters like department and salary.

## 2. String Comparison

**Description:** Compares strings using `==` and `Equals()` methods.

- **`==` Operator:** Compares string references, checking if two strings point to the same object.
- **`Equals()` Method:** Checks for value equality, regardless of object references.
- **Code Output:**
  - `str1 == str2`: `true` (same literal string)
  - `str1 == str3`: `false` (different object instances)
  - `str1.Equals(str3)`: `true` (same string content)

## 3. Abstraction

**Description:** Shows how abstraction is implemented with abstract classes and derived classes.

- **Abstract `Shape` Class:** Defines an abstract method `Draw()`.
- **Derived Classes:** `Circle` and `Square` implement the `Draw()` method and include additional properties and methods.

## 4. Output Predictions

**Description:** Predicts and explains the output of various code snippets.

- **Array Printing:** Prints each element of an integer array.
- **String Comparison with Ignore Case:** Shows case-insensitive comparison results.
- **Object Equality:** Demonstrates comparison of object references.
- **Variable Assignment:** Outputs the result of a variable assignment and addition.

## 5. Finding Max/Min in List

**Description:** Finds the largest and smallest integers in a list, handling an empty list.

- **Method:** Returns the largest and smallest values from a list, with special handling for empty lists.

## 6. Reading Integers and Ignoring Duplicates

**Description:** Reads integers from the console until a negative number is entered, ignoring duplicates.

- **Program:** Calculates and displays the sum of unique integers entered by the user.

## 7. Enum for Days of the Week

**Description:** Uses an enum to represent days of the week.

- **Enum Operations:** Identifies weekend days and performs operations based on the enum value.

## 8. Reversing a String

**Description:** Reverses a string input from the user and prints it.

- **Program:** Reads a string and outputs its reversed version.

## 9. Dictionary for Student Grades

**Description:** Demonstrates the use of a `Dictionary<TKey, TValue>` to store and retrieve student grades.

- **Example:** Shows how to manage student grades with a dictionary, supporting various data types for keys and values.

## 10. Interfaces and Abstract Classes

**Description:** Shows the use of interfaces and abstract classes for abstraction and polymorphism.

- **IDrive Interface:** Defines a `Drive()` method implemented by `Car` and `Bike` classes. Demonstrates polymorphism using a list of `IDrive` objects.
- **Abstract `Animal` Class:** Defines an abstract method `MakeSound()` with derived classes `Dog` and `Cat` implementing the method. Demonstrates polymorphism with a list of `Animal` objects.

## 11. Project Approaches

**Description:** Compares top-down and bottom-up design approaches.

- **Top-Down Approach:** Benefits from structured planning of high-level functionality before implementation. Example: Designing a large-scale application with clear module definitions.
- **Bottom-Up Approach:** Focuses on developing small, independent functions first and combining them. Example: Building a library with reusable components.

## 12. Value Types vs. Reference Types

**Description:** Explains the difference between value types and reference types in C#.

- **Value Types:** Stored directly and include types like `int` and `struct`. Efficient for small, simple data.
- **Reference Types:** Store references to objects and include types like `string` and `class`. Suitable for complex data and objects.

- **Example Program:** Demonstrates comparisons and memory address handling between `int` and `string` arrays using `Object.ReferenceEquals`.

## 13. Encapsulation

**Description:** Demonstrates encapsulation principles using private fields and public properties.

- **Person Class:** Uses private fields for `name` and `age` and public properties with validation to control access. Ensures age is non-negative.

## 14. Arrays and Enums

**Description:** Differentiates between single-dimensional and jagged arrays, and provides use cases for each.

- **Single-Dimensional Array:** A simple array with one dimension, used for straightforward data storage.
- **Jagged Array:** An array of arrays, useful for irregular data structures.
- **Example Method:** Calculates the sum of elements in a two-dimensional array, handling irregular shapes.

## 15. Threads and Concurrency

**Description:** Explains the role of threads and compares `Thread` and `Task` classes for concurrent execution.

- **Thread Class:** Demonstrates creating and starting a new thread. Includes synchronization and thread safety handling.
- **Task Class:** Provides a higher-level abstraction for asynchronous programming, simplifying task management.

## 16. HttpClient and File Operations

**Description:** Shows how to make HTTP requests and handle file operations.

- **HttpClient Example:** Fetches data from a public API and parses JSON to display article titles and summaries.
- **File Operations Example:** Reads lines from one file and writes them to another, with optional filtering based on keywords or length.

## 17. Interfaces in C#

**Description:** Discusses the purpose and benefits of using interfaces for loose coupling and code reusability.

- **IDrive Interface:** Defines a `Drive()` method implemented by `Car` and `Bike`. Demonstrates polymorphism using a list of `IDrive` objects.
- **Abstract Classes vs. Interfaces:** Explains when to use abstract classes versus interfaces, focusing on scenarios where one might be more appropriate than the other.
- **Animal Example:** Uses an abstract class `Animal` with a method `MakeSound()` implemented by derived classes `Dog` and `Cat`. Demonstrates polymorphism with a list of `Animal` objects.

## 18. Project Design Approaches

**Description:** Compares top-down and bottom-up design strategies.

- **Top-Down Approach:** Focuses on planning and defining high-level functionality first. Example: Complex application requiring clear module definitions.
- **Bottom-Up Approach:** Builds small, independent components first, then integrates them. Example: Modular library development with testable units.

## Summary

This repository showcases a diverse set of C# programming examples that demonstrate key concepts, including basic operations, string handling, object-oriented principles, and advanced features like concurrency, file operations, and design approaches. Each example includes explanations to help you understand and apply these concepts effectively in your projects.

Feel free to explore, modify, and expand upon these examples to suit your needs. Happy coding!
