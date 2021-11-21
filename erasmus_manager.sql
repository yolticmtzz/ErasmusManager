CREATE DATABASE erasmus_manager

use erasmus_manager

CREATE TABLE Users (
	userId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	email varchar(155) NOT NULL UNIQUE,
	username varchar(155) NOT NULL,
	password varchar(155) NOT NULL,
)

CREATE TABLE Projects (
	projectId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	projectName varchar(155) NOT NULL,
	userId int FOREIGN KEY REFERENCES Users(userId) NOT NULL,
)

CREATE TABLE Partners (
	partnerId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	projectId int FOREIGN KEY REFERENCES Projects(projectId) NOT NULL,
	userId int FOREIGN KEY REFERENCES Users(userId) NOT NULL,
)

CREATE TABLE Students (
	studentId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	studentName varchar(155) NOT NULL,
	--atributos ainda precisam serem adicionados
)

CREATE TABLE Teams (
	teamId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	projectId int FOREIGN KEY REFERENCES Projects(projectId) NOT NULL,
	studentId int FOREIGN KEY REFERENCES Students(studentId) NOT NULL,
)

CREATE TABLE Results (
	resultId int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	chemistry int NOT NULL,
	createdAt DATETIME NOT NULL,
	projectId int FOREIGN KEY REFERENCES Projects(projectId) NOT NULL,
	userId int FOREIGN KEY REFERENCES Users(userId) NOT NULL,
)