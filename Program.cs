public class Employee 
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime HireDate { get; set; }
    public string JobTitle { get; set; }
    public decimal Salary { get; set; }

        public Employee(
        int EmployeeId, string firstName, string lastName, string email, string phoneNumber, DateTime hireDate, string jobTitle, decimal salary) 
    {
        EmployeeId = EmployeeId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        HireDate = hireDate;
        JobTitle = jobTitle;
        Salary = salary;
    }

    public Employee()
    {
    }
}

Employee newEmployee1 = new Employee(1, "Sarah", "Marshall", "sarah.marshall@gmail.com',"132 - 546 - 8970", DateTime.Now, "Software Engineer", 10000);;
