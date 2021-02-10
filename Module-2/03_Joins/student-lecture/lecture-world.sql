-- Show all cities with all their country information
SELECT *
	FROM City AS ci
	JOIN Country AS co ON ci.CountryCode=co.Code;
	

-- List the "city name, country name" and city population, sorted by country and city population descending
SELECT CONCAT(ci.Name,', ',co.Name) AS City, ci.Population
	FROM City AS ci
	JOIN Country AS co ON co.Code=ci.CountryCode
	ORDER BY co.name, ci.Population;

-- List the city name, country name and the percentage of the country's population in the city
SELECT ci.Name AS CityName, co.Name AS CountryName, (ci.Population*100.0)/co.Population AS PopulationPercent
	FROM City AS ci
	JOIN Country AS co ON ci.CountryCode=co.Code;
-- List the country name and its languages
SELECT Co.Name, Co_Lang.LanguageId
	FROM Country AS Co
	JOIN CountryLanguage AS Co_Lang ON Co.Code=Co_Lang.CountryCode
	JOIN Language AS Lang ON Co_Lang.LanguageId=Lang.LanguageId
	ORDER BY Co.Name ASC, Co_Lang.Percentage DESC;

-- List the country name and its official languages
SELECT Co.Name, Lang.LanguageName
	FROM Country AS Co
	JOIN CountryLanguage AS Co_Lang ON Co.Code=Co_Lang.CountryCode
	JOIN Language AS Lang ON Co_Lang.LanguageId=Lang.LanguageId
	WHERE Co_Lang.IsOfficial=1
	ORDER BY Co.Name ASC, Co_Lang.Percentage DESC;

-- Let's display a list of all countries and their capitals.
SELECT co.Name AS CntryName, ci.Name AS CntryCapital
	FROM City AS ci
	Join Country AS co ON ci.CityId=co.Capital;

-- Only 232 rows. Where are the other 7 rows?
-- There are 239 countries. So how do we show them all even if they don’t have a capital?
-- That’s because if the rows don’t exist in both tables, we won’t show any information for it. If we want to show data FROM the left side table everytime, we can use a different join:

-- ********* LEFT JOIN ***********
-- A Left join selects all records from the "left" table and matches them with records from the "right" table if a matching record exists.
SELECT co.Name AS CntryName, ci.Name AS CntryCapital
	FROM Country AS co LEFT OUTER JOIN City AS ci ON co.Capital=ci.CityId


-- Just to see what would happen if we did Right Join?
SELECT co.Name AS CntryName, ci.Name AS CntryCapital
	FROM Country AS co RIGHT OUTER JOIN City AS ci ON co.Capital=ci.CityId

-- Correct result using a right join
SELECT co.Name AS CntryName, ci.Name AS CntryCapital
	FROM City AS ci Right OUTER JOIN Country AS co ON co.Capital=ci.CityId;

	/*
-- Cross Join- relates every row in one table to every row in the other table- rearly used! Usualy used for data retrival
SELECT *
	FROM City AS ci CROSS JOIN Country co;
	*/

-- List the countries and their capital cities, but make sure the country is listed even if it has no capital

SELECT cntry.Name AS CntryName, cty.Name AS CtyName
From Country AS cntry Left JOIN City AS cty ON cntry.Capital=cty.CityId;

-- (go play in the dvd store for a while...)



------------------------- More JOINs and UNION -------------------------------------

-- List the cities which are not capitals
SELECT*
From City AS cty RIGHT JOIN Country AS cntry

-- Can we do this another way?


-- List the city and the country it's a capital of


-- *********** UNION *************

-- How does the population of the largest cities compare with entire countries?
-- Get the name, population, and whether it is a city or a country, order by population descending



-- ***** What if I want to list every city, alongside the capital city for the country this city is in?
-- List the city, its country, and the capital city for that country.



-- ******** SELF-JOIN ***************
-- An Example of joining a table to itself, AND
-- An Example of joining to columns other than the PK

-- List each US city along with the other cities in that state.

