-- Start the process from Master
Use master;
Go

-- Make sure we stat from scratch, aka delete previose database version
Drop Database If Exists ProjectManagment;
Go

-- Create new database
Create Database ProjectManagment;
Go

-- From now own use the database
Use ProjectManagment;
Go

-- Creat the tables all in one transaction
Begin Transaction;
 
/*********************************** Create Tables ***********************************/

-- Deparment
Create Table Department(
	DepartmentID int identity (1010,10),
	DepName nvarchar(25) Not Null,

Constraint PK_Deparment Primary Key (DepartmentID)
)

-- Project
Create Table Project(
	ProjectID int identity(2010,10),
	ProjName nvarchar(50) Not Null,
	ProjStartDate Date Not Null Default(Getdate()),

Constraint PK_Project Primary Key (ProjectID)
)

-- Employee
Create Table Employee(
	EmployeeID int identity (1,1),
	DepartmentID int Not Null,
	JobTitle nvarchar(25),
	LastName nvarchar(50) Not Null,
	FirstName nvarchar(50) Not Null,
	Gender nvarchar(25) Not Null,
	BirthDate date Not Null,
	HireDate date not Null Default(Getdate()),

Constraint PK_Employee Primary Key (EmployeeID),
Constraint FK_Employee_DepartmentID Foreign Key(DepartmentID) References Department(DepartmentID),
Constraint CK_Employee_Gender Check (Gender IN ('Female','Male','Transgender','Gender-Neutral','Non-binary','Agender','Pangender'))
)

-- EmployeeProject (relator table)- assuming that an employee can be part of several projects, and many projects can be work by same person
Create Table EmployeeProject(
	EmployeeID int,
	ProjectID int,

Constraint PK_EmployeeProject Primary Key (EmployeeID,ProjectID),
Constraint FK_EmployeeProject_EmployeeID Foreign Key(EmployeeID) References Employee(EmployeeID),
Constraint FK_EmployeeProject_ProjectID Foreign Key(ProjectID) References Project(ProjectID)

)


/*********************************** Populate Tables ***********************************/

-- Deparment (3)
Insert Into Department (DepName) Values
	('Programing Department'),	--1010
	('Production Department'),	--1020
	('Accounting Department');	--1030
-- Project (4)
Insert Into Project(ProjName, ProjStartDate) Values
	('Multi-Page Responsive Website 0.2', '2021-02-15'),	--2010
	('Cost Evaluationg for Website 0.2', '2020-12-05'),		--2020
	('Website 0.2 Production Evaluation', '2020-09-30'),	--2030
	('Website 0.2 Overview','2020-11-26');					--2040

-- Employee (8)
-- Check Gender:'Female','Male','Transgender','Gender-Neutral','Non-binary','Agender','Pangender'
-- Find DepartmentID=(Select DepartmentID From Department Where DepName='('Programing Department','Production Department','Accounting Department')'
Insert Into Employee(DepartmentID,JobTitle,LastName,FirstName,Gender,BirthDate,HireDate) Values
	((Select DepartmentID From Department Where DepName='Programing Department'),'Programing Manager','Ikbar','Jim','Pangender', '2000-09-30', '2019-09-30'),
	((Select DepartmentID From Department Where DepName='Production Department'),'Production Manager','Jawad','Kim','Agender', '1987-09-30', '2018-09-30'),
	((Select DepartmentID From Department Where DepName='Accounting Department'),'Accounting Manager','Jones','Nancy','Non-binary', '1999-10-30', '2015-06-13'),
	((Select DepartmentID From Department Where DepName='Programing Department'),'Programing Supervisor','Kuller','Minke','Gender-Neutral', '1995-11-15', '2020-01-13'),
	((Select DepartmentID From Department Where DepName='Production Department'),'Line Assistant','Clark','Lisa','Transgender', '1965-09-30', '2020-09-30'),
	((Select DepartmentID From Department Where DepName='Programing Department'),'Junior Programer','Rimos','Alex','Male', '1958-10-16', '2020-09-30'),
	((Select DepartmentID From Department Where DepName='Production Department'),'Line Supervisor','Smith','Adam','Female', '1975-02-27', '2020-09-30'),
	((Select DepartmentID From Department Where DepName='Accounting Department'),'Senior Accountant','Frikery','Deidreck','Female', '1948-05-29', '2010-03-08');

-- EmployeeProject (one manager per project)
Insert Into EmployeeProject (EmployeeID, ProjectID) Values
	((Select EmployeeID From Employee where JobTitle='Programing Manager'),(Select ProjectID From Project Where ProjName='Website 0.2 Overview')),
	((Select EmployeeID From Employee where JobTitle='Production Manager'),(Select ProjectID From Project Where ProjName='Website 0.2 Production Evaluation')),
	((Select EmployeeID From Employee where JobTitle='Accounting Manager'),(Select ProjectID From Project Where ProjName='Cost Evaluationg for Website 0.2')),
	((Select EmployeeID From Employee where JobTitle='Accounting Manager'),(Select ProjectID From Project Where ProjName='Multi-Page Responsive Website 0.2')),
	((Select EmployeeID From Employee where JobTitle='Junior Programer' And LastName='Rimos'),(Select ProjectID From Project Where ProjName='Website 0.2 Overview')),
	((Select EmployeeID From Employee where JobTitle='Line Assistant' And LastName='Clark'),(Select ProjectID From Project Where ProjName='Website 0.2 Production Evaluation'));
-- Complete the transaction
Commit Transaction;

----Checking

----Select *
----	From Employee;
----Select *
----	From EmployeeProject;
----Select *
----	From Department;
----Select *
----	From Project;

	