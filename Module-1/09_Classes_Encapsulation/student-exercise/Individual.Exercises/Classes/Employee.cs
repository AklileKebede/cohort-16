namespace Individual.Exercises.Classes
{
    public class Employee
    {
       
        public int EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public double AnnualSalary { get; private set; }
        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AnnualSalary = salary;

        }
        public string FullName
        {
            get
            {
                string fullName = LastName + ", " + FirstName;
                return fullName;
            }
        }
        
        public void RaiseSalary(double percent)
        {
            //The method increases the current annual salary by the percentage provided. For example, 5.5 represents 5.5%.
            this.AnnualSalary = this.AnnualSalary * (percent / 100) + this.AnnualSalary;
        }
    }
}
