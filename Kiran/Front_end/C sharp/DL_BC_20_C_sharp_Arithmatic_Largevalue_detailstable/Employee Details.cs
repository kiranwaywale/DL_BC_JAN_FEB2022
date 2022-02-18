// whose salary is between 6000 and 8000
// using LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee{
	
// Declare 4 variables - id,age, name and salary
int emp_id;
string emp_dept;
string emp_name;
int emp_salary;

// Get the to string method that returns id,
// name, age and salary
public override string ToString()
{
	return emp_id + " " + emp_name + " " +
		emp_dept + " " + emp_salary;
}

// Driver code
static void Main(string[] args)
{
	
	// Declare a list variable
	List<Employee> emp = new List<Employee>()
	{
		
		// Create 3 employee details
		new Employee{ emp_id = 101, emp_name = "Akash",
					emp_dept = "HR", emp_salary = 7800 },
		new Employee{ emp_id = 102, emp_name = "kiran",
					emp_dept = "Development", emp_salary = 7000 },
		new Employee{ emp_id = 103, emp_name = "Raju",
					emp_dept = "HR", emp_salary = 6700 }};
						
	// Iterate the Employee by selecting Employee id
	// greater than 101 using where function
	IEnumerable<Employee> Query =
	from employee in emp where employee.emp_salary >= 6000 &&
	employee.emp_salary <= 8000 select employee;

	// Display employee details
	Console.WriteLine("ID Name Department Salary");
	Console.WriteLine("+++++++++++++++++++++++++++");
	foreach (Employee e in Query)
	{
		
		// Call the to string method
		Console.WriteLine(e.ToString());
	}
}
}
