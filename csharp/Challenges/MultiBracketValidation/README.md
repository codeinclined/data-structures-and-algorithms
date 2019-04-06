# Multi-bracket Validation

This challenge takes in an input string and returns whether or not any bracket
characters from the following list are mismatched: '(', '{', '[', ']', '}', ')'.
A mismatched bracket means that the opening version of that bracket character
does not pair up with its corresponding closing character before encountering
some other opening or closing character per the rules of grouping expressions
in mathematics.

## Challenge

- Your function should take a string as its only argument, and should return a
boolean representing whether or not the brackets in the string are balanced.
- There are 3 types of brackets:
  - Round Brackets: (
  - Square Brackets: [
  - Curly Brackets: {

### Examples

    Input                     Output
    --------------------------------
    {}                        true
    ()[[Extra Characters]]    true
    (){}[[]]                  true
    {}{Code}[Fellows](())     true
    (]                        false

## Solution

![Whiteboard Solution Photo](/assets/MultiBracketValidation.jpg)
