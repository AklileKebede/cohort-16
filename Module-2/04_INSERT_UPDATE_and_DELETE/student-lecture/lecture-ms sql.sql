SELECT *
	FROM City
	WHERE District='Ohio';

-- INSERT
-- 1. Add a city to the City table, district 'Ohio'
INSERT INTO City (Name,CountryCode,District,Population)
	Values ('Richfield', 'USA', 'Ohio', 12000);

-- 1a. What is the @@Identity? Last ID that was created 
SELECT @@IDENTITY

-- 2. Add 2 more cities to Ohio using one insert statement
INSERT INTO City(Name,CountryCode,District,Population)
	VALUES 
	('Cleveland Heights','USA','Ohio',43000),
	('Lakewood','USA','Ohio',50000);
-- 2a. What is the @@Identity?(4082)
SELECT @@IDENTITY

-- 0. Add Klingon to the Language table
INSERT INTO Language(LanguageName)
	VALUES ('Klingon')
-- 0a. What is the @@Identity?
SELECT @@IDENTITY
-- 1. Add Klingon as a spoken language in the USA
INSERT INTO CountryLanguage(CountryCode,LanguageId,IsOfficial,Percentage)
	VALUES ('USA',458,0,12.0)
		-- Languages of the USA:
		SELECT*
		FROM CountryLanguage AS CL
			JOIN Language ON CL.LanguageId=Language.LanguageId
		WHERE CL.CountryCode='USA';

-- 2. Add Klingon as a spoken language in Great Britain
INSERT INTO CountryLanguage (CountryCode,LanguageId,IsOfficial,Percentage)
	VALUES ('GRB',(SELECT LanguageId FROM Language WHERE LanguageName='Klingon'),1,32.0) --Usage of a subquery is to make sure we find the correct languageId


-- UPDATE

-- 0. Update the population of Cleveland to 2020 values (379,233)
UPDATE City
	SET Population=379233
	--SELECT* From City -- Always do this to confirm it works
	WHERE Name='Cleveland';
-- 1. Update the capital of the USA to Houston
	-- Confiming before updating
			SELECT * From City WHERE Name='Houston' -- Confirm there isn't another Houston, Also used for subquery
			SELECT * FROM Country WHERE Code='USA' -- Confirm which Capital it has
	-- ACTUAL UPDATE
			UPDATE Country
				SET Capital=(SELECT CityId From City WHERE Name='Houston')
				WHERE Code='USA';

-- 2. Update the capital of the USA to Washington DC and the head of state
	-- Confiming before updating
				SELECT * From City WHERE Name='Washington' -- Confirm there isn't another Houston, Also used for subquery
				SELECT * FROM Country WHERE Code='USA' -- Confirm which Capital it has
	-- ACTUAL UPDATE
				UPDATE Country
					SET Capital=(SELECT CityId From City WHERE Name='Washington'),
						HeadOfState='Joe Biden'
					WHERE Code='USA';
-- DELETE

-- 0. Delete the newly added Ohio cities
	DELETE /*SELECT **/ FROM City WHERE Name='Richfield' AND District='Ohio'
	DELETE /*SELECT **/ FROM City WHERE Name in ('Lakewood', 'Cleveland Heights') AND District='Ohio'			
-- 1. Delete English as a spoken language in the USA
DELETE --SELECT * 
	FROM CountryLanguage 
	WHERE CountryCode='USA' AND LanguageId=(SELECT LanguageId FROM Language WHERE LanguageName='English')
-- 2. Delete all occurrences of the Klingon language 
DELETE --SELECT * 
	FROM CountryLanguage 
	WHERE LanguageId=(SELECT LanguageId FROM Language WHERE LanguageName='Klingon')
DELETE --SELECT *
	FROM Language
	WHERE LanguageName='Klingon'

-- REFERENTIAL INTEGRITY

-- 1. Add a city to the City table in the country 'ZZZ'
INSERT INTO City(CountryCode,District,Population)
	VALUES ('Richfield', 'ZZZ','Ohio', 1200) -- this will fail because there is no country code for ZZZ
-- 1. Try just adding Elvish to the country language table.
UPDATE Country
	SET Continent= 'Outer Space'
	WHERE Code='USA' -- Fail, because there is a constrain on the continent that limits it to specific continents
-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?
DELETE Country 
	WHERE Code='USA'; -- cannot delete because USA has cities with the reference USA
-- 3. Try deleting the country USA. What happens?


-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA
BEGIN TRANSACTION
	Delete From CountryLanguage
	SELECT * FROM CountryLanguage
ROLLBACK TRANSACTION

SELECT * FROM CountryLanguage
-- 2. Try again. What happens?

-- 3. Let's relocate the USA to the continent - 'Outer Space'


-- How to view all of the constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS


-- TRANSACTIONS

-- 1. Try deleting all of the rows from the country language table and roll it back.

-- 2. Try updating all of the cities to be in the USA and roll it back

-- 3. Demonstrate two different SQL connections trying to access the same table where one happens to be inside of a transaction but hasn't committed yet.