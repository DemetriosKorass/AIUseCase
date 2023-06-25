# README for StringValidator Application

## Application Description

The StringValidator application is a simple .NET 6 application written in C#. The main purpose of this application is to validate strings according to specific requirements, including checks for string length, the presence of uppercase and lowercase letters, digits, special characters, and the absence of any whitespace characters. This application is designed for easy reusability and efficient execution, providing a reliable tool for complex string validation tasks.

## Regex Implementation Description

The application includes a StringValidator class, which hosts a `IsStringValid` function. This function takes a string and maximum length as parameters and uses a regular expression to validate the string against the criteria outlined above. The regular expression pattern includes lookahead assertions for lowercase and uppercase letters, digits, and special characters, ensuring at least one of each is present. It also checks for the absence of any whitespace characters. The regex is engineered to match the length of the input string to the provided maximum length, providing a direct and efficient solution to all criteria. The StringValidator class is designed for easy reusability, offering a reliable string validation method that can be easily employed in other applications.

## How to Run Application Locally

Before running the application, make sure that you have .NET 6 SDK installed on your machine. Follow these steps to run the application:

1. Clone the repository to your local machine.

   ```
   git clone <repository-url>
   ```
   
2. Navigate to the directory containing the project.

   ```
   cd <directory-name>
   ```
   
3. Run the application using the `dotnet run` command.

   ```
   dotnet run
   ```
   
After running the application, you will see the output in your console, indicating whether each test string is valid according to the implemented regular expression and the set criteria.

For any modifications to the code, use a text editor or IDE of your choice, preferably one that supports C# and .NET development (like Visual Studio, Visual Studio Code, or Rider). If you make any changes, be sure to rebuild the project using `dotnet build` before running it again.