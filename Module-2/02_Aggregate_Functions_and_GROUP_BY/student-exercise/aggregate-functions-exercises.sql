-- The following queries utilize the "world" database.
-- Write queries for the following problems. 
-- Notes:
--   GNP is expressed in units of one million US Dollars
--   The value immediately after the problem statement is the expected number 
--   of rows that should be returned by the query.

-- 1. The name and state plus population of all cities in states that border Ohio 
-- (i.e. cities located in Pennsylvania, West Virginia, Kentucky, Indiana, and 
-- Michigan).  
-- The name and state should be returned as a single column called 
-- name_and_state and should contain values such as ‘Detroit, Michigan’.  
-- The results should be ordered alphabetically by state name and then by city 
-- name. 
-- (19 rows)
SELECT Name + ', ' + District AS 'name_and_state', Population
	FROM City
	WHERE CountryCode='USA'
		AND District IN ('Pennsylvania', 'West Virginia', 'Kentucky', 'Indiana','Michigan')
	ORDER BY District, CityId;

-- 2. The name, country code, and region of all countries in Africa.  The name and
-- country code should be returned as a single column named country_and_code 
-- and should contain values such as ‘Angola (AGO)’ 
-- (58 rows)
SELECT CONCAT(Name,' ','(',Code,')') AS 'country_and_code', Region
	FROM Country
	WHERE Continent='Africa';

-- 3. The per capita GNP (i.e. GNP multipled by 1000000 then divided by population) of all countries in the 
-- world sorted from highest to lowest. Recall: GNP is express in units of one million US Dollars 
-- (highest per capita GNP in world: 37459.26)
SELECT Name, CAST(((GNP*1000000)/Population) AS decimal(10,2)) AS 'GNP Per Capita'
	FROM Country
	WHERE Population<>0
	ORDER BY 'GNP Per Capita' DESC;

-- 4. The average life expectancy of countries in South America.
-- (average life expectancy in South America: 70.9461)
SELECT AVG(LifeExpectancy) AS'AVG LifeExpectancy in South America'
	FROM Country
	WHERE Continent='South America';

-- 5. The sum of the population of all cities in California.
-- (total population of all cities in California: 16716706)
SELECT SUM(Population) AS 'Total Population in California'
	FROM City
	WHERE District='California';

-- 6. The sum of the population of all cities in China.
-- (total population of all cities in China: 175953614)
SELECT SUM(Population) AS 'Total Population in China'
	FROM City
	WHERE CountryCode='CHN';

-- 7. The maximum population of all countries in the world.
-- (largest country population in world: 1277558000)
SELECT MAX(Population) AS 'Largest Country Population'
	FROM Country;

-- 8. The maximum population of all cities in the world.
-- (largest city population in world: 10500000)
SELECT MAX(Population) AS 'Largest City Population- World'
	FROM City;

-- 9. The maximum population of all cities in Australia.
-- (largest city population in Australia: 3276207)
SELECT MAX(Population) AS 'Largest City Population- Australia'
	FROM City
	WHERE CountryCode='AUS';

-- 10. The minimum population of all countries in the world.
-- (smallest_country_population in world: 50)
SELECT MIN(Population) AS 'Smallest_Country_Population- World'
	FROM Country
	WHERE Population<>0;

-- 11. The average population of cities in the United States.
-- (avgerage city population in USA: 286955.3795)
SELECT CAST(AVG(population) AS Decimal (10,4)) AS 'AVG City Population- USA'
	FROM City
	WHERE CountryCode='USA';
-- Another way:
SELECT CAST((SUM (population)/239) AS Decimal (10,4)) AS 'AVG City Population- USA'
	FROM City
	WHERE CountryCode='USA';

-- 12. The average population of cities in China.
-- (average city population in China: 484720.6997 approx.)
SELECT CAST(AVG(Population) AS Decimal(10,4))
	FROM City
	WHERE CountryCode='CHN';

-- 13. The surface area of each continent ordered from highest to lowest.
-- (largest continental surface area: 31881000, "Asia")
SELECT Continent, SUM(SurfaceArea) AS 'continental surface area'
	FROM Country
	GROUP BY Continent
	ORDER BY 'continental surface area' DESC;

-- 14. The highest population density (population divided by surface area) of all 
-- countries in the world. 
-- (highest population density in world: 26277.7777)
SELECT CAST(MAX(Population/SurfaceArea) AS decimal(10,4))
	FROM Country;

-- 15. The population density and life expectancy of the top ten countries with the 
-- highest life expectancies in descending order. 
-- (highest life expectancies in world: 83.5, 166.6666, "Andorra")
SELECT TOP 10 LifeExpectancy, Population/SurfaceArea AS 'Population Density', Name
	FROM Country
	ORDER BY LifeExpectancy DESC;

-- 16. The difference between the previous and current GNP of all the countries in 
-- the world ordered by the absolute value of the difference. Display both 
-- difference and absolute difference.
-- (smallest difference: 1.00, 1.00, "Ecuador")
SELECT (GNPOld-GNP)AS 'GNP Difference',ABS(GNPOld-GNP) AS 'Absolute GNP Difference', Name
	FROM Country
	--WHERE GNP IS NOT NULL AND GNPOld IS NOT NULL
	WHERE (GNPOld-GNP) IS NOT NULL 
	ORDER BY 'Absolute GNP Difference' ASC;
-- 17. The average population of cities in each country (hint: use city.countrycode)
-- ordered from highest to lowest.
-- (highest avg population: 4017733.0000, "SGP")
SELECT AVG(Population) AS AvgPopulation, CountryCode
	FROM City
	GROUP BY CountryCode
	ORDER BY AvgPopulation DESC;

-- 18. The count of cities in each state in the USA, ordered by state name.
-- (45 rows)
SELECT COUNT(*) AS CitiesCount, District
	FROM City
	WHERE CountryCode='USA'
	GROUP BY District
	ORDER BY District ASC;

-- 19. The count of countries on each continent, ordered from highest to lowest.
-- (highest count: 58, "Africa")
SELECT COUNT(*) AS CountryCount, Continent
	FROM Country
	GROUP BY Continent
	ORDER BY CountryCount DESC;

-- 20. The count of cities in each country ordered from highest to lowest.
-- (largest number of  cities ib a country: 363, "CHN")
SELECT COUNT(*) AS CityCount, CountryCode
	FROM City
	GROUP BY CountryCode
	ORDER BY CityCount DESC;

-- 21. The population of the largest city in each country ordered from highest to 
-- lowest.
-- (largest city population in world: 10500000, "IND")
SELECT MAX(Population) AS 'Largest City Population', CountryCode
	FROM City
	GROUP BY CountryCode
	ORDER BY 'Largest City Population' DESC;

-- 22. The average, minimum, and maximum non-null life expectancy of each continent 
-- ordered from lowest to highest average life expectancy. 
-- (lowest average life expectancy: 52.5719, 37.2, 76.8, "Africa")
SELECT Cast(AVG(LifeExpectancy) AS decimal(10,4)) AS AvgLifeExpectancy, MIN(LifeExpectancy) AS MinLifeExpectancy, MAX(LifeExpectancy) AS MaxLifeExpectancy, Continent
	FROM Country
	WHERE LifeExpectancy IS NOT NULL
	GROUP BY Continent
	ORDER BY AvgLifeExpectancy ASC;