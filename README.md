# 🏀 NBA School League Manager

This is a C# console application designed to manage and track NBA games between different school teams. The application reads data from a file and provides users with insights into teams, players, and game results, all directly from the command line.

## 📌 Features

- **View Team's Players**  
  Display a complete list of players for a selected team, including active and reserve players.  

- **View Active Players in a Game**  
  Retrieve the list of players who actively participated in a specific game.  

- **View Games from a Date Range**  
  Filter and display all games played within a specified calendar period.  

- **View Game Scores**  
  Check the final score of a selected game.

## ⚙️ Technologies Used

- **C#:**
  - Core programming language used to build the application logic and data management.

- **File Handling:**
  - Application stores data in text files for persistence.
 
## 🌐 Architecture

- **Domain:**
  - Encapsulates the core business logic and entities.

- **Repository Layer:**
  - Responsible for interacting directly with the file, ensuring data is stored, retrieved, and manipulated securely.
  - Provides an abstraction layer for data access, keeping the application’s business logic separate from the underlying data layer.

- **Service Layer:**
  - Coordinates the operations and integrates various domain functionalities.
  - Handles business rules, ensuring a smooth flow of operations.

- **Command Line Interface (CLI):**
  - Interacts with the user through the terminal.
  - A simple and efficient interface to control the application.
