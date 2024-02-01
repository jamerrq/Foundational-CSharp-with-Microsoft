# Challenge project - Develop foreach and if-elseif-else structures to process array data in C\#

Demonstrate your ability to update a console app that implements arrays, foreach
loops, and if statements in response to a user requested feature update.

## Introduction

End users often ask developers to add new features to an application. User
requests indicate that your application is being used, and more importantly,
that the customer plans to continue using your application. The customer just
wants some features updated. The ability to update an existing application based
on user requests is very important. A successful update will preserve the
integrity of the original application while providing the user with the improved
experience they requested.

Suppose you're a teacher assistant at a school and that you developed an
application to automate the grading process. The application uses arrays to
store student names and graded assignments. The application also implements a
combination of iteration and selection statements to calculate and report each
student's final grade. Your application even differentiates between exam
assignments and extra credit assignments when calculating student grades.
Although the application does everything that the teacher asked for, you've
received a request for new features. The teacher has asked you to update the
grading report to show an exam and extra credit assignment scores separately
from the final numeric score and letter grade.

This module challenges you to add new capabilities to your Student Grading
application.

In short, you need to use the teacher's updated grading report specification to:

- update the iteration and selection code to calculate separate final scores for
  exams, extra credit assignments, and the overall grade.

- update the code that writes the grading report to the console.

###

In this module, you'll demonstrate your ability to:

- Use Visual Studio Code to revise a C# console application based on an updated feature specification.
- Update the variables and `if` statements in a C# console application to create the
code branches and calculations required to satisfy an updated feature
specification.

## Prepare

In this guided project, you'll use Visual Studio Code to develop portions of a
C# console application. You'll begin by writing the code that performs various
numeric calculations. All calculations must be completed within the existing
iteration and selection structures. This Prepare unit provides you with the
overall goals of the project and the requirements for your application. The
Setup section describes how to set up your development environment, including a
"Starter" code project.

### Project specification

The Starter code project for this module is a C# console application that implements the following code features:

- Uses arrays to store student names and assignment scores.

- Uses a foreach statement to iterate through the student names as an outer program loop.

- Uses an if statement within the outer loop to identify the current student's name and access that student's assignment scores.

- Uses a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.

- Uses an algorithm within the outer loop to calculate the average exam score for each student.

- Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.

- Integrates extra credit scores when calculating the student's final score and letter grade as follows:

    - Detects extra credit assignments based on the number of elements in the student's scores array.
    - Applies a 10% weighting factor to extra credit assignments before adding extra
credit scores to the sum of exam scores.

Your goal in this challenge is to implement the coding updates required to produce the teacher's requested score report.

The current score report lists the student's name followed by the calculated
overall grade and letter grade. Here is the existing report format:

```
Student         Grade   Letter Grade

Sophia          95.6    A
Andrew          91.6    A-
Emma            89.2    B+
Logan           93      A
```

In addition to the student's final numeric score and letter grade, the teacher
wants the updated report to include the exam score and the impact that extra
credit work has on the student's final grade. The format of the updated score
report should appear as follows:

```
Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)
Andrew          89.6            91.38   A-      89 (1.78 pts)
Emma            85.6            90.94   A-      89 (5.34 pts)
Logan           91.2            93.12   A       96 (1.92 pts)
```

[Exercise](./Challenge-project-foreach-if-array-CSharp-main/ChallengeProject/Starter/Program.cs)

## Summary

Your challenge was to update an application with new features based on user feedback.

By implementing the teacher's requested updates in a way that preserved the integrity of the original application, you were able to satisfy the user request in the best possible way.

Having the ability to interpret and apply user feedback in a manner that avoids
significant redesigns is an important part of maintaining and updating
applications.

![](../../imgs/learn.microsoft.com_en-us_training_modules_challenge-project-arrays-iteration-selection_6-summary(Nest%20Hub%20Max).png)
