Select * From employee;

/* Find all employees whose names contain the search strings.
	Returned employees names must contain *both* first and last names.
	Be sure to use LIKE for proper search matching.
	RESULT: A list of employees that matches the search.</returns>
*/
Select *
	From employee
	Where first_name like'%a%' And last_name like '%h%'
-- Another way

Select * 
	From employee
	Where first_name like CONCAT('%','a','%') And last_name like CONCAT('%','h','%')
-- how to test before using in C#
Declare @firstname varchar(20)= 'a'
Declare @lastname varchar(20)= 'h'
Select * From employee Where first_name like CONCAT('%',@firstname,'%') And last_name like CONCAT('%',@lastname,'%')

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

--------------------- Department--------------------------------
-- GetDepartments
Select * From department

-- CreateDepartment
Declare @name varchar(50)= 'aklile';
Insert Into department(name) Values (@name); Select @@IDENTITY; -- returns the departnemt_id PK

-- UpdateDepartment
Declare @name varchar(50)='aklileupdated';
Declare @department_id int= 5;
Update department Set name=@name Where department_id=@department_id; Select @@IDENTITY;


--------------------- Project & Project_Employee --------------------------------
Select* From project_employee
-- Declare
Declare @name varchar(50)='';
Declare @from_date date='';
Declare @to_date date='';
Declare @project_id int= 1;
Declare @employee_id int= 1;

-- Get All Projects
Select * From project;

-- Assign Employee To Project
Insert Into project_employee(project_id,employee_id) Values (@project_id,@employee_id); Select @@IDENTITY; -- usually we will need a subquery for each id, but in this case not needed

-- Remove Employee From Project
--Declare @project_id int= 1;
--Declare @employee_id int= 1;
Delete From project_employee Where project_id=@project_id And employee_id=@employee_id; Select @@IDENTITY; -- returns


-- Create Project
Declare @name varchar(50)='aklile';
Declare @from_date date='';
Declare @to_date date='';
Insert Into project(name,from_date,to_date) Values (@name, @from_date, @to_date); Select @@IDENTITY;

delete from project where name='aklile';