-- *********** Sub-queries *************

-- List the cites that are in the 5 smallest coutries in the world
SELECT*
	FROM City
	Where CountryCode IN (SELECT Top 5 Code	FROM Country	ORDER BY SurfaceArea)


-- Can it be done with a Join? fail becuase we should get 7 cities
SELECT Top 7*
	FROM Country
	JOIN City on City.CountryCode=Country.Code
	ORDER BY SurfaceArea;

-- *********** UNION *************
-- I wonder how the world's largest cities stack up against entire countries?
-- Get the name, population, and whether it is a city or a country, order by population descending

Select Name, Population, 'Country' AS CountryOrCity -- We are adding a column that everythings selected from this table will have this value-name
	From Country
	--ORDER BY Population desc;
UNION -- Union only allows one ORDER BY of the whole new list
Select Name, Population, 'City'
	From City
	Order By Population desc;

-- *********** SELF-JOINS *************
-- *********** SELF_Referencing Constraints *************
-- The table below shows that one row is referce to another row. For example a supervisor is an employee and it's subordinates are employees

	-- Creating Employee table
		create table Employee( 
			emp_id int identity primary key,
			name varchar(30),
			supervisor_id int null,
			constraint fk_supervisor Foreign Key (supervisor_id) references Employee (emp_id)
		);
	-- Add employees to table
		Insert Into Employee (name, supervisor_id) Values ('Ben', null) -- Ben is a supervisor there for he has no supervisor_id
		Insert Into Employee (name, supervisor_id) Values ('Mike', 1)
		Insert Into Employee (name, supervisor_id) Values ('Rosa', 1)
		Insert Into Employee (name, supervisor_id) Values ('Luci', 1)
		Insert Into Employee (name, supervisor_id) Values ('Robin', 1);

	-- Check table
		Select* From Employee;
	-- Find the name of Rosa's name
		Select emp.name, sup.name
			From Employee AS emp
				Join Employee AS sup ON emp.supervisor_id=sup.emp_id
			Where emp.name='Rosa'
/***
***** List every city, alongside the capital city for the country this city is in.
e.g.:
Los Angeles		USA		Washington
New York		USA		Washington
Barcelona		ESP		Madrid
Madrid			ESP		Madrid
***/ 
-- List the city, its country, and the capital city for that country.



-- ******** SELF-JOIN ***************
-- An Example of joining a table to itself, AND
-- An Example of joining to columns other than the PK

-- List each US city along with the other cities in that state.
