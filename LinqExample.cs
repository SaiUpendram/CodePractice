using System;
using System.Linq;
using System.Collections.Generic;

					
public class Program
{
	public static void Main()
	{
		
		IList<Employee> employeeList = new List<Employee>() { 
			new Employee() { empID = 1, empName= "John", Age = 28 } ,
				new Employee() { empID = 2, empName= "Steve",  Age = 31} ,
				new Employee() { empID = 3, empName= "Bill",  Age = 38 } ,
				new Employee() { empID = 4, empName= "Ram" , Age = 26 } ,
				new Employee() {empID = 5, empName= "Ron" , Age = 29 } 
		};
		
		var empNames = employeeList .Where(e => e.Age > 30)
                              .Select(e => e)
                              .Select(e => e.empName);

							  
		foreach(var name in empNames ){			
			Console.WriteLine(name);
		}
	}
}

public class Employee{

	public int empID { get; set; }
	public string empName { get; set; }
	public int Age { get; set; }
	
}
