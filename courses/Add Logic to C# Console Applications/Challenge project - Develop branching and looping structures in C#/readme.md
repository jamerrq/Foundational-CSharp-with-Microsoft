# Challenge project - Develop branching and looping structures in C\#

Demonstrate your ability to develop a console app that implements selection and iteration statements to achieve app specifications.

## Introduction

Applications often use a combination of selection and iteration statements to establish code execution paths. In addition, user input and calculations influence the flow through an application. Creating a user interface that implements a design specification can be challenging.

Suppose you're a developer working on the Contoso Pets application, an application that's used to find homes for stray or abandoned pets. Some of the development work has already been completed. For example, the application's main menu and the code used to store new pet information have been developed. However, certain information isn't always available when a pet is entered in your system. You need to develop the features that ensure a complete dataset exists for each animal in your care.

### Learning objectives

In this module, you'll demonstrate your ability to:

Use Visual Studio Code to develop a C# console application that uses a combination of selection and iteration statements to implement logical workflows.
Evaluate the underlying conditions in your application and make an informed decision between selection statement options.
Evaluate the underlying conditions in your application and make an informed decision between iteration statement options.
Scope variables at an appropriate level within an application.

## Prepare

In this challenge project, you'll use Visual Studio Code to develop portions of a C# console application. You'll use boolean expressions, selection statements, and iteration statements to implement the features of a design specification. As you develop the application, you'll need to scope variables at the appropriate level.

### Project specification

- The Starter code project for this module includes a Program.cs file with the following code features:

- The code declares variables used to collect and process pet data and menu item selections

- The code declares the ourAnimals array that includes the following information for each animal in the array:

  - Pet ID #.
  - Pet species (cat or dog).
  - Pet age (years).
  - A description of the pet's physical appearance.
  - A description of the pet's personality.
  - The pet's nickname.
  - The code uses a for loop around a switch-case construct to populate elements of the ourAnimals array.

- The code includes a loop around a main menu that terminates when the user enters "exit". The main menu includes:

  1. List all of our current pet information.
  2. Assign values to the ourAnimals array fields.
  3. Ensure animal ages and physical descriptions are complete.
  4. Ensure animal nicknames and personality descriptions are complete.
  5. Edit an animal’s age.
  6. Edit an animal’s personality description.
  7. Display all cats with a specified characteristic.
  8. Display all dogs with a specified characteristic.

Enter menu item selection or type "Exit" to exit the program

- The code reads the user's menu item selection and uses a switch statement to branch the code for each menu item number.

- The code includes implementation for menu options 1 and 2.

- The code displays an "under construction" message for menu options 3-8.

Your goal in this challenge is to create the app features aligned with menu options 3 and 4.

To ensure that animal ages and physical descriptions are complete, your code must:

- Assign a valid numeric value to petAge for any animal that has been assigned data in the ourAnimals array but has not been assigned an age.
- Assign a valid string to petPhysicalDescription for any animal that has been assigned data in the ourAnimals array but has not been assigned a physical description.
- Verify that physical descriptions have an assigned value. Assigned values cannot have zero characters. Any further requirement is up to you.
- To ensure that animal nicknames and personality descriptions are complete, your code must:

- Assign a valid string to petNickname for any animal that has been assigned data in the ourAnimals array but has not been assigned a nickname.
- Assign a valid string to petPersonalityDescription for any animal that has been assigned data in the ourAnimals array but has not been assigned a personality description.
- Verify that nicknames and personality descriptions have an assigned value. Assigned values cannot have zero characters. Any further requirement is up to you.

## Exercise 1 - Ensure that petAge and petPhysicalDescription contain valid information

The Contoso Pets application is used to help find new homes for abandoned pets. Your goal in this challenge is to develop the application features used to ensure that you have a completed dataset for each animal in the ourAnimals array.

### Specification

In this challenge exercise, you need to develop a feature that ensures animal ages and physical descriptions are complete.

This feature must:

- Be enabled inside the appropriate application branch (must not overwrite the code in the code branch for menu option 2).

- Skip over any animal in the ourAnimals array when the value of pet ID is set to the default value.

- Display the pet ID value and prompt the user for an updated data value if ourAnimals array data is missing or incomplete.

- Ensure that a valid numeric value is assigned to animalAge for all animals in the ourAnimals array that have assigned data.

- Ensure that a valid string is assigned to animalPhysicalDescription for all animals in the ourAnimals array that have assigned data.

- Enforce the following validation rules for animalAge.

  - It must be possible to convert the value entered to numeric data type.
- Enforce the following validation rules for animalPhysicalDescription:

  - Values cannot be null.
  - Values cannot have zero characters.
  - Any further restriction is up to the developer.
- Inform the application user when all data requirements are met, pausing the application to ensure the message can be seen and responded to.

## Exercise 2 - Ensure that pet nicknames and personality descriptions are complete

The Contoso Pets app is used to help find new homes for abandoned pets. Your goal in this challenge is to develop the app features used to ensure that we have a completed dataset for each animal in the ourAnimals array.

### Specification

You need to develop a feature that ensures animal nicknames and personality descriptions are complete.

This feature must:

- Be enabled inside the appropriate application branch (must not overwrite the code in the code branch for menu option 2).

- Skip over any animal in the ourAnimals array when the value of pet ID is set to the value default value.

- Display the pet ID value and prompt the user for an updated data value if ourAnimals array data is missing or incomplete.

- Ensure that a valid string is assigned to animalNickname for all animals in the ourAnimals array that have assigned data.

- Ensure that a valid string is assigned to animalPersonalityDescription for all animals in the ourAnimals array that have assigned data.

- Enforce the following validation rules for petNickname and petPersonalityDescription:

  - Values cannot be null.
  - Values cannot have zero characters.
  - Any further restriction is up to the developer.

- Inform the application user when all data requirements are met, pausing the application to ensure the message can be seen and responded to.


## Summary

Your goal was to demonstrate the ability to develop features of an application that achieve a design specification. You needed to choose and implement the appropriate iteration and selection statement types to meet the stated requirements.

By creating nested combinations of iteration and selection statements, you built a user interface that enables the application user to enter valid pet data that filled gaps in the ourAnimals array.

Your ability to implement features of the Contoso Pets application based on a design specification demonstrates your understanding of the iteration and selection statements.

## Achievement

![Achievement](achievement.png)
