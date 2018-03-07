# AnsibleProblemSolving
Print all numbers in the sequence 1 – 100 inclusive on a separate line. If the number is divisible by 3 print “ Ansible” next to the number, if the number is divisible by 5 print “ Australia” next to the number, otherwise if the number is divisible by 3 and 5 print “ Ansible Australia” next to the number.

The structure of the project is:

- A .NET Library targeting .NET Standard 2.0 which provides a class to process an int number and returns the type of number based in the following requirements
  1. Type "Ansible" if the number is divisible by 3
  2. Type "Australia" if the number is divisible by 5
  3. Type "AnsibleAus" if the number is divisible by 3 and 5
  4. Type "None" for every other case
  
- A .NET console project targeting .Net Core 2.0 as an entry point to this solution and which references the library in order to determine the types for numbers from 1 to 100

- A .NET UnitTest project targeting .Net Core 2.0 with the UnitTests to test the functionality of the library
