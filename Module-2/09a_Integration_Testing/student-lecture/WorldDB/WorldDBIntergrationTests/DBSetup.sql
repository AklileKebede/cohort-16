--Use World_Test;
--Go
-- This script will be run before every integration test
	-- to establish the DB into a known state

-- First, remove all data from the tables starting with most integrated
	-- We need to null all the capitals first so we don't have dual references between city and coutnry
	Update Country Set Capital = null
Delete From CountryLanguage;
Delete From City;
Delete From Country;
Delete From Language;

-- Second, Add data to to the tables from the most independant
	-- Language
	Insert into Language (LanguageName) Values ('English'),('Javascript'),('Elvish');
	-- Country
	Insert into [dbo].[Country]([Code],[Name],[Continent],[Region],[SurfaceArea],[IndepYear],[Population],[LifeExpectancy],[GNP],[GNPOld],[LocalName],[GovernmentForm],[HeadOfState],[Capital],[Code2])
     VALUES
           ('USA', 'United States', 'North America', '', 100000, 1776, 1000000, 80, null, null, 'United States', 'Republic', 'Mickey Mouse',null,'US'),
           ('CAN', 'Canada', 'North America', '', 200000, null, 2000000, 60, null, null, 'Canada', 'Democracy', 'Daffy Duck',null,'CA'),
           ('GBR', 'United Kingdom', 'Europe', '', 300000, 1066, 3000000, 70, null, null, 'England', 'Monarchy', 'Mickey Mouse',null,'UK');

	-- Country-Language
	Insert into CountryLanguage(CountryCode,LanguageId, IsOfficial,Percentage) Values
		('USA',(Select LanguageId From Language Where LanguageName= 'English') ,0,75.0),
		('USA',(Select LanguageId From Language Where LanguageName= 'Javascript') ,1,55.0),
		('CAN',(Select LanguageId From Language Where LanguageName= 'Elvish') ,1,95.0),
		('GBR',(Select LanguageId From Language Where LanguageName= 'English') ,0,53.0),
		('GBR',(Select LanguageId From Language Where LanguageName= 'Elvish') ,1,85.0);
	-- City
	Insert into City (Name,CountryCode,District,Population) Values
		('Cleveland','USA','Ohio', 10000),
		('Mayberry','USA','North Carolina', 20000),
		('Toronto','CAN','Ontario', 30000),
		('London','GBR','', 40000);
-- update table
	-- Set the capital Citites
	Update Country set Capital=(Select CityId From City Where Name= 'Cleveland') Where Code='USA'
	Update Country set Capital=(Select CityId From City Where Name= 'Toronto') Where Code='CAN'
	Update Country set Capital=(Select CityId From City Where Name= 'London') Where Code='GRG'





          