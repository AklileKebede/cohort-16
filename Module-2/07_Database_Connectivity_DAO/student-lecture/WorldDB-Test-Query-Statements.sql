-- Example for one return value to use SqlDataReader reader = cmd.ExecuteScalar
select count(*)	from Country;

Select max(GovernmentForm) from Country
-- Example for no retun 
Insert City (Name, District, Population, CountryCode) values ('Richfield', 'Ohio', 10000, 'USA')
-- To add a return to it we campus the following query too.
select @@IDENTITY

Select *
 from City
 Where Name='mayfield'