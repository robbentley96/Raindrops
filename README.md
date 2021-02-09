# Raindrops
## Purpose
This projects aims to solve the raindrops problem as seen below.
## Task
Write a function that takes as its input a number (n) and converts it to a string, the contents of which depend on the numbers factors

- if the number has a factor of 3, output 'Pling'
- if the number has a factor of 5, output 'Plang'
- if the number has a factor of 7, output 'Plong'
- if the number does not have any of the above as a factor simply return the numbers digits

## Examples

- 28's factors are 1, 2, 4, 7, 14 and 28: this would be a simple 'Plong'
- 30's factors are 1, 2, 3, 5, 6, 10, 15, 30: this would be a 'PlingPlang'
- 34 has four factors: 1, 2, 17, and 34: this would be '34'

## Testing
Unit tests have been written using the constraint model and included in the project to demonstrate the performance of the raindrops method.
These tests are split into testing methods with multiple testcases. There is a testing method for each permutation of pling, plang and plong. Additionally there are testcases for numbers which are not multiples of 3, 5 and 7.
Negative integers and 0 have been included in the tests for wider test coverage.
