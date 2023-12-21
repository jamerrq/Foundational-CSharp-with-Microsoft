# Guided project - Develop foreach and if-elseif-else structures to process array data in C\#

Gain experience developing a console app that implements arrays, foreach loops,
and if statements to achieve app specifications.

## Introduction

Creating a code branch and iterating through a code block are essential
capabilities for a developer. In C#, the `if` statement can be used to evaluate
an expression and branch the execution path. The code block of a `foreach`
statement can be used to iterate through each element of an array. Powerful and
extensible applications can be created by combining the ability to branch the
execution path.

Suppose you are a teacher's assistant at a school. You have been working with a
teacher to create an application that automates the grading process. Your C#
programming skills have increased since you completed the initial version of
your application. The updates focus on using arrays, `foreach` statements, and
`if` statements. The teacher also wants you to include extra credit assignments
in your calculations of the final grades.

In this module, you'll be guided through the process of updating your Student
Grading application. You'll use arrays to store student names and the scores of
graded assignments, and you'll use `foreach` statements to iterate through the
array values. Each student's final grade will be calculated inside a `foreach`
code block. You'll use an `if` statement to assign a final letter grade. Your
completed application will output student grades using the teacher's score
report specification.

By the end of this module, you'll have experience developing applications that
use arrays, `foreach` statements, and `if` statements. You'll also be
comfortable creating applications that efficiently process data using nested
iteration and selection statements.

## Prepare

In this guided project, you'll use Visual Studio Code to develop a C# application. The application will use arrays, `foreach` statements, and `if` statements to implement a list of design parameters. You'll begin by creating the array variables that contain your application data. To complete the project, you'll develop `foreach` and `if` statements that implement the application design goals.

### Project overview

You're developing a Student Grading application that automates the calculation of grades for each student in a class. The parameters for your application are:

- Create a C# console application.
- Start with four students. Each student has five exam scores.
- Each exam score is an integer value, 0-100, where 100 represents 100% correct.
- A student's overall exam score is the average of their five exam scores.
- Criteria for extra credit assignments:
    - Include extra credit assignment scores in the student's scores array.
    - Extra credit assignments are worth 10% of an exam score (when calculating the final numeric grade).
    - Add extra credit assignment scores to the student's total exam score before calculating the final numeric grade.
- Your application needs to automatically assign letter grades based on the calculated final score for each student.
- Your application needs to output/display each student’s name and formatted grade.
- Your application needs to support adding other students and scores with minimal impact to the code.

You've already completed an initial version of the application. The Starter code project for this Guided project module includes a Program.cs file that provides the following code features:

- The code declares variables used to define student names and individual exam scores for each student.
- The code includes the variables and algorithms used to sum the exam scores and calculate the average exam score for each student.
- The code includes a hard coded letter grade that the developer must apply manually.
- The code includes Console.WriteLine() statements to display the student grading report.

Your goal is to update the existing code to include the following features:

- Use arrays to store student names and assignment scores.

- Use a foreach statement to iterate through the student names as an outer program loop.

- Use an if statement within the outer loop to identify the current student name and access that student's assignment scores.

- Use a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.

- Use an updated algorithm within the outer loop to calculate the average exam score for each student.

- Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.

- Integrate extra credit scores when calculating the student's final score and letter grade as follows:

    - Your code must detect extra credit assignments based on the number of elements in the student's scores array.
    - Your code must apply the 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.

The following list shows the letter grade that corresponds to numeric scores:

```
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F
```

The update application needs to produce a formatted student grading report that appears as follows:

```
Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-
```

[Exercise](./Guided-project-foreach-if-array-CSharp-main/GuidedProject/Starter/Program.cs)

## Summary

Your goal was to build an application that uses a combination of iteration and selection statements to process the contents of arrays and achieve the design goals of your application.

By creating a nested combination of `foreach` and `if` statements, you built an application that processes the contents of student name and assignment score arrays to calculate and report student grades. The application logic supports adding additional students and assignment scores with minimal code updates.

Having the ability to implement nested iteration statements that process array data, and selection statements that branch the code execution path, enables you to create more efficient and extensible code.

![](../../imgs/learn.microsoft.com_en-us_training_modules_guided-project-arrays-iteration-selection_7-summary(Nest%20Hub%20Max).png)
