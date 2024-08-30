# Application-programming-
Application programming codes
# C# Coding Examples

This repository contains C# code examples that cover fundamental and advanced programming concepts. Each example demonstrates key functionalities and programming principles.

## 1. Calculator Application

**Code:** A console application that performs basic arithmetic operations and calculates the average of a list of integers.

- **Calculator Program:** 
  - Reads two numbers from the user.
  - Performs addition, subtraction, multiplication, or division based on user choice.
- **Average Calculation Method:**
  - Computes the average of integers in an array.
  - Handles an empty array by returning 0.
- **Employee Class:**
  - Includes a constructor for an employee's name and ID.
  - Demonstrates a secondary constructor with optional parameters like department and salary.

## 2. String Comparison

**Code:** Demonstrates string comparison using the `==` operator and the `Equals()` method.

- **String Comparisons:**
  - `==` checks if two strings reference the same object.
  - `Equals()` checks for value equality, regardless of object references.
  - Code examples show the results of comparisons between literal strings and string objects.

## 3. Advanced C# Concepts

### Abstraction

**Code:** Shows how abstraction can be implemented using abstract classes and interfaces.

- **Abstract Shape Class:**
  - Defines an abstract class `Shape` with an abstract method `Draw()`.
  - Derived classes `Circle` and `Square` implement the `Draw()` method and include additional properties.

### Additional Code Examples

- **Output Predictions:**
  - Includes code to predict and explain the output of various operations, such as array printing and variable assignments.
- **Finding Max/Min in List:**
  - Returns the largest and smallest integers from a list.
  - Handles cases where the list might be empty.
- **Reading Integers and Ignoring Duplicates:**
  - Reads integers until a negative number is entered.
  - Calculates and displays the sum of unique integers.
- **Enum for Days of the Week:**
  - Demonstrates how to use an enum to represent days of the week.
  - Includes operations based on the enum value, such as identifying weekends.
- **Reversing a String:**
  - Takes a string input from the user and prints it in reverse order.
- **Dictionary for Student Grades:**
  - Uses a `Dictionary<TKey, TValue>` to store and retrieve student grades.
  - Handles various data types for keys and values.

## 4. Interfaces and Abstract Classes

**Code:** Demonstrates the use of interfaces and abstract classes for abstraction and polymorphism.

- **IDrive Interface:**
  - Defines an interface `IDrive` with a `Drive()` method.
  - Implemented in `Car` and `Bike` classes.
  - Demonstrates polymorphism using a list of `IDrive` objects.
- **Abstract Animal Class:**
  - Defines an abstract class `Animal` with an abstract method `MakeSound()`.
  - Derived classes `Dog` and `Cat` implement `MakeSound()`.
  - Demonstrates polymorphism with a list of `Animal` objects.

## 5. Project Approaches

### Top-Down Approach

**Description:** 
- **Top-Down Design:**
  - Benefits include structured planning and clear module definition before implementation.
  - Example: A large-scale system with multiple modules, where high-level functionality is defined first.

### Bottom-Up Approach

**Description:** 
- **Bottom-Up Design:**
  - Focuses on implementing small, independent functions first, then combining them.
  - Example: A library with reusable components, where individual functionalities are developed and tested before integration.

## Summary

This repository provides a range of C# code examples that illustrate essential programming concepts, from basic operations and string handling to advanced features like abstraction, interfaces, and different project design approaches. 
