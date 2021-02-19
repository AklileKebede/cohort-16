-- EmployeeDB_IntegrationTests
	-- Script for Integration testing by establishing the DB into a known state (each run)

	-- 1. Remove all datat from the tables starting with most integrated tables
		-- (Make sure that integrated colums are set to null if necessary)
		Delete From project_employee;
		Delete From employee;
		Delete From department;
		Delete From project;

	-- 2. Add data to the tables, starting with most independant
		-- (If column is affected after creating of data stat it with a null)
		--Department
		INSERT INTO [dbo].[department] ([name]) VALUES 
		('Marketing'),('Finance'),('HR');
		 -- Project
		 INSERT INTO [dbo].[project] ([name], [from_date], [to_date]) VALUES 
		 ('Car','2020-02-15','2020-06-13'),('House','2019-09-01','2023-07-23'),('Boat','2018-05-05','2019-08-05');
		-- Employee
		-- Subquery for department_id: Select department_id From department Where name='';
		INSERT INTO [dbo].[employee] ([department_id],[first_name],[last_name],[job_title],[birth_date],[gender],[hire_date]) VALUES
           ((Select department_id From department Where name='Marketing'),'Clayton','Cross','Marketing Officer','1978-04-01','m','2006-05-20'),
           ((Select department_id From department Where name='Finance'),'Lucinda','VerPlanck','Financial Analyst','1998-09-01','f','2016-05-20'),
           ((Select department_id From department Where name='HR'),'Marissa','Buss','HR specialist','1995-03-01','f','2019-05-20'),
           ((Select department_id From department Where name='Finance'),'Paul','Broeck','Credit Analyst','2002-10-01','m','2018-05-20'),
           ((Select department_id From department Where name='HR'),'Dejan','Cancer','HR analyst','1986-11-01','m','2016-05-20'),
           ((Select department_id From department Where name='Marketing'),'Kameron','Howes','Marketing analyst','2000-12-01','m','2020-05-20');

			-- Project_Employee
			-- Subquery for project_id: (Select project_id From project Where name='')
			-- Subquery for employee_id: (Select employee_id From employee Where first_name='' And last_name='')
		INSERT INTO [dbo].[project_employee]([project_id],[employee_id]) VALUES
           ((Select project_id From project Where name='Car'), (Select employee_id From employee Where first_name='Clayton' And last_name='Cross')),
		   ((Select project_id From project Where name='House'), (Select employee_id From employee Where first_name='Lucinda' And last_name='VerPlanck')),
           ((Select project_id From project Where name='Boat'), (Select employee_id From employee Where first_name='Dejan' And last_name='Cancer')),
		   ((Select project_id From project Where name='House'), (Select employee_id From employee Where first_name='Marissa' And last_name='Buss')),
		   ((Select project_id From project Where name='Boat'), (Select employee_id From employee Where first_name='Lucinda' And last_name='VerPlanck'));