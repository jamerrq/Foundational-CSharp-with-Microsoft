# Guided project - Work with variable data in C#

Demonstrate your ability to develop a console app that implements data
formatting and using arrays to deliver a search feature.

## Introduction

Suppose you're a developer who likes to support the local community. You and
some of your friends started a business that helps find new homes for stray or
abandoned cats and dogs. Your business started off small, with just a couple of
animals, but it's starting to grow. Your friends have an initial application
developed that enables the entry and display of the animals available for
adoption. They ask you to investigate adding features to the app that could help
to match the animals in your care with people who are looking for a new family
pet.

In completing this coding project, you apply your C# data knowledge and skills
in:

Choosing the correct data types and safely converting data types. Manipulating
number, string and character arrays, as well as adding, removing, and sorting
data. Modifying and building complex strings from multiple data sources, and
formatting data for display across regions. Your team has found that it's
important to search the pet data to identify animals with possible matches based
on characteristics provided by potential owners. Further, the team wants to
include a fundraising feature to include suggested donation data and to present
the pet data with fewer lines of output.

You begin with a starting application that adds a predefined sample data to the
pets array. The application has two menu items. The first item displays all the
pet data, and the code is complete. The second is menu item, "Display all dogs
with a specified characteristic", is "work in progress" that you complete.

You also make updates to existing code to add `suggestedDonation` data and
display all data in a shortened format.

By the end of this module, you're able to develop code that combines iteration
statements with data input, data processing, string indexing, and data output.

## Prepare for guided project

Use Visual Studio Code to develop a version of a C# console application. The
application comes with the basic features that create sample data on pets
available for adoption and is able to display the pet's information. The main
feature to add is searching available dogs using a single search term. The
secondary tasks include adding and displaying `suggestedDonation` data.

### The design specification

For the new features of the Contoso Pets application, the design specification
provides details for the dog search and suggested donation features:

- Dog attribute search

  - Gather input for the pet characteristic search term
  - Loop through the animals array and identify "dogs"
  - For each dog, combine the physical and personality descriptions to search
  - Search the combined description for the input term match
  - Output the dogs that have a term match

- Suggested donation data

    - Define `suggestedDonation` string
    - Expand the `ourAnimals` array to contain `suggestedDonation` and populate
      sample data for `suggestedDonation`
    - Ensure all usage of `ourAnimals` array accounts for the added
      `suggestedDonation` data
    - Output `suggestedDonation` with regional currency symbol ($, €, ¥,... )

### Starter code overview

Initial starter code development is complete.

1. The Starter project for this guided project module includes a Program.cs file
   that provides the following code features:

- the code declares variables used to collect and process pet data and menu item
  selections
- the code declares the ourAnimals array
- the code uses a for loop around an `if`-`else if`-`else` construct to populate
  the ourAnimals array with a sample dataset
- the code displays the following main menu options for user selection:
    ```
    1. List all of our current pet information
    2. Display all dogs with a specified characteristic

    Enter menu item selection or type "Exit" to exit the program
    ```
- the code reads the user's menu item selection and displays a message echoing
  their selection
- only selection "1. List all of our current pet information" functions using
  the starter code

Your goal is to update the existing code to develop app features described
previously. The key features:

- Add dog attribute search
- Include suggested donation data

You use Visual Studio Code as your development environment, and you test your
application at each stage of your development process.

## Exercise 1 - Review starter code

In this first step of the development process, you review the code provided in
the Starter project folder.

### Review the contents of the Program.cs file

The Program.cs file contains a preliminary version of the application that
you're working on. The code includes features to generate and display the sample
data for the application, and it displays a list of menu options that define the
main features of the application.

```csharp
// #1 the ourAnimals array will store the following:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// #2 variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// #3 array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];
```

First, you see a comment (comment #1) followed by a list of variables. These
variables, `animalSpecies` through `animalNickname`, used to hold the values of
the pet characteristics within a multidimensional string array named
`ourAnimals`, and initialized to contain a zero length string `""`. The
`ourAnimals` array declaration is a little further down in the code.

The next group of variables (under comment #2) are a mix of `string` and `int`
variables used to help generate sample data, read user input, and establish exit
criteria for the main program loop. Notice the code line `string? readResult;`.
You use the `?` character to transform a normally non-nullable variable type
(int, string, bool,...) with support for the nullable type.

> [!NOTE]
> When reading user entered values with the Console.ReadLine() method,
> it's best to enable a nullable type string using string? to avoid the code
> compiler generating a warning when you build the project.

The final variable (under comment #3) is the two-dimensional string array named `ourAnimals`. You initialized the number of rows, defined by `maxPets`, to 8. The number of characteristics that you're storing initially is six. The six characteristics match the number of string variables that you examined in the sample code, but the number of characteristics needs to expand to add a field for `suggestedDonation`.

Futhermore, examine the `for` loop that populates the `ourAnimals` array with
sample data:

```csharp
// #4 create sample data ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            break;

        // case 2: deleted for brevity
        // case 3: deleted for brevity

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}
```

Notice that the for loop uses the maxPets variable to establish an upper bound on the number of iterations following comment # 4.

Also notice that the switch construct selectively branches the code so that you can define different pet characteristics for the pets in the sample data set.

You use a switch statement to define different values for the first four iterations of the for loop. After the sample data processing, all characteristics are empty, or zero-length, string.

The values of the animal characteristic variables are assigned to the ourAnimals array at the bottom of the for loop.

Scroll to the bottom of the code file in Visual Studio Code. Examine the code used to display the menu options and capture the input of the user's selection.

```csharp
// #5 display the top-level menu options
do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        case "2":
            // Display all dogs with a specified characteristic");
            Console.WriteLine("\nUNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");
```

Take a minute to review the two `case` statements.

There are only two menu options working with a limited version of the application. The starter application provides only the capabilities needed for running and testing features prototype.

Notice the line of code is `readResult = Console.ReadLine();` is followed by a check for a null value.

The code using the `Console.ReadLine()` method, has the value set to the nullable string `readResult` to avoid the code compiler generating a warning when you build the project.

## Code

[C#](./Guided-project-Work-with-variable-data-in-CSharp-main/Starter/Program.cs)

## Summary

You updated the pet adoption application in this guided project to support single term search functionality, improve readability of output, and add a suggested donation to descriptions.

In this module, you practiced your ability to:

- Apply iteration statements to gather data input
- Use data processing
- Format data output
- Choose the correct data types and safely converting data types
- Manipulate number, string and character arrays, as well as add, remove, and sort data
- Modify and build complex strings from multiple data sources, and format data for display across regions

You delivered functionality to your Contos pet app team, including:

- Gather the pet characteristic search term input
- Loop through the animals array and identify "dogs"
- For each dog, search the description for a term match
- Display the dogs that have a term match
- Provide suggested donation data formatted in local currency

## Achievement

![achievement](achievement.png)
