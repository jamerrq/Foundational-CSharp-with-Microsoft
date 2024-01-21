# Guided project - Develop conditional branching and looping structures in C\#

Gain experience developing a console app that implements selection and iteration
statements to achieve app specifications.

## Introduction

It's common for developers to begin a project by developing the features that
import or generate application data. Once your application has access to the
data it depends on, you can begin developing the features that process data and
generate reports.

Suppose you're a developer who likes to support the local community. You and
some of your friends started a business that helps find new homes for stray or
abandoned cats and dogs. Your business started off small, with just a couple of
strays, but it's starting to grow. You want to create an application that will
help you match the animals in your care with people looking for a pet. You've
found that it's important to have a detailed description of the animals to share
with potential owners. In addition, being able to describe the personality of
the dog or cat makes them more appealing to potential owners. You decide to
create an application that helps you manage information about the dogs and cats
you're caring for.

This module guides you through the process of developing the data-centric
features of the Contoso Pets application. You'll use selection and iteration
statements to create sample data, list the animals in your care, and add new
animals to your business. Throughout the application, you'll use variables and
expressions to control the execution of code branches. You will also ensure that
variables are scoped appropriately.

The application you develop will:

- Add predefined sample data to the pets array.
- Iterate a "menu options and user selection" code block to establish the outer
  loop of your application.
- Implement code branches corresponding to the user's menu selections.
- Display all the information contained in the array used to store pet data
  (based on user's menu selection).
- Iterate an "add new animal information" code block that enables the user to
  add one or more new animals to the pets array (based on user's menu
  selection).

By the end of this module, you will be able to develop code that combines
selection and iteration statements to achieve your application design goals.

### Learning Objectives

In this module, you'll practice how to:

- Use Visual Studio Code to develop a C# console application that uses a
  combination of selection and iteration statements to implement logical
  workflows.
- Evaluate the underlying conditions in your application and make an informed
  decision between selection statement options.
- Evaluate the underlying conditions in your application and make an informed
  decision between iteration statement options.
- Scope variables at an appropriate level within an application.

## Prepare

### Project overview

You're working on the Contoso Pets application, an application that helps place
pets in new homes. The specifications for your application are:

- Create a C# console application.

- Store application data in a multidimensional string array named ourAnimals.

- The ourAnimals array includes the following "pet characteristics" for each
  animal:

  - Pet ID #.
  - Pet species (cat or dog).
  - Pet age (years).
  - A description of the pet's physical condition/characteristics.
  - A description of the pet's personality.
  - The pet's nickname.

- Implement a sample dataset that represents dogs and cats currently in your
  care.

- Display menu options to access the main features of the application.

- The main features enable the following tasks:

  - The pet species (dog or cat) must be entered when a new animal is added to
    the ourAnimals array.
  - A pet ID must be programmatically generated when a new animal is added to
    the ourAnimals array.
  - Some physical characteristics for a pet may be unknown until a
    veterinarian's examination. For example: age, breed, and neutered/spayed
    status.
  - An animal's nickname and personality may be unknown when a pet first
    arrives.

- Ensure animal ages and physical descriptions are complete. This may be
  required after a veterinarian's examination.

- Ensure animal nicknames and personality descriptions are complete (this action
  can occur after the team gets to know a pet).

- Edit an animal’s age (if a pet's birth date is known and the pet has a
  birthday while in our care).

- Edit an animal’s personality description (a pet may behave differently after
  spending more time in our care).

- Display all cats that meet user specified physical characteristics.

- Display all dogs that meet user specified physical characteristics.

An initial version of the application has already been completed. The Starter
code project for this Guided project module includes a Program.cs file that
provides the following code features:

- The code declares variables used to collect and process pet data and menu item
  selections.

- The code declares the ourAnimals array.

- The code uses a for loop around an if-elseif-else construct to populate the
  ourAnimals array with a sample dataset.

- The code displays the following main menu options for user selection:

  1. List all of our current pet information.
  2. Assign values to the ourAnimals array fields.
  3. Ensure animal ages and physical descriptions are complete.
  4. Ensure animal nicknames and personality descriptions are complete.
  5. Edit an animal’s age.
  6. Edit an animal’s personality description.
  7. Display all cats with a specified characteristic.
  8. Display all dogs with a specified characteristic.

Enter menu item selection or type "Exit" to exit the application

- The code reads the user's menu item selection and displays a message echoing
  their selection.

Your goal is to develop the features that implement the first two menu options.
To achieve this goal, you'll complete the following tasks:

1. Update the code that's used to create the sample data for the app.
2. Construct a loop around the main menu and create a selection statement that
   establishes a code branch for each menu option.
3. Write the code to display all ourAnimals array data (menu option 1).
4. Build a loop for entering new ourAnimals array data (menu option 2 - part 1).
5. Write code to read and save new ourAnimals array data (menu option 2 - part
   2).

## Exercise 1 - Build sample data and menu selection loops

[C#](./Exercises/GuidedProject/Starter/Program.cs)

## Summary

Your goal was to build an application that implements a combination of selection and iteration statements to achieve the design goals of your application.

By creating nested combinations of iteration and selection statements, you built a user interface that enables the user to display pet data from the ourAnimals array. You also developed the features to enter and validate characteristics of new pets and add them to the ourAnimals array. The app user can continue making menu selections until they choose to exit the application.

Having the ability to implement a variety of iteration and selection statements enables you to optimize your code.

## Achievement

![Achievement](achievement.png)
