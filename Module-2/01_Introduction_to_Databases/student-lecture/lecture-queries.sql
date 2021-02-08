/* This is a 
multi-line comment
*/

-- SELECT ... FROM
-- Selecting the names for all countries
SELECT Name  FROM Country; 

-- Selecting the name and population of all countries
SELECT Name, Population From Country;

-- Selecting all columns from the city table
Select * FROM City;

-- SELECT ... FROM ... WHERE
-- Selecting the cities in Ohio
SELECT * 
	FROM City 
	WHERE District='Ohio';

-- Selecting countries that gained independence in the year 1776
SELECT *
	FROM Country
	WHERE IndepYear=1776;

-- Selecting countries not in Asia
SELECT Name, Continent 
	FROM Country
	Where Continent!= 'Asia';
	

-- Selecting countries that do not have an independence year
SELECT *
	FROM Country
	WHERE IndepYear IS NULL;
-- Selecting countries that do have an independence year
SELECT *
	From Country
	WHERE IndepYear IS NOT NULL;

-- Selecting countries that have a population greater than 5 million
SELECT *
	FROM Country
	WHERE Population > 5000000;


-- SELECT ... FROM ... WHERE ... AND/OR
-- Selecting cities in Ohio and Population greater than 400,000
SELECT *
	From City
	WHERE District='Ohio'
		AND Population > 400000;


-- Selecting country names and continent on the continent North America or South America
SELECT Name, Continent
	FROM Country
	WHERE Continent='North America'
		OR Continent='South America';
-- Another Way!
SELECT Name, Continent	
	FROM Country
	WHERE Continent IN ('North America','South America');

-- SELECTING DATA w/arithmetic
	-- Selecting the population, life expectancy, and population per area
	--	note the use of the 'as' keyword
	SELECT Name, Population, LifeExpectancy, (Population/SurfaceArea) AS 'Population Density'
		FROM Country



