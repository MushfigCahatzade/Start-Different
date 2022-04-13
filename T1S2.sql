CREATE DATABASE Moves
USE Moves
CREATE TABLE Movies(
Id int primary key identity,
[Name] varchar(255),
Duration int,
)
CREATE Table Actors(
Id int primary key identity,
[Name] varchar(255),
Surname varchar(255)
)
CREATE TABLE MoviesActors(
MoviesId int Constraint MovelM Foreign key references Movies(Id),
ActorsId int Constraint MovelA Foreign key references Actors(Id)
)
CREATE TABLE Genres(
Id int primary key identity,
[Name] varchar(255)
)
CREATE TABLE MoviesGenres(
MoviesId int Constraint MovelL Foreign key references Movies(Id),
GenresId int Constraint MovelG Foreign key references Genres(Id)
)

CREATE TABLE Directors(
Id int primary key identity,
[Name] varchar(255),
Surname varchar(255),
DirectorsId int Constraint MovelD Foreign key references Movies(Id)
)


Select Len(Name)'Length',Name From Movies where Movies.Name.length>10





