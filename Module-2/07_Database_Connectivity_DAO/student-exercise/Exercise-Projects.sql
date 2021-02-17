Select * From employee;

/* Find all employees whose names contain the search strings.
	Returned employees names must contain *both* first and last names.
	Be sure to use LIKE for proper search matching.
	RESULT: A list of employees that matches the search.</returns>
*/
Select *
	From employee
	Where first_name like'%a%' And last_name like '%h%'

/*Gets a list of employees who are not assigned to any active projects.*/

Select employee.* 
	From employee
		Left Join project_employee on employee.employee_id=project_employee.employee_id 
	Where project_id Is Null;

-- find all the employees that are on a project

--Select Distinct employee_id
--	From project_employee;
-- find all employees that are not in the list
Select * From employee Where employee_id not in (select Distinct employee_id From project_employee);