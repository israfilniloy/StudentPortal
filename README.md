
# Student Portal System

## Project Overview
This project is a web-based **Student Portal System** developed using **ASP.NET Core** and **Entity Framework**. It enables managing student information, including the ability to add, view, update, and delete student records. The project focuses on implementing CRUD (Create, Read, Update, Delete) operations with a simple and user-friendly interface.

## Table of Contents
1. [Technologies Used](#technologies-used)
2. [Prerequisites](#prerequisites)
3. [Features](#features)
4. [Setup](#setup)
5. [Usage](#usage)
6. [Challenges and Considerations](#challenges-and-considerations)
7. [How to Run](#how-to-run)

## Technologies Used
- **C#**: Core programming language for the project.
- **ASP.NET Core**: Framework for building the web application.
- **Entity Framework Core**: Object-relational mapper (ORM) for database access.
- **SQL Server**: Database for storing student records.
- **Visual Studio**: Integrated development environment (IDE) for developing the project.

## Prerequisites
- Visual Studio 2022 or later
- .NET 6 SDK or later
- SQL Server (Express or any version)

## Features
- **Add New Students**: Users can input student details such as Name, Email, Phone, and Subscription status. The student is then added to the database.
- **View Student List**: Displays all students in a list format, showing key details such as Name, Email, and Phone.
- **Update Student Information**: Users can edit the details of existing students and update them in the database.
- **Delete Students**: Users can delete student records from the system.
- **Search Functionality**: Allows users to search for students by their unique identifier.

## Setup
1. **Clone the Repository**  
   Clone the repository to your local machine:
   ```bash
    [   git clone https://github.com/your-repository/student-portal-system.git](https://github.com/israfilniloy/StudentPortal.git)
   ```

2. **Set Up the Database**  
   Open SQL Server Management Studio (SSMS) and run the necessary SQL scripts to create the database and tables. Update the connection string in the `appsettings.json` file with your database details.

   Example connection string:
   ```json
   "ConnectionStrings": {
       "StudentPortal": "Server=YOUR_SERVER_NAME;Database=StudentPortalDB;Trusted_Connection=True;"
   }
   ```

3. **Configure Entity Framework**  
   Run the following commands to apply migrations and set up the database:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

## Usage
- **Adding Students**: Navigate to the 'Add Student' page, fill in the student's details, and submit the form to add the student to the system.
- **Viewing Students**: The 'List Students' page shows all the students in the system.
- **Editing Students**: Click on a student's name to edit their details, then submit the form to update the record.
- **Deleting Students**: Select a student to delete from the list.
  
## Challenges and Considerations
- **Error Handling**: Proper validation and error handling mechanisms should be in place to ensure smooth database transactions and manage user input errors.
- **Database Connection**: Ensure the correct database connection string is set up before running the application.

## How to Run
1. **Build the Project**  
   Open the project in Visual Studio and build the solution.
   
2. **Run the Application**  
   Run the project in Visual Studio. The application will start, and you can manage student records through the web interface.

---

# Screenshot:
![image](https://github.com/user-attachments/assets/c4463802-788c-44dd-b4f4-75a27c837df7)
![image](https://github.com/user-attachments/assets/9e1c201a-6c93-4f6c-ae6e-79495734a667)
![image](https://github.com/user-attachments/assets/c1568c00-2b43-4e46-9672-d960e270a8d1)
![image](https://github.com/user-attachments/assets/0dc31dba-01ac-49c5-a7a0-45503f1ff5bf)
