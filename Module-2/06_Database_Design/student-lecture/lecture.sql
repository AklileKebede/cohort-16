-- Use master so that we are not "sitting" on another database.
-- Master is specific to oracal, and other servers may use a different 
USE Master;
Go

-- Delete the database to start from scratch
Drop Database If Exists ArtGallery;
Go

-- Creat a new empty database
Create Database ArtGallery;
Go

-- From now on use the ArtGallery database
USE ArtGallery;
Go

-- Start a transaction so the create process is ALL or NON
Begin Transaction

/*************************** Create Tables ***************************/
-- First creat any tables with no Foreign Keys, AKA independent tables

-- Address
Create Table Address(
	AddressID int identity(1,1),
	Street nvarchar(100),
	City nvarchar(50),
	State nvarchar(50),
	PostalCode nvarchar(10),

Constraint PK_Address Primary Key (AddressID)
)

-- Customer

Create Table Customer(
	CustomerID int identity(1,1),
	CustomerName nvarchar(100) Not Null,
	Phone Varchar(20),

Constraint PK_Customer Primary Key (CustomerID)
)

-- Artist
Create Table Artist(
	ArtistID int Identity(1,1),		-- 1000 is starting number, 10 is increment
	ArtistName nvarchar(50) Not Null,	--nvarchar is 2 byte per character, and is safer.
	AddressID int Null,		-- every column is by default nullable
	Phone Varchar(20),

Constraint PK_Artist Primary Key (ArtistID),
Constraint FK_Artist_Address Foreign Key (AddressID) REferences Address(AddressID)
	)

-- Painting
Create Table Painting(
	PaintingID int Identity(1,1),
	ArtistID int Not Null,
	Title nvarchar(100) Not Null,
	AskingPrice money Null,

Constraint PK_Painting Primary Key (PaintingID),
Constraint FK_Painting_Artist Foreign Key(ArtistID) References Artist(ArtistID)
	)

-- Transaction
Create Table ArtTransaction(
	ArtTransactionID int Identity(1,1),
	ArtTransactionType nvarchar(8) Not Null,
	CustomerID int Not Null,
	PaintingID int Not Null,
	TransactionDate datetime Not Null Default(Getdate()),
	TransPrice money Not Null,

Constraint PK_ArtTransaction Primary Key (ArtTransactionID),
Constraint FK_ArtTransaction_CustomerID Foreign Key(CustomerID) References Customer(CustomerID),
Constraint FK_ArtTransaction_PaintingID Foreign Key(PaintingID) References Painting(PaintingID),
Constraint Ck_ArtTransaction_ArtTransactionType Check (ArtTransactionType IN('Sale','Purchase'))
)

-- CustomerAddress
Create Table CustomerAddress (
	CustomerID int, 
	AddressID int,

Constraint PK_CustomerAddress Primary Key(CustomerID,AddressID),
Constraint FK_CustomerAddress_CustomerID Foreign Key(CustomerID) References Customer(CustomerID),
Constraint FK_CustomerAddress_Address Foreign Key (AddressID) REferences Address(AddressID)
)

/*************************** Populate Table w/data ***************************/

-- Address
Insert Into Address (Street,City,State,PostalCode)
	Values ('123-4th Ave','Fonthill','ON','L3J 4S4')
-- Customer
Insert Into Customer(CustomerName,Phone) 
	Values ('Jackson, Elizabeth','2062846783')
-- CustomerAddress
Insert Into CustomerAddress(CustomerID,AddressID) 
	Values (1,1) -- we can do @@identity from each table
--Artist
Insert Into Artist(ArtistName) Values
	('Carol Channing'), --1
	('Deniss Frings')	--2
-- Painting
Insert Into Painting(ArtistID, Title, AskingPrice) Values
	(1, 'Laugh with Teeth', 10000),			--1
	(2, 'South toward Emerald Sea', 3000),	--2
	(1, 'At the Movies', 7000)				--3
-- Transaction
Insert Into ArtTransaction(ArtTransactionType, CustomerID,PaintingID,TransactionDate, TransPrice) Values
	('Sale',1,1,'2000-09-17', 7000),
	('Sale',1,2,'2000-05-11', 1800),
	('Sale',1,3,'2000-02-14', 5550),
	('Sale',1,2,'2000-07-15', 2200)

-- Complete the transaction
Commit Transaction;