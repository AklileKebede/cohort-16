/*************************************************************************************
	Some additional queries from yesterday
*************************************************************************************/

-- The name and region of all countries in North or South America.  HOW MANY ways can we do this?
SELECT Name, Region
	FROM Country
	WHERE Continent IN ('North America','South America');

	/* Another Way*/
SELECT Name, Region
	FROM Country
	WHERE Continent LIKE '%America';
	/*Another Way*/
SELECT Name, Region
	FROM Country
	WHERE Continent='North America' 
		OR Continent='South America';
  
-- The name, continent, and head of state of all countries whose form of government is a monarchy
SELECT Name, Continent, HeadOfState
	FROM Country
	WHERE GovernmentForm LIKE '%monarchy%';

-- The name and region of all countries in North or South America except for countries in the Caribbean
SELECT Name, Region
	FROM Country
	WHERE Continent LIKE '%America' 
		AND Continent<>'Caribbean';

-- The name, population, and GNP of all countries with a GNP greater than $1 trillion dollars and a population of less than 1 billion people

-- The names of all the US States
SELECT DISTINCT District /*DISTINCT removes any cities that are duplicates*/
	FROM City
	WHERE CountryCode='USA';

/*************************************************************************************
*************************************************************************************/

-- ORDERING RESULTS

-- Order cities by country, then by name of the city
SELECT Name, CountryCode
	FROM city
	ORDER BY CountryCode DESC, Name /*Instead of Column name we can use the column number*/

-- Populations of all countries in descending order
SELECT Name, Population
	FROM Country
	ORDER BY Population DESC;

--Names of countries and continents in ascending order
SELECT Name, Continent
	FROM Country
	ORDER BY Continent ASC, Name ASC; /* The default ORDER BY is ASC*/

-- LIMITING RESULTS
-- The name and average life expectancy of the countries with the 10 highest life expectancies.
SELECT TOP 10 Name, LifeExpectancy /*If we write 'TOP 10 Percent' for percent*/
	FROM Country
	ORDER BY LifeExpectancy DESC;

-- ISNULL Example (if it ISNULL)
SELECT Name, ISNULL(CAST (IndepYear AS VARCHAR (15)), 'Not Independent') AS IsIndependent
	FROM Country
	ORDER BY IndepYear;


-- CONCATENATING OUTPUTS

-- The name & state of all cities in California, Oregon, or Washington.
-- "city, state", sorted by state then city
SELECT Name + ',' + District
	FROM City
	WHERE District in ('California','Oregon','Washington')
	ORDER BY District, Name;
-- Can you do it another way?


-- AGGREGATE FUNCTIONS
-- Average Life Expectancy in the World
SELECT AVG(LifeExpectancy) AS 'AVG Life EXpectancy'
	From Country
	WHERE Continent ='Africa';

-- Total population in Ohio
SELECT SUM(Population) AS 'Total Population'
	FROM City
	WHERE District='Ohio'
		AND CountryCode='USA';

-- The surface area of the smallest country in the world
SELECT MIN (SurfaceArea) AS 'SurfaceArea'
	FROM Country;

-- Another way (so we can see the name of country without needing to group)
SELECT TOP 1 Name, SurfaceArea
	FROM Country
	ORDER BY SurfaceArea ASC;

-- The 10 largest countries in the world
SELECT TOP 10 Name, SurfaceArea
	FROM Country
	ORDER BY SurfaceArea DESC;

-- The number of countries who declared independence in 1991
SELECT COUNT(*) AS 'NumCountries'
	FROM Country
	WHERE IndepYear=1991;

-- GROUP BY
-- Count the number of countries where each language is spoken, ordered from most countries to least
SELECT LanguageId, Count(*) AS 'NUM Countries'
	FROM CountryLanguage
	GROUP BY LanguageId 
	ORDER BY 'NUM Countries' DESC ;

-- Average life expectancy of each continent ordered from highest to lowest
SELECT Continent, AVG(LifeExpectancy) AS 'AVG LifeExpectancy'
	FROM Country
	GROUP BY Continent
	ORDER BY 'AVG LifeExpectancy' DESC;

-- Exclude Antarctica from consideration for average life expectancy
SELECT Continent, AVG(LifeExpectancy) AS 'AVG LifeExpectancy'
	FROM Country
	-- WHERE LifeExpectancy IS NOT NULL
	WHERE Continent<>'Antarctica'
	GROUP BY Continent
	ORDER BY 'AVG LifeExpectancy' DESC;

-- Sum of the population of cities in each state in the USA ordered by state name
SELECT District AS State, SUM(Population) AS 'Total Population'
	FROM City
	WHERE CountryCode='USA'
	GROUP BY District
	ORDER BY District;

-- The average population of cities in each state in the USA ordered by state name
SELECT District, AVG(Population) AS 'AVG Population'
	FROM City
	WHERE CountryCode='USA'
	GROUP BY District
	ORDER BY District;

-- Count the number of languages spoken in each country, ordered from most countries to least
SELECT CountryCode, COUNT(*) AS 'Language Count'
	FROM CountryLanguage
	GROUP BY CountryCode
	ORDER BY 'Language Count'DESC;

-- Show the total population of all districts in the world, ordered by country and District
SELECT CountryCode, District, sum(Population) AS 'Total Population'
	FROM City
	GROUP BY District
	ORDER BY CountryCode, District;

-- SUBQUERIES
-- Find the names of cities under a given(USA) government leader(George W. Bush)
	--1. Find the countries under this leader
		SELECT Code
			FROM Country
			WHERE HeadOfState='George W. Bush'
	--2. Find the Cities in these coutnries
		SELECT *
			FROM City
			WHERE CountryCode in ('ASM','GUM', 'MNP','PRI','UMI','USA', 'VIR')
	--3. Use SUB-QUERY to accomplish assignment
		SELECT *
		FROM City
		WHERE CountryCode in (SELECT Code
									FROM Country
									WHERE HeadOfState='George W. Bush')
-- Find the names of cities whose country they belong to has not declared independence yet

-- Select those countries with lower than average life expectancy

-- Additional samples
-- You may alias column and table names to be more descriptive

-- Alias can also be used to create shorthand references, such as "c" for city and "co" for country.

-- Ordering allows columns to be displayed in ascending order, or descending order (Look at Arlington)

-- While you can use TOP to limit the number of results returned by a query,
-- in SQL Server it is recommended to use OFFSET and FETCH if you want to get
-- "pages" of results. For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)

-- Most database platforms provide string functions that can be useful for working with string data. In addition to string functions, string concatenation is also usually supported, which allows us to build complete sentences if necessary.

-- Aggregate functions provide the ability to COUNT, SUM, and AVG, as well as determine MIN and MAX. Only returns a single row of value(s) unless used with GROUP BY.
-- Counts the number of rows in the city table

-- Also counts the number of rows in the city table

-- Gets the SUM of the population field in the city table, as well as
-- the AVG population, and a COUNT of the total number of rows.

-- Gets the MIN population and the MAX population from the city table.

-- Using a GROUP BY with aggregate functions allows us to summarize information for a specific column. For instance, we are able to determine the MIN and MAX population for each countrycode in the city table.
