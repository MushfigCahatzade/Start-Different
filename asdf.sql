create database Pizza
use Pizza

CREATE TABLE Settings(
Id INT PRIMARY KEY IDENTITY,
[Key] NVARCHAR(150) NOT NULL,
[Value] NVARCHAR(150) NOT NULL
)

CREATE TABLE Categories (
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(255) NOT NULL
)


CREATE TABLE Meals(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(255) NOT NULL,
[Description] varchar (255),
Price decimal,
[Image] varchar(255),
CatagoryId int FOREIGN KEY REFERENCES Categories(Id)
)

CREATE TABLE Sliders(
Id INT PRIMARY KEY IDENTITY,
Title VARCHAR(255) NOT NULL,
Subtitle varchar (255),
[Description] varchar (255),
[Image] varchar(255)
)