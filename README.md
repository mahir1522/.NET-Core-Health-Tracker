# ASP.NET Core Health Tracker

Welcome to the ASP.NET Core Health Tracker repository! This project was created as part of my studies at Conestoga College. It's an ASP.NET Core MVC web application designed to record and manage Blood Pressure measurements in a Microsoft SQL Server database.

## Features

- **Blood Pressure Measurement Tracking**: Record and manage blood pressure measurements, including systolic and diastolic values and measurement dates.

- **Data Migration**: Gradually introduce additional attributes like categories and positions through migrations, ensuring scalability and flexibility.

- **Data Validation**: Implement data validation to ensure that user inputs are accurate and conform to health measurement standards.

## Prerequisites

Before you get started, make sure you have the following prerequisites:

- ASP.NET Core SDK
- Microsoft SQL Server
- Visual Studio or Visual Studio Code (for development)
- Git (for cloning the repository)

## Getting Started

To set up and run this project:

1. Clone the repository to your local machine: `https://github.com/mahir1522/.NET-Core-Health-Tracker`
2. Open the project in your preferred development environment.
3. Update the connection string in the `appsettings.json` file to point to your Microsoft SQL Server database.
4. Run the Entity Framework migration to create the database schema: `dotnet ef database update`
5. Build and run the application: `dotnet run`


## Usage

1. Access the Health Tracker web application in your web browser.
2. Create an account or log in if you already have one.
3. Start recording your blood pressure measurements, ensuring you provide systolic and diastolic values and measurement dates.
4. Use the application to track your health over time and take advantage of the data validation and migration features to expand functionality as needed.
