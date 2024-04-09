namespace bd_dz
{
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public Region(int regionId, string regionName)
        {
            RegionId = regionId;
            RegionName = regionName;
        }
    }

    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int RegionId { get; set; }
        public Country(int countryId, string countryName, int regionId)
        {
            CountryId = countryId;
            CountryName = countryName;
            RegionId = regionId;
           
        }
    }

    public class Location
    {
        public int LocationId { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public int CountryId { get; set; }
        public Location(int locationId, string streetAddress, string postalCode, string city, string stateProvince, int countryId)
        {
            LocationId = locationId;
            StreetAddress = streetAddress;
            PostalCode = postalCode;
            City = city;
            StateProvince = stateProvince;
            CountryId = countryId;

        }
    }

    public class Job
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public Job(int jobId, string jobTitle, decimal minSalary, decimal maxSalary)
        {
            JobId = jobId;
            JobTitle = jobTitle;
            MinSalary = minSalary;
            MaxSalary = maxSalary;
        }
    }

    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int ManagerId { get; set; }
        public int LocationId { get; set; }
        public Department(int departmentId, string departmentName, int managerId, int locationId)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            ManagerId = managerId;
            LocationId = locationId;
        }
    }

    public class JobHistory
    {
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int JobId { get; set; }
        public int DepartmentId { get; set; }
        public JobHistory(int employeeId, DateTime startDate, DateTime endDate, int jobId, int departmentId)
        {
            EmployeeId = employeeId;
            StartDate = startDate;
            EndDate = endDate;
            JobId = jobId;
            DepartmentId = departmentId;
        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int JobId { get; set; }
        public decimal Salary { get; set; }
        public decimal? CommissionOct { get; set; }
        public int? ManagerId { get; set; }
        public int DepartmentId { get; set; }
        public Employee(int employeeId, string firstName, string lastName, string email, string phoneNumber, DateTime hireDate, int jobId, decimal salary, decimal? commissionOct, int? managerId, int departmentId)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            HireDate = hireDate;
            JobId = jobId;
            Salary = salary;
            CommissionOct = commissionOct;
            ManagerId = managerId;
            DepartmentId = departmentId;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Region> regions = new List<Region>
{
    new Region(1, "Region 1"),
    new Region(2, "Region 2"),

};

            List<Country> countries = new List<Country>
{
    new Country(1, "Country 1", 1),
    new Country(2, "Country 2", 1),

};

            List<Location> locations = new List<Location>
{
    new Location(1, "Street 1", "12345", "City 1", "State 1", 1),
    new Location(2, "Street 2", "23456", "City 2", "State 2", 2),

};

            List<Job> jobs = new List<Job>
{
    new Job(1, "IT_PROG", 5000, 10000),
    new Job(2, "SALES_REP", 6000, 12000)
    // Add more jobs as needed
};

            List<Department> departments = new List<Department>
{
   new Department(1, "Department 1", 1, 1),
    new Department(2, "Department 2", 2, 2),
    new Department(50, "Department 50", 3, 3),
    new Department(80, "Department 80", 4, 4)

};

            List<JobHistory> jobHistories = new List<JobHistory>
{
   new JobHistory(1, DateTime.Now.AddDays(-365), DateTime.Now, 1, 1),
    new JobHistory(2, DateTime.Now.AddDays(-365), DateTime.Now, 2, 2),
    new JobHistory(3, DateTime.Now.AddDays(-365), DateTime.Now, 1, 50),
    new JobHistory(4, DateTime.Now.AddDays(-365), DateTime.Now, 2, 80)

};

            List<Employee> employees = new List<Employee>
{
    new Employee(1, "John", "Doe", "john.doe@example.com", "123-456-7890", new DateTime(2022, 1, 1), 1, 5000, null, null, 1),
    new Employee(2, "Jane", "Smith", "jane.smith@example.com", "987-654-3210", new DateTime(2022, 1, 15), 2, 6000, null, 1, 2),
    new Employee(3, "David", "Brown", "david.brown@example.com", "111-222-3333", new DateTime(2022, 2, 1), 1, 7000, null, null, 50),
    new Employee(4, "David", "Lee", "david.lee@example.com", "444-555-6666", new DateTime(2022, 2, 15), 2, 8000, null, null, 80),
    new Employee(5, "Anna", "Johnson", "anna.johnson@example.com", "777-888-9999", new DateTime(2022, 3, 1), 1, 9000, 0.05m, null, 1),
    new Employee(6, "Hannah", "Williams", "hannah.williams@example.com", "000-111-2222", new DateTime(2022, 3, 15), 2, 10000, 0.03m, null, 2)
};
            var allEmployees = employees.Select(e => new { FullName = $"{e.FirstName} {e.LastName}", Email = e.Email });
            PrintEmployees("Информация о всех сотрудниках:", allEmployees);
            var employeesNamedDavid = employees.Where(e => e.FirstName == "David")
                                               .Select(e => new { FullName = $"{e.FirstName} {e.LastName}", Email = e.Email });
            PrintEmployees("Employees with name David:", employeesNamedDavid);
            var itProgs = employees.Where(e => e.JobId == 1)
                       .Select(e => new { FullName = $"{e.FirstName} {e.LastName}", Email = e.Email });
            PrintEmployees("Employees that work in IT_PROG:", itProgs);
            var highPaidEmployeesInDept50 = employees.Where(e => e.DepartmentId == 50 && e.Salary > 4000)
                                                      .Select(e => new { FullName = $"{e.FirstName} {e.LastName}", Email = e.Email });
            PrintEmployees("Employees from department 50 with a salary of more than 4000:", highPaidEmployeesInDept50);
            var employeesInDept20And30 = employees.Where(e => e.DepartmentId == 20 || e.DepartmentId == 30)
                                                  .Select(e => new { FullName = $"{e.FirstName} {e.LastName}", Email = e.Email });
            PrintEmployees("Employees from departments 20 and 30:", employeesInDept20And30);
            var employeesWithLastLetterA = employees.Where(e => e.FirstName.EndsWith("a"))
                                                     .Select(e => new { FullName = $"{e.FirstName} {e.LastName}", Email = e.Email });
            PrintEmployees("Employees with the last letter 'a' in their name:", employeesWithLastLetterA);
            var employeesWithBonusInDept50And80 = employees.Where(e => (e.DepartmentId == 50 || e.DepartmentId == 80) && e.CommissionOct != null)
                                                           .Select(e => new { FullName = $"{e.FirstName} {e.LastName}", Email = e.Email });
            PrintEmployees("Employees from departments 50 and 80 with a bonus:", employeesWithBonusInDept50And80);
            var employeesWithTwoNsInName = employees.Where(e => e.FirstName.Count(c => c == 'n') >= 2)
                                                     .Select(e => new { FullName = $"{e.FirstName} {e.LastName}", Email = e.Email });
            PrintEmployees("Employees with at least two 'n's in their name:", employeesWithTwoNsInName);
        }
        static void PrintEmployees(string header, IEnumerable<dynamic> employees)
        {
            Console.WriteLine(header);
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FullName} ({employee.Email})");
            }
            Console.WriteLine();
        }
    }
}
