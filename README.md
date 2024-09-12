# Online Testing Management System

## Overview

The Online Testing Management System is a C# application developed in Visual Studio using the ADO.NET framework. It follows a layered architecture including DAO, DTO, BUS, and GUI layers, and connects to a SQL Server database.

## System Features

### Common User Features

- **Login**: Secure authentication for all users.

### Student Features

- **View Exam Schedule**: Access the timetable of upcoming exams.
- **Take Exams**: Participate in scheduled exams.
- **View Scores**: Check results after exams are graded.

### Instructor Features

- **Manage Exam Papers**: Create and organize exam content.
- **View Classes**: Access information about classes they teach.
- **View Scores**: Review student scores.

### Admin Features

- **Manage Exam Schedule**: Set and modify exam timetables.
- **Reports and Statistics**: Generate and view various reports.

## Technical Details

- **Language**: C#
- **IDE**: Visual Studio
- **Database**: SQL Server
- **Frameworks and Libraries**: ADO.NET

## Architecture

### Layers

1. **DAO (Data Access Object)**: Handles all database interactions.
2. **DTO (Data Transfer Object)**: Represents data structures.
3. **BUS (Business Logic Layer)**: Contains business rules and logic.
4. **GUI (Graphical User Interface)**: User interface layer for interaction.

### ERD
![image](https://github.com/user-attachments/assets/a16ccac7-657f-4140-8b83-6a6625743e5a)

### Class Diagram
![image](https://github.com/user-attachments/assets/c4f0ec63-c42d-4c82-8912-da405cf83f1a)


## Setup Instructions

1. **Prerequisites**:
   - Visual Studio
   - SQL Server

2. **Database Setup**:
   - Import the SQL script provided in the `/Database` folder to set up the database schema.

3. **Project Configuration**:
   - Open the solution in Visual Studio.
   - Update the database connection string in `App.config` to match your SQL Server instance.

4. **Build and Run**:
   - Build the solution (`Build > Build Solution`).
   - Run the application (`Debug > Start Debugging`).

## Usage

1. **Login** with provided credentials.
2. **Navigate** to the relevant sections based on your user role (Student, Instructor, Admin).
3. **Perform actions** as per your role's capabilities.

## Demo
Please refer section 4. Mô tả sản phẩm (product description) in our report Nhóm 12_Báo cáo phần mềm Thi trắc nghiệm online.docx
