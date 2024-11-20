# Progress

Overview

This repository contains automated UI tests for the Progress Contact Form. The tests are written in C# using Selenium WebDriver and are executed in the Chrome browser. The project is structured to ensure scalability, maintainability, and ease of use, adhering to best practices for automation frameworks.

Technologies Used

    .NET 6.0
    Selenium WebDriver - v4.26.1
    ChromeDriver - v131.0.6778.6900
    NUnit Framework

How to Use

    Clone the repository: git clone https://github.com/SSvetoslav/Automation_Task_Progress.git
    Build the project:
    Open the project in your preferred IDE (e.g., Visual Studio) and restore the NuGet packages to resolve all dependencies. 
    Then, build the solution to ensure everything is correctly set up.
    Ensure you have the latest version of ChromeDriver (v131.0.6778.6900) installed that matches your Chrome browser version.
    Install dependencies and ensure you have the latest version of ChromeDriver installed.
    Run the tests:
    Run the tests using your preferred test runner or IDE.
If you want to run tests for different languages, you have navigate to the WebTest.cs class and to set chosen language like is shown at the picture.
(This setup will execute all tests on English language)
![изображение](https://github.com/user-attachments/assets/4a692d3c-1611-492a-87e9-9d042c459aa9)

NOTE: If you want to be independent of Chrome browser version you can delete NuGet Package - Selenium.WebDriver.ChromeDriver from NuGet Package Manager.


P.S. I saw that the phone input field can accepted and letters and that the message field was marked as required for TW and JP.

I am available for additional questions.

